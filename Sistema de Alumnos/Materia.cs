using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Materia : IExportable
    {
        public string name { get; set;  }
        public string code { get; set; }
        public int hours { get; set; }

        public Materia (string code, string name, int hours)
        {
            this.code = code;
            this.name = name;
            this.hours = hours;
        }
        public string ExportarLinea()
        {
            return $"ALUMNO;{code};{name};{hours}";
        }
    }
}
