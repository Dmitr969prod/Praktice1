using System;
using System.Collections.Generic;

using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor=ConsoleColor.DarkCyan;
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Л');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("евая");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Ф');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("айл");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('Д');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("иск");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('К');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("оманды");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("    ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('П');
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("равая");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write("                             ");
            Console.BackgroundColor=ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2554");
            for(int i = 0; i < 12; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\u2550");
            }

            Console.Write(" C:\\NC ");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2557");
            
            Console.Write("\u2554");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\u2550");
            }
            Console.BackgroundColor= ConsoleColor.Cyan;
            Console.Write(" C:\\NC ");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\u2564");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("\u2550");
            }
            Console.Write("\u2564");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\u2550");
            }
            Console.WriteLine("\u2557");


            Console.Write("\u2551");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"C:  Имя");
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("    ");
            Console.Write("Имя");
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("    ");
            Console.Write("Имя");
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2551");
            Console.Write("\u2551");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.Write($"C:  Имя");
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2502  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Размер ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2502  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Дата  ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Время ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\u2551");

            for (int i=0; i<17; i++)
            {
                Console.Write("\u2551");
                for(int j=0; j < 12; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2502");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2502");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2551");
                Console.Write("\u2551");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2502");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2502");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\u2502");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\u2551");
            }
            Console.Write("\u255F");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2562");
            Console.Write("\u255F");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 8; i++)
            {
                Console.Write("\u2500");
            }
            Console.Write("\u2534");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\u2500");
            }
            Console.WriteLine("\u2562");

            Console.Write("\u2551");
            Console.Write("..");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ");
            }
            Console.Write($" >КАТАЛОГ< 11.10.02  19:48\u2551");
            Console.Write("\u2551");
            Console.Write("..");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($" >КАТАЛОГ< 11.10.02  19:48\u2551");


            Console.Write("\u255A");
            for (int i = 0; i < 38; i++)
            {
                Console.Write("\u2550");

            }
            Console.Write("\u255D");
            Console.Write("\u255A");
            for (int i = 0; i < 38; i++)
            {
                Console.Write("\u2550");

            }
            Console.WriteLine("\u255D");


            /* string[] array = {"ImageEditor.exe 8388608 14.08.2024 16:30",
 "SalesSummary.xlsx 1048576 21.09.2024 10:15",
 "VacationClip.mp4 209715200 30.07.2023 21:45",
 "SetupInstaller.msi 20971520 15.10.2024 14:20",
 "GuideDocument.pdf 314572 02.06.2024 08:50",
 "MainCode.py 20480 12.09.2024 18:40",
 "InvoiceClient.docx 419430 06.04.2024 12:00",
 "BackupPlaylist.m3u 20480 22.08.2024 17:25",
 "LogAccess.txt 81920 11.10.2024 09:15",
 "ConfigServer.xml 32768 05.11.2023 09:30",
 "ProductPicture.png 4194304 25.03.2024 15:20",
 "BudgetMonthly.csv 1048576 02.05.2024 11:10",
 "SlidesPresentation.pptx 4194304 20.07.2024 20:35",
 "BackupDB.sql 12582912 27.10.2024 22:55",
 "ShortMovie.mov 67108864 13.09.2024 11:40",
 "PrototypeUX.sketch 20971520 29.07.2024 12:50",
 "AudioRecording.wav 67108864 18.06.2024 19:30",
 "FilesWebsite.zip 52428800 26.04.2024 18:15",
 "AnimationClip.mov 167772160 09.10.2024 23:45",
 "FontCustom.otf 3145728 08.01.2024 10:30",
 "DataResearch.txt 81920 14.08.2024 14:05",
 "DesignArchitectural.dwg 16777216 19.09.2024 15:20",
 "GameSetup.exe 52428800 23.05.2024 12:40",
 "PolicyPrivacy.rtf 81920 17.12.2023 17:10",
 "ScriptAutomation.sh 16384 25.10.2024 07:45"};

             foreach(string str in array)
             {
                 Console.WriteLine(str);
             }*/

            List<FileInfo> files = new List<FileInfo>
            {
                 new FileInfo { Name = "ImageEditor", Extension = ".exe", Size = 8388608, Date = "14.08.24", Time = "16:30" },
    new FileInfo { Name = "SalesSummary", Extension = ".xlsx", Size = 1048576, Date = "21.09.24", Time = "10:15" },
    new FileInfo { Name = "VacationClip", Extension = ".mp4", Size = 209715200, Date = "30.07.23", Time = "21:45" },
    new FileInfo { Name = "SetupInstaller", Extension = ".msi", Size = 20971520, Date = "15.10.24", Time = "14:20" },
    new FileInfo { Name = "GuideDocument", Extension = ".pdf", Size = 314572, Date = "02.06.24", Time = "08:50" },
    new FileInfo { Name = "MainCode", Extension = ".py", Size = 20480, Date = "12.09.24", Time = "18:40" },
    new FileInfo { Name = "InvoiceClient", Extension = ".docx", Size = 419430, Date = "06.04.24", Time = "12:00" },
    new FileInfo { Name = "BackupPlaylist", Extension = ".m3u", Size = 20480, Date = "22.08.24", Time = "17:25" },
    new FileInfo { Name = "LogAccess", Extension = ".txt", Size = 81920, Date = "11.10.24", Time = "09:15" },
    new FileInfo { Name = "ConfigServer", Extension = ".xml", Size = 32768, Date = "05.11.23", Time = "09:30" },
    new FileInfo { Name = "ProductPicture", Extension = ".png", Size = 4194304, Date = "25.03.24", Time = "15:20" },
    new FileInfo { Name = "BudgetMonthly", Extension = ".csv", Size = 1048576, Date = "02.05.24", Time = "11:10" },
    new FileInfo { Name = "SlidesPresentation", Extension = ".pptx", Size = 4194304, Date = "20.07.24", Time = "20:35" },
    new FileInfo { Name = "BackupDB", Extension = ".sql", Size = 12582912, Date = "27.10.24", Time = "22:55" },
    new FileInfo { Name = "ShortMovie", Extension = ".mov", Size = 67108864, Date = "13.09.24", Time = "11:40" },
    new FileInfo { Name = "PrototypeUX", Extension = ".sketch", Size = 20971520, Date = "29.07.24", Time = "12:50" },
    new FileInfo { Name = "AudioRecording", Extension = ".wav", Size = 67108864, Date = "18.06.24", Time = "19:30" },
    new FileInfo { Name = "FilesWebsite", Extension = ".zip", Size = 52428800, Date = "26.04.24", Time = "18:15" },
    new FileInfo { Name = "AnimationClip", Extension = ".mov", Size = 167772160, Date = "09.10.24", Time = "23:45" },
    new FileInfo { Name = "FontCustom", Extension = ".otf", Size = 3145728, Date = "08.01.24", Time = "10:30" },
    new FileInfo { Name = "DataResearch", Extension = ".txt", Size = 81920, Date = "14.08.24", Time = "14:05" },
    new FileInfo { Name = "DesignArchitectural", Extension = ".dwg", Size = 16777216, Date = "19.09.24", Time = "15:20" },
    new FileInfo { Name = "GameSetup", Extension = ".exe", Size = 52428800, Date = "23.05.24", Time = "12:40" },
    new FileInfo { Name = "PolicyPrivacy", Extension = ".rtf", Size = 81920, Date = "17.12.23", Time = "17:10" },
    new FileInfo { Name = "ScriptAutomation", Extension = ".sh", Size = 16384, Date = "25.10.24", Time = "07:45" },
    new FileInfo { Name = "ProjectPlan", Extension = ".mpp", Size = 10485760, Date = "01.01.24", Time = "09:00" },
    new FileInfo { Name = "ResearchPaper", Extension = ".doc", Size = 524288, Date = "15.02.24", Time = "11:30" },
    new FileInfo { Name = "PresentationSlides", Extension = ".ppt", Size = 2097152, Date = "10.03.24", Time = "14:00" },
    new FileInfo { Name = "DatabaseBackup", Extension = ".bak", Size = 104857600, Date = "20.04.2024", Time = "16:45" },
    new FileInfo { Name = "SourceCode", Extension = ".cs", Size = 10240, Date = "05.05.2024", Time = "13:20" },
    new FileInfo { Name = "WebPage", Extension = ".html", Size = 5120, Date = "25.06.2024", Time = "10:10" },
    new FileInfo { Name = "StyleSheet", Extension = ".css", Size = 2048, Date = "30.07.2024", Time = "15:50" },
    new FileInfo { Name = "ScriptFile", Extension = ".js", Size = 4096, Date = "12.08.2024", Time = "18:30" },
    new FileInfo { Name = "ConfigurationFile", Extension = ".ini", Size = 1024, Date = "22.09.2024", Time = "08:00" },
    new FileInfo { Name = "LogFile", Extension = ".log", Size = 8192, Date = "03.10.2024", Time = "19:40" },
    new FileInfo { Name = "Spreadsheet", Extension = ".ods", Size = 1048576, Date = "14.11.2024", Time = "12:15" },
    new FileInfo { Name = "VectorGraphic", Extension = ".svg", Size = 51200, Date = "25.12.2024", Time = "17:55" },
    new FileInfo { Name = "AudioFile", Extension = ".mp3", Size = 10485760, Date = "05.01.2025", Time = "20:25" },
    new FileInfo { Name = "VideoFile", Extension = ".avi", Size = 209715200, Date = "16.02.2025", Time = "22:10" },
    new FileInfo { Name = "CompressedArchive", Extension = ".rar", Size = 52428800, Date = "27.03.2025", Time = "09:35" },
    new FileInfo { Name = "ExecutableFile", Extension = ".bat", Size = 2048, Date = "08.04.25", Time = "11:50" },
    new FileInfo { Name = "DiskImage", Extension = ".iso", Size = 1073741824, Date = "19.05.25", Time = "14:05" },
    new FileInfo { Name = "FontFile", Extension = ".ttf", Size = 1048576, Date = "30.06.25", Time = "16:20" },
    new FileInfo { Name = "CADDrawing", Extension = ".dxf", Size = 5242880, Date = "11.07.25", Time = "18:35" },
    new FileInfo { Name = "EBook", Extension = ".epub", Size = 2097152, Date = "22.08.25", Time = "20:50" },
    new FileInfo { Name = "PresentationTemplate", Extension = ".potx", Size = 1048576, Date = "02.09.25", Time = "09:15" },
    new FileInfo { Name = "DatabaseScript", Extension = ".sql", Size = 5120, Date = "13.10.25", Time = "11:30" },
    new FileInfo { Name = "PythonScript", Extension = ".py", Size = 2048, Date = "24.07.23", Time="11:33" }
            };

            /* foreach (var file in files)
             {
                 Console.WriteLine($"Name:{file.Name}, Size: {file.Size}, Date: {file.Date}, Time: {file.Time}");
             }*/
                int str=3, col=1;
            
                
                Console.SetCursorPosition(col, str);
                foreach (var file in files.OrderBy(w => w.Name))
                {
                    if (file.Name.Length > 8)
                    {
                        char[] MyStr = file.Name.ToCharArray();
                        string Output = "";
                        for (int i = 0; i < 7; i++)
                        {
                            Output += MyStr[i];
                        }
                        Output += "~";
                        Console.Write($"{Output} ");
                    }
                    else
                    {
                        Console.Write($"{file.Name} ");
                    }
                    Console.SetCursorPosition(col+9, str);
                    if (file.Extension.Length >= 4)
                    {
                        char[] MyStr = file.Extension.ToCharArray();
                        string Output = "";
                        for (int i = 1; i < 4; i++)
                        {
                            Output += MyStr[i];
                        }
                        Console.WriteLine(Output);
                    }
                    else
                    {
                        char[] MyStr = file.Extension.ToCharArray();
                        string Output = "";
                        for (int i = 1; i < 3; i++)
                        {
                            Output += MyStr[i];
                        }
                        Console.WriteLine($" {Output}");
                    }



                    str++;
                    if (str == 20)
                    {
                        str = 3;
                        col += 13;
                   
                    }
                    if (col > 35)
                    {
                        break;
                    }
                    Console.SetCursorPosition(col, str);
                }
            
            str = 3;
            
            foreach (var file in files)
            {
                col = 41;
                Console.SetCursorPosition(col, str);
                if (file.Name.Length > 8)
                {
                    char[] MyStr = file.Name.ToCharArray();
                    string Output = "";
                    for (int i = 0; i < 7; i++)
                    {
                        Output += MyStr[i];
                    }
                    Output += "~";
                    Console.Write($"{Output} ");
                }
                else
                {
                    Console.Write($"{file.Name} ");
                }
                Console.SetCursorPosition(col + 9, str);
                if (file.Extension.Length >= 4)
                {
                    char[] MyStr = file.Extension.ToCharArray();
                    string Output = "";
                    for (int i = 1; i < 4; i++)
                    {
                        Output += MyStr[i];
                    }
                    Console.WriteLine(Output);
                }
                else
                {
                    char[] MyStr = file.Extension.ToCharArray();
                    string Output = "";
                    for (int i = 1; i < 3; i++)
                    {
                        Output += MyStr[i];
                    }
                    Console.WriteLine($" {Output}");
                    
                }

                string NewStr = file.Size.ToString();
                col = 54+(9-NewStr.Length);
                Console.SetCursorPosition(col, str);
                Console.WriteLine(NewStr);


                col = 64;
                Console.SetCursorPosition(col, str);
                Console.WriteLine(file.Date);

                col = 74;
                Console.SetCursorPosition(col, str);
                Console.WriteLine(file.Time);

                
                str++;
                if (str == 20)
                {
                    break;


                }

                Console.SetCursorPosition(col, str);
            }

                

                Console.ReadLine();
        }
    }
}
