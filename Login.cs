using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Earth1702483_Gabriela
{
    public abstract class Login
    {
        private readonly int id;
        public int ID { get; { return id; } set { id = value; } }
        public string Nome { get; set; }
        public double Email { get; set; }
        public string Senha { get; set; }
        public Login () { }

       
        public string ObterNome()
        {
            return ID.ToString() + Nome;
        }
        public string ObterUser_Name()
        {
            return ID.ToString() + Email
        }
        public string ObterSenha()
        {
            return ID.ToString() + Senha;
        }
    }
}
