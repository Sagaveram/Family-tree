using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        public Persona persona{get;set;}
        public Node(Persona persona)
        {
            this.persona=persona;

        
        }
        
        private List<Node<T>> children = new List<Node<T>>();


        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }


        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor<T> visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
