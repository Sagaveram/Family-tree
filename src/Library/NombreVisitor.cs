using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;

namespace Library
{
    public class NombreVisitor<Persona> : Visitor<Persona>
    {
        public string Nombremaslargo="";
        
        public override void Visit(Node<Persona> node)
        {
            if(node.persona.nombre.Length>Nombremaslargo.Length)
            Nombremaslargo=node.persona.nombre;
            foreach(Node<Persona> children in node.Children)
            {  
                children.Accept(this);

            }
            
        }
    }
}