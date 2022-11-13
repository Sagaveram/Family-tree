using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class GrandeVisitor<Persona> : Visitor<Persona>
    {
        public int Mayoredad=0;
        public string Mayor="";
        public override void Visit(Node<Persona> node)
        {
            if(node.persona.edad>Mayoredad)
            {
                Mayoredad=node.persona.edad;
                Mayor=node.persona.nombre;
            }
            foreach(Node<Persona> children in node.Children)
            {
                
                children.Accept(this);
            

            }
            
        }
    }
}