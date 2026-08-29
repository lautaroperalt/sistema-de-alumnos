
using Sistema_de_Alumnos;

Alumno alumnoUno = new Alumno()
{
    name = "Lautaro"
};
alumnoUno.note1 = 9.99m;
alumnoUno.note2 = 9.10m;
alumnoUno.file = 2;

Console.WriteLine($"El nombre del alumno es {alumnoUno.name} y cuenta con un legajo de {alumnoUno.file} paginas");

Alumno alumnoDos = new Alumno()
{
    name = "Tomas"
};
alumnoDos.note1 = 7.11m;
alumnoDos.note2 = 7m;
alumnoDos.file = 2;

Console.WriteLine($"El nombre del alumno es {alumnoDos.name} y cuenta con un legajo de {alumnoDos.file} paginas");