using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorizationController : ControllerBase
{
    private readonly ILogger<AuthorizationController> _logger;

    public AuthorizationController(ILogger<AuthorizationController> logger)
    {
        _logger = logger;
    }
    
    private static Dictionary<string, User> Users = new Dictionary<string, User>();
    
    
    [HttpPost]
    public User CreateNewUser([FromBody] User user)
    {
        if (user.Discription == null)
            user.Discription = "...";
        Users.Add(user.UserName, user);
        return user;
    }

    [HttpGet]
    [Route("{username}")]
    public User GetUser(string username, [FromBody] string password)
    {
        if (Users[username].Password == password)
            return Users[username];
        return null;
    }

    [HttpGet]
    public IEnumerable<string> GetUsers()
    {
        return Users.Values.Select(x => "User: " + x.UserName + " Discription: " +  x.Discription);
    }

    [HttpDelete]
    [Route("{username}")]
    public void DeleteUser(string username, [FromBody] string password)
    {
        if (Users[username].Password == password)
            Users.Remove(username);
    }

    [HttpPatch]
    [Route("{username}")]
    public User UpdateUser(string username, [FromQuery] string password, [FromBody] string discription)
    {
        if (Users[username].Password == password)
        {
            Users[username].Discription = discription;
            return Users[username];
        }
        return Users[username];
    }

}

public class User
{
    public string UserName { get; set; }
    public string Password { get; set;  }
    public string? Discription { get; set; }
    
}