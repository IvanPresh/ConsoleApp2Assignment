using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2Assignment.Features
{
    internal class Paramentals
    {
        int X;
        int Y;
        public Paramentals(int a, int b) 
        {

            X = a; 
            
            Y = b;
        
        
        }
        

        public  void Results() 
        {

            Console.WriteLine(X+Y);

        }



        //assigment 2 using paramentals


        string Username= "first name,  Last name";
        
        public Paramentals(string username)// constructor
        {

            Username=username;


        }


        public void Redisplay()
        {

            Console.WriteLine(Username);

        }



    }






}
