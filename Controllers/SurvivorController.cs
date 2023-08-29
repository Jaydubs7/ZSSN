using System;
using Microsoft.AspNetCore.Mvc;
using ZSSN_Octoco_technical_assessment.Services;
using SurvivorsTracking.Models;

namespace SurvivorsTracking.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class SurvivorController: Controller
    {
        private readonly SurvivorContext _mongoDBService;

        public SurvivorController(SurvivorContext mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        [HttpGet]
        public async Task<List<Survivor>> Get() { throw new NotImplementedException(); }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Survivor survivor) 
        {
            await _mongoDBService.CreateAsync(survivor);
            return CreatedAtAction(nameof(Get), new { id = survivor.Id }, survivor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLocation(string id, [FromBody] Location newLocation) { throw new NotImplementedException(); }


    }
}
