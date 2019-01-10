using System;
using Xunit;
using Lab02UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //use a theory when calling in more than one paramenter
        [Theory]
        [InlineData(250)]
        [InlineData(300)]
        [InlineData(350)]
        //test that you can deposit money in bank account
        public void CanDepositTest(decimal userDeposit)
        {
            Program.balance = 0;
            Assert.Equal(userDeposit, Program.Deposit(userDeposit));
        }

        [Theory]
        [InlineData(750, 250)]
        [InlineData(500, 500)]
        [InlineData(350, 650)]
        //test that you can withdraw from account
        public void CanWithdrawTest(decimal result, decimal userWithdrawal)
        {
            Program.balance = 1000;
            Assert.Equal(result, Program.Withdraw(userWithdrawal));
        }

        //use fact when there is only one parameter
        [Fact]
        //test to display current balance
        public void CanFindBalanceTest()
        {
            Program.balance = 50;
            Assert.Equal(50, Program.balance);
        }
    }
}
