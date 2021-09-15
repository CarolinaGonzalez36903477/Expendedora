using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases.Utilidades
{

    public static class LataHelper
    {
        public static List<Lata> _listaLatas = new List<Lata>();

        public static void ListaLatas()
        {

            Lata lat1 = new Lata("1", "Coca","dulce",35,30,20);
            Lata lat2 = new Lata("2", "pepsi", "dulce", 30, 30, 10);
            Lata lat3 = new Lata("3", "7up", "amargo", 30, 30, 10);
            Lata lat4 = new Lata("4", "sprite", "dulce", 30, 30, 20);


            _listaLatas.Add(lat1);
            _listaLatas.Add(lat2);
            _listaLatas.Add(lat3);
            _listaLatas.Add(lat4);

        }
        public static void MostrarLatas()
        {
            foreach (Lata l in _listaLatas)
            {
                Console.WriteLine(l.ToString() + System.Environment.NewLine);
            }
        }



    



    }
}
