using System.Diagnostics;

namespace full_set_up
{
    class install_odbc_and_redist
    {
        private static string installCMD = "choco install vcredist140 sqlserver-odbcdriver --yes";

        public static void Install()
        {
            try
            {
                Process.Start("powershell", installCMD).WaitForExit();
                Console.WriteLine("Odbc i Redist zainstalowane.");
                Console.WriteLine("Za 30 sekund nastapi Restart komputera");
                Thread.Sleep(30000);
                Process.Start("powershell", "Restart-Computer");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}.");
                throw;
            }
        }
    }
}
