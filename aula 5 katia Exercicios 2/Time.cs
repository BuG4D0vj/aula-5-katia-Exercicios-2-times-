using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5_katia_Exercicios_2
{
    internal class Time
    {
        // construtores
        public Time()
        {
            Nome = "Atibaia FC";
            Pais = "Brasil";
            Estado = "São Paulo";
            Titulo = 0;
        }

        public Time(String p, string e)
        {
            Pais = p;
            Estado = e;
        }

    public string Nome {get; set;}
    public string Pais { get; set; }
    public string Estado { get; set; }
    public int Titulo { get; set; }
    }
}
