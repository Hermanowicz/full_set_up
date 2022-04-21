using System.Diagnostics;

namespace full_set_up
{
    class Install_software
    {
        private static readonly string installCMD = @"choco install 7zip adobereader googlechrome teamviewer --yes";

        public static void Install()
        {
            try
            {
                Process.Start("powershell", installCMD).WaitForExit();
                Console.WriteLine();
                Console.WriteLine("Zainstalowano: Chrome, 7Zip, Adobe Reader, TeamViewer");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}.");
                throw;
            }
        }
    }
}
