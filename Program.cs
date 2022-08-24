using System;
internal class Program
{   
    private static void Main(string[] args)
    {
        float Membresia;
        float Precio;
        float Descuento;
        float Total;
        Console.WriteLine("Precio del helado seleccionado");
        Precio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Lista de descuentos por compra del clientes segun su membresia");
        Console.WriteLine("1. Tipo A: 10% de descuento");
        Console.WriteLine("2. Tipo B: 15% de descuento");
        Console.WriteLine("3. Tipo C: 20% de descuento");
        Console.WriteLine("Membresia del cliente");
        Membresia = Convert.ToInt32(Console.ReadLine());

        switch(Membresia) 
        {
            case 1:
                Descuento = (Precio/100)*10;
                break;
            case 2:
                Descuento = (Precio/100)*15;
                break;
            case 3:
                Descuento = (Precio/100)*20;
                break;
            default:
                Descuento = 0;
                break;
        }

        Total = Precio-Descuento;
        Console.WriteLine("Total a pagar: " + Total);
        Console.WriteLine("Membresia: " + Membresia);
        Console.WriteLine("Total de desuento: " + Descuento);
    }
}