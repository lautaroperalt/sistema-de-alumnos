using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    public class Alumno
    {
        public string name { get; set; }
        public int file { get; private set; }
        public decimal note1 { get; private set; }
        public decimal note2 { get; private set; }

        public Alumno(string name, int file)
        {
            this.name = name;
            this.file = file;
        }

        public decimal AverageGrade() 
        {
           return (note1 + note2) / 2;
        }
        public bool Passed() 
        {
            if (AverageGrade() > 6)
                return true;
            else return false;
        }
        public void ExtraCredit() 
        {
            if (note1 <10)
            { note1++; }

            if (note2 < 10)
            { note2++; }
        }
        public override string ToString()
        {
            return $"{file} - {name} (Promedio : {AverageGrade()})";
        }
        public bool UploadGrades(decimal note1, decimal note2)
        {
            if ((0 <= note1 && note1 <= 10) && (0 <= note2 && note2 <= 10))
            { 
                this.note1 = note1;
                this.note2 = note2;
                return true;
            } else return false;
            
        }
    }
}
