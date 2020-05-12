using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace ElectroTienda
{
    abstract class ProductosEntre
    {
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        } 
        
        public ProductosEntre(string name)
        {
            _name = name;
        }

        public ProductosEntre(string name, int stock)
        {
            _name = name;   
        }

        public ProductosEntre(string name, int stock, int cant)
        {
            _name = name;   
        }

        public void Comprar()
        {
            Console.WriteLine("Objeto Comprado");
        }

        public String WritteConsole()
        {
            string infotext = null;
            
            return infotext;
        }

        public virtual void Info(Text consoleTT, int numStock)
        {
            //Console.WriteLine("Informacion del Producto:");  
        }


    }

   
}
