using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1=new Persona("Jorge",10);
            Persona persona2=new Persona("Juan",10);
            Persona persona3=new Persona("Julian",10);
            Persona persona4=new Persona("Roberto",10);
            Persona persona5=new Persona("Marcos",10);
            Persona persona6=new Persona("Andres",10);
            Persona persona7=new Persona("Martina",10);
            Persona persona8=new Persona("Camila",10);
            Persona persona9=new Persona("Gervasio",10);
            

            Node<Persona> n1 = new Node<Persona>(persona1);
            Node<Persona> n2 = new Node<Persona>(persona2);
            Node<Persona> n3 = new Node<Persona>(persona3);
            Node<Persona> n4 = new Node<Persona>(persona4);
            Node<Persona> n5 = new Node<Persona>(persona5);
            Node<Persona> n6 = new Node<Persona>(persona6);
            Node<Persona> n7 = new Node<Persona>(persona7);
            Node<Persona> n8 = new Node<Persona>(persona8);
            Node<Persona> n9 = new Node<Persona>(persona9);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            
            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n4.AddChildren(n8);
            n4.AddChildren(n9);

            SumaPersonaVisitor<Persona> sumaPersonaVisitor=new SumaPersonaVisitor<Persona>();
            sumaPersonaVisitor.Visit(n1);
            Console.WriteLine($"La edad total de los integrantes del árbol es {sumaPersonaVisitor.sumaTotal}.");
            SumaPersonaVisitor<Persona> sumaPersonaVisitor2=new SumaPersonaVisitor<Persona>();
            sumaPersonaVisitor2.Visit(n4);
            Console.WriteLine($"La edad total de los integrantes del árbol es {sumaPersonaVisitor2.sumaTotal}.");

            
            



            
            
            

        }
    }
}
