using System;

class Program
{
    static void Main()
    {
        // Diccionario de palabras
        string[] diccionario = { "programacion", "computadora", "teclado", "monitor", "algoritmo", "redes", "internet" };

        // Crear una instancia de Random
        Random random = new Random();

        // Elegir una palabra aleatoria del diccionario
        string palabraSecreta = diccionario[random.Next(diccionario.Length)];
        string palabraUsuario = "";

        Console.WriteLine("Adivina la palabra secreta.");

        // Bucle para seguir pidiendo intentos hasta que el usuario acierte
        while (palabraUsuario != palabraSecreta)
        {
            Console.Write("Introduce tu intento: ");
            palabraUsuario = Console.ReadLine().ToLower(); // Convertir a minúsculas para comparación sin importar el caso

            if (palabraUsuario == palabraSecreta)
            {
                Console.WriteLine("¡Felicidades! Has adivinado la palabra secreta.");
            }
            else
            {
                Console.WriteLine("Intento incorrecto. Inténtalo de nuevo.");
            }
        }

        // Mantiene la consola abierta hasta que el usuario presione una tecla
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
