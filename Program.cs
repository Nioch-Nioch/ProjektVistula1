using System;

namespace program
{
    class Program
    {


        public static void ClearCurrentConsoleLine() //czyszczenie konsoli
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        static (float, int) calculation(bool isAdding) //jeśli fausz to pomnóż jeśli prawda to dodaj
        {
            float suma;
            if (isAdding) { suma = 0.0F; } //suma zaczyna się od 0 kiedy dodajemy
            else { suma = 1.0F; }  //suma zaczyna się od 1 kiedy mnożymy

            Console.Write("\n\tdługość ciągu n= :");

            string numberStr = Console.ReadLine();
            int number;


            bool isParsable = Int32.TryParse(numberStr, out number);
            if (!isParsable || number < 0)
            {
                do
                {
                    Console.WriteLine("\tNie jest to liczba całkowita nieujemna upewnij się że wprowadzasz poprawne dane");
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    System.Threading.Thread.Sleep(1000);

                    ClearCurrentConsoleLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    Console.Write("\n\tdługość ciągu n= :");
                    numberStr = Console.ReadLine();
                    isParsable = Int32.TryParse(numberStr, out number);
                } while (!isParsable || number <= 0);


            }
            float number_n;
            for (int n = 0; n < number; n++)
            {
                Console.Write("\n\tn " + n.ToString() + " = :?");


                numberStr = Console.ReadLine();



                bool isParsable_n = float.TryParse(numberStr, out number_n);
                if (!isParsable_n)
                {
                    do
                    {
                        Console.WriteLine("\tNie jest to liczba poprawna");
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        System.Threading.Thread.Sleep(1000);
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        Console.Write("\n\tn " + n.ToString() + " = :?");
                        numberStr = Console.ReadLine();
                        isParsable_n = float.TryParse(numberStr, out number_n);
                    } while (!isParsable_n);


                }
                if (isAdding) { suma += number_n; }
                else { suma *= number_n; }



            }


            (float suma, int number) p = (suma, number);
            return p;
        }



        static void MainMenu()
        {
            Console.Clear();
            ConsoleKeyInfo CKI;
            bool needtobedisplayed = true;
            do
            {
                Console.WriteLine("\n\n\tProgram obliczenia wielkości matematycznych umożliwia" + " oblicznanie wartości wybranych wielkości matematycznych");
                Console.WriteLine("\n\tA. Obliczanie ceny jednostki paszy (in-line)");
                Console.WriteLine("\n\tB. Obliczanie ceny jednostki paszy (Method-call)");
                Console.WriteLine("\n\tC. Obliczanie średniej harmonicznej (in-line)");
                Console.WriteLine("\n\tD. Obliczanie średniej harmonicznej (Method-call)");
                Console.WriteLine("\n\tE. Obliczanie średniej geometrycznej (in-line)");
                Console.WriteLine("\n\tF. Obliczanie średniej geometrycznej (Method-call)");
                Console.WriteLine("\n\tG. Obliczanie średniej kwadratowej (in-line)");
                Console.WriteLine("\n\tH. Obliczanie średniej kwadratowej (Method-call)");   
                Console.WriteLine("\n\tI. Obliczanie średniej podęgowej <średniej uogólnionej> (in-line)");
                Console.WriteLine("\n\tJ. Obliczanie średniej podęgowej <średniej uogólnionej> (Method-call)");
                Console.WriteLine("\n\tK. Obliczanie (konwersja) znakowego zapisu liczby całkowitej w systemie liczbowym " + " o podanej (przez użytkownika programu) podstawie liczenia (in-line)");      
                Console.WriteLine("\n\tX. Zakończ");
                Console.Write("\n\tNaciśnij klawisz przyporządkowny funkcjionalności aby ją wybrać");
                Console.WriteLine("\n\t");

                CKI = Console.ReadKey();
                char x = CKI.KeyChar;
                Console.Clear();
                switch (x.ToString().ToUpper())
                {
                    case "A":

                        Console.WriteLine("\n\tA. oblicznenie sumy wyrazów ciągu liczbowego");
                        needtobedisplayed = false;
                        float suma = 0.0F;
                        Console.Write("\n\tdługość ciągu n= :");

                        string numberStr = Console.ReadLine();
                        int number;


                        bool isParsable = Int32.TryParse(numberStr, out number);
                        if (!isParsable || number < 0)
                        {
                            do
                            {
                                Console.WriteLine("\tNie jest to liczba całkowita nieujemna upewnij się że wprowadzasz poprawne dane");
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                System.Threading.Thread.Sleep(1000);

                                ClearCurrentConsoleLine();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                ClearCurrentConsoleLine();
                                Console.Write("\n\tdługość ciągu n= :");
                                numberStr = Console.ReadLine();
                                isParsable = Int32.TryParse(numberStr, out number);
                            } while (!isParsable || number <= 0);


                        }
                        float number_n;
                        for (int n = 0; n < number; n++)
                        {
                            Console.Write("\n\tn " + n.ToString() + " = :?");


                            numberStr = Console.ReadLine();



                            bool isParsable_n = float.TryParse(numberStr, out number_n);
                            if (!isParsable_n)
                            {
                                do
                                {
                                    Console.WriteLine("\tNie jest to liczba poprawna");
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    System.Threading.Thread.Sleep(1000);
                                    ClearCurrentConsoleLine();
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    ClearCurrentConsoleLine();
                                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                                    ClearCurrentConsoleLine();
                                    Console.Write("\n\tn " + n.ToString() + " = :?");
                                    numberStr = Console.ReadLine();
                                    isParsable_n = float.TryParse(numberStr, out number_n);
                                } while (!isParsable_n);


                            }

                            suma += number_n;


                        }
                        Console.WriteLine(suma);

                        Console.WriteLine("naciśnij dowolny przycisk by wyjść do menu głównego");
                        Console.ReadKey();

                        MainMenu();



                        break;
                    case "B":
                        needtobedisplayed = false;
                        Console.WriteLine("\n\tB. obliczanie iloczynu wyrazów ciągu liczbowego");
                        Console.WriteLine("\n\t" + calculation(false).Item1);

                        Console.WriteLine("naciśnij dowolny przycisk by wyjść do menu głównego");
                        Console.ReadKey();

                        MainMenu();
                        break;
                    case "C":

                        Console.WriteLine("\n\tC.obliczanie siredniej arytmetycznej wyrazów ciągu liczbowego");
                        needtobedisplayed = false;
                        (float obj, int obj2) = calculation(true);
                        Console.WriteLine("\n\t" + (obj / obj2));

                        Console.WriteLine("\n\tnaciśnij dowolny przycisk by wyjść do menu głównego");
                        Console.ReadKey();

                        MainMenu();
                        break;



                    case "D":

                        Console.WriteLine("\n\tD. wywołanie metody dla obliczenia sumy wyrazów ciągu liczbowego");
                        needtobedisplayed = false;

                        Console.WriteLine("\n\t" + calculation(true).Item1);

                        Console.WriteLine("\n\tnaciśnij dowolny przycisk by wyjść do menu głównego");
                        Console.ReadKey();

                        MainMenu();
                        break;

                    case "X":
                        Console.WriteLine("\n\tX. Zakończ");
                        needtobedisplayed = false;
                        break;
                    default:
                        MainMenu();
                        break;
                }
            }
            while (needtobedisplayed);

        }
        static void Main(string[] args)
        {  //funkcja main
            MainMenu();
        }
    }
}
