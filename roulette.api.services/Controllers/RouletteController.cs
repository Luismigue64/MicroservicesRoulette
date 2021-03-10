using Microsoft.AspNetCore.Mvc;
using roulette.api.services.Core.Entities;
using roulette.api.services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roulette.api.services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RouletteController : ControllerBase
    {
        private readonly IRouletteRepository rouletteRepository;
        public RouletteController(IRouletteRepository rouletteRepository)
        {
            this.rouletteRepository = rouletteRepository;
        }
        [HttpPost]
        public async Task Post(Roulette roulette)
        {
            await this.rouletteRepository.InsertRoulette(roulette);
        }

        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
