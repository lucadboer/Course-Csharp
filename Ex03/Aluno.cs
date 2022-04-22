using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string AproRepro()
        {
            if (NotaFinal() >= 60)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }

        public double NotaRestante()
        {
            return (60 - NotaFinal()); 
        }
    }
}
