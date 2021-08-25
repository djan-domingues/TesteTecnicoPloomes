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
    public class EmpresaController : ControllerBase
    {
        private readonly ServicoContext _servicoContext;
        
        public EmpresaController(ServicoContext servicoContext)
        {
            _servicoContext = servicoContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmpresas()
        {
            return Ok(new
            {
                succes = true,
                data = await _servicoContext.Empresas.ToListAsync()
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmpresa(Empresa empresa)
        {
            _servicoContext.Add(empresa);
            await _servicoContext.SaveChangesAsync();

            return Ok(new
            {
                succes = true,
                data = empresa
            });
        }
    }
}
