using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElectroTienda;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    ProductosEntre Productos = null;

    public int playStock;
    public int xboxStock;
    public int ninswitchStock;
    public int blurayStock;
    public int tabletStock;
    public int teleStock;

    

    public Text stockText;
    public Text consolText;



    public string nombre;
    public string numeroDeProducto;

    public bool deseaComprar;
    // Start is called before the first frame update
    void Start()
    {
        playStock = 12;
        xboxStock = 12;
        ninswitchStock = 12;
        blurayStock = 12;
        tabletStock = 12;
        teleStock = 12;

        deseaComprar = false;

        WritteStock();
        


    }

    // Update is called once per frame
    void Update()
    {
        WritteStock();
        Buy();

    }

    void WritteStock()
    {

        stockText.text = "(1)Playstation: " + playStock +
                         "  (2)X-Box: " + xboxStock +
                         "  (3)Nintendo Switch: " + ninswitchStock +
                         "  (4)Blu-Ray: " + blurayStock +
                         "  (5)Tablets: " + tabletStock +
                         "  (6)Televisor: " + teleStock;


        Debug.Log("Playstation: " + playStock);
        Debug.Log("X-Box: " + xboxStock);
        Debug.Log("Nintendo Switch: " + ninswitchStock);
        Debug.Log("Blu-Ray: " + blurayStock);
        Debug.Log("Tablets: " + tabletStock);
        Debug.Log("Televisor: " + teleStock);
    }


    public void Buy()
    {
        name = nombre;
        int prdStock = 0;

        switch (numeroDeProducto)
        {
            case "1":
                Productos = new PlayStation(name);
                prdStock = playStock;        
                
                break;

            case "2":
                Productos = new XBox(name);
                prdStock = xboxStock;
                
                break;

            case "3":
                Productos = new NintendoSwitch(name);
                prdStock = ninswitchStock;
                
                break;

            case "4":
                Productos = new Tablets(name);
                prdStock = tabletStock;
                
                break;

            case "5":
                Productos = new BluRay(name);
                prdStock = blurayStock;
                
                break;

            case "6":
                Productos = new Televisor(name);
                prdStock = teleStock;
                
                break;

            default:
                Debug.Log("Objeto no encontrado");
                consolText.text = "Objeto no encontrado";
                break;
        }


        if (Productos == null)
            return;
        
        Productos.Info(consolText,prdStock);

        if (prdStock-1 >=0)
        {
            if (deseaComprar==true)
            {
                prdStock--;
                deseaComprar = false;
                consolText.text = "Compra Realizada";
            }
        }
        else
        {
            if (deseaComprar==true)
            {
                deseaComprar = false;
                consolText.text = "Compra denegada, producto agotado";
            }
        }

        switch (numeroDeProducto)
        {
            case "1": 
                playStock = prdStock;

                break;

            case "2":
                xboxStock = prdStock;

                break;

            case "3":
                ninswitchStock = prdStock;

                break;

            case "4":
                tabletStock = prdStock;

                break;

            case "5":
                blurayStock = prdStock;

                break;

            case "6":
                teleStock = prdStock;

                break;

            default:
                Debug.Log("Error de compra");
                break;
        }



    }
}
