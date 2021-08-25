using APIfinalPloomes.Data;
using APIfinalPloomes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIfinalPloomes.Controllers
{
    [Route("PloomesAPI/[Controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private readonly ServicoContext _servicoContext;

        public ServicoController(ServicoContext servicoContext)
        {
            _servicoContext = servicoContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetServicos()
        {
            return Ok(new
            {
                succes = true,
                data = await _servicoContext.Servicos.ToListAsync()
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateServico(Servico servico)
        {
            _servicoContext.Add(servico);
            await _servicoContext.SaveChangesAsync();

            return Ok(new
            {
                succes = true,
                data = servico
            });
        }
    }
}
