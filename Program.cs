
using System.Runtime.CompilerServices;

namespace MyProject3
{
    class Program{

        private string model = "Mustang";
        static void Main(string[] args){
               // Console.WriteLine("Hello");

//Program myObj = new Program();
   // Console.WriteLine(myObj.model);
//Peter myinfo = new Peter();

//string output = myinfo.AboutMe();
    //Console.WriteLine(myinfo.AboutMe());
    //person myObj = new person();
    //myObj.Name = "Liam";
    //Console.WriteLine(myObj.Name);

    //car myCar = new car();
    //myCar.honk();
   //Console.WriteLine(myCar.brand + "" + myCar.modelName);
      
    //animal myAnimal = new animal();
    //animal myPig = new pig();
    //animal myDog = new dog();

    //myAnimal.animalsound();
    //myPig.animalsound();
    //myDog.animalsound(); 

    pig myPig = new pig();
    myPig.animalsound();
    
        }
    }


    public class Peter{
        public string Name = "Peter Onwuka";
        private int Age = 20;

        public string AboutMe(){
            return $"my name is {Name} and i am {Age}";
        }

       public string MyNameOnly(){
            return Name;
        }

        private string MyOtherName(){
            return Name;
        }
    }
   //Properties
    class person
    {
        private string name;
        public string Name{
            get{return name;}
            set {name = value;}
        }
    }
    //inheritance
    class vehicle
    {
        public string brand = "ford";
        public void honk()
        {
            Console.WriteLine("tuut, tuut");
        }
    }
    class car : vehicle
    {
        public string modelName = "Mustang";
    }
    //polymorphism
    class animal
    {
        public virtual void animalsound()
        {
            Console.WriteLine("the animal makes a sound");
        }
    }    
     class pig  : animal{
            public override void animalsound()
            {
                Console.WriteLine("the pig says: wee,wee");
            }
        }
    class dog : animal
    {
        public override void animalsound(){
            Console.WriteLine("the dog says: bow wow");
        }
    }
   //abstract
   abstract class Animal{
     public abstract void animalsound();
     public void sleep()
     {
        Console.WriteLine("zzzzz");
     }
   }
     class pigs : Animal{
            public override void animalsound()
            {
                Console.WriteLine("the pig says: wee wee");
            }
    }
}