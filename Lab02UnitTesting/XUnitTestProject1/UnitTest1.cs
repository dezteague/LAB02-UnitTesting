using System;
using Xunit;
using Lab02UnitTesting;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(250)]
        [InlineData(300)]
        [InlineData(350)]
        public void CanDepositTest(decimal userDeposit)
        {
            Program.balance = 0;
            Assert.Equal(userDeposit, Program.Deposit(userDeposit));
        }

        [Theory]
        [InlineData(750, 250)]
        [InlineData(500, 500)]
        [InlineData(350, 650)]
        public void CanWithdrawTest(decimal result, decimal userWithdrawal)
        {
            Program.balance = 1000;
            Assert.Equal(result, Program.Withdraw(userWithdrawal));
        }
    }
}
