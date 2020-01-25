using System;
using InstrumentShop.Models;
using System.Data.SqlClient;



namespace InstrumentShop
{
    class Program
    {
        /***
         * Goal: The goal of the app is to obtain an inventory of products of an Instrument Store, and have the client
         * choose from this instruments, and purchase them
         * OOP uses Inheritance, Polymorphism
         ***/
        static void Main(string[] args)
        {
           string connectionString = @"Server=localhost\SQLEXPRESS;Database=instruments;Trusted_Connection=True;";
            int instrumentID;
            string instrument_name;

            Console.WriteLine("\nPlease enter your username: ");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            if (name == "QEL") {
                Console.WriteLine($"\n{ name}   is the correct username, {name}, logged in date: {date:d}");

                Caller c = new Caller();

                const int total_guitars = 3;
                const int total_saxophones = 3;

                Guitar[] guitarArray = new Guitar[total_guitars];
                Saxophone[] saxophoneArray = new Saxophone[total_saxophones];

                guitarArray[0] = new Guitar("Fender", "electric", 7000);
                guitarArray[1] = new Guitar("Conde", "acoustic", 85000);
                guitarArray[2] = new Guitar("Gibson", "acustic", 5000);

                saxophoneArray[0] = new Saxophone("Yamaha", "acustic", 3600);
                saxophoneArray[1] = new Saxophone("Cannoball", "acustic", 92000);
                saxophoneArray[2] = new Saxophone("Jupiter", "acustic", 92000);


                /*** This data should be generated from a Database ***/
                Console.WriteLine("\nInstruments in Stock:");
                for (int i = 0; i < guitarArray.Length; i++)
                {
                    c.CallerInstrumentType(guitarArray[i]);
                    c.CallerInstrumentType(saxophoneArray[i]);

                }

                Console.WriteLine("Starting DB Connection to SQL:...");

                // ask user to enter add new instrument
                Console.WriteLine("\nPlease add new instrument: ");
                var instrument = Console.ReadLine();
                Console.WriteLine("\nType of instrument: ");
                var instrument_type = Console.ReadLine();

                using (var db = new DBInstrumentContext())
                {
                    db.Instruments.Add(new Instrument { name = instrument, type = instrument_type });
                    db.SaveChanges();
                }


                Console.WriteLine("\n The current Inventory of Instruments is:");

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   string query = @"select * from instruments";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                     
                    
                    if (dr.HasRows)
                    {
                          while (dr.Read())
                          {
                            instrumentID = dr.GetInt32(0);
                            instrument_name = dr.GetString(1);
                            Console.WriteLine("{0},{1}", instrumentID.ToString(), instrument_name);

                          }

                      }

                }
             } // if correct user name
                
               
            
            else
            {
                Console.WriteLine("Incorrect username.  Please try it again \n");
            }

            
            

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}