using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DATA
{
    public class BD
    {
        //REPRESENTA UMA CONSULTA AO BANCO DE DADOS COM AS INFORMAÇÕES DOS AMIGOS;
        public static List<Amigo> GetAmigo()
        {
            Amigo obj = new Amigo();
            List<Amigo> lst = new List<Amigo>();

            obj = new Amigo();
            obj.ID = 1;
            obj.Nome = "Renato";
            obj.X = 11;
            obj.Y = 1;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 2;
            obj.Nome = "Marcos";
            obj.X = 15;
            obj.Y = 15;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 3;
            obj.Nome = "Daniel";
            obj.X = 12;
            obj.Y = 10;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 4;
            obj.Nome = "Pedro";
            obj.X = 15;
            obj.Y = 6;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 5;
            obj.Nome = "Rodrigo";
            obj.X = 9;
            obj.Y = 12;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 6;
            obj.Nome = "Bruno";
            obj.X = 4;
            obj.Y = 5;
            lst.Add(obj);

            obj = new Amigo();
            obj.ID = 7;
            obj.Nome = "Alex";
            obj.X = 1;
            obj.Y = 1;
            lst.Add(obj);

            return lst;
        }

    }
}
