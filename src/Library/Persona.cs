using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public string nombre;
        public int edad{get;set;}
        public Persona(string nombre,int edad)
        {
            this.nombre=nombre;
            this.edad=edad;
        }  
        
    }
}