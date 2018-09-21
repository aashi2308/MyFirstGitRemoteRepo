using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace ClassLibrary1
{
    public class UserMgr
    {
        public void CreateUser(User u)
        {
            u.Age = Int32.Parse(Console.ReadLine());
            u.Name = Console.ReadLine();
        }
        public void ShowUser(User u)
        {
            if (u.Age < 18)
            {
                Console.WriteLine("{0} years people cannot vote", u.Age);
            }
            else
            {
                Console.WriteLine("Hello {0} you can vote", u.Name);
            }
        }
    }
}
