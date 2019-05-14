using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonPlua3B.Tercer_Nivel_Cía._Ltda
{
    public class Cliente
    {

        public Cliente(string apellidos, string nombres, string numeroCedula, string direccion)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            NumeroCedula = numeroCedula;
            Direccion = direccion;
        }

        private string apellidos;
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombres;
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private string numeroCedula;
        public string NumeroCedula
        {
            get { return numeroCedula; }
            set { numeroCedula = value; }
        }

        private string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
