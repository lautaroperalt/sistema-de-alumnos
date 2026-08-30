using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Profesor : Persona
    {
        public string subject {  get; set; }
        public Profesor (string name, int file, string subject) : base(name, file)
        {
            this.subject = subject;
        }
    }
}
