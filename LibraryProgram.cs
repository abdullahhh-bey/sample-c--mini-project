using System;
/*I used this for adding Threads but this project 
does not contain Threads*/
using System.Threading.Tasks;

//Starting
class LibraryProgram
{
    static void Main()
    {

        System.Console.WriteLine("Welcome to BOOK MARKET");
        Library lib = new Library();
        int count = 0;
        char choice;
        //Excepotion Handling

        do
        {


            System.Console.WriteLine("Enter option (1/2/3): ");
            System.Console.WriteLine("1 - Add new Book\n2 - Display all Books\n3 - Borrow a Book  ( by ID )");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    System.Console.WriteLine("Enter Book (Name/Author/ID)");
                    string t = Console.ReadLine();
                    string a = Console.ReadLine();
                    int id = Convert.ToInt32(Console.ReadLine());
                    Book b2 = new Book(t, id, a, true);
                    Book.noOfBook += 1;
                    lib.AddNewBook(b2, count);
                    count++;

                    break;
                case 2:
                    lib.DisplayBooks(Book.noOfBook);
                    break;
                case 3:
                    System.Console.WriteLine("Which Book you wanna borrow ( Enter ID ): ");
                    int i = Convert.ToInt32(Console.ReadLine());
                    lib.BorrowBook(i, Book.noOfBook);
                    break;
            }


            System.Console.WriteLine("Play Again? (Y/N)");
            choice = Convert.ToChar(Console.ReadLine());

        } while (choice == 'Y' || choice == 'y');



    }
}


//CLASSES
public class Book
{

    //It does nit belong to any object, it only relate to Class and
    //used for counting total numbr of books objects created
    public static int noOfBook = 0;
    public string title;
    public int id;
    public string author;
    public bool isAvaiable;

    public Book(string title, int id, string author, bool isAvaiable)
    {
        this.title = title;
        this.id = id;
        this.author = author;
        this.isAvaiable = isAvaiable;
    }

    //Sample fnc I didnt use it in this Program
    public void ShowDetails()
    {
        System.Console.WriteLine($"Book: {title}\nAuthor: {author}\nID: {id}\nAvailable: {((isAvaiable) ? "Yes" : "No")}");
    }

}


//Library Class
public class Library
{
    public Book[] collectedBooks = new Book[10];
    //3 FUnctions

    //Add books
    public void AddNewBook(Book b, int c)
    {
        collectedBooks[c] = b;
        System.Console.WriteLine($"Book: {collectedBooks[c].title} has been added");
    }


    //Display Books
    public void DisplayBooks(int c)
    {
        if (collectedBooks[0].title != "")
        {
            System.Console.WriteLine("Displaying Books\n");
            for (int i = 0; i < c; i++)
            {
                System.Console.WriteLine($"Book {i + 1}\nTitle : {collectedBooks[i].title}\nAuthor: {collectedBooks[i].author}\nID: {collectedBooks[i].id}\nAvailable: {((collectedBooks[i].isAvaiable) ? "Yes" : "Out of Stock")}\n");
            }
        }
        else
        {
            System.Console.WriteLine("No Books to Display\n");
        }

    }
    //Borrow a book by id
    public void BorrowBook(int id, int c)
    {

        if (collectedBooks[1].title != "")
        {
            for (int i = 0; i < c; i++)
            {
                if (collectedBooks[i].id == id)
                {
                    collectedBooks[i].isAvaiable = false;
                    System.Console.WriteLine($"Book {collectedBooks[i].title} has been Borrowed");
                }

            }
        }
        else
        {
            System.Console.WriteLine("No Books to Borrow");
        }
    }
}
//END CLASSES