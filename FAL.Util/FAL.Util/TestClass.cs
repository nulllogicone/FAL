using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAL.Util
{
    public class TestClass
    {
        int i = 0;

        public void Hallo()
        {
            Console.Write("Hallo");
        }

        public void Add()
        {
            i++;
        }

        public TestClass getMe()
        {
            return this;
        }

        public static void TryWhat()
        {
            Console.Write("Habs versucht");
        }
    }
}
