using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace EditorTexto
{
    class CArchivo
    {
        //determinar mas adelante la interfal para el patron extrategia. guardara y abrira los archivos de acuerdo a la extencion
        public CArchivo()
        {

        }
        public void Salvar(string directorio)
        {
            string extencion = Path.GetExtension(directorio).ToLower();

            if (extencion == ".pdf")
                GuardarArchivoPdf(directorio);
            if (extencion == ".doc" || extencion == ".docx")
                LeerAchivoWord(directorio);
            if (extencion == ".txt")
                LeerAchivoTxt(directorio);

        }

        public string LeerArchivos(string directorio)
        {
            string extencion = Path.GetExtension(directorio).ToLower();

            if (extencion == ".pdf")
                return LeerArchivoPdf(directorio);
            if (extencion == ".doc" || extencion == ".docx")
                return LeerAchivoWord(directorio);
            if (extencion == ".txt")
                return LeerAchivoTxt(directorio);
            else
                return null;
        }

        private void GuardarArchivoPdf(string directorio)
        {
            PdfWriter writer = new PdfWriter(directorio);
            writer.Close();
        }

        private string LeerAchivoTxt(string directorio)
        {
            string text = File.ReadAllText(directorio);
            return text;
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
                    if (aux[aux.Length - 1] != "")
                        sumar += aux.Length -1;
                    else
                        sumar += aux.Length - 2;
                }
                  
            }
            if (contador[contador.Length - 1] == "" || contador[0] == null)
                sumar--;
            return contador.Length + sumar;
        }

        public string LeerAchivoWord(string directorio)
        {
            Application archivo = new Application();
            Document doc = archivo.Documents.Open(directorio);
            string text = doc.Content.Text;
            doc.Close();
            return text;
        }


        public string LeerArchivoPdf(string directorio)
        {
            int i = 0;
            //List<string> texto = new List<string>(); //se supone que los arreglos son mas rapidos que las listas ¿pongamolos a puerba?
            var pdf = new PdfDocument(new PdfReader(directorio));
            var strategy = new LocationTextExtractionStrategy();
            int NumPag = pdf.GetNumberOfPages();
            string[] texto = new string[NumPag];
            
            for (i = 0; i < NumPag;  i++)
            {
                var page = pdf.GetPage(i+1);
                texto[i] = PdfTextExtractor.GetTextFromPage(page);
            }
            pdf.Close();            
            return string.Join(" ", texto);
        }

        public int ObtenerNumPag(string directorio)
        {
            var pdf = new PdfDocument(new PdfReader(directorio));
            int NumPag = pdf.GetNumberOfPages();
            pdf.Close();
            return NumPag;
        }
    }

}
