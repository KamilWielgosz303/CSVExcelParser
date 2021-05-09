namespace CSVExcelParser
{
    public static class ConstDefine
    {
        // Popup Messages
        public const string FILE_OPEN_FILTER = "CSV |*.csv";
        public const string LOAD_FILE_FAILED_DESC = "Błąd wczytywania";
        public const string LOAD_FILE_FAILED_LABEL = "Błąd";
        public const string FILE_SAVE_FILTER = "All types|*.*";
        public const string FILE_NAME_LABEL_EMPTY = "Plik: Nie wczytano";
        public const string PARSE_ERROR_TITLE = "Błąd";
        public const string PARSE_ERROR_GROUP_DESC = "CSV zawiera błędny adres grupy.";
        public const string PARSE_ERROR_UNKOWN_DESC = "Wystąpił nieznany błąd.";
        public const string PARSE_ERROR_UNKOWN_CELL = "Nie można odczytać komórki.";
        public const string PARSE_ERROR_SAVE_DESC = "Błąd zapisu";
        public const string PARSE_COMPLETE_TITLE = "Ukończono";
        public const string PARSE_COMPLETE_DESC = "Ukończono pomyślnie konwersję i zapis";

        // CNC file
        public const string CNC_FILE_HEADER = "NR      X           Y           Z           FADE CLEARANCE   ";
        public const string CNC_FILE_END = "[END]";

        // WHITE SPACES
        public const int ID = 8;
        public const int COORDS = 12;
        public const int FADE = 5;
        public const int CLEARANCE = 12;

        // Default values
        public const string FADE_DEFAULT = "N";
        public const string CLEARITY_DEFAULT = "+60";
    }
}
