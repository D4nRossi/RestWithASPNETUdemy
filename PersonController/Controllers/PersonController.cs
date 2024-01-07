using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonController.Model;
using PersonController.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraRest.Controllers {
    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService) {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult FindAll() {
            return Ok(_personService.FindAll());
        }

        [HttpGet]
        public IActionResult FindById(long id) {
            var person = _personService.FindById(id);
            if(person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Person person) {
            if (person == null) return BadRequest();
            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Person person) {
            if (person == null) return BadRequest();
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id) {
            _personService.Delete(id);
            return NoContent();
        }
    }
}


