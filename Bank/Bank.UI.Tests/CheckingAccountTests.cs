using NUnit.Framework;
using Bank.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Bank.UI.Tests
{
    [TestFixture]
    public class CheckingAccountTests
    {
        [Test]
        public void Account_HasCorrectBalanceAfterConstruction()
        {
            var initialBalance = 2500;
            var interestRate = 0.05;
            var owner = "TestOwner";

            var account = new CheckingAccount(owner, initialBalance, interestRate);

            Assert.That(account.Balance, Is.EqualTo(initialBalance));
        }

        [Test]
        public void Deposit_AddsAmountToTheBalance()
        {
            var account = new CheckingAccount("Tamerlan", 0.05, 2500);

            account.Deposit(500);

            Assert.That(account.Balance, Is.EqualTo(3000));
        }

        [Test]
        public void Balance_IncreasesCorrectlyAfterYearlyInterests()
        {
            var account = new SavingsAccount("Tamerlan", 0.05, 2500);

            account.AddInterests();

            Assert.That(account.Balance, Is.EqualTo(2625));
        }
    }
}
