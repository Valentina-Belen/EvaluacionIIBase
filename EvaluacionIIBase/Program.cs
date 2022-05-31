using LibreriaEvaluacion.DTO;
using LibreriaEvaluacion.DAL;

const string nombreAlumno = "Valentina";

while (Menu(nombreAlumno))
{
    Console.ReadKey();
}


static bool Menu(string nombreAlumno)
{ 
    bool continuar = true;

    Console.Clear(); // Limpia la pantalla
    Console.Title = $"Evaluación II: {nombreAlumno}";

    Console.WriteLine("Menú de opciones");
    Console.WriteLine("================");
    Console.WriteLine("1) Listar préstamos");
    Console.WriteLine("2) Agregar préstamo");
    Console.WriteLine("3) Actualizar préstamo");
    Console.WriteLine("4) Eliminar préstamo");
    Console.WriteLine("");
    Console.WriteLine("0) Salir");

    string opcion = Console.ReadLine()
        .Trim(); // " 1 " => "1"

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Listado de préstamos registrados");
            OpcionListar();
            break;
        case "2":
            Console.WriteLine("Insertar un nuevo préstamo");
            OpcionInsertar();
            break;
        case "3":
            Console.WriteLine("Actualizar un préstamo existente");
            OpcionActualizar();
            break;
        case "4":
            Console.WriteLine("Eliminar un préstamo existente");
            OpcionEliminar();
            break;
        case "0":
            Console.WriteLine("Saliendo del programa ...");
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }

    return continuar;
}

static void OpcionInsertar(object nuevoPrestamo, int Monto)
{
    PrestamoDal prestamoDal = new PrestamoDal();

    try
    {
        Console.WriteLine("Ingrese ID:");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
        int id = int.Parse(s: Console.ReadLine().Trim());
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

        Console.WriteLine("Ingrese monto:");
        int monto = Console.ReadLine().Trim();

PrestamoDTO nuevoPrestamo = new PrestamoDTO()
        {
            Id = id;
            Monto = monto;
        }; 

    bool resultadoInsertar = prestamoDal.Insertar(nuevoPrestamo);


    if (resultadoInsertar)
        {
            Console.WriteLine(value: $"Se ha insertado el monto {nuevoPrestamo.Monto} exitosamente");
        }
        else
        {
            Console.WriteLine($"Hubo un error al insertar el préstamo {nuevoPrestamo.Monto}");
        }

    }

internal class PrestamoDal
{
    internal bool OpcionInsertar(object nuevoPrestamo)
    {
        throw new NotImplementedException();
    }

    internal bool OpcionEliminar(int id)
    {
        throw new NotImplementedException();
    }

    internal List<PrestamoDTO> OpcionListar()
    {
        throw new NotImplementedException();
    }

    internal bool Insertar(object nuevoPrestamo)
    {
        throw new NotImplementedException();
    }

    internal List<PrestamoDTO> Listar()
    {
        throw new NotImplementedException();
    }

    internal bool Eliminar(int id)
    {
        throw new NotImplementedException();
    }
{
    catch (Exception)
}
    Console.WriteLine($"Por favor ingrese datos válidos para la nueva prenda");
}

Console.ReadKey(); 
}

static void OpcionActualizar()
{

}

static void OpcionEliminar()
{
    PrestamoDal prestamoDAL = new PrestamoDal();

    Console.WriteLine("Ingrese el ID que desea eliminar:");
    int id = int.Parse(Console.ReadLine().Trim());

    bool resultadoEliminacion = prestamoDAL.Eliminar(id); 

    if (resultadoEliminacion)
    {
        Console.WriteLine("Se ha eliminado el préstamo");
    }
    else
    {
        Console.WriteLine("No se ha podido eliminar el préstamo, revise el ID ingresado");
    }

    Console.ReadKey();
}

static void OpcionListar()
{
    PrestamoDal prestamoDAL = new PrestamoDal();
    List<PrestamoDTO> datosLista = prestamoDAL.Listar();

    foreach (PrestamoDTO dato in datosLista)
    {
        Console.WriteLine(dato.ToString());
    }

    Console.ReadKey();

}