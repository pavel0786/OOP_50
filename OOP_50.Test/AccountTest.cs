using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OOP_50.Class;

namespace OOP_50.Test
{
    [TestFixture]
    class AccountTest
    {
        private Account anaccount;

        [SetUp]
        public void Init()
        {
             anaccount = new Account("Pavel", "192.168.0.1");
            
        }

        [Test]
        public void DepositTest()
        {
           
            anaccount.Deposit(200);
            Assert.Greater(anaccount.Withdraw(200), true);
            
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void Check_If_Exception_Thrown_Withdraw_More_Than_Balance()
        {
            anaccount.Withdraw(50);
        }
    }
}
