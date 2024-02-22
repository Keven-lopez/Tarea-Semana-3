using System.Collections.Specialized;

void mayor_tres()
{
    int n1, n2, n3;

    Console.WriteLine("Ingrese un numero: ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero: ");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese otro numero: ");
    n3 = int.Parse(Console.ReadLine());
    if (n1 > n2)
    {
        if (n1 > n3)
        {
            Console.WriteLine("El numero mayor es: " + n1);
        }
        else
        {
            Console.WriteLine("El numero mayor es: " + n3);
        }
    }
    else
    {
        if (n2 > n3)
        {
            Console.WriteLine("El numero mayor es: " + n2);
        }
        else
        {
            Console.WriteLine("El numero mayor es: " + n3);
        }
    }
}
void edad_club()
{
    int n1;

    Console.WriteLine("Ingrese su edad");
    try
    {
        n1 = int.Parse(Console.ReadLine());
        if (n1 >= 18)
        {
            Console.WriteLine("Puedes ingresar al club");
        }
        else
        {
            Console.WriteLine("No puedes ingresar al club");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Invalido. Por favor, ingrese un numero entero.");
    }
}
void precio_final()
{
    double n1, resul;

    Console.WriteLine("Ingrese precio original del producto.");
    try
    {
        n1 = double.Parse(Console.ReadLine());
        if (n1 > 100)
        {
            resul = n1 - (n1 * .1);
        }
        else
        {
            resul = n1;
        }
        Console.WriteLine("El precio final es: " + resul);
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Invalido.");
    }
}
void usu_contra()
{
    string user, pass;
    try
    {
        Console.WriteLine("Ingrese usuario");
        user = Console.ReadLine();
        Console.WriteLine("Ingrese contrasena");
        pass = Console.ReadLine();
        if (user != "usuario" || pass != "contrasena")
        {
            Console.WriteLine("Usuario o Contrasena incorrecta.");
        }
        else
        {
            Console.WriteLine("Hola, usuario.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Invalido.");
    }
}
void par_impar()
{
    try
    {
        int n1;
        Console.WriteLine("Ingresar un numero.");
        n1 = int.Parse(Console.ReadLine());
        if (n1 % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }
    catch (FormatException) 
    {
        Console.WriteLine("Formato invalido.");   
    }
}
void prestamo()
{
    try
    {
        double monto;
        int edad;
        Console.WriteLine("Ingrese monto del prestamo");
        monto = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese edad");
        edad = int.Parse(Console.ReadLine());
        if (monto < 5000 || edad > 60)
        {
            Console.WriteLine("El prestamo es aprobado");
        }
        else
        {
            Console.WriteLine("El prestamo es rechazado");
        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Formato Invalido");
    }
}
void area()
{
    try
    {
        int choice;
        double b, a, resul;
        Console.WriteLine(@"Que tipo de figura geometrica quieres calcular?
1. Triangulo
2. Cuadrado
3. Circulo");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Ingrese base");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura");
                a = double.Parse(Console.ReadLine());
                resul = (b * a) / 2;
                Console.WriteLine("El resultado es: " + resul);
                break;
            case 2:
                Console.WriteLine("Ingrese base");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura");
                a = double.Parse(Console.ReadLine());
                resul = b * a;
                Console.WriteLine("El resultado es: " + resul);
                break;
            case 3:
                Console.WriteLine("Ingresar radio del circulo");
                b = double.Parse(Console.ReadLine());
                resul = Math.PI * Math.Pow(b, 2);
                Console.WriteLine("El resultado es: " + resul);
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato invalido");
    }
}
void letra_numero()
{
    string input;
    Console.WriteLine("Ingrese un numero del 1 al 5 en letra");
    input = Console.ReadLine();
    switch (input.ToLower())
    {
        case "uno":
            Console.WriteLine("Numero en digito: 1");
            break;
        case "dos":
            Console.WriteLine("Numero en digito: 2");
            break;
        case "tres":
            Console.WriteLine("Numero en digito: 3");
            break;
        case "cuatro":
            Console.WriteLine("Numero en digito: 4");
            break;
        case "cinco":
            Console.WriteLine("Numero en digito: 5");
            break;
        default:
            Console.WriteLine("Opcion invalida");
            break;

    }
}
void dia()
{
    try
    {
        int input;
        Console.WriteLine("Ingrese un numero del 1 al 7");
        input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miercoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sabado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Opcion Invalida");
                break;

        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Invalido");
    }
}
void pago_servicio()
{
    try
    {
        int input;
        Console.WriteLine(@"Que tipo de servicio quieres pagar?
1. Lavado de auto
2. Cambio de aceite
3. Revision mecanica");
        input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Total a pagar: Q30");
                break;
            case 2:
                Console.WriteLine("Total a pagar: Q80");
                break;
            case 3:
                Console.WriteLine("Total a pagar: Q150");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
    catch(FormatException)
    {
        Console.WriteLine("Formato invalido");
    }
}
void bienvenida()
{
    try
    {
        int input;
        Console.WriteLine(@"Ingrese idioma preferido/Enter preferred language/Saisir la langue préférée:
1. Espanol
2. Ingles
3. Frances");
        input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Bienvenidos.");
                break;
            case 2:
                Console.WriteLine("Welcome.");
                break;
            case 3:
                Console.WriteLine("Bienvenue");
                break;
            default:
                Console.WriteLine("Opcion invalida/Invalid Option/Option invalide");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Invalido/Invalid Format/Format invalide");
    }
}
void calificar()
{
    try
    {
        int input;
        Console.WriteLine("Ingrese calificacion del examen.");
        input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Perfecto.");
                break;
            case int n when (n >= 80 && n <= 89):
                Console.WriteLine("Satisfactorio.");
                break;
            case int n when (n >= 70 && n <= 79):
                Console.WriteLine("Acceptable.");
                break;
            case int n when (n >= 60 && n <= 69):
                Console.WriteLine("Pasaste.");
                break;
            case int n when (n >= 0 && n <= 59):
                Console.WriteLine("bruh.");
                break;
            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato invalido");
    }
}

int i1, i2;
try
{
    do
    {
        Console.WriteLine(@"1. Uso de Estructuras Condicionales
2. Ejercicios usando switch
3. Salir");
        i1 = int.Parse(Console.ReadLine());
        switch (i1)
        {
            case 1:
                Console.Clear();
                Console.WriteLine(@"1. Calcular el Mayor de Tres Números
2. Validar Edad para Ingresar a un Club
3. Calcular el Precio Final de un Producto
4. Validar Usuario y Contraseña
5. Determinar si un Número es Par o Impar
6. Mostrar un Mensaje de Aprobación o Rechazo de Préstamo
7. Calcular el Área de una Figura Geométrica");
                i2 = int.Parse(Console.ReadLine());
                switch (i2)
                {
                    case 1:
                        mayor_tres();
                        break;
                    case 2:
                        edad_club();
                        break;
                    case 3:
                        precio_final();
                        break;
                    case 4:
                        usu_contra();
                        break;
                    case 5:
                        par_impar();
                        break;
                    case 6:
                        prestamo();
                        break;
                    case 7:
                        area();
                        break;
                }
                break;
            case 2:
                Console.Clear();
                Console.WriteLine(@"1. Convertir un Número de Letra a Número
2. Mostrar el Día de la Semana a partir de un Número
3. Calcular el Importe a Pagar por un Servicio
4. Mostrar un Mensaje de Bienvenida en Diferentes Idiomas
5. Evaluar la Calificación de un Examen");
                i2 = int.Parse(Console.ReadLine());
                switch (i2)
                {
                    case 1:
                        letra_numero();
                        break;
                    case 2:
                        dia();
                        break;
                    case 3:
                        pago_servicio();
                        break;
                    case 4:
                        bienvenida();
                        break;
                    case 5:
                        calificar();
                        break;
                }
                break;
            case 3:
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opcion invalida");
                break;
        }
    } while (i1 != 3);
} catch (FormatException)
{
    Console.WriteLine("Formato invalido");
}