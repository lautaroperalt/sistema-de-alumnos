using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Alumno
    {
        public required string name { get; set; }
        public int file { get; set; }
        public decimal note1 { get; set; }
        public decimal note2 { get; set; }
    }
}
