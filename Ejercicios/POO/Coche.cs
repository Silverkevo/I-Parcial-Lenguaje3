using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        //atributos 
        private string marca;
        //private string modelo;
        //private string precio;
        //private string km;
        //private int año;

        //Propiedades
        public string Marca
        {
            get => marca;
            set => marca = value;
        }

        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Kilometros { get; set; }
        public int Año { get; set; }

        //Constructores
        public Coche() { }

        public Coche(string marca, int año) 
        {
            Marca = marca;
            Año = año;
        }

        public Coche(string marca,string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;


        }

        public Coche(string marca, string modelo, decimal precio, int kilometros, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Kilometros = kilometros;
            Año = año;

            
            
        }
        //metodos
        public string DevolverDatosBasicos()
        {
            return "Marca" + Marca + "Modelo" + Modelo + "Año:" + Año;
        }
    }
}
