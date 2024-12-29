using CityInfoApi.Dtos;
using CityInfoApi.Models;
using CityInfoApi.Repositories.Interfaces;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Unicode;

namespace CityInfoApi.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuth authRepo;
        public AuthController(IAuth repo)
        {
            authRepo = repo;
        }
        public class UserPasswordDTO()
        {
            [Required]
            public string username { get; set; }
            [Required]
            public string password { get; set; }
        }
        public class serverDetailDto()
        {
            [Required]
            public float year { get; set; }
            [Required]
            public string daftar { get; set; }
            [Required]
            public string company { get; set; }
        }

        [HttpGet("users")]
        public async Task<ActionResult<string[]>> getUser()
        {
            string[]? users = await authRepo.GetAllUserAsync();
            if (users==null)
            {
                return NotFound();  
            }
            return Ok(users);
        }

        [HttpPost("db")]
        public async Task<ActionResult<ConfigDto>> getConfig([FromBody] serverDetailDto detail)
        {
            ConfigDto? dbName =await authRepo.GetConfigDBAsync(detail.year,detail.daftar,detail.company);
            if (dbName == null)
            {
                return NotFound();
            }
            return Ok(dbName);
        }
        [HttpPost]
        public async Task<ActionResult<UserResault>> Login([FromBody] UserPasswordDTO up)
        {
            UserResault? user = await authRepo.GetUserAsync(up.username, up.password);
            if (user == null)
            {
                    return NotFound("User Not Found");
            }
            return Ok(user);
        }

    }
}
