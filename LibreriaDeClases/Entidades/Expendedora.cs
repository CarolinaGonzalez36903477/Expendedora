using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        //constructores
        public Expendedora()
        { 
        
        }

        public Expendedora(List <Lata> latas, string prov , int cap, double dinero , bool enc)
        {
            _latas = latas;
            _proveedor = prov;
            _capacidad = cap;
            _dinero = dinero;
            _encendida = enc;

        }

        //propiedades 

        public List<Lata> latas

        { get

           { return _latas;

            }
        }

        public string proveedor 

        {
            get

            {
                return _proveedor;

            }
        }

        public int capacidad

        {
            get

            {
                return _capacidad;

            }
            set
            {
                capacidad= 100;
            }
        }

        public double dinero

        {
            get

            {
                return _dinero;

            }
        }

        public bool encendida

        {
            get

            {
                return _encendida;

            }
        }

        //Metodos
        public void AgregarLata(Lata lata)
        {
            if (lata == null)
            {
                Console.WriteLine("Debe agregar una lata ");
            }

            //determino la capacidad maxima de la expendedora como un 100 
            else if (capacidad==100)
            {
                Console.WriteLine("EXPENDEDORA LLENA : No se pueden agregar mas latas");
            }

            else
            {
                foreach (Lata l in _latas)
                {
                    if (l.codigo == lata.codigo)
                    {
                        Console.WriteLine("La lata con el codigo " + lata.codigo + " ya fue ingresada");
                    }

                }

                _latas.Add(lata);
                capacidad ++ ;

            }
        
        
        }

        public Lata ExtraerLata(ref string codigo,ref double dineroIngresado)
        {
            Lata lataElegida=null;

            foreach (Lata l in _latas)
            {
                if (l.codigo == codigo || l.precio <= dineroIngresado || l.cantidad!=0)
                {
                    lataElegida = l;
                }

                else
                {
                    lataElegida = null;
                }
            }

            return lataElegida;
        }

        public string GetBalance()

        {
         
            string balance;
            int cantLatas=0;
            double dineroTotal=0;
            double precioPorLata=0;

            foreach (Lata l in _latas)
            {
                cantLatas = +l.cantidad;
                precioPorLata = l.cantidad * l.precio;
                dineroTotal = +precioPorLata;
            
            }

            balance = "Cantidad de latas:" + Convert.ToDouble(cantLatas) + System.Environment.NewLine + "Dinero Total:" + Convert.ToDouble(dineroTotal);
            return balance;
        }

        public int GetCapacidadRestante()
        {

            int cantLatas=0;

            foreach (Lata l in _latas)
            {
                cantLatas = +l.cantidad;
            
            }

            return capacidad - cantLatas;
        
        }

        public bool EstaVacia()
        {
            bool Vacia;

            if (_latas.Count == 0)
            {
                Vacia = true;
            }

            else
            {
                Vacia = false;
            }

            return Vacia;

        
        }

        public void EncenderMaquina()
        {
            _encendida = true;
        
        }

    }
}
