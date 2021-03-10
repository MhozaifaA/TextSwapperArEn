using System;
using System.Diagnostics;
using TextSwapperArEn;

namespace TextSwapperConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool IsArToEn = false;
            Console.WriteLine("Wellcome to TextSwapper console version");
            Console.WriteLine(">--------------------------------------");

            Console.WriteLine("q to Quit");

            Console.WriteLine("The Default Swap En->Ar press 'e' to change to 'En->Ar' or 'a' to 'Ar->En' ");
            Console.WriteLine("or just enter your text \n");

            string enter = string.Empty;
            while(!enter.Equals("q",StringComparison.OrdinalIgnoreCase))
            {
               enter=Console.ReadLine();

                switch (enter)
                {
                    case "e" or "E":
                        IsArToEn = false;
                        Console.WriteLine($">Flip to :{(IsArToEn ? "Ar->En" : "En->Ar")}: done ");
                        break;

                    case "a" or "A":
                        IsArToEn = true;
                        Console.WriteLine($">Flip to :{(IsArToEn ? "Ar->En" : "En->Ar")}: done ");
                        break;

                    case "q" or "Q" or "":
                        continue;

                    default:
                        string data = "";
                        Console.WriteLine($"To {(IsArToEn ? "Ar->En" : "En->Ar")}:  ");

                        if (IsArToEn)
                        {

                            data = enter.LayoutArToEn();
                        }
                        else
                        {
                            data = enter.LayoutEnToAr();
                        }
                        try
                        {
                            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/TextSwapper.txt",
                                data);
                        }
                        catch (UnauthorizedAccessException)
                        {
                           
                            System.IO.StreamWriter myStream = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "/TextSwapper.txt", append: true);
                            myStream.WriteLine(data);
                            myStream.Close();
                        }
                        Console.WriteLine(data);
                        Console.WriteLine("---------------------------------------");
                     
                        try
                        {
                            Process.Start( new ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/TextSwapper.txt") { UseShellExecute=true });
                        }
                        catch (Exception)
                        {
                        }
                      
                        break;
                }

            }
        }
    }
}
