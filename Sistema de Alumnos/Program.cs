
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

Console.WriteLine();

List<Alumno> listaAlumnos = new List<Alumno>();
bool exit = false; 

while (!exit)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Agregar un alumno");
    Console.WriteLine("2. Listar todos los alumnos");
    Console.WriteLine("3. Buscar un alumno por legajo");
    Console.WriteLine("4. Promedio general del curso");
    Console.WriteLine("5. Cantidad de alumnos aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opción: ");
    string option = Console.ReadLine();
    Console.WriteLine();
    switch (option)
    {
        case "1":
            Console.Write("Ingresar el nombre del alumno que desea almacenar: ");
            string nameNombre = Console.ReadLine();

            Console.Write("Ingrese el numero de legajo: ");
            int fileLegajo = int.Parse(Console.ReadLine());

            Alumno newAlumn = new Alumno(nameNombre, fileLegajo);

            Console.Write("Ingrese la primer nota del alumno 'x,xx': ");
            decimal newGradeOne = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la segunda nota del alumno 'x,xx': ");
            decimal newGradeTwo = decimal.Parse(Console.ReadLine());
            newAlumn.UploadGrades(newGradeOne, newGradeTwo);

            listaAlumnos.Add(newAlumn);
            Console.WriteLine();
            Console.WriteLine("Alumno agregado correcamente");
            break;

        case "2":
            foreach (Alumno aF in listaAlumnos)
            {
                Console.WriteLine($"{aF}");
            }
            break;

        case "3":
            Console.WriteLine("Ingrese el legajo a buscar: ");
                int fileToSearch = int.Parse(Console.ReadLine());

            foreach (Alumno aF in listaAlumnos)
            {
                if (aF.file == fileToSearch)
                {
                    Console.WriteLine($"El alumno es {aF.name}");
                    break;
                }
                else
                    Console.WriteLine("El legajo no coincide con ninguno de los alumnos del sistema");
            }
            break;

        case "4":
            if (listaAlumnos.Count == 0)
            {
                Console.WriteLine("Todavia no hay alumnos cargados en el sistema para calcular el promedio: ");
            }
            else
            {
                decimal sumAverage = 0;

                foreach (Alumno aF in listaAlumnos)
                    sumAverage += aF.AverageGrade();

                decimal sumGeneral = sumAverage / listaAlumnos.Count;
                Console.WriteLine($"El promedio general de curso es de: {sumGeneral}");
            }
            break;

        case "5":
            int alumnTotalPassed = 0;
            foreach (Alumno aF in listaAlumnos)
            {
                if (aF.Passed())
                    alumnTotalPassed++;
            }
            Console.WriteLine($"Cantidad de alumnos aprobados: {alumnTotalPassed}");
            break;

        case "6":
            exit = true;
            break;
        default:
            Console.WriteLine("Ingresar una opcion valida: ");
            break;
    }    
}
//////////////////////////////////////////////////////////////////
List<Persona> peopleList = new List<Persona>();

peopleList.Add(new Persona("Marta Luna", 5678));
peopleList.Add(new Persona("Marto Sol", 1234));

foreach (Persona p in peopleList)
{
    Console.WriteLine(p.Presentarse());
} //gracais al polimorfismo se evita de escribir cadenas de if ineficientes y permite que el programa sea escalable a futuro (con alguna nueva clase)

List<IExportable> exportableList = new List<IExportable>();

exportableList.Add(new Alumno("Ana Perez", 1234));
exportableList.Add(new Profesor("Marta Diaz", 5678, "Programacion"));
exportableList.Add(new Materia("PROG1", "Programacion I", 128));

foreach (IExportable item in exportableList)
{
    Console.WriteLine(item.ExportarLinea());
}

Console.ReadLine();