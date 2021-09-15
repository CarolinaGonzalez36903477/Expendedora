using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaDeClases;
using LibreriaDeClases.Utilidades;
using ExpendedoraEjercicio.Interfaz;


namespace Expendedoras.Interfaz
{
    class Program
    {

        static bool _ExpendedoraEncencida;
        static Expendedora _tiendaExpendedora;
        
        //Enciendo Expendedora y la cargo con productos.
        static Program()
        {
            _tiendaExpendedora.EncenderMaquina();
            LataHelper.ListaLatas();

        }

        static void Main(string[] args)
        {

            int opcion;
            while (_ExpendedoraEncencida)
            {
                Console.WriteLine("EXPENDEDORA");
                DesplegarMenu();
                opcion = ValidacionesHelpers.PedirInt("Opcion que desea realizar");

                switch (opcion)
                {
                    case 1:
                        LatasDisponibles();
                        break;
                    case 2:
                        InsertarLata();
                        break;
                    case 3:
                        ExtraerLata();
                        break;
                    case 4:
                        ConocerBalance();
                        break;
                    case 5:
                        StockDisponible();
                        break;
                    case 6:
                        _ExpendedoraEncencida = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                    
                }

            }

        }


        static void DesplegarMenu()
        {
            Console.WriteLine("******* Menu *******");
            Console.WriteLine("1- Listar latas disponibles");
            Console.WriteLine("2- Insertar una Lata");
            Console.WriteLine("3- Extraer una Lata");
            Console.WriteLine("3- Conocer Balance");
            Console.WriteLine("4- Traer el stock disponible y la descripcion de cada lata");

        }

        //Caso 1 - Pido lista de Latas 

        private static void LatasDisponibles()
        {
            LibreriaDeClases.Utilidades.LataHelper.MostrarLatas();

        }

        //Caso2 Insertar Una lata 

        private static void InsertarLata()
        {
           string codigo;
           string nombre;
           double precio;
           double volumen;
           int cantidad;
           string sabor="";

            do
            {
                
                codigo = ValidacionesHelpers.SolicitarString(Console.ReadLine());
                nombre = ValidacionesHelpers.SolicitarString(Console.ReadLine());
                precio = ValidacionesHelpers.PedirDouble(Console.ReadLine());
                volumen = ValidacionesHelpers.PedirDouble(Console.ReadLine());
                cantidad = ValidacionesHelpers.PedirInt(Console.ReadLine());

                Lata lat = new Lata(codigo, nombre, sabor, precio,volumen, cantidad);
                _tiendaExpendedora.AgregarLata(lat);

            } while (_ExpendedoraEncencida);
        }

        private static void ExtraerLata()
        {
            string codigo;
            double dineroIngresado=0;
            Lata lataAExtraer;

            LatasDisponibles();
            codigo = ValidacionesHelpers.SolicitarString(Console.ReadLine());
            lataAExtraer=_tiendaExpendedora.ExtraerLata(ref codigo, ref dineroIngresado);

            if (lataAExtraer == null)
            {
                Console.WriteLine("Error al extraer la lata");

            }

            else
            {
                _tiendaExpendedora.capacidad--;
                lataAExtraer.cantidad--;
            
            }
        }

        private static void ConocerBalance()
        {

            string balance;
            do
            {
                balance = _tiendaExpendedora.GetBalance(); 

            } while (_ExpendedoraEncencida);

            Console.WriteLine(balance);
        }

        private static void StockDisponible()
        {
            do
            {

                if (_tiendaExpendedora.GetCapacidadRestante()==100)
                {
                    Console.WriteLine("La expendedora esta vacia");

                }

                else
                {
                    foreach (Lata l in _tiendaExpendedora.latas)
                    { 
                        Console.WriteLine("")
                    
                    }

                }

            } while (_ExpendedoraEncencida);
        
        }

    }
}
