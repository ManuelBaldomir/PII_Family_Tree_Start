using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Juan", 10);
            Person person2 = new Person("Maria", 30);
            Person person3 = new Person("Pedro", 30);
            Person person4 = new Person("Sofia", 50);
            Person person5 = new Person("Luis", 50);
            Person person6 = new Person("Ana", 70);
            Person person7 = new Person("Rigoberto", 70);
            Person person8 = new Person("Susana", 90);
            Person person9 = new Person("Carlos", 90);

            Node<Person> nP1 = new Node<Person>(person1);
            Node<Person> nP2 = new Node<Person>(person2);
            Node<Person> nP3 = new Node<Person>(person3);
            Node<Person> nP4 = new Node<Person>(person4);
            Node<Person> nP5 = new Node<Person>(person5);
            Node<Person> nP6 = new Node<Person>(person6);
            Node<Person> nP7 = new Node<Person>(person7);
            Node<Person> nP8 = new Node<Person>(person8);
            Node<Person> nP9 = new Node<Person>(person9);

            nP1.AddChildren(nP2);
            nP1.AddChildren(nP3);

            nP2.AddChildren(nP4);
            nP2.AddChildren(nP5);

            nP3.AddChildren(nP6);
            nP3.AddChildren(nP7);

            nP4.AddChildren(nP8);
            nP4.AddChildren(nP9);
//-----------------------------------------------------------------------------------//
            
            AgeSumVisitor nV = new AgeSumVisitor();
            OldestAgeVisitor nV2 = new OldestAgeVisitor();
            LongestNameVisitor nV3 = new LongestNameVisitor();

            nV.Visit(nP1);
            System.Console.WriteLine($"Suma de edades de la familia = {nV.ageTotal}");
            nV2.Visit(nP1);
            System.Console.WriteLine($"Edad maxima de la familia = {nV2.oldestAge}");
            nV3.Visit(nP1);
            System.Console.WriteLine($"Nombre más largo de la familia = {nV3.longestName}");


        }
    }
}
