using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class GrandeVisitor<Persona> : Visitor<Persona>
    {
        public override void Visit(Node<Persona> node)
        {
            
            foreach(Node<Persona> children in node.Children)
            {
                Persona p=children.Valor;  
                children.Accept(this);

            }
            
        }
    }
}