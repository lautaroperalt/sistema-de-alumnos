using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Persona
    {
        public string name { get; set; }
        public int file { get;  set; }
        public Persona (string name, int file)
        {
            this.name = name;
            this.file = file;
        }
    }
}
//La propiedad nombre esta escrita unicamente en Persona; la propiedad la tienen 3 clases porque los hijos la adoptan gracias a la estructura del padre