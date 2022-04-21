using System.Diagnostics;
using full_set_up;
using Sharprompt;

string runner = "powershell";

Console.WriteLine();
Console.WriteLine("Witaj, Zaraz wybierzesz co zostanie zrobione,");
Console.WriteLine("Ale na razie sprawdzimy twoje połaczenie z internetem.");
Console.WriteLine();

Console.WriteLine("Running ping to check internet connection...");
Process.Start(runner, "ping 8.8.8.8").WaitForExit();
Console.WriteLine();


bool flag = true;

while (flag)
{
    // Zaczynamy
    var val = Prompt.Select("Co chcesz Zrobić?", new[] {"Sprawdź pogodę", "Zainstaluj Choco", "Zainstaluj Driver ODBC I biblioteki VS C++",
                             "Zainstaluj Chrome + Adobe + TeamViewer", "Zainstaluj CRM-a", "Więcej...", "Zakończ."});


    switch (val)
    {
        case "Sprawdź pogodę":
            Check_weather.check();
            break;
        case "Zainstaluj Choco":
            choco_install.Install();
            break;
        case "Zainstaluj Driver ODBC I biblioteki VS C++":
            install_odbc_and_redist.Install();
            break;
        case "Zainstaluj Chrome + Adobe + TeamViewer":
            Install_software.Install();
            break;
        case "Zainstaluj CRM-a":
            installing_crm.Install();
            break;
        case "Więcej...":
            Console.WriteLine("Wiecej opcji już niedługo");
            break;
        case "Zakończ.":
            Console.WriteLine("Do widzenia.");
            flag = false;  
            break;
    }
    if (flag)
    {
        Console.WriteLine();
    }
}
// System.Environment.Exit(0);