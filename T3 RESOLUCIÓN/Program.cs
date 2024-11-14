byte opc1;

Console.WriteLine("Hola. Bienvenido al registro de academia");
Console.WriteLine("¿Qué acción desea realizar? ");
Console.WriteLine(" 1. CREAR");
Console.WriteLine(" 2. LISTAR");
Console.WriteLine(" 3. MODIFICAR");
Console.WriteLine(" 4. TERMINAR");
Console.WriteLine("-------------------------------------------");

Console.WriteLine("\nIngrese una opción (1-3)");
while (!byte.TryParse(Console.ReadLine(), out opc1) || opc1 > 4) ;
    Console.WriteLine("Error: Ingrese una opción adecuada.");


switch (opc1)
{
    case 1:

        break;
    case 2:

        break;
            case 3:

        break;
        case 4:
        Environment.Exit(0);
        break;
}
Console.ReadKey();