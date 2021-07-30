using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorTexto
{
    class CArchivo
    {
        private string path = "";
        private string extencion;
        private List<int> tamaño = new List<int>();

        public List<int> Tamaño { get => tamaño; set => tamaño = value; }

        public CArchivo()
        {
            
        }
        public void Salvar()
        {
            //logica para guardar archvivo
        }

        public void Abrir()
        {
            //logica para abrir el archivo;
       
        }
       
        public List<int> ObtenerTamaños()
        {
            for (int i = 8; i <= 30; i++)
            {
                this.Tamaño.Add(i);
            }
            return Tamaño;
        }

        public static int ContadorPalabras(string texto)
        {
            string[] contador = texto.Split(' ');
            int sumar= 0;

            foreach (var item in contador)
            {
                if (item.Contains('\n'))
                {
                    string[] aux = item.Split('\n');
                    if (aux[1] != "")
                        sumar++;
                }
                  
            }
            if (contador[contador.Length - 1] == null || contador[contador.Length - 1] == "")
                sumar--;
            return contador.Length + sumar;
        }



    }
}
