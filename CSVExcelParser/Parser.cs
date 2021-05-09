using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CSVExcelParser
{
    public class Parser
    {
        public string FilePath;
        public string Fade  = ConstDefine.FADE_DEFAULT;
        public string Clearance = ConstDefine.CLEARITY_DEFAULT;


        public ParseResult Result;

        private List<string> DataFromFile = new List<string>();

        private List<GroupCoords> GroupList = new List<GroupCoords>();

        public enum LoadResult
        {
            OK,
            Error
        }

        public enum ParseResult
        {
            OK,
            InvalidGroup,
            InvalidCell,
            UnkownError
        }

        public enum Axis
        {
            X,
            Y
        }

        public Parser(string filename)
        {
            this.FilePath = filename;
        }

        public LoadResult LoadData()
        {
            StreamReader stream = new StreamReader(FilePath);
            try
            {
                DataFromFile.Clear();
                while (!stream.EndOfStream)
                {
                    DataFromFile.Add(stream.ReadLine());
                }
                DataFromFile.RemoveAt(0);
                Debug.WriteLine(DataFromFile.Count);
                DataFromFile.RemoveAll(LinesWithoutSeparator);
                if(DataFromFile.Count == 0)
                {
                    return LoadResult.Error;
                }
                stream.Dispose();
                return LoadResult.OK;
            }
            catch (Exception ex)
            {
                return LoadResult.Error;
            }
            finally
            {
                stream.Dispose();
            }
        }
        private static bool LinesWithoutSeparator(String s)
        {
            return !s.Contains(";");
        }
        public ParseResult Parse(int range = 0, Axis Column = Axis.X)
        {
            try
            {
                GroupList.Clear();
                var Lines = AddWhiteSpaces(ParseLineFromCSV());
                int Part = 1;
                string ChosedColumn;
                range = Math.Abs(range);

                if (range == 0)
                {
                    foreach (var data in Lines)
                    {
                        if (GroupList.Count == 0 || !data.Name.ToString().Equals(GroupList.Last().Name))
                        {
                            var Group = new GroupCoords
                            {
                                Name = data.Name.ToString()
                            };
                            Group.Data.Add(data);
                            GroupList.Add(Group);
                        }
                        else
                        {
                            GroupList.Last().Data.Add(data);
                        }

                    }
                }
                else
                {
                    int AbsRange = Math.Abs(range);
                    int OriginalRange = Math.Abs(range);

                    foreach (var data in Lines)
                    {
                        ChosedColumn = data.X;
                        if (Column == Axis.Y)
                        {
                            ChosedColumn = data.Y;
                        }
                        if (GroupList.Count == 0)
                        {
                            var Group = new GroupCoords
                            {
                                Name = data.Name.ToString()
                            };
                            Group.Data.Add(data);
                            GroupList.Add(Group);
                            continue;
                        }
                        if (Math.Abs(double.Parse(ChosedColumn, CultureInfo.InvariantCulture)) < AbsRange)
                        {
                            if (GroupList.Last().Name[0].Equals(data.Name))
                            {
                                GroupList.Last().Data.Add(data);
                            }
                            else
                            {
                                var Group = new GroupCoords
                                {
                                    Name = data.Name.ToString()
                                };
                                Group.Data.Add(data);
                                GroupList.Add(Group);
                                Part = 1;                       //nie robi sie to sprowdz yfa
                                AbsRange = OriginalRange;
                            }
                        }
                        else
                        {
                            do
                            {
                                AbsRange += OriginalRange;
                                Part++;
                            } while(Math.Abs(double.Parse(ChosedColumn, CultureInfo.InvariantCulture)) > AbsRange);
                            var Group = new GroupCoords
                            {
                                Name = data.Name.ToString() + (Part - 1).ToString()
                            };
                            Group.Data.Add(data);
                            GroupList.Add(Group);
                        }
                        
                    }
                    
                }
                    
                return ParseResult.OK;
            }
            catch (GroupException)
            {
                return Result = ParseResult.InvalidGroup;
            }
            catch (FormatException)
            {
                return Result = ParseResult.InvalidCell;
            }
            catch (InvalidCellFormatException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                return Result = ParseResult.UnkownError;
            }
        }

        private List<LineData> ParseLineFromCSV()
        {
            List<LineData> Steps = new List<LineData>();
            Debug.WriteLine(DataFromFile.Count);
            int i = 1;
            foreach (var Line in DataFromFile)
            {
                string[] Data = Line.Split(';');
                char Temp = Data.ElementAt(0).ElementAt(0);
                if (Temp >= 65 && Temp <= 90)
                {
                    LineData Step = new LineData
                    {
                        Name = Temp,
                        ID = Data[0].Substring(1),          //cut only number
                        X = Data[1].Replace(",", "."),
                        Y = Data[2].Replace(",", "."),
                        Fade = this.Fade,
                        Clearance = this.Clearance
                    };
                    if (Data.Length > 3)
                    {
                        if (double.TryParse(Data[3], out double t))
                        {
                            Step.Z = Data[3].Replace(",", ".");
                        }
                    }
                    try
                    {
                        double.Parse(Step.ID, CultureInfo.InvariantCulture);
                        double.Parse(Step.X, CultureInfo.InvariantCulture);
                        double.Parse(Step.Y, CultureInfo.InvariantCulture);
                        double.Parse(Step.Z, CultureInfo.InvariantCulture);
                    }
                    catch (FormatException)
                    {
                        throw new InvalidCellFormatException(Step.Name.ToString());
                    }
                    Steps.Add(Step);
                    i++;
                }
                else
                {
                    throw new GroupException();
                }
            }

            return Steps;
        }

        public bool SaveToFile(string FilePath, bool RevertXAxis = false, bool RevertYAxis = false, bool ChangeAxis = false)
        {
            var indexEndDirectory = FilePath.LastIndexOf("\\");
            var filename = FilePath.Substring(indexEndDirectory + 1, FilePath.Length - indexEndDirectory - 1);
            var directory = FilePath.Substring(0, indexEndDirectory);
            foreach (var Group in GroupList)
            {
                var path = directory + "\\" + filename + Group.Name + ".pnt";
                StreamWriter stream = new StreamWriter(path);

                try
                {
                    stream.WriteLine("BEGIN " + filename.ToUpper() + Group.Name + ".PNT MM");
                    stream.WriteLine(ConstDefine.CNC_FILE_HEADER);
                    stream.Flush();
                    foreach (var LineData in Group.Data)
                    {
                        if (RevertXAxis)
                        {
                            LineData.RevertXAxis();
                        }
                        if (RevertYAxis)
                        {
                            LineData.RevertYAxis();
                        }
                        if (ChangeAxis)
                        {
                            LineData.ChangeAxis();
                        }
                        stream.WriteLine(LineData.ID + LineData.X + LineData.Y + LineData.Z + LineData.Fade + LineData.Clearance);
                        stream.Flush();
                    }
                    stream.WriteLine(ConstDefine.CNC_FILE_END);
                    stream.Flush();
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    stream.Dispose();
                }
            }
            return true;
        }

        private List<LineData> AddWhiteSpaces(List<LineData> Data)
        {
            foreach (var data in Data)
            {
                data.AddPadsToVariables();
            }
            return Data;
        }

        public class LineData
        {
            public char Name { get; set; }
            public string ID { get; set; }
            public string X { get; set; }
            public string Y { get; set; }
            public string Z { get; set; } = "0";
            public string Fade { get; set; }
            public string Clearance { get; set; }

            public enum HeaderName
            {
                ID,
                X,
                Y,
                Z,
                Fade,
                Clearance
            }

            private static Dictionary<HeaderName, int> Pads = new Dictionary<HeaderName, int>();

            static LineData()
            {
                Pads.Add(HeaderName.ID, ConstDefine.ID);
                Pads.Add(HeaderName.X, ConstDefine.COORDS);
                Pads.Add(HeaderName.Y, ConstDefine.COORDS);
                Pads.Add(HeaderName.Z, ConstDefine.COORDS);
                Pads.Add(HeaderName.Fade, ConstDefine.FADE);
                Pads.Add(HeaderName.Clearance, ConstDefine.CLEARANCE);
            }

            public void RevertXAxis() {
                float X = float.Parse(this.X, CultureInfo.InvariantCulture);
                X = -X;
                string temp = X.ToString().Replace(",", ".");
                this.X = temp.PadRight(Pads[HeaderName.X]);
            }

            public void RevertYAxis()
            {
                float Y = float.Parse(this.Y, CultureInfo.InvariantCulture);
                Y = -Y;
                string temp = Y.ToString().Replace(",", ".");
                this.Y = temp.PadRight(Pads[HeaderName.Y]);
            }

            public void ChangeAxis()
            {
                string y = this.Y;
                this.Y = this.X;
                this.X = y; ;
            }
            public bool ChangePad(HeaderName variable, int padSize)
            {
                if (Pads.ContainsKey(variable))
                {
                    Pads.Remove(variable);
                    Pads.Add(variable, padSize);
                    return true;
                }
                return false;
            }

            public void AddPadsToID()
            {
                ID = ID.PadRight(Pads[HeaderName.ID]);
            }

            public void AddPadsToVariables()
            {
                ID = ID.PadRight(Pads[HeaderName.ID]);
                X = X.PadRight(Pads[HeaderName.X]);
                Y = Y.PadRight(Pads[HeaderName.Y]);
                Z = Z.PadRight(Pads[HeaderName.Z]);
                Fade = Fade.PadRight(Pads[HeaderName.Fade]);
                Clearance = Clearance.PadRight(Pads[HeaderName.Clearance]);
            }

            public override string ToString()
            {
                return Name + " " + ID + " " + X + " " + Y + " " + Z + " " + Fade + " " + Clearance;
            }

        }
        public class GroupCoords
        {
            public string Name { get; set; }
            public List<LineData> Data { get; set; } = new List<LineData>();
        }
    }
}
