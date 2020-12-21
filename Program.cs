using System;
using Nova_pasta.Classes;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Console.WriteLine(user.Nome);

            Login app = new Login();
        }
    }
}
