using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROJETO_API_REPORT.Dto;
using PROJETO_API_REPORT.Services;

namespace PROJETO_API_REPORT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    
    
    public class RelatorioProdutoController : ControllerBase
    {
        
        private DbService _dbService;

        public RelatorioProdutoController()
        {
            _dbService = new DbService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            return await _dbService.GetProdutoAsync();
        }
    
    }
}