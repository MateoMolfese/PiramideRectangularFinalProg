using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Datos
{
    public class RepositorioDePiramides
    {
        private List<PiramideRegular>? piramidesRegulares;
        private string nombreArchivo = "PiramideRectangular.txt";
        private string rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;
        public RepositorioDePiramides()
        {
            piramidesRegulares = new List<PiramideRegular>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto, nombreArchivo);
            piramidesRegulares = LeerDatos();
        }

        private List<PiramideRegular> LeerDatos()
        {
            var lista= new List<PiramideRegular>();
            if (!File.Exists(rutaCompletaArchivo))
            {
                return lista;
            }
            using (var lector=new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? lineaLeida = lector.ReadLine();
                    PiramideRegular piramideRegular = construirPiramide(lineaLeida);
                    lista.Add(piramideRegular);
                }
            }
            return lista;
        }
        public int GetCantidad(PiramideRegular? piramideRegular = null)
        {
            if (piramideRegular is null)
            {
                return piramidesRegulares!.Count;
            }
            return piramidesRegulares.Count(r=>r.)
        }
        public bool Existe(PiramideRegular piramideRegular)
        {
            return  
        }
        private PiramideRegular construirPiramide(string? lineaLeida)
        {
            var campos = lineaLeida!.Split("|");
            int LB=int.Parse(campos[0]);
            int A = int.Parse(campos[1]);
            int CL = int.Parse(campos[2]);
            Color Col = (Color) int.Parse(campos[3]);
            Material M = (Material) int.Parse(campos[4]);
            return new PiramideRegular(LB, A, CL, Col, M);
        }
    }
}
