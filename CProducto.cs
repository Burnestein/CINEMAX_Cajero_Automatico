﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPP21B_ProyectoFinal_NemesisSIerra
{
    //---------------------------------------------------------------------
    //Clase que representa un producto en venta.
    //NJSA. 14/11/2021.
    //---------------------------------------------------------------------
    public class CProducto
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------
        public int Codigo { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Image Imagen;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public CProducto(int Codigo, string Producto, double Precio, int Stock, Image Imagen)
        {
            this.Codigo = Codigo;
            this.Producto = Producto;
            this.Precio = Precio;
            this.Stock = Stock;
            this.Imagen = Imagen;
        }
    }
}
