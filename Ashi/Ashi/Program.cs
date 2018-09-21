using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using ClassLibrary1;

namespace Ashi
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            UserMgr u1 = new UserMgr();
            u1.CreateUser(u);
            u1.ShowUser(u);
            Console.ReadKey();

        }
    }
}
