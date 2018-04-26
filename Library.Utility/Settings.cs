namespace Library.Utility
{
    public static class Settings
    {
        private static int _Iterations = 2;
        public static int Iterations { get => _Iterations; set => _Iterations = value; }

        private static int _KeySize = 256;
        public static int KeySize { get => _KeySize; set => _KeySize = value; }

        private static string _Hash = "SHA256";
        public static string Hash { get => _Hash; set => _Hash = value; }

        private static string _Salt;
        public static string Salt { get => _Salt; set => _Salt = value; }

        private static string _Vector;
        public static string Vector { get => _Vector; set => _Vector = value; }

        public const int StandardIterations = 2;
        public const int StandardKeySize = 256;
        public const string StandardHash = "SHA256";
        public const string StandardSalt = "xZoqvRzsILt8GuA7";
        public const string StandardVector = "7nEeuuzSBSTn010P";

        public static void LoadSettings()
        {
            Settings.Iterations = Properties.Settings.Default.Iterations;
            Settings.KeySize = Properties.Settings.Default.KeySize;
            Settings.Hash = Properties.Settings.Default.Hash;
            Settings.Salt = Properties.Settings.Default.Salt;
            Settings.Vector = Properties.Settings.Default.Vector;
        }

        public static void SaveSettings(int iterations, int keySize, string hash, string salt, string vector)
        {
            Properties.Settings.Default.Iterations = iterations;
            Properties.Settings.Default.KeySize = keySize;
            Properties.Settings.Default.Hash = hash;
            Properties.Settings.Default.Salt = salt;
            Properties.Settings.Default.Vector = vector;
            Properties.Settings.Default.Save();

            LoadSettings();
        }

        public static void ResetToStandard()
        {
            Properties.Settings.Default.Iterations = Settings.StandardIterations;
            Properties.Settings.Default.KeySize = Settings.StandardKeySize;
            Properties.Settings.Default.Hash = Settings.StandardHash;
            Properties.Settings.Default.Salt = Settings.StandardSalt;
            Properties.Settings.Default.Vector = Settings.StandardVector;
            Properties.Settings.Default.Save();

            LoadSettings();
        }
    }
}