using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            */

            //tictactoe();

            //counter();

            //firstTriangle();

            //mathOp();

            //triangle();

            //fizzBuzz();

            //array();

            //babisUppgift();

            //babisUppgift2();

            //babisUppgift3();

            //babisUppgift4();

            //babisUppgift5();

            //babisUppgift6();

            //babisUppgift7();

            //kassa();

            //lager();

            talArray();
        }

        static void repeatYN(Action func)
        {
            Console.WriteLine();
            Console.Write("Do you want to play one more game [Y/N]: ");

            string answer = Console.ReadLine();
            Console.WriteLine();
            if (answer == "Y" || answer == "y")
            {
                func();

            }
            else if (answer == "N" || answer == "n")
            {
                Console.Write("");
            }
            else
            {
                Console.WriteLine("You fucking retard, you don't deserve another game");
                Console.WriteLine();
            }
        }

        static void tictactoe()

        {
            bool isGameGoing = true;
            bool isDraw = false;
            bool xTurn = true;
            string[] values = new string[9];
            Console.Write("Are you a retard [Y/N]: ");
            string answer = Console.ReadLine();
            Console.WriteLine();
            if (answer == "N" || answer == "n")
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = " ";
                }

            }
            else
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = $"{i + 1}";
                }
            }


            Console.Write("Enter an integer between 1 and 9, ");

            while (isGameGoing)
            {
                if (xTurn)
                {
                    Console.Write("Player X: ");
                }
                else
                {
                    Console.Write("Player O: ");
                }
                int num;
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine();
                    Console.WriteLine("An invalid input was given");
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    continue;

                }

                if (num > 9 || num < 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(num + " is an invalid input");
                    Console.WriteLine();
                    continue;
                }
                if (values[num - 1] != " " && values[num - 1] != $"{num}")
                {
                    Console.WriteLine();
                    Console.WriteLine("Spot " + num + " is already taken");
                    Console.WriteLine();
                    continue;
                }

                if (xTurn)
                {
                    values[num - 1] = "X";
                }
                else
                {
                    values[num - 1] = "O";
                }
                Console.WriteLine();

                for (int i = 0; i < 3; i++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        int index = (n + 1) + 3 * (i);

                        String value = values[index - 1];
                        if (n == 2)
                        {
                            Console.Write(value);
                            continue;
                        }
                        Console.Write(value);
                        Console.Write("|");
                    }

                    Console.WriteLine();
                    if (i != 2)
                    {
                        for (int n = 0; n < 5; n++)
                        {

                            Console.Write("-");

                        }

                    }
                    Console.WriteLine();

                }

                for (int i = 0; i < 9; i++)
                {
                    if (values[i] != "O" && values[i] != "X")
                    {

                        break;
                    }
                    if (i == 8)
                    {
                        isGameGoing = false;
                        isDraw = true;
                    }

                }


                if ((values[0] == "O" && values[4] == "O" && values[8] == "O") || (values[0] == "X" && values[4] == "X" && values[8] == "X"))
                {
                    isGameGoing = false;
                    isDraw = false;
                }

                if ((values[2] == "O" && values[4] == "O" && values[6] == "O") || (values[2] == "X" && values[4] == "X" && values[6] == "X"))
                {
                    isGameGoing = false;
                    isDraw = false;

                }

                for (int i = 0; i < 3; i++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        int index = ((n + 1) + 3 * (i)) - 1;
                        if (n == 0)
                        {
                            if ((values[index] == "O" && values[index + 1] == "O" && values[index + 2] == "O") || (values[index] == "X" && values[index + 1] == "X" && values[index + 2] == "X"))
                            {
                                isGameGoing = false;
                                isDraw = false;
                            }
                        }

                        if (i == 0)
                        {
                            if ((values[index] == "O" && values[index + 3] == "O" && values[index + 6] == "O") || (values[index] == "X" && values[index + 3] == "X" && values[index + 6] == "X"))
                            {
                                isGameGoing = false;
                                isDraw = false;
                            }
                        }

                    }
                }


                xTurn = !xTurn;

            }
            if (isDraw)
            {
                Console.WriteLine("Epic Draw");
            }
            else
            {
                String player;
                if (xTurn)
                {
                    player = "O";
                }
                else
                {
                    player = "X";
                }
                Console.WriteLine("Congrats palyer " + player);
            }
            repeatYN(tictactoe);
        }

        static void counter()
        {

            for (int n = 0; n < 1000000000; n++)
            {
                Console.WriteLine(n);
            }
        }

        static void firstTriangle()
        {

            Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" / \"\" \\");
            Console.WriteLine("/______\\");
            Console.WriteLine("   /\\\n  /  \\\n / \"\" \\\n/______\\");

        }

        static void mathOp()
        {
            Console.WriteLine("ENter som enumber");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition Thing: {0}", some(input));
            Console.WriteLine("Factorial: {0}", fac(input));
            Console.WriteLine("Fibonacci: {0}", fib(input));

        }
        static int some(int n)
        {
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                num += i;
            }
            return num;
        }

        static int fac(int n)
        {
            int num = 1;
            for (int i = 1; i <= n; i++)
            {
                num *= i;
            }
            return num;
        }

        static int fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return fib(n - 1) + fib(n - 2);
            }
        }
        static void rect()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < 10; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void triangle()
        {
            Console.Write("Enter an integer:");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < r; i++)
            {
                for (int x = 0; x < r - 1 - i; x++)
                {
                    Console.Write(" ");
                }

                for (int n = 0; n < 2 * i + 1; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            repeatYN(triangle);

        }
        static void fizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
        static void array()
        {
            int[] numbers = genarateNumbers();
            printArray(numbers);
            reverse(numbers);
            printArray(numbers);


        }

        static int[] genarateNumbers()
        {
            var rand = new Random();
            int arrayLength = rand.Next(1, 100);
            int[] numbers = new int[arrayLength];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(0, 9);
            }
            return numbers;
        }
        static int[] reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int number = numbers[i];
                numbers[i] = numbers[numbers.Length - i - 1];
                numbers[numbers.Length - i - 1] = number;
            }
            return numbers;
        }

        static void printArray(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
        }

        static void babisUppgift()
        {


            test();

            medelvärde();

            yearsLeftTo2100();

            blandadForm();

            medellön();

            triangelnsArea();

            secondsToHoursMinutesAndSecounds();

            fahrenheitToCelsius();

        }

        static void test()
        {
            int tal1, tal2;
            Console.Write("Enter a number: ");
            tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number: ");
            tal2 = Convert.ToInt32(Console.ReadLine());
            int summa = tal1 + tal2;
            Console.WriteLine("Summan är {0}", summa);
            string meddelande = "Babis";
            string namn = "hej";
            string yrke = "fisk";
            Console.WriteLine("{0} du heter {1} och gillar {2}", namn, meddelande, yrke);
        }

        static void medelvärde()
        {
            int tal1 = 56;
            int tal2 = 34;
            double meddelvärdet = (tal1 + tal2) / 2;
            Console.WriteLine("Medevärdet är {0}", meddelvärdet);
        }

        static void yearsLeftTo2100()
        {
            int currentYear = 2020;
            int yearsLeft = 2100 - currentYear;
            Console.WriteLine("There are {0} years left to year 100", yearsLeft);
        }

        static void blandadForm()
        {
            Console.Write("Enter a numerator: ");
            int täljare = int.Parse(Console.ReadLine());
            Console.Write("Enter a denominator: ");
            int nämnare = int.Parse(Console.ReadLine());
            double kvot = täljare / nämnare;
            double heltal = Math.Floor(kvot);
            int rest = täljare % nämnare;
            Console.WriteLine("{0}/{1} blir {2} {3}/{1} i blandad form", täljare, nämnare, heltal, rest);
        }

        static void medellön()
        {
            int tal1, tal2, tal3;
            Console.Write("Enter salary 1: ");
            tal1 = int.Parse(Console.ReadLine());
            Console.Write("Enter salary 2: ");
            tal2 = int.Parse(Console.ReadLine());
            Console.Write("Enter salary 3: ");
            tal3 = int.Parse(Console.ReadLine());
            double meddelvärdet = (tal1 + tal2 + tal3) / 3;
            Console.WriteLine("Medevärdet är {0}", meddelvärdet);
        }

        static void triangelnsArea()
        {
            int bas, höjd;
            Console.Write("Skriv basen här:");
            bas = int.Parse(Console.ReadLine());
            Console.Write("Skriv höjden här:");
            höjd = int.Parse(Console.ReadLine());
            double area = (bas * höjd) / 2;
            Console.WriteLine("Arean är {0}", area);
        }

        static void secondsToHoursMinutesAndSecounds()
        {
            Console.Write("Enter how many seconds here: ");
            double input = double.Parse(Console.ReadLine());
            double years = Math.Floor(input / (3600 * 24 * 7 * 52));
            double weeks = Math.Floor((input - (years * 3600 * 24 * 7 * 52)) / (3600 * 24 * 7));
            double days = Math.Floor((input - (years * 3600 * 24 * 7 * 52) - (weeks * 3600 * 24 * 7)) / (3600 * 24));
            double hours = Math.Floor((input - (years * 3600 * 24 * 7 * 52) - (weeks * 3600 * 24 * 7) - (days * 3600 * 24)) / (3600));
            double minutes = Math.Floor((input - (years * 3600 * 24 * 7 * 52) - (weeks * 3600 * 24 * 7) - (days * 3600 * 24) - (hours * 3600)) / (60));
            double secounds = input - (years * 3600 * 24 * 7 * 52) - (weeks * 3600 * 24 * 7) - (days * 3600 * 24) - (hours * 3600) - (minutes * 60);
            Console.WriteLine("{0} seconds is the same as {1} years, {2} weeks, {3} days, {4} hours, {5} minutes and {6} secounds.", input, years, weeks, days, hours, minutes, secounds);
        }

        static void fahrenheitToCelsius()
        {
            Console.Write("Enter a Farenheit degree here: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celcius = Math.Round((fahrenheit - 32) * 5 / 9, 1);
            Console.WriteLine("{0} degrees farenheit in celsius is {1}", fahrenheit, celcius);
        }

        static void babisUppgift2()
        {
            int max = 100;
            int antal = 0;
            int fibb1 = 0;
            int fibb2 = 1;

            Console.WriteLine(fibb1);
            Console.WriteLine(fibb2);

            while (antal < max)
            {

                Console.WriteLine(fibb1 + fibb2);

                if (antal % 2 == 0)
                {
                    fibb1 = fibb1 + fibb2;
                }
                else
                {
                    fibb2 = fibb1 + fibb2;
                }
                antal++;
            }

        }

        static void babisUppgift3()
        {
            golf();
            namnsdag();
            betyg();
        }

        static void golf()
        {
            Console.Write("Hur gammal är du: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 50)
            {
                Console.WriteLine("WOW du kom med i golfklubben");

            }
            else
            {
                Console.WriteLine("synd, du är tyvärr för ung för att komma med");
            }
        }

        static void namnsdag()
        {
            Console.Write("Vad heter du: ");
            string namn = Console.ReadLine();
            if (namn == "Stig")
            {
                Console.WriteLine("Grattis, du har namnsdag idag");
            }
            else if (namn == "Abraham")
            {
                Console.WriteLine("Grattis, du har namnsdag imorgon");
            }
            else
            {
                Console.WriteLine("Attans, du har varken namnsdag idag eller imorgon");
            }
        }

        static void betyg()
        {
            Console.Write("Ange din poäng i intervallet 0-60: ");
            int poäng = int.Parse(Console.ReadLine());
            Console.Write("Ditt betyg är ");
            if (poäng >= 60)
            {
                Console.WriteLine("inte tillgängligt, eftersom du inte har angett ett giltigt poäng ");
            }
            else if (poäng >= 48)
            {
                Console.WriteLine("A");
            }
            else if (poäng >= 36)
            {
                Console.WriteLine("C");
            }
            else if (poäng >= 24)
            {
                Console.WriteLine("E");
            }
            else if (poäng >= 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("inte tillgängligt, eftersom du inte har angett ett giltigt poäng ");
            }
        }

        static void babisUppgift4()
        {
            whileloop();
            forloop();
            numberSeries();
            numberGrid();
        }

        static void whileloop()
        {
            int number = 50;
            int min = 1;
            while (number >= min)
            {
                Console.WriteLine(number);
                number--;

            }
        }

        static void forloop()
        {
            for (int i = -20; i <= 3; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i >= -10; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 5; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            for (double i = 0.0; i <= 9.0; i += 0.3)
            {
                Console.WriteLine(i);
            }
        }

        static void numberSeries()
        {
            Console.Write("Enter an integer:");
            int r = int.Parse(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
                for (int n = 1; n <= i; n++)
                {
                    Console.Write(n);

                }
                Console.WriteLine();
            }
        }

        static void numberGrid()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int n = 1; n <= 10; n++)
                {
                    Console.Write(n * i + " ");

                }
                Console.WriteLine();
            }
        }

        static void babisUppgift5()
        {
            //städer();
            //sporter();
            //somTal();
            //somTal2();
            //somTal3();
        }

        static void städer()
        {
            string[] städer = new string[3];
            städer[0] = "Borås";
            städer[1] = "Jönköping";
            Console.Write("Skrv in en svensk stad: ");
            städer[2] = Console.ReadLine();
            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine(städer[i]);
            }
        }
        static void sporter()
        {
            Console.Write("Hur många sporter har de testat: ");
            int antalSporter = int.Parse(Console.ReadLine());
            string[] sporter = new string[antalSporter];
            for (int i = 0; i < sporter.Length; i++)
            {
                Console.Write("Skriv in sport " + (i + 1) + " : ");
                sporter[i] = Console.ReadLine();
            }
            Console.Write("Du har testat följande sporter: ");
            for (int i = 0; i < sporter.Length; i++)
            {
                Console.Write(sporter[1] + ", ");
            }
        }

        static void somTal()
        {
            int[] tal = { 2, 3, 4, 5, 1, 3, 64535, 342, 1, 12, 23, 4, 43, 433434 };
            int minstaTal = tal[0];
            int störstaTal = tal[0];
            for (int i = 0; i < tal.Length; i++)
            {
                if (tal[i] < minstaTal)
                {
                    minstaTal = tal[i];
                }
                if (tal[i] > störstaTal)
                {
                    störstaTal = tal[i];
                }
            }
            Console.WriteLine(minstaTal);
            Console.WriteLine(störstaTal);
        }

        static void somTal2()
        {
            try
            {
                Console.Write("Hur många tal ska lagras i min array: ");
                int längd = int.Parse(Console.ReadLine());
                int[] tal = new int[längd];
                for (int i = 0; i < tal.Length; i++)
                {
                    Console.Write("Skriv in tal " + (i + 1) + " : ");
                    tal[i] = int.Parse(Console.ReadLine());
                }
                double summa = 0;
                for (int i = 0; i < tal.Length; i++)
                {
                    summa += tal[i];
                }
                double medelvärde = summa / tal.Length;
                int minstaTal = (int)(Math.Round(medelvärde));
                int störstaTal = (int)(Math.Round(medelvärde));
                int minstaIndex = 0;
                int störstaIndex = 0;
                for (int i = 0; i < tal.Length; i++)
                {
                    if (tal[i] < minstaTal)
                    {
                        minstaTal = tal[i];
                        minstaIndex = i;
                    }
                    if (tal[i] > störstaTal)
                    {
                        störstaTal = tal[i];
                        störstaIndex = i;
                    }
                }
                IEnumerable<int> nyaTal = tal.Where((num, index) => index != minstaIndex && index != störstaIndex);
                int nästMinstaTal = (int)(Math.Round(medelvärde));
                int nästStörstaTal = (int)(Math.Round(medelvärde));
                foreach (int num in nyaTal)
                {
                    if (num < nästMinstaTal)
                    {
                        nästMinstaTal = num;
                    }
                    if (num > nästStörstaTal)
                    {
                        nästStörstaTal = num;
                    }
                }
                Console.WriteLine("Minsta tal: " + minstaTal);
                Console.WriteLine("Näst minsta tal: " + nästMinstaTal);
                Console.WriteLine("Största tal: " + störstaTal);
                Console.WriteLine("Näst största tal: " + nästStörstaTal);
                Console.WriteLine("Medevärde: " + medelvärde);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        static void kassa()
        {
            try
            {
                Console.Write("Ange totalsumma: ");
                double totalsumma = double.Parse(Console.ReadLine());
                Console.Write("Ange erhållet belopp: ");
                int erhålletBelopp = int.Parse(Console.ReadLine());
                if (erhålletBelopp < 0 || erhålletBelopp < totalsumma)
                {
                    Console.WriteLine("Du är fattig bre");
                    return;
                }
                string mellanslag(string tal)
                {
                    string värde = "";
                    for (int i = 0; i < (14 - tal.Length); i++)
                    {
                        värde = värde + " ";
                    }
                    värde = värde + tal;
                    return värde;
                }
                int attBetala = (int)Math.Round(totalsumma, 0);
                double öresavrundning = Math.Round(attBetala - totalsumma, 2);
                int tillbaka = erhålletBelopp - attBetala;
                Console.WriteLine();
                Console.WriteLine("KVITTO");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Total                   :" + mellanslag($"{totalsumma}") + " kr");
                Console.WriteLine("Öresavrundning          :" + mellanslag($"{öresavrundning}") + " kr");
                Console.WriteLine("Att Betala              :" + mellanslag($"{attBetala}") + " kr");
                Console.WriteLine("Kontant                 :" + mellanslag($"{erhålletBelopp}") + " kr");
                Console.WriteLine("Tillbaka                :" + mellanslag($"{tillbaka}") + " kr");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                int antal500 = (tillbaka / 500);
                int antal100 = (tillbaka % 500) / 100;
                int antal50 = (tillbaka % 100) / 50;
                int antal20 = (tillbaka % 50) / 20;
                int antal10 = (tillbaka % 20) / 10;
                int antal5 = (tillbaka % 10) / 5;
                int antal1 = (tillbaka % 5) / 1;
                if (antal500 > 0)
                {
                    Console.WriteLine(" 500-lappar             : " + antal500);
                }
                if (antal100 > 0)
                {
                    Console.WriteLine(" 100-lappar             : " + antal100);
                }
                if (antal50 > 0)
                {
                    Console.WriteLine("  50-lappar             : " + antal50);
                }
                if (antal20 > 0)
                {
                    Console.WriteLine("  20-lappar             : " + antal20);
                }
                if (antal10 > 0)
                {
                    Console.WriteLine("  10-lappar             : " + antal10);
                }
                if (antal5 > 0)
                {
                    Console.WriteLine("   5-lappar             : " + antal5);
                }
                if (antal1 > 0)
                {
                    Console.WriteLine("   1-lappar             : " + antal1);
                }
                Console.WriteLine();
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        static void lager()
        {
            bool isRunning = true;
            int storlek = 10;
            string[] namn = new string[storlek];
            int[] pris = new int[storlek];
            int[] antal = new int[storlek];

            int index = 0;

            while (isRunning)
            {
                try
                {
                    Console.Write("Vad vill du göra (C/R/U/D/E): ");
                    string action = Console.ReadLine().ToLower();

                    void read()
                    {
                        string mellanslag(string tal)
                        {
                            string värde = "";
                            {
                                for (int i = 0; i < (12 - tal.Length); i++)
                                {

                                    värde = värde + " ";
                                }
                                värde = värde + tal;
                                return värde;
                            }
                        }
                        Console.WriteLine("   |        Namn|        Pris|       Antal");

                        for (int i = 0; i < index; i++)
                        {
                            Console.WriteLine($" {i + 1} |{mellanslag(namn[i])}|{mellanslag($"{pris[i]}")}|{mellanslag($"{antal[i]}")}");
                        }
                    }

                    void create()
                    {
                        Console.Write("Vad ska varan heta: ");
                        namn[index] = Console.ReadLine();
                        Console.Write("Vad ska varan kosta: ");
                        pris[index] = int.Parse(Console.ReadLine());
                        Console.Write("Hur många vill du att det ska vara: ");
                        antal[index] = int.Parse(Console.ReadLine());
                        index++;
                    }

                    void update()
                    {
                        read();
                        Console.WriteLine();
                        Console.Write("Vilken product vill du ändra: ");
                        int plats = int.Parse(Console.ReadLine());
                        if (plats - 1 > index || plats == 0)
                        {
                            return;
                        }
                        Console.Write("Vilket fält vill du ändra (N/P/A): ");
                        string fält = Console.ReadLine().ToLower();

                        void ändraNamn()
                        {
                            Console.Write("Vad vill du ändra namnet till: ");
                            namn[plats - 1] = Console.ReadLine();
                        }

                        void ändraPris()
                        {
                            Console.Write("Vad vill du ändra priset till: ");

                            pris[plats - 1] = int.Parse(Console.ReadLine());
                        }

                        void ändraAntal()
                        {
                            Console.Write("Vad vill du ändra antalet till: ");

                            antal[plats - 1] = int.Parse(Console.ReadLine());
                        }

                        switch (fält)
                        {
                            case "n": ändraNamn(); break;
                            case "p": ändraPris(); break;
                            case "a": ändraAntal(); break;
                            default: break;

                        }
                    }

                    void delete()
                    {
                        read();
                        Console.WriteLine();
                        Console.Write("Vilken product vill du ta bort: ");
                        int plats = int.Parse(Console.ReadLine());

                        if (plats - 1 > index || plats == 0)
                        {
                            return;
                        }

                        for (int i = 0; i < index; i++)
                        {
                            if (plats - 1 <= i)
                            {
                                namn[i] = namn[i + 1];
                                pris[i] = pris[i + 1];
                                antal[i] = antal[i + 1];
                            }
                        }
                        index--;
                    }

                    void exit()
                    {
                        isRunning = false;
                    }

                    Console.WriteLine();
                    switch (action)
                    {
                        case "c": create(); break;
                        case "r": read(); break;
                        case "u": update(); break;
                        case "d": delete(); break;
                        case "e": exit(); break;
                        default: break;
                    }
                    Console.WriteLine();
                }


                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void babisUppgift6()
        {
            exceptionLoop();
            arrayBaklänges();

        }

        static void exceptionLoop()
        {
            int start = 0;
            int stop = 0;
            int steg = 0;
            while (true)
            {
                try
                {
                    Console.Write("Mata in start: ");
                    start = int.Parse(Console.ReadLine());
                    Console.Write("Mata in stop: ");
                    stop = int.Parse(Console.ReadLine());
                    Console.Write("Mata in steg: ");
                    steg = int.Parse(Console.ReadLine());
                    for (int i = start; i <= stop; i += steg)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }



        }
        static void arrayBaklänges()
        {
            int längd = 0;
            int[] lista;
            while (true)
            {
                try
                {
                    Console.Write("Hur lång ska din array vara: ");
                    längd = int.Parse(Console.ReadLine());
                    lista = new int[längd];
                    for(int i = 0; i < lista.Length; i++)
                    {
                        Console.Write($"Skriv in tal {i + 1}: ");
                        lista[lista.Length - i - 1] = int.Parse(Console.ReadLine());
                    }

                    foreach(int tal in lista)
                    {
                        Console.Write(" " + tal + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void babisUppgift7()
        {
            lönerevision();
        }

        static string mellanslag(string tal, int len)
        {
            string värde = "";
            for (int i = 0; i < (len - tal.Length); i++)
            {
                värde = värde + " ";
            }
            värde = värde + tal;
            return värde;
        }

        static void lönerevision()
        {
            int längd;
            int summa = 0;
            int medelvärde;
            int median;
            int lönespridning;
            int[] löner;
            int[] gamlaLöner;
            while (true)
            {
                try
                {
                    Console.Write("Ange antal löner att mata in: ");
                    längd = int.Parse(Console.ReadLine());
                    löner = new int[längd];
                    for(int i = 0; i < löner.Length; i++)
                    {
                        Console.Write($"Ange lön nummer {i + 1}: ");
                        int input = int.Parse(Console.ReadLine());
                        summa += input;
                        löner[i] = input;
                    }
                    medelvärde = Convert.ToInt32(löner.Average());
                    gamlaLöner = löner;
                    Array.Sort(löner);
                    if(löner.Length % 2 == 0)
                    {
                        median = (löner[(löner.Length / 2) - 1] + löner[(löner.Length / 2)]) / 2;
                    } else
                    {
                        median = löner[(löner.Length / 2)];
                    }
                    lönespridning = löner.Max() - löner.Min();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Medianlön:        " + mellanslag($"{median}", 10) + " KR");
                    Console.WriteLine("Medellön:         " + mellanslag($"{medelvärde}", 10) + " KR");
                    Console.WriteLine("Lönespridninglön: " + mellanslag($"{lönespridning}", 10) + " KR");
                    Console.WriteLine("---------------------------------------------");
                    for (int i = 0; i < gamlaLöner.Length; i++)
                    {
                        if(i % 3 == 2)
                        {
                            Console.WriteLine("    " + gamlaLöner[i]);
                        } else
                        {
                            Console.Write("    " + gamlaLöner[i]);
                        }
                    }
                    Console.WriteLine();
                    Console.Write("Klicka esc för att avbryta och vad som helst för att förtsätta: ");
                    Console.WriteLine();
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void talArray()
        {
            Console.Write("Hur många tal vill du mata in: ");
            int längd = int.Parse(Console.ReadLine());
            int[] tal = new int[längd];
            for (int i = 0; i < längd; i++)
            {
                Console.Write($"Tal {i + 1}: ");
                tal[i] = int.Parse(Console.ReadLine());
            }


            int konstigLängd = 0;

            foreach (int t in tal)
            {
                if (t <= 100 && t >= 1)
                {
                    Console.Write(t + " ");
                }
                else
                {
                    konstigLängd++;
                }
            }
            Console.WriteLine();
            int konstigIndex = 0;
            int[] konstigaNummer = new int[konstigLängd];
            foreach (int t in tal)
            {
                if (t > 100 || t < 1)
                {
                    konstigaNummer[konstigIndex] = t;
                    konstigIndex++;
                }
            }
            foreach (int k in konstigaNummer)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        }
    }
}
