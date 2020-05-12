using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectroTienda;
using UnityEngine;

namespace ConsoleApp1
{
    

    /*class Program {
        //Stock();
        
        public int playStock = 12;
        public int xboxStock = 12;
        public int ninswitchStock = 12;
        public int blurayStock = 12;
        public int tabletStock = 12;
        public int teleStock = 12;

        void Stock()
        {
            Console.WriteLine("Select character class");
            Console.WriteLine("1 - PlayStation");
            Console.WriteLine("2 - X-Box");
            Console.WriteLine("3 - Nintendo Switch");
            Console.WriteLine("4 - Tablets");
            Console.WriteLine("5 - Blu Ray");
            Console.WriteLine("6 - Televisor");

        }




        static void Main(string[] args) {
            bool nextLoop = true;

            while (nextLoop) {
                Console.Clear();
                Loop();

                Console.WriteLine("Continue? (Y/N)");
                string next = Console.ReadLine();

                if (next.ToUpper() != "Y")
                    nextLoop = false;

            }

        }
        

        static void Loop() {

            Console.WriteLine("Introdusca su nombre:");
            string name = Console.ReadLine();

            ProductosEntre Productos = null;



            Console.WriteLine("Selecione producto de compra");
            Console.WriteLine("1 - PlayStation");
            Console.WriteLine("2 - X-Box");
            Console.WriteLine("3 - Nintendo Switch");
            Console.WriteLine("4 - Tablets");
            Console.WriteLine("5 - Blu Ray");
            Console.WriteLine("6 - Televisor");

            string str = Console.ReadLine();


            switch (str) {
                case "1":
                    Productos = new PlayStation(name);
                    //Play((Fighter)character);
                    break;

                case "2":
                    Productos = new XBox(name);
                    //Play((Druid)character);
                    break;

                case "3":
                    Productos = new NintendoSwitch(name);
                    //Play((Ranger)character);
                    break;

                case "4":
                    Productos = new Tablets(name);
                    //Play((Ranger)character);
                    break;

                case "5":
                    Productos = new BluRay(name);
                    //Play((Ranger)character);
                    break;

                case "6":
                    Productos = new Televisor(name);
                    //Play((Ranger)character);
                    break;

                default:
                    Console.WriteLine("Objeto no encontrado");
                    break;
            }


            if (Productos == null)
                return;


            Productos.Info();

        }

    }*/

}
