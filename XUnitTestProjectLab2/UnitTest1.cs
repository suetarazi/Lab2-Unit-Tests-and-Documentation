using System;
using Xunit;
using Lab2_Unit_Tests_and_Documentation;

namespace XUnitTestProjectLab2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            decimal number = 3;
            Assert.Equal(3, Program.ViewBalance(number));
        }
        [Fact]
        public void Test2()
        {
            decimal number = -3;
            Assert.Equal(-3, Program.ViewBalance(number));
        }

        [Fact]
        public void Test3()
        {
            Program.Balance = 500;
            Program.WithdrawMoney(20);
            Assert.Equal(480, Program.Balance);
        }
        
        [Fact]
        public void Test4()
        {
            Program.Balance = 500;
            Program.WithdrawMoney(600);
            Assert.Equal(-100, Program.Balance);
        }

        [Fact]
        public void Test5()
        {
            Program.Balance = 300;
            Program.AddMoney(50);
            Assert.Equal(350, Program.Balance);
        }

        [Fact]
        public void Test6()
        {
            Program.Balance = 100;
            string result = Program.AddMoney(-101);
            Assert.Equal("Invalid input", result);
        }
    }
}
