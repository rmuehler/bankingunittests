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
        [Fact]
        public void Should_AddAnAccountToBanksAccountList()
        {
            // Arrange
            Bank bank = new Bank();
            Account account = new Account("CX-3", "Monica", "Barns");
            // Assert
            bank.AddAccount(account);
            // Act
            bank.Accounts.Should().Contain(account);
        }
        
    }
}