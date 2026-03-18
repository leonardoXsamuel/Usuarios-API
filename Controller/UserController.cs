using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using users_API.service;
using Usuarios_API.DTOs.UserDTOs;
using Usuarios_API.Model;

namespace Usuarios_API.Controllers;

[ApiController]
[Route("usuario")]
public class UserController : ControllerBase
{
    //public static List<User> ListaUsuarios = new List<User>();

    private readonly UserService _service;
    private readonly IMapper _mapper;

    public UserController(UserService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostUsuario([FromBody] UserCreateDTO dto)
    {

        var usuario = _mapper.Map<User>(dto);

        _service.PostUser(usuario);

        return CreatedAtAction(
            nameof(GetUsuarioById),
            new {id = usuario.Id},
            usuario);
    }

    [HttpPost("list")]
    public void PostListUsuarios([FromBody] List<User> usuarios)
    {
        usuarios.ForEach(u => _service.PostUser(u));
    }

    [HttpGet]
    public IEnumerable<User> GetAllUsuarios([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _service.GetAllUsers(skip, take);
    }

    [HttpGet("id")]
    public IActionResult GetUsuarioById(int id)
    {
        var user = _service.GetUserById(id);

        if (user == null)
        {
            return NotFound();
        }
        else
        {
            return Ok(user);
        }
    }

    [HttpGet("test")]
    public string GetTestOfRoute()
    {
        return "rota de teste funcionando normalmente...url dos jsons: https://jsonplaceholder.typicode.com/users";
        // http://localhost:5243/usuario/test => validar funcionamento da API
    }

}
