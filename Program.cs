using System;

class Program
{
    // static void Main()
    // {

        // System.Console.WriteLine("Hey Abdullah\nYou have been assigned a number:");
        // Random r = new Random();
        // double a = r.Next();
        // System.Console.WriteLine(a);    


        // System.Console.WriteLine("Enter side A: ");
        // double a = Convert.ToDouble(Console.ReadLine());

        // System.Console.WriteLine("Enter side B: ");
        // double b = Convert.ToDouble(Console.ReadLine());

        // //SQRT ( square root ) TAKE 1 ARGUMENT ONLY
        // double c = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
        // // double c = Math.Sqrt((a*a)+(b*b));

        // System.Console.WriteLine("Hypotenuse: " + c);


        //Variables
        // int min = 1, max = 100;
        // Random r = new Random();
        // int count = 0;
        // int guess = -1;
        // char choice;
        // string userName;
        // bool play = true;
        // int number;

        // //Take User Name
        // System.Console.WriteLine("Enter your name: ");
        // userName = Console.ReadLine();

        // count = 0;
        // number = r.Next(min, max + 1);

        // //We can use Nested Loop but this is efficient and Simple as TC is O(1)
        // while (play)
        // {

        //     System.Console.WriteLine("Guess a number between " + min + "-" + max + " :");
        //     guess = Convert.ToInt32(Console.ReadLine());

        //     count++;

        //     if (guess > number)
        //     {
        //         System.Console.WriteLine(guess + " is too high");
        //     }
        //     else if (guess < number)
        //     {
        //         System.Console.WriteLine(guess + " is too low");
        //     }
        //     else if (guess == number)
        //     {
        //         System.Console.WriteLine(guess + " is CORRECT");
        //         System.Console.WriteLine("Your total Guesses: " + count + "\nYOU WON THE GAME!");
        //         System.Console.WriteLine("Would you like to play again (Y/N)");
        //         choice = Convert.ToChar(Console.ReadLine());
        //         if (choice == 'Y' || choice == 'y')
        //         {
        //             play = true;
        //             count = 0;
        //             number = r.Next(min, max + 1);
        //         }
        //         else if (choice == 'N' || choice == 'n')
        //         {
        //             play = false;
        //         }
        //     }

        // }

        // System.Console.WriteLine("Thanks for playing game, "+ userName);
        //dynamic x = "String";
        //x = 100;
        //x is now 100
        // var cars = new string[2] { "H", "B" };
        //  for (int i = 0; i < cars.Length; i++)
        // {
        //     System.Console.WriteLine($"Index {i}: " + cars[i]);
        // }

        // System.Console.WriteLine(cars.Length);


        //Declaring and Initializing Array with SIZE AND VALUES
        // var users = new string[5] {"Alex", "Hoor", "Abdullah" , "Hopi", "Pingu"};


        // var number = new int[5];

        // for (int i = 0; i < number.Length ; i++)
        // {
        //     number[i]  = Convert.ToInt32(Console.ReadLine());
        // }

        // System.Console.WriteLine();


        // //Foreach Loop 
        // //Used only for the Iteration of to fetch Json format data
        // foreach ( int val in number ){
        //     System.Console.WriteLine(val);
        // }
        // foreach (string val in users)
        // {
        //     System.Console.WriteLine(val);
        // }


        // helloWorld();



        // //ROCK, PAPER, SCISSORS
        // //Variables
        // int winCount = 0;
        // int totalPlayed = 0;
        // int lostCount = 0;
        // bool play  = true;
        // string user="";
        // string cpu="";
        // Random r = new Random();
        // string choice="";

        // do{
        //     user = "";
        //     //user input done
        //     //Validation that user only enters on of these three options
        //     while (user != "ROCK" && user != "PAPER" && user != "SCISSOR"){

        //         System.Console.WriteLine("Enter ROCK, PAPER OR SCISSOR: ");
        //         user = Console.ReadLine();
        //         user = user.ToUpper();
        //     }

        //     totalPlayed++;
        //     int n = r.Next(1, 4);

        //     //Cpu selected done
        //     switch (n)
        //     {
        //         case 1:
        //             cpu = "ROCK";
        //             break;
        //         case 2:
        //             cpu = "PAPER";
        //             break;
        //         case 3:
        //             cpu = "SCISSOR";
        //             break;
        //     }       

