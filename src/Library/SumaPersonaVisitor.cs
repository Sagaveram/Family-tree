using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class SumaPersonaVisitor<Persona> : Visitor<Persona>
    {
        public int sumaTotal{get;set;}
        public override void Visit(Node<Persona> node)
        {
            sumaTotal=sumaTotal+node.persona.edad;
            foreach(Node<Persona> children in node.Children)
            {
                Persona p=children.Valor;  
                children.Accept(this);

            }
            
        }
    }
}