using Domain.Commands;

namespace Domain.Entities
{
    public class User
    {
        public string Name { get; private set; }

        public static User Of(CreateUserCommand command)
        {
            return new User
            {
                Name = command.Name,
            };
        }
    }
}
