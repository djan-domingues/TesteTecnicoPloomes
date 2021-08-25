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
    [Route("PloomesAPI/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ServicoContext _servicoContext;

        public ClienteController(ServicoContext servicoContext)
        {
            _servicoContext = servicoContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            return Ok(new
            {
                succes = true,
                data = await _servicoContext.Clientes.ToListAsync()
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCliente(Cliente cliente)
            {
            _servicoContext.Add(cliente);
            await _servicoContext.SaveChangesAsync();

            return Ok(new
            {
                succes = true,
                data = cliente
            });

        }
    }
}
