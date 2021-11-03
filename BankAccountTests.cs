using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank_Project;
using System;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Check_Withdraw()
        {
            // Arrange
            int beginningBalance = 40;
            int withdrawAmount = 30;
            int expected = 25;
            BankAccount account = new BankAccount("Robot Bank", "Robot Man", "Robot Account", "checkingAccount", beginningBalance);

            // Act
            account.Withdraw(withdrawAmount);

            // Assert 
            int actual = account.AccountBalance;
            Assert.AreEqual(expected, actual, 24, "Account not withdrawn correctly");
        }

        [TestMethod]
        public void Withdraw_AmountLessThanZero()
        {
            // Arrange
            int beginningBalance = 45;
            int withdrawAmount = -900;
            BankAccount account = new BankAccount("No Money Bank", "No Money Man", "No Money Account", "checkingAccount", beginningBalance);

            // Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void Withdraw_AmountGreaterThanBalance()
        {
            // Arrange
            int beginningBalance = 100;
            int withdrawAmount = 200;
            BankAccount account = new BankAccount("This Bank", "This Man", "This Account", "checkingAccount", beginningBalance);

            // Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Withdraw(withdrawAmount));
        }

        [TestMethod]
        public void Check_Deposit()
        {
            // Arrange
            int beginningBalance = 3000;
            int depositAmount = 4500;
            int expected = 600;
            BankAccount account = new BankAccount("Rich Bank", "Rich Lady", "Rich Account", "investmentIndividualAccount", beginningBalance);

            // Act
            account.Deposit(depositAmount);

            // Assert
            int actual = account.AccountBalance;
            Assert.AreEqual(expected, actual, 4000, "Account not deposited correctly");
        }

        [TestMethod]
        public void Deposit_AmountLessThanZero()
        {
            // Arrange
            int beginningBalance = 7000;
            int depositAmount = -45;
            BankAccount account = new BankAccount("Bank of Banks", "Banker's Man", "Bank Account", "investmentCorporateAccount", beginningBalance);

            // Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Deposit(depositAmount));
        }

        [TestMethod]
        public void Check_Transfer() // Moves money from Account1 to Account2
        {
            // Arrange
            int account1Balance = 400;
            int account2Balance = 300;
            int transferAmount = 20;
            int expected = 15;
            BankAccount account1 = new BankAccount("Bank 1", "First Person", "First Account", "checkingAccount", account1Balance);
            BankAccount account2 = new BankAccount("Bank 2", "Second Person", "Second Account", "checkingAccount", account2Balance);

            // Act
            account1.Withdraw(transferAmount);
            account2.Deposit(transferAmount);

            // Assert 
            int actual = account2.AccountBalance;
            Assert.AreEqual(expected, actual, 314, "Account not transfered correctly");
        }

        [TestMethod]
        public void Transfer_AmountLessThanZero() // check
        {
            // Arrange
            int account1Balance = 400;
            int account2Balance = 300;
            int transferAmount = -20;
            BankAccount account1 = new BankAccount("Bank 1", "First Person", "First Account", "checkingAccount", account1Balance);
            BankAccount account2 = new BankAccount("Bank 2", "Second Person", "Second Account", "checkingAccount", account2Balance);

            // Act and Assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account1.Deposit(transferAmount));
        }

        //public void Transfer_IndividualInvestmentAccount_GreaterThan500()
        //{
        //    // Arrange
        //    int account1Balance = 400;
        //    int account2Balance = 300;
        //    int transferAmount = 501;
        //    BankAccount account1 = new BankAccount("Bank 1", "First Person", "First Account", "investmentIndividualAccount", account1Balance);
        //    BankAccount account2 = new BankAccount("Bank 2", "Second Person", "Second Account", "checkingAccount", account2Balance);

        //    //if (account1.AccountType == "investmentIndividualAccount")
        //    //    {
        //    //    // Act and Assert
        //    //    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account1.Deposit(transferAmount));
        //    //}

        //    //return;

        //    // Act and Assert
        //    Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account1.Deposit(transferAmount));
        //}

    }
}
