using System.Diagnostics;

namespace full_set_up
{
    class installing_crm
    {
        private static readonly string installCMD = @"robocopy \\app1\Resources\03_INSTALKI\00_CRM C:\CRM /mir /MT /z";

        public static void Install()
        {
            try
            {
                Process.Start("powershell", installCMD).WaitForExit();
                Console.WriteLine();
                Console.WriteLine("Zainstalowano: CRM na dysku C, w folderze CRM.");
                Console.WriteLine("Możesz teraz dodać ikonę do paska lub Menu.");
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
