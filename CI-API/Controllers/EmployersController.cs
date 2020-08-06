using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CI_API.ViewModels;
using CI_DAL;
using CI_DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        private readonly UserManager<User> _userManager;

        public EmployersController(UserManager<User> userManager)
        {
            _userManager = userManager;

        }
        // POST api/employers/create
        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateEmployerViewModel model)
        {
            var employer = new User
            {
                UserName = model.Username,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(employer, model.Password);
            if (!result.Succeeded)
            {
                return BadRequest(result);
            }
            return Ok(employer);
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}