using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndersonPlua3B.Tercer_Nivel_Cía._Ltda;

namespace AndersonPlua3B
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Plua", "Anderson", "1010240190", "Uleam");
            Gasolina valoresC1 = new Gasolina("Extra", 5, 1.5);

            Cliente cliente2 = new Cliente("Macias", "Beba", "1110421090", "Mi casa");
            Gasolina valoresC2 = new Gasolina("Super", 5, 2);

            Console.WriteLine(":Datos del usuario 1:::::" );
            Console.WriteLine("Apellido: {0}, Nombre: {1}, N° cédula: {2}, Dirección: {3}",
                    cliente1.Apellidos, cliente1.Nombres, cliente1.NumeroCedula, cliente1.Direccion);
                    Console.WriteLine(" ");

            Console.WriteLine(":Datos gasolina usuario 1::::: ");
            Console.WriteLine("Tipo: {0}, Galones: {1}, Precio: {2}",
                    valoresC1.Tipo, valoresC1.CantidadGalones, valoresC1.PrecioVenta);
                    Console.WriteLine(" ");

            Console.WriteLine(":Datos del usuario 2:::::" );
            Console.WriteLine("Datos personales del usuario 2: Apellido: {0}, Nombre: {1}, N° cédula: {2}, Dirección: {3}",
                    cliente2.Apellidos, cliente2.Nombres, cliente2.NumeroCedula, cliente2.Direccion);
                    Console.WriteLine(" ");
            Console.WriteLine(":Datos gasolina usuario 2::::: ");
            Console.WriteLine("Datos gasolina: Tipo: {0}, Galones: {1}, Precio: {2}",
                    valoresC2.Tipo, valoresC2.CantidadGalones, valoresC2.PrecioVenta);
                    Console.WriteLine(" ");

            Console.WriteLine(":::::::TOTAL FACTURA 1:::::::     ");
            Console.WriteLine("     Subtotal:     "+ valoresC1.Subtotal );
            Console.WriteLine("     Iva 12%:      "+ valoresC1.ImpuestoVA );
            Console.WriteLine("     Valor Final:  "+ valoresC1.TotalFactura);
            Console.WriteLine(" ");

            Console.WriteLine(":::::::TOTAL FACTURA 2:::::::     ");
            Console.WriteLine("Subtotal:     " + valoresC2.Subtotal);
            Console.WriteLine("Iva 12%:      " + valoresC2.ImpuestoVA);
            Console.WriteLine("Valor Final:  " + valoresC2.TotalFactura);

            Console.ReadKey();
        }
    }
}