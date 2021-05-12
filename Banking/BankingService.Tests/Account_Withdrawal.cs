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
        public void TestName()
        {
        //Given 
        Account account = new Account("CS-X", "Bob", "Putnam");
        //When
        //Then
        account.Withdrawal(-1).Should().Throw<ApplicationException>();
        }
    }
        
}