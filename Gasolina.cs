using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPlua3B.Tercer_Nivel_Cía._Ltda
{
    public class Gasolina
    {

        public Gasolina(string tipo, double cantidadGalones, double precioVenta)
        {
            Tipo = tipo;
            CantidadGalones = cantidadGalones;
            PrecioVenta = precioVenta;

        }


        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private double cantidadGalones;
        public double CantidadGalones
        {
            get { return cantidadGalones; }
            set { cantidadGalones = value; }
        }

        private double precioVenta;
        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }


        public double Subtotal
        {
            get { return PrecioVenta * CantidadGalones; }
        }

        public double ImpuestoVA 
        {
            get { return Subtotal * 0.12; }
        }

        public double TotalFactura
        {
            get { return Subtotal + ImpuestoVA; }
        }

    }
}