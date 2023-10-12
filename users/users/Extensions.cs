using static users.Dtos;
using users.models;

namespace users
{
    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
             return new UserDto(user.Id, user.Name, user.Email, user.Age, user.Created);
        }
    }
}