        //     System.Console.WriteLine("CPU: "+cpu );
        //     //Comparison & making result & counting
        //    switch (user)
        //     {
        //         case "ROCK":
        //             if(cpu == "ROCK")
        //             {
        //                 System.Console.WriteLine("It's a DRAW.");
        //             } else if (cpu == "PAPER")
        //             {
        //                 System.Console.WriteLine("CPU WON!");
        //             } else{
        //                 System.Console.WriteLine("YOU WON!");
        //                 winCount++;
        //             }
        //             break;
        //         case "PAPER":
        //             if(cpu == "ROCK")
        //             {
        //                 System.Console.WriteLine("YOU WON");
        //                 winCount++;
        //             } else if (cpu == "PAPER")
        //             {
        //                 System.Console.WriteLine("It's a DRAW.");
        //             } else{
        //                 System.Console.WriteLine("CPU WON!");
        //             }
        //             break;
        //         case "SCISSOR":
        //             if(cpu == "ROCK")
        //             {
        //                 System.Console.WriteLine("CPU WON");
        //             } else if (cpu == "PAPER")
        //             {
        //                 System.Console.WriteLine("YOU WON");
        //                 winCount++;
        //             } else{
        //                 System.Console.WriteLine("It's a DRAW.");
        //             }
        //             break;
        //     }

        //     lostCount = totalPlayed - winCount;

        //     System.Console.WriteLine("Would you like to play again (Y/N): ");
        //     choice = Convert.ToString(Console.ReadLine());
        //     choice = choice.ToUpper();

        // }while(choice == "Y");     

        //     //Showing Stats
        //     System.Console.WriteLine("Your STATS:\nTotal Played: "+totalPlayed);
        //     System.Console.WriteLine("WINS: "+ winCount);
        //     System.Console.WriteLine("LOST: " + lostCount);

        //     System.Console.WriteLine("Thanks for Playing");

        // int total = Checkout(2,5,10,6);
        // System.Console.WriteLine("Total price would be = " + total);



        // //Declred ansd Initializaed the 2D-Array
        // int[,] array = new int[3,4] {
        //     {1,2,3,4},
        //     {5,6,7,8},
        //     {9,10,11,12},
        // };

        // //Accessing them through Foreach loop
        // // foreach(int val in array)
        // // {
        // //     Console.WriteLine(val);
        // // }

        // //Making tables/grid of 3 by 4
        // for(int  i=0 ; i<3 ; i++)
        // {
        //     for(int j=0 ; j<4 ; j++)
        //     {
        //         System.Console.Write($"{array[i,j]} ");
        //     }
        //     System.Console.WriteLine();
        // }


        //Creating an Object and initializing its values initially
        // Human h1 = new Human("Alex" , 21 , "Computer Science");
        // Human h2 = new Human("Pingu" , 10 , "AI");
        // Human h3 = new Human("Ab" , 18 , "Love");

        // h1.name = "Abdullah";

        // h1.canWalk();
        // h2.checkAge();
        // h3.canWalk();


        // System.Console.WriteLine($"Number of Objectes Created: {Human.noOfObjects}");



        //CONCEPT OF INHERITANCE
        //USING PARENT CONSTRUCTOR PARAMETERS IN CHILD
        // Computer c1 = new Computer("HP", 128, 8 , "Computer" , "3000W", 45000 );

        // c1.Info();
        // System.Console.WriteLine();
        // System.Console.WriteLine();

        // c1.Specs();




        //DEFINE

        // Book b1 = new Book("Big Times", 1146, "Alex john", true);

        // System.Console.WriteLine();

        // b1.ShowDetails();

        // System.Console.WriteLine("Welcome to BOOK MARKET");
        // Library lib = new Library();
        // int count = 0;
        // char choice;
        // //Excepotion Handling

        // do
        // {


        //     System.Console.WriteLine("Enter option (1/2/3): ");
        //     System.Console.WriteLine("1 - Add new Book\n2 - Display all Books\n3 - Borrow a Book  ( by ID )");
        //     int option = Convert.ToInt32(Console.ReadLine());

        //     switch (option)
        //     {
        //         case 1:
        //             System.Console.WriteLine("Enter Book (Name/Author/ID)");
        //             string t = Console.ReadLine();
        //             string a = Console.ReadLine();
        //             int id = Convert.ToInt32(Console.ReadLine());
        //             Book b2 = new Book(t, id, a, true);
        //             Book.noOfBook += 1;
        //             lib.AddNewBook(b2, count);
        //             count++;

