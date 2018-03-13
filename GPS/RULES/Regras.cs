using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace RULES
{
    public class Regras
    {
        public static List<Localizacao> Main()
        {
            //busca todos os amigos cadastrados
            List<Amigo> lstAmigos = LocalizarAmigos();
            //verifica a localizacao
            List<Localizacao> lstLocal = VerificaLocalizacao(lstAmigos);

            return lstLocal;
        }






        /// <summary>
        /// BUSCA TODOS OS AMIGOS
        /// </summary>
        /// <returns>LISTA COM INFORMACOES DOS AMIGOS</returns>
        public static List<Amigo> LocalizarAmigos()
        {
            //busca todos os amigos cadastrados
            List<Amigo> lst = DATA.BD.GetAmigo();

            //orderna lista em ordem alfabética
            lst = lst.OrderBy(x => x.Nome).ToList();

            return lst;
        }

        /// <summary>
        /// Lista todos os amigos para definir os  mais próximos 
        /// </summary>
        /// <param name="lstAmigo"></param>
        /// <returns></returns>
        public static List<Localizacao> VerificaLocalizacao(List<Amigo> lstamigo)
        {
            List<LocalizacaoAmigos> lstLocalAmigos = new List<LocalizacaoAmigos>();
            List<Localizacao> lst = new List<Localizacao>();
            Localizacao obj = new Localizacao();
            foreach (var amigoref in lstamigo)
            {
                lstLocalAmigos = new List<LocalizacaoAmigos>();
                obj = new Localizacao();
                obj.ID = amigoref.ID;
                obj.NomeAmigo = amigoref.Nome;
                obj.X = amigoref.X;
                obj.Y = amigoref.Y;

                foreach (var amigo in lstamigo)
                {
                    //para cada amigo do loop vai verificar onde estão todos os outros
                    if (obj.ID != amigo.ID)
                    lstLocalAmigos.Add(CalculaLocalizacao(obj, amigo));
                }
                obj.lstAmigos = lstLocalAmigos.OrderBy(x => x.AmigoP).ToList();
                lst.Add(obj);
            }

            return lst;
        }


        /// <summary>
        /// recebemos como parametro 2 amigos - com essas 2 informações é calculado a distancia entre os 2
        /// </summary>
        /// <param name="amigo"></param>
        /// <returns></returns>
        public static LocalizacaoAmigos CalculaLocalizacao(Localizacao objref, Amigo objamigo)
        {
            List<LocalizacaoAmigos> local = new List<LocalizacaoAmigos>();
            LocalizacaoAmigos obj = new LocalizacaoAmigos();

            //formula
            //raiz de (xa-xb)2 + (ya-yb)2 

            double x = (objamigo.X - objref.X);
            double y = (objamigo.Y - objref.Y);

            double xq = (x * x);
            double yq = (y * y);

            obj.AmigoP = Math.Sqrt(xq + yq);
            obj.AmigoNome = objamigo.Nome;

            return obj;
        }

    }
}
