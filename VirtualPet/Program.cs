using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using VirtualPet;

namespace VirtualPet

{

    class Program
    {
<<<<<<< HEAD


        static void Main(string[] args)
        {
            //PlayThemeSong();
=======
        public static Pet pet1;

        private static Timer _timer;
        static void Main(string[] args)
        {
            
            PlayThemeSong();
>>>>>>> d6aafa86912a5d551ed8fbd865fce586ec1e7433
            RunAnimatedMenu();

            Console.WriteLine("Welcome to the Pet Shop!");
            Console.WriteLine("There are many cute pets just waiting to be your friend.");
<<<<<<< HEAD
            // Console.WriteLine("What kind of pet do you pick? Enter its species:");
            // string petSpecies = Console.ReadLine();
            // Console.WriteLine("What a cute " + petSpecies + " you picked!");
            // Console.WriteLine("What would you like to name your pet?");
            // string petName = Console.ReadLine();

            Pet pet1 = new Pet();
            Ironper pet2 = new Ironper();
            pet1.SetSpecies("flaffi");
            pet1.SetName("Flower");
=======
            Console.WriteLine("What kind of pet do you pick? Enter its species:");
            string petSpecies = Console.ReadLine();
            Console.WriteLine("What a cute " + petSpecies + " you picked!");
            Console.WriteLine("What would you like to name your pet?");
            string petName = Console.ReadLine();

            _timer = new Timer(Tick, null, 0, 2000);
            pet1 = new Pet();

            pet1.SetSpecies(petSpecies);
            pet1.SetName(petName);
>>>>>>> d6aafa86912a5d551ed8fbd865fce586ec1e7433
            pet1.Boredom = 50;
            pet1.Hunger = 50;
            pet1.Health = 50;

<<<<<<< HEAD
            pet2.SetSpecies("robot200");
            pet2.SetName("Iron");
            pet2.Boredom = 50;
            pet2.Hunger = 50;
            pet2.Health = 50;

            //initialize pet attributes

         //   Console.WriteLine(petName + " looks tired and hungry! You should take them home.");
=======

            //initialize pet attributes

            Console.WriteLine(petName + " looks tired and hungry! You should take them home.");
>>>>>>> d6aafa86912a5d551ed8fbd865fce586ec1e7433

            bool keepPlaying = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check your pet's status.");
            Console.WriteLine("2. Feed your pet.");
            Console.WriteLine("3. Play with your pet.");
            Console.WriteLine("4. Take your pet to the doctor.");
            Console.WriteLine("Press Q to exit the game.");



            Console.WriteLine("choose pet 1 or 2");
            int option = Convert.ToInt32(Console.ReadLine());
          //  Pet pet = null;
            if (option == 1)
            {
<<<<<<< HEAD
                Pet pet = null;
                pet = pet1;
                // else { pet = pet2; }



                while (keepPlaying == true)
                {
                    //  Console.Clear();

                   
                        Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++     ");
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Check your pet's status.");
                    Console.WriteLine("2. Feed your pet.");
                    Console.WriteLine("3. Play with your pet.");
                    Console.WriteLine("4. Take your pet to the doctor.");
                    Console.WriteLine("5. method Tick.");

                    Console.WriteLine("Press Q to exit the game.");
                    string userInput = Console.ReadLine().ToLower();
                    switch (userInput)
                    {
                        case "1":
                            pet.CheckStatus();
                            // Console.ReadLine();
                            break;
                        case "2":
                            pet.Feed();
                            pet.CheckStatus();
                            //Console.ReadLine();
                            break;
                        case "3":
                            pet.Play();
                            pet1.CheckStatus();
                            //Console.ReadLine();
                            break;
                        case "4":
                            pet.SeeDoctor();
                            pet.CheckStatus();
                            //Console.ReadLine();
                            break;
                        case "5":
                            pet.Tick();
                            pet.CheckStatus();
                            //Console.ReadLine();
                            break;

                        case "q":
                            keepPlaying = false;
                            break;
                        default:
                           
                            
                           
                            break;



                    }


                    if (pet.GetHealth() < 10   || pet.GetHealth()>100)      { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }
                    if (pet.GetHunger() > 100  || pet.GetHunger() < 10)     { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }
                    if (pet.GetBoredom() > 100  ||   pet.GetBoredom() < 10) { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }

                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();




=======
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check your pet's status.");
                Console.WriteLine("2. Feed your pet.");
                Console.WriteLine("3. Play with your pet.");
                Console.WriteLine("4. Take your pet to the doctor.");
                Console.WriteLine("Press Q to exit the game.");
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "1":
                        pet1.CheckStatus();
                        break;
                    case "2":
                        pet1.Feed();
                        break;
                    case "3":
                        pet1.Play();
                        break;
                    case "4":
                        pet1.SeeDoctor();
                        break;
                    case "q":
                        keepPlaying = false;
                        break;
                    default:
                        break;


                }

            }
        }
        public static void PlayThemeSong()
        {
>>>>>>> d6aafa86912a5d551ed8fbd865fce586ec1e7433



                }

               
            }
            else
            {
                Ironper pet = pet2;


                while (keepPlaying == true)
                {
<<<<<<< HEAD
                    Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++     ");
                  
                    Console.ForegroundColor = ConsoleColor.Green;
                   // Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Check your pet's status.");
                    Console.WriteLine("2. Feed your pet.");
                    Console.WriteLine("3. Play with your pet.");
                    Console.WriteLine("4. Take your pet to the doctor.");
                    Console.WriteLine("5. method Tick.");

                    Console.WriteLine("Press Q to exit the game.");
                    string userInput = Console.ReadLine().ToLower();
                    switch (userInput)
                    {
                        case "1":
                          //  pet.CheckStatus();
                            pet.HookupCharher();
                            pet.CheckStatusI();
                           // Console.ReadLine();
                            break;
                        case "2":
                            pet.CheckStatusI();
                            pet.FeedI();
               
                         //   Console.ReadLine();
                            break;
                        case "3":
                            pet.PlayI();
                            pet.CheckStatusI();
                       //     Console.ReadLine();
                            break;
                        case "4":
                            pet.SeeDoctor();
                            pet.CheckStatusI();
                        //    Console.ReadLine();
                            break;
                        case "5":
                            pet.Tick();
                            pet.CheckStatusI();
                         //   Console.ReadLine();
                            break;

                        case "q":
                            keepPlaying = false;
                            break;


                        default:
                           

                           
                            break;


                    }


                    if (pet.GetHealth() < 10 || pet.GetHealth() > 100) { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }
                    if (pet.GetHunger() > 100 || pet.GetHunger() < 10) { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }
                    if (pet.GetBoredom() > 100 || pet.GetBoredom() < 10) { keepPlaying = false; Console.WriteLine("<<<<<<<<<<<<<<<<<<     YOU LOSS       >>>>>>>>>>>>>>>>>>>>"); }

                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                    Console.ReadLine();










                }
                





            }

        }
            public static void PlayThemeSong()
            {

                Console.Beep(262, 250); //C
                Console.Beep(294, 250); //D
                Console.Beep(330, 250); //E
                Console.Beep(294, 500); //D
                Console.Beep(262, 500); //C
                Console.Beep(392, 750); //G
            }

