using System;
using System.Collections.Generic;
using System.Text;

namespace Metas.Domain
{
    public class User
    {
        public int ID { get; set; }
        public int FUNC { get; set; }
        public string NOME { get; set; }
        public User(int id, int func, String nome)
        {
            ID = id;
            FUNC = func;
            NOME = nome;
        }
    }
}
