using System;
using System.Collections.Generic;
using System.Text;

namespace IceDog.xUnit.Test.Mocks
{
    public class Arithmetic
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Divide(int nb1, int nb2)
        {
            return nb1 / nb2;
        }
    }
}