        //             break;
        //         case 2:
        //             lib.DisplayBooks(Book.noOfBook);
        //             break;
        //         case 3:
        //             System.Console.WriteLine("Which Book you wanna borrow ( Enter ID ): ");
        //             int i = Convert.ToInt32(Console.ReadLine());
        //             lib.BorrowBook(i , Book.noOfBook);
        //             break;
        //     }


        //     System.Console.WriteLine("Play Again? (Y/N)");
        //     choice = Convert.ToChar(Console.ReadLine());
            
        // } while (choice == 'Y' || choice  == 'y');




    }

    // //Param keyword usage
    // static int Checkout(params int[] a)
    // {
    //     int total= 0;
    //     int count = 0;

    //     foreach(int val in a)
    //     {
    //         total += val;
    //     }

    //     return total;

    // }

    //We use static access modifier if we want to call function without creating object
    //we can use int, string  if we wanna return int or string respectively
    // static void helloWorld()
    // {
    //     Console.WriteLine("Hello World\nI m User");
    // }

//}


//CLASSES

// public class Book
// {

//     public static int noOfBook = 0;
//     public string title;
//     public int id;
//     public string author;
//     public bool isAvaiable;

//     public Book(string title, int id, string author, bool isAvaiable)
//     {
//         this.title = title;
//         this.id = id;
//         this.author = author;
//         this.isAvaiable = isAvaiable;
//     }

//     public void ShowDetails()
//     {
//         System.Console.WriteLine($"Book: {title}\nAuthor: {author}\nID: {id}\nAvailable: {((isAvaiable) ? "Yes" : "No")}");
//     }

// }




// public class Library
// {
//     public Book[] collectedBooks = new Book[10];
//     //3 FUnctions

//     //Add books
//     public void AddNewBook(Book b, int c)
//     {
//         collectedBooks[c] = b;
//         System.Console.WriteLine($"Book: {collectedBooks[c].title} has been added");
//     }


//     //Display Books
//     public void DisplayBooks( int c)
//     {
//         if (collectedBooks[1].title != "")
//         {
//             System.Console.WriteLine("Displaying Books\n");
//             for (int i = 0; i < c ; i++)
//             {
//                 System.Console.WriteLine($"Book {i + 1}\nTitle : {collectedBooks[i].title}\nAuthor: {collectedBooks[i].author}\nID: {collectedBooks[i].id}\nAvailable: {((collectedBooks[i].isAvaiable) ? "Yes" : "Out of Stock")}\n");
//             }
//         }
//         else
//         {
//             System.Console.WriteLine("No Books to Display\n");
//         }

//     }


//     //Borrow a book by id
//     public void BorrowBook(int id, int c)
//     {

//         if (collectedBooks[1].title != "")
//         {
//             for (int i = 0; i < c; i++)
//             {
//                 if (collectedBooks[i].id == id)
//                 {
//                     collectedBooks[i].isAvaiable = false;
//                     System.Console.WriteLine($"Book {collectedBooks[i].title} has been Borrowed");
//                 }

//             }
//         }
//         else
//         {
//             System.Console.WriteLine("No Books to Borrow");
//         }
//     }





// }

// //END CLASSES





// //PARENT CLASS FOR COMPUTER 
// class Machine{
//     public string name;
//     public string power;
//     public int price;

//     public Machine(string name , string power, int price)
//     {
//         this.name = name;
//         this.power = power;
//         this.price = price;
//         System.Console.WriteLine("Parent Constructor");
//     }

//     public void Info()
//     {
//         System.Console.WriteLine($"Machine name = {name}\nPower Consumption = {power}\nPrice = {price}");
//     }
// }



// //Child Class 
// //Used INHERITANCE
// class Computer : Machine{

//     public string brand;
//     public int ram;
//     public int rom;

//     //:base(parameters) calls the parent constructor with the parameters in the parentheses
//     //We dont need to add :base(para) if parent constructor is parameterless or is default

//     public Computer(string brand , int ram , int rom, string name , string power , int price) : base(name, power, price)
//     {
//         this.brand = brand;
//         this.ram = ram;
//         this.rom = rom;
//         System.Console.WriteLine("Child Constructor");
//     }


//     public void Specs()
//     {
//         System.Console.WriteLine($"Machine name = {name}\nPower Consumption = {power}\nRAM = {ram}\nROM = {rom}\nPrice = {price}");
//     }

// }