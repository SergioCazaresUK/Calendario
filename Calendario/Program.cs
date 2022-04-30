static void identificar_Mes(int numMes)
{
    string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

    Console.WriteLine($"El mes con numero { numMes } es: {meses[numMes - 1]}");
};

Console.WriteLine("Ingresa el Numero: ");
int mesRecibido = int.Parse(Console.ReadLine());
identificar_Mes(mesRecibido);
