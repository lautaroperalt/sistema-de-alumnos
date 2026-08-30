using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Preceptor : Persona
    {
        public string year { get; set; }
        public Preceptor(string name, int file, string year) : base(name, file)
        {
            this.year = year;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {name} y estoy a cargo del año {year}.";
        }
    }
}
