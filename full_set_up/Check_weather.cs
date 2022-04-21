using System.Diagnostics;

namespace full_set_up
{
    class Check_weather
    {
        private static readonly string CMD = "Invoke-RestMethod wttr.in";

        public static void check()
        {
            try
            {
                Process.Start("powershell", CMD).WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}.");
                throw;
            }
        }
    }
}