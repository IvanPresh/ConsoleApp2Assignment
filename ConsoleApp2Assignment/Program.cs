// See https://aka.ms/new-console-template for more information
using ConsoleApp2Assignment.Features;
using System.Linq.Expressions;

Console.WriteLine("ASSIGNment Result. printing out even numbers from 1-50!");

//Assinngment1
// Use (For) to print out even number from 1-50

for (int Y = 1; Y <= 50; Y++)
{
  
    if (Y % 2 == 0)

       Console.WriteLine("Y = " + Y);
    


}

//Assignment 2

Console.WriteLine("assignment ii. using switch case to print out any day of the week");
//Switch Case
string Nameofday = "Friday";
Console.WriteLine("please enter W as week");

Console.ReadLine();

switch (Nameofday)
{
    case "Monday":
        {
            Console.WriteLine(" Monday");
            break;
        }
    case "Tuesday":
        {

            Console.WriteLine("Tuesday");
            break;
        }
    case "Friday":
        {

            Console.WriteLine("Friday");
            break;

        }
    default:
        {
            Console.WriteLine("name not found");
            break;
        }

}

/*Assignment 3. create a class that will have constructor while using string paramental value in the constructor.*/


Paramentals value = new Paramentals(3, 6); //instance of a class
value.Results();


Paramentals Rresult= new Paramentals( "Ivan, Precious"); //instance of the class Paramentals
Rresult.Redisplay();

Console.ReadKey();