using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        //Constructor 
        public Lata()
        { 
        
        }

        public Lata(string cod , string nom , string sabor, double precio , double volumen , int cant)

        {
            _codigo = cod;
            _nombre = nom;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
            _cantidad = cant;
        
        }

        //propiedad 

        public string codigo

        {
            get

            {
                return _codigo;

            }
        }

        public string nombre

        {
            get

            {
                return _nombre;

            }
        }

        public string sabor

        {
            get

            {
                return _sabor;

            }
        }

        public double precio

        {
            get

            {
                return _precio;

            }
        }
        public double volumen

        {
            get

            {
                return _volumen;

            }
        }

        public int cantidad

        {
            get

            {
                return _cantidad;

            }
            set
            {
                cantidad = value;
            
            }
        }

        //Metodos

        private double GetPrecioPorLitro()
        { 

            return
        
        }

        public override string ToString()
        {
            return string.Format(
           "Codigo:{0}" + System.Environment.NewLine +
           "Nombre:{1}" + System.Environment.NewLine + 
           "Cantidad:{2}" + System.Environment.NewLine +
          _codigo, _nombre, _cantidad);

        }

    }
}
