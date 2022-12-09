using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Backend.utils;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Controllers{
    
    [ApiController]
    [Route("api/imc")]

    public class ImcController : ControllerBase{
        
        private readonly DataContext _context;

        public ImcController(DataContext context) => 
        _context = context;

        [Route("cadastrar")]
        [HttpPost]

        public IActionResult Cadastrar([FromBody] ImcModels imc){

            imc.imc = Calculo.CalcularImc
            (imc.altura, imc.peso);

            imc.classificacao = Calculo.RetornaClassificacao
            (imc.classificacao, imc.imc);

            _context.Imcs.Add(imc);
            _context.SaveChanges();
            return Created("", imc);
        }

        [HttpGet]
        [Route("listar")]
        public IActionResult Listar(){
            List<ImcModels> Imcs =
                _context.Imcs.Include(f => f.usuario).ToList();

                if(Imcs.Count ==0) return NotFound();

                return Ok(Imcs);
        }

       [Route("alterar")]
        [HttpPatch]
        public IActionResult Alterar([FromBody] ImcModels imc){
            _context.Imcs.Update(imc);
            _context.SaveChanges();
            return Ok(imc);
        }
        
    }
}