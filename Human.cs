
//Public Class with Encapsulated Variable name and Parametarized Constructor
public class Human{

    //these get, set are auto implemented functions that make our variable secure and we can also use the
    //private setter, and for private setter, we can only assign it in constructor when making object and within class only

    public string name {get ; set ;}
    public int age;
    public string field;

    //static variable to keep track of the variable made 
    public static int noOfObjects;

    public Human( string name , int age, string field)
    {   
        this.name = name;
        this.age  = age;
        this.field = field;
        noOfObjects++;
    }

    public void canWalk()
    {
        //user string interpolation
        System.Console.WriteLine($"{name} can Walk.");
    }

    public void checkAge()
    {
        System.Console.WriteLine($"{name} is {age} years old");
    }
}