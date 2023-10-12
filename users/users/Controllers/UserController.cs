using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using users.models;
using static users.Dtos;

namespace users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        Connect connect = new();
        [HttpGet]
        public string Get()
        {
            
            try
            {
                connect.connection.Open();
                return "Sikeres Csatlakozás";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        [HttpPost]
        public ActionResult Post(CreateUserDto createUser)
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToString("yyy-MMM-dd HH-mm:ss");
            
            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = createUser.Name,
                Email = createUser.Email,
                Age = createUser.Age,
                Created = time
            };
            
            try
            {
                connect.connection.Open();
                string sql = $"INSERT INTO users(id, Name, Email, Age, Created)VALUES{user.Id},{user.Name},{user.Email},{user.Age},{user.Created})";

                MySqlCommand cmd = new MySqlCommand(sql, connect.connection);
                cmd.ExecuteNonQuery();

                connect.connection.Close();
                return StatusCode(201, user);
            }
            catch (Exception)
            {

                return BadRequest();
            }
            
        }
    }
}
