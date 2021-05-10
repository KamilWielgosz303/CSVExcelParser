using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace CSVExcelParser
{
    public partial class CSVExcelParser : Form
    {
        Parser Parser;

        public CSVExcelParser()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = ConstDefine.FILE_OPEN_FILTER
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Parser = new Parser(ofd.FileName);
                if (Parser.LoadData() == Parser.LoadResult.OK)
                {
                    FadeInput.Enabled = true;
                    ClearityInput.Enabled = true;
                    maxRange.Enabled = true;
                    FileNameLabel.Text = "Plik: " + ofd.FileName;
                }
                else
                {
                    FadeInput.Enabled = false;
                    ClearityInput.Enabled = false;
                    maxRange.Enabled = false;

                    FileNameLabel.Text = ConstDefine.FILE_NAME_LABEL_EMPTY;
                    MessageBox.Show(ConstDefine.LOAD_FILE_FAILED_DESC
                        , ConstDefine.LOAD_FILE_FAILED_LABEL
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            if (Parser != null)
            {
                var sfd = new SaveFileDialog
                {
                    Filter = ConstDefine.FILE_SAVE_FILTER
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ProgressBar.Visible = true;
                    Parser.Fade = FadeInput.Text;
                    Parser.Clearance = ClearityInput.Text;
                    int maxRange = 0;int.TryParse(this.maxRange.Text, out maxRange);
                    Parser.Axis Axis = Parser.Axis.X;
                    if (SortedYRadioBox.Checked)
                        Axis = Parser.Axis.Y;

                    try
                    {
                        if (Parser.Parse(maxRange, Axis) == Parser.ParseResult.OK)
                        {
                            ProgressBar.Increment(50);
                            if (Parser.SaveToFile(sfd.FileName, revertXCheckBox.Checked, revertYCheckBox.Checked, changeCheckBox.Checked))
                            {
                                ProgressBar.Increment(100);
                                
                                MessageBox.Show(ConstDefine.PARSE_COMPLETE_DESC,
                                    ConstDefine.PARSE_COMPLETE_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                ProgressBar.Value = 0;
                            }
                            else
                            {
                                MessageBox.Show(ConstDefine.PARSE_ERROR_SAVE_DESC,
                                    ConstDefine.PARSE_ERROR_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            if (Parser.Result == Parser.ParseResult.InvalidGroup)
                            {
                                MessageBox.Show(ConstDefine.PARSE_ERROR_GROUP_DESC,
                                    ConstDefine.PARSE_ERROR_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else if (Parser.Result == Parser.ParseResult.InvalidCell)
                            {
                                MessageBox.Show(ConstDefine.PARSE_ERROR_UNKOWN_CELL,
                                    ConstDefine.PARSE_ERROR_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(ConstDefine.PARSE_ERROR_UNKOWN_DESC,
                                    ConstDefine.PARSE_ERROR_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (InvalidCellFormatException ex)
                    {
                        MessageBox.Show(ConstDefine.PARSE_ERROR_UNKOWN_CELL + " W sekcji: " + ex.Group,
                                    ConstDefine.PARSE_ERROR_TITLE,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                    ProgressBar.Visible = false;
                }
            }
        }
    }
}