            public static void RunAnimatedMenu()
            {
                Console.WriteLine("\n\n\n\n\n\t\t\t\t\tHello! Welcome to CyberPets! =^.u.^=\n\n\n\n\n");
                Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                Console.ReadKey();
                Console.Clear();

                for (int i = 5; i > 0; i--)
                {
                    for (int j = i; j > 0; j--)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine("\t\t\t\t\tHello! Welcome to CyberPets! =^.u.^=\n\n\n\n\n");
                    Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                    System.Threading.Thread.Sleep(250);
                    Console.Clear();
                }

                for (int k = 5; k > 0; k--)
                {
                    for (int l = k; l > 0; l--)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                    System.Threading.Thread.Sleep(250);
                    Console.Clear();
                }
            }
        }
    }


=======
                    Console.Write("\n");
                }
                Console.WriteLine("\t\t\t\t\tPress any key to continue.");
                System.Threading.Thread.Sleep(250);
                Console.Clear();
            }
        }
      
      public static void Tick(Object o)
        {
            //Pet pet = new Pet();  
           
            pet1.Tick();  //will +5 Hunger/ +5 Boredom/ -5 Health

            // put methods/updates that change the pet in some way            
>>>>>>> d6aafa86912a5d551ed8fbd865fce586ec1e7433


