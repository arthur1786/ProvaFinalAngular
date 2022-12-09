using System.Collections.Generic;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/usuario")]

    public class UsuarioController : ControllerBase{
        
        private readonly DataContext _context;

        public UsuarioController(DataContext context) =>
        _context = context;

        private static List<Usuario> usuarios = new List<Usuario>();


        [Route("cadastrar")]
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
        }
    }
}