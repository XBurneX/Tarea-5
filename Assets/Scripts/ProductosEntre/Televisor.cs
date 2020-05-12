using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace ElectroTienda
{
    class Televisor : ProductosEntre
    {
        int stock = 12;

        int _cant = 1;
        int num = 1;

        private float _precio = 5000;
        private float _video = 720;

        public Televisor(string name) : base(name) { }

        public Televisor(string name, int cant) : base(name, cant)
        {
            num = _cant * cant;
        }

        public override void Info(Text consoleTT, int numStock)
        {
            stock = numStock;

            string almacen = null;

            if (stock - num >= 0)
            {
                almacen = ("  Comprar:(Yes/No)");

            }

            else
            {
                almacen = ("---Producto agotado---");
            }

            string elTexto =
            ("Stock: " + stock) +
            ("  Precio: " + _precio + "soles") +
            ("  Calidad de video: " + _video + "pixeles") +
            almacen;

            consoleTT.text = elTexto;

            return;
        }
    }
}
