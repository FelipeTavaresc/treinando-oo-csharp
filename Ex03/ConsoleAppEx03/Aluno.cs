using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx03
{
    public class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        private double ValorMinimoParaAprovacao = 60.0;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= ValorMinimoParaAprovacao)
                return true;
            else
                return false;
        }

        public double NotaFaltante()
        {
            if (Aprovado())
                return 0;
            return ValorMinimoParaAprovacao - NotaFinal();
        }
    }
}
