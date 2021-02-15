using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Tema4_Ejer8
{
    class Imagen
    {
        public Bitmap imagen;
        private float tamano;
        public string nombre;
        public string resolucion;

        public Imagen(Bitmap imagen, float tamano, string nombre)
        {
            this.imagen = imagen;
            this.tamano = tamano;
            this.nombre = nombre;
            this.resolucion = imagen.HorizontalResolution + "x" + imagen.VerticalResolution;
        }

        public string DevuelveTamano()
        {
            if (tamano >= 1048576)
            {
                return tamano / 1048576 + "MB";
            }
            else
            {
                return tamano / 1024 + "KB";
            }

        }
    }
}
