﻿namespace DigglesModManager
{
    /// <summary>
    /// Holds several constant file-paths and directory names.
    /// </summary>
    public class Paths
    {
        public static string ExePath = @".";                //dyn: @"." | local: D:\Programme\Wiggles
        public static string ModPath = ExePath;             //dyn: exePath | local: @"D:\Projekte\DigglesModManager"
        public static string ModDirectoryName = "Mods";
        public static string WigglesExecutableName = "Wiggles.exe";

        //.dm
        public static string RestoreFileName = "restore.dm";

        //JSON
        public static string AppSettingsName = "diggles-mod-manager.json";
        public static string ModConfigName = "config.json";
    }
}
