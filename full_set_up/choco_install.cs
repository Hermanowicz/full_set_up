using System.Diagnostics;

namespace full_set_up
{
    class choco_install
    {
        private static string command = @"Set - ExecutionPolicy Bypass -Scope Process -Force; 
                                   [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072;
                                   iex((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))";
       public static void Install()
        {
            try
            {
                Process.Start("powershell", command).WaitForExit();
                Console.WriteLine("Choco zostało zainstalowane.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}.");
                throw;
            }
        }
    }
}
