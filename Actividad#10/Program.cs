using Actividad_10;

bool generalContinue = true;
List <Products> productsList = new List <Products>();
while (generalContinue)
{
    try
    {
        ShowSwitch(ref productsList, ref generalContinue);
    }
    catch (FormatException)
    {
        Console.WriteLine("\nERROR!, Datos Inválidos");
        Console.ReadKey();
    }
}
static int ShowMenu()
{
    Console.Clear();
    Console.WriteLine(" --- Sistema de Gestión de Productos ---");
    Console.WriteLine("1. Agregar Productos");
    Console.WriteLine("2. Listar Productos");
    Console.WriteLine("3. Buscar Productos");
    Console.WriteLine("4. Salir");
    Console.Write("\nIngrese una Opción: ");
    int menuOption = int.Parse(Console.ReadLine());
    return menuOption;
}
static bool GoOut(ref bool generalContinue)
{
    Console.Clear();
    Console.WriteLine("Usted está Saliendo del Programa");
    generalContinue = false;
    return generalContinue;
}
static void ShowSwitch(ref List<Products> productsList, ref bool generalContinue)
{
    switch (ShowMenu())
    {
        case 1:
            Products.AddProduct(ref productsList);
            break;
        case 2:
            Products.ListProduct(ref productsList);
            break;
        case 3:
            Products.SearchProduct(ref productsList);
            break;
        case 4:
            GoOut(ref generalContinue);
            break;
        default:
            Console.WriteLine("Ingrese una Opción Válida (1 - 4)");
            Console.ReadKey();
            break;
    }
}