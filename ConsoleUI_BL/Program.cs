﻿using System;
using System.Runtime.Serialization;
using IBL.BO;

namespace ConsoleUI_BL
{
    partial class Program
    {
        static void Main(string[] args)
        {
            PrintEnterToTheProject();

            int choises = 0;

            IBL.IBL bl = new BL();

            do
            {
                Pause();

                PrintFirstMenu();
                int.TryParse(Console.ReadLine(), out choises);

                try
                {
                    switch (choises)
                    {
                        case 1:
                            PrintMenu1();
                            Switch1(bl);
                            break;
                        case 2:
                            PrintMenu2();
                            Switch2(bl);
                            break;
                        case 3:
                            PrintMenu3();
                            Switch3(bl);
                            break;
                        case 4:
                            PrintMenu4();
                            Switch4(bl);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    PrintException(e);
                }
            } while (choises != 5);
        }
    }
}
