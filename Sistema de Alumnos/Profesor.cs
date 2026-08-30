using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Profesor : Persona, IExportable
    {
        public string subject {  get; set; }
        public Profesor (string name, int file, string subject) : base(name, file)
        {
            this.subject = subject;
        }
        public override string Presentarse()
        {
            return $"Hola, soy {name} y dicto {subject}";
        }
        public string ExportarLinea()
        {
            return $"ALUMNO;{file};{name};{subject}";
        }
    }
}
