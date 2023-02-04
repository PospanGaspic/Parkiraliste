using System;
using System.Collections.Generic;
using System.IO;

namespace Parkiraliste
{
    public class Program
    {

        public static void Main(string[] args)
        {
            park[] mjesta = new park[1];
            int izbor;
            //menu
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("izaberit broj od 1 do 4");
            izbor = Convert.ToInt32(Console.ReadLine());

        }

        /*   delete cili file
            string path = @"C:\users\bruno\source\Parkiraliste\bin\Debug\haha.txt";
            File.Delete(path);*/

        /*ovo je za vadit tocnu liniju, ali user bira koju, šta sad kad razmislim mi ne treba.
            int lineNumber = 3;
           
            Console.WriteLine("upisi broj");
            lineNumber = Convert.ToInt32(Console.ReadLine());

            try
            {
                using (StreamReader sr = File.OpenText("informacije.txt"))
                {
                    for (int i = 1; i < lineNumber; i++)
                    {
                        sr.ReadLine();
                    }

                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file: ");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }*/






        //ovo je streamreader za citat cilu datoteku

        /* using (StreamReader sr = File.OpenText("informacije.txt"))
        {
            string linija = "";
            while ((linija = sr.ReadLine()) != null)
            {
                Console.WriteLine(linija);
            }

        }
        Console.ReadKey();*/

        //ovo je sta smo zajeno radili

        /*string input = "";



        using (StreamWriter writer = new StreamWriter("informacije.txt"))
        {
            while (input != "-1")
            {
                Console.WriteLine("upisi ime : ");
                input = Console.ReadLine();

                if (input != "-1")
                {
                    writer.WriteLine(input);

                }


            }
            writer.Close();

            using (StreamReader citac = File.OpenText("informacije.txt"))
            {
                string linija = "";
                while ((linija = citac.ReadLine()) != null)
                {
                    Console.WriteLine(linija);
                }

            }*/



        /*napraviti file
             void WriteToFile (String ime)
        {
            using (StreamWriter writer = new StreamWriter("informacije.txt"))
            {

                writer.Write(ime);
            }
            Console.ReadKey();*/



        /* using (StreamWriter writer = new StreamWriter("informacije.txt"))
         {

             writer.WriteLine(imena);

         }
         Console.ReadKey();

      using (StreamReader citac = File.OpenText("informacije.txt") )
         {
             string linija = "";
             while((linija = citac.ReadLine()) != null)
             {
                 Console.WriteLine(linija);
             }
         }*/
    }

} 


        /*static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("GLAVNI IZBORNIK:");
            Console.WriteLine("");
            Console.WriteLine("1. Parkirna mjesta");
            Console.WriteLine("2. Financije");
            //Console.WriteLine("3. Stanje Blagajne");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Upišite broj ispred vašeg izbora za navigaciju i zatim tipku ENTER");

            string opcije;
            opcije = Console.ReadLine();
            switch (opcije)
            {
                case "1":
                    ParkirnaMjesta();
                    break;
                case "2":
                    Financije();
                    break;
                case "3":
                    StanjeBlagajne();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Molim vas izaberite postojeću kategoriju");
                    Console.ReadLine();
                    break;

            }
            MainMenu();
        }
        static void ParkirnaMjesta()
        {
            
        
            Console.Clear();
            Console.WriteLine("PARKIRNA MJESTA");
            Console.WriteLine("");
            Console.WriteLine("1. Ukupno mjesta");
            Console.WriteLine("2. Slobodna mjesta:");
            Console.WriteLine("3. Zauzeta Mjesta:");
            Console.WriteLine("4. Preplatnici:");
      
               
            Console.WriteLine("5. Povratak na Glavni izbornik");
            Console.WriteLine("");
            Console.WriteLine("za izmjenu podatka pritisnite broj ispred izbora i zatim tipku ENTER");
            
            string opcije1;
            opcije1 = Console.ReadLine();
            switch(opcije1)
            {
                case "1":
                    UkupnoMjesta();
                    break;
                case "2":
                    ZauzetaMjesta();
                    break;
                case "3":
                    SlobodnaMjesta();
                    break;
                case "4":
                    Pretplatnici();
                    break;
                case "5":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Molim vas izaberite postojeću kategoriju");
                    Console.ReadLine();
                    break;
                    void UkupnoMjesta()
                    {
                        string filepath = "info"
                        int all = int.Parse(Console.ReadLine());
                        Console.WriteLine("upisi broj");
                        all = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("broj koji ste upisali :" + all.ToString());
                        

                    }
                    void SlobodnaMjesta()
                    {
                        int free;
                        Console.WriteLine("upisi broj");
                        free = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("broj koji ste upisali :" + free.ToString());
                    }
                    void Pretplatnici()
                    {
                        string pret;
                        Console.WriteLine("upisi ime");
                        pret = Console.ReadLine();
                        Console.WriteLine("broj koji ste upisali :" + pret);
                    }
                    void ZauzetaMjesta()
                    {
                        int taken;
                        Console.WriteLine("upisi broj");
                        taken = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("broj koji ste upisali :" + taken.ToString());
                    }

            }

        }
        
        static void aaaaa()
        {

        }
        static void Financije()
        {
            Console.Clear();
            Console.WriteLine("FINANCIJE:");
            Console.WriteLine("");
            Console.WriteLine("1. Stanje Blagajne");
            Console.WriteLine("2. ");
            //Console.WriteLine("3. Stanje Blagajne");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.WriteLine("Upišite broj ispred vašeg izbora za navigaciju i zatim tipku ENTER");

            string opcije;
            opcije = Console.ReadLine();
            switch (opcije)
            {
                case "1":
                    ParkirnaMjesta();
                    break;
                case "2":
                    Financije();
                    break;
                case "3":
                    StanjeBlagajne();
                    break;
                case "4":
                    Exit();
                    break;
                default:
                    Console.WriteLine("Molim vas izaberite postojeću kategoriju");
                    Console.ReadLine();
                    break;

            }

            void StanjeBlagajne()
            {

            }
           
            
        }
        static void StanjeBlagajne()
        {

        }
        
        static void Exit()
        {

        }
        
        static void UkupnoMjesta()
        {
            int all;
            Console.WriteLine("upisi broj");
            all = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("broj koji ste upisali :" + all.ToString());
            
        }
        static void ZauzetaMjesta()
        {
            int taken;
            Console.WriteLine("upisi broj");
            taken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("broj koji ste upisali :" + taken.ToString());
        }
        static void SlobodnaMjesta()
        {
            int free;
            Console.WriteLine("upisi broj");
            free = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("broj koji ste upisali :" + free.ToString());
        }
        static void Pretplatnici()
        {
            string pret;
            Console.WriteLine("upisi ime");
            pret = Console.ReadLine();
            Console.WriteLine("broj koji ste upisali :" + pret);
        }
        

    }
}
        */