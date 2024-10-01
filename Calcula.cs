using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjCalculadoraRadio
{
    internal class Calcula
    {
        Double res = 0.0;
        Double resSenCos = 0.0;
        public Double Calcular(Double v1, Double v2, String op)
        {
            if (op == "+")
            {
                res = v1 + v2;
                return res;
            } else if (op == "-")
            {
                res = v1 - v2;
                return res;
            } else if (op == "x")
            {
                res = v1 * v2;
                return res;
            } else
            {
                res = v1 / v2;
                return res;
            }
        }
        
        public Double CalcularRadio (Double v1, Double v2, String op)
        {
            if (op == "sen")
            {
                resSenCos = Math.Sin((Math.PI / 180) * v1);
                return resSenCos;
            } else
            {
                resSenCos = Math.Cos((Math.PI / 180) * v1);
                return resSenCos;
            }
        }
    }
}
