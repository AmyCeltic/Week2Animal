using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Animal
    {
        public Animal(int age) 
        int age { get; set; }
        public virtual void speak()
        {
        Console.WriteLine("");
}
        static void Main(string[] args)
        {
            Animal a = new Animal(9);
            Dog b = new Dog(2);
            Cat c = new Cat(5)


            Console.WriteLine("Arf");
            Console.WriteLine("Meow");

        {
            throw new NotImplementedException();
        }
    }
            


                           //Notice that we did not using Console.WriteLine. Like I mentioned earlier, in production
                           //we would use Console.WriteLine(a.speak());



                           /*Create a class called Animal.
                  a.Give it the following property: Age
                  b.Give it the following method/function: speak (This will print an empty string)
                  c.Create a constructor that will take a parameter and assign it to that instance's age. In other words, I should be able to do the following:
                  i.Animal a = new Animal(9);
                          d.Create a class called Dog and a class called Cat that both derive from Animal.
                         e.Override the speak method in both classes, where if you call speak on a dog instance it will print "Arf".
                  f.If you call speak on a cat instance, it will print "Meow".
                  g.Note: In an actual production environment, we would never print something from within an instance method. This would be done in main, as shown in previous problems.
                  Example:
                  class Program
                          {
                              static void Main(string[] args)
                              {
                                  Animal a = new Animal(9);
                                  Dog b = new Dog(2);
                                  Cat c = new Cat(5)
                              a.speak(); //should print nothing (aka empty string)
                                  b.speak(); //should print "Arf"
                                  c.speak(); //should print "Meow"
                                             //Notice that we did not using Console.WriteLine. Like I mentioned earlier, in production
                                             //we would use Console.WriteLine(a.speak());
                              }
                          }
                  14.

                      }
                  }*/
