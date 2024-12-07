using Microsoft.AspNetCore.Mvc;

namespace UserInfo.Controllers;

[ApiController]
[Route("[controller]")]
public class UserInfoController : ControllerBase
{
    private readonly ILogger<UserInfoController> _logger;
    
    public UserInfoController(ILogger<UserInfoController> logger)
    {
        _logger = logger;
    }
    
    private static readonly IDictionary<long, User> Users = new Dictionary<long, User>();

    private static long _currentId = 0;

    [HttpGet]
    [Route("{userId:long}")]
    public User? Get([FromRoute] long userId)
    {
        return Users[userId];
    }
    
    [HttpGet]
    public IEnumerable<User> Get()
    {
        if (Users.Count == 0)
            return Array.Empty<User>();
        return Enumerable.Range(1, Users.Count).Select(index => Users[index]);
    }
    
    
    [HttpPost]
    public User Create([FromBody] User user)
    {
        if (user.UserId == 0)
        { 
            user.UserId = ++_currentId;
        }
        Users.Add(user.UserId, user);
        return user;
    }

    [HttpDelete]
    [Route("{userId:long}")]
    public void Delete([FromRoute] long userId)
    {
        Users.Remove(userId);
    }

    [HttpPut]
    [Route("{userId:long}")]
    public User? Update([FromBody] User user, long userId)
    {
        user.UserId = userId;
        Users[userId] = user;
        return user;
    }
    
}

public class User
{
    public long UserId { get; set; }
    public string UserName { get; set; }
    public string CityName { get; set; }
    public string ProgramName { get; set; }
}
