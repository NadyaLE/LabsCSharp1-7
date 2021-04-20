using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Litke_04
{
    public class Class1 : TypeLibrary.ILab4
    {
        private string[] Vars = { "A", "B", "C", "D", "E", "X"};

        public string[] GetAvailableVariables()
        {
            return Vars;
        }

        public int GetVariant()
        {
            return 5;
        }

        public void SetVariable(string variable, object val)
        {
            Vars[Array.IndexOf(Vars, variable)] = val.ToString();
        }

        public double GetResult()
        {
            int A, B, C, D, E;
            double X;
            int.TryParse(Vars[0], out A);
            int.TryParse(Vars[1], out B);
            int.TryParse(Vars[2], out C);
            int.TryParse(Vars[3], out D);
            int.TryParse(Vars[4], out E);
            double.TryParse(Vars[5], out X);
    
            return ((A * Math.Pow(X,2) + B * X + C)/(D * X + E));
        }
    }
 }

