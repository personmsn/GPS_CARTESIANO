using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Localizacao
    {
        public int ID { get; set; }
        public string NomeAmigo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public List<LocalizacaoAmigos> lstAmigos { get; set; }

     }



    public class LocalizacaoAmigos
    {
        public int ID { get; set; }
        public string AmigoNome { get; set; }
        public double AmigoP { get; set; }

    }

}
