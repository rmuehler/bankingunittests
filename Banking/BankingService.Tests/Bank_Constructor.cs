using FluentAssertions;
using Xunit;

namespace BankingService.Tests
{
    public class Bank_Constructor
    {
        [Fact]
        public void Should_CreatBankWithEmptyAccountsList()
        {
            // Arrange
            Bank bank = new Bank();
            // Assert
            // Act
            bank.Accounts.Should().BeEmpty();
        }
    }
}