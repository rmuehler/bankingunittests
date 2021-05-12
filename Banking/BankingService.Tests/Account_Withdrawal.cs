using System;
using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
    public class Account_Withdrawal
    {
        [Fact]
        public void Test()
        {
            // Arrange
            Account account = new Account("CS-X", "Bob", "Putnam");
            // Act
            account.Deposit(100);
            account.Withdrawal(30);
            // Assert

            account.Balance.Should().Be(70);
        }
    }
}`