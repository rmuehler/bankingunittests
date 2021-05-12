using System;
using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
    public class Account_Withdrawal
    {
        [Fact]
        public void Should_withdraw30fromAccountandBalanceof100_should_be70()
        {
            // Arrange
            Account account = new Account("CS-X", "Bob", "Putnam");
            // Act
            account.Deposit(100);
            account.Withdrawal(30);
            // Assert

            account.Balance.Should().Be(70);
        }

        [Fact]
        public void Should_ThrowExeptionIfNegativeAmountisBeingWithdrawn()
        {
        //Given 
        Account account = new Account("CS-X", "Bob", "Putnam");
        //When
        Action action = () => account.Withdrawal(-1);
        //Then
        action.Should().Throw<ApplicationException>();

        }

           [Fact]
        public void Should_ThrowExeptionIfTooPoor()
        {
            // Arrange
            Account account = new Account("CS-X", "Bob", "Putnam");
            // Act
            account.Deposit(50);
            Action action = () => account.Withdrawal(80);

            // Assert
            action.Should().Throw<ApplicationException>();

        }


               [Fact]
        public void Should_AddTransactionWhenWithdrawing()
        {
            // Arrange
            Account account = new Account("CS-X", "Bob", "Putnam");
            // Act
            account.Deposit(100);
            account.Withdrawal(30);
            // Assert

            account.Transactions.Should().Contain("Withdraw: $30");
        }
    }
        
}