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

        private static string _Salt = "aselrias38490a32";
        public static string Salt { get => _Salt; set => _Salt = value; }

        private static string _Vector = "8947az34awl34kjq";
        public static string Vector { get => _Vector; set => _Vector = value; }

        public static void LoadSettings()
        {
            Settings.Iterations = Properties.Settings.Default.Iterations;
            Settings.KeySize = Properties.Settings.Default.KeySize;
            Settings.Hash = Properties.Settings.Default.Hash;
            Settings.Salt = Properties.Settings.Default.Salt;
            Settings.Vector = Properties.Settings.Default.Vector;
        }
    }
}