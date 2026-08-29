
using Sistema_de_Alumnos;

Alumno alumnoUno = new Alumno("Juan", 2);

Console.WriteLine($"El nombre del alumno es {alumnoUno.name} y cuenta con un legajo de {alumnoUno.file} paginas");

if (alumnoUno.UploadGrades(10, 9.99m))
{
    Console.WriteLine($"Notas de {alumnoUno.name} cargadas con exito");
}
else Console.WriteLine("Error al cargar las notas del alumno, volver a ingresar");

Console.WriteLine(alumnoUno);
Console.WriteLine();

Alumno alumnoDos = new Alumno("Lautaro", 2);

Console.WriteLine($"El nombre del alumno es {alumnoDos.name} y cuenta con un legajo de {alumnoDos.file} paginas");

if (alumnoDos.UploadGrades(11, 9.99m))
{
    Console.WriteLine($"Notas de {alumnoDos.name} cargadas con exito");
}
else Console.WriteLine("Error al cargar las notas del alumno, volver a ingresar");

Console.WriteLine(alumnoDos);

Console.WriteLine($"El promedio de los alumnos esta formado por: {alumnoUno.name}: {alumnoUno.AverageGrade()}, y {alumnoDos.name}: {alumnoDos.AverageGrade()} ");
//saca las notas del propio constructor que almacena los datos en memoria, y se traspasan ya que el metodo se enuentra dentro de la clase Alumno()

//Console.WriteLine(alumnoDos);
//sin override: Sistema_de_Alumnos.Alumno Alumno.ToString() oculta a objeto.ToString(), para q el miembro actual la invalide: agregar override o new

//No, no hay forma de que haya una nota de 47. Primero se utilizo private set para limitar las variaciones externas
//luego la unica forma de moficiar es pasando por el metodo de UploadGrades que rechazaria cualquier nota superior a 10