using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramideRectangularFinalProg.Entidades
{
    public class PiramideRegular
    {
        public int LadoBase { get; set; }
        public int Altura { get; set; }
        public int CantidadLados { get; set; }
        public Color Color { get; set; }
        public Material Material { get; set; }
        private double AreaBase;
        public double areaBase
        {
            get { return GetCntidadLados(); }
        }
        public PiramideRegular()
        {
            
        }
        public PiramideRegular(int LB, int A,int CL, Color Col,Material M)
        {
            LadoBase = LB;
            Altura = A;
            CantidadLados = CL;
            Color = Col;
            Material = M;
            AreaBase = GetCntidadLados();
        }
        public override string ToString()
        {
            return $"Piramide Regular: LB = {LadoBase}, A = {Altura}, CL = {CantidadLados}, Col = {Color}, M = {Material}";
        }
        private double GetCntidadLados()
        {
            if (areaBase==3)
            {
                AreaBase = (Math.Sqrt(3) / 4) * Math.Pow(LadoBase, 2);
            }
            else
            {
                if (areaBase==4)
                {
                    AreaBase = LadoBase * 2;
                }
            }
            return areaBase*Altura;
        }
        public double GetVolumen() => AreaBase * Altura / 3;
        private double GetPerimetroBase() => LadoBase * CantidadLados;
        private double GetAlturaLateral() => Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(LadoBase / 2, 2));
        public double GetAreaLateral() => GetPerimetroBase() * GetAlturaLateral() / 2;
        public double GetAreaTotal() => AreaBase + GetAreaLateral();


    }
}
