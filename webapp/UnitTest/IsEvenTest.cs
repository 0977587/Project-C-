using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace UnitTest
{
    [TestClass]
    public class IsEvenTest
    {
        [TestMethod]
        public bool IsEven(int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }

        [TestMethod]
        public void returnWachtrijLengthTest()
        {
            //arrange 


            //act

            
            //assert


        }
    }
}
