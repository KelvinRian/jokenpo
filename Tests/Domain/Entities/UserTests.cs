using Domain.Commands;
using Domain.Entities;
using FluentAssertions;

namespace Tests.Domain.Entities
{
    public class UserTests
    {
        [Fact]
        public void ShouldCreateUser()
        {
            var command = new CreateUserCommand
            {
                Name = "Asterisco"
            };

            var user = User.Of(command);

            user.Name.Should().Be(command.Name);
        }
    }
}
