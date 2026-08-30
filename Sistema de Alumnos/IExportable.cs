using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Alumnos
{
    internal interface IExportable
    {
        string ExportarLinea();
        //string ExportarEncabezado();
        //sin implementarlo aparece el error CS0535, donde indica que las clases no implementan este miembro de interfaz
    }
}
