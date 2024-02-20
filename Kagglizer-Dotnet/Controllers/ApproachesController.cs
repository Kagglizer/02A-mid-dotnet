using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kagglizer_Dotnet.Data;
//using Kagglizer.Services;
//using Kagglizer.Services.Interfaces;
using Kagglizer_Dotnet.Models;
using Kagglizer_Dotnet.Interfaces;
using Kagglizer_Dotnet.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kagglizer_Dotnet.Controllers
{
    [Route("api/Approaches")]
    [ApiController]
    public class ApproachesApiController : ControllerBase
    {
        ////TEMPLATED FROM SABIO CURRICULUM
        private readonly IApproachesService _approachesService;
        private readonly IAuthenticationService<int> _authenticationService;
        private readonly ILogger<ApproachesApiController> _logger;

        public ApproachesApiController(IApproachesService approachesService
            , ILogger<ApproachesApiController> logger
            , IAuthenticationService<int> authenticationService)
        {
            _approachesService = approachesService;
            _logger = logger;
            _authenticationService = authenticationService;
        }


        // GET: api/Approaches
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Get()
        {
            if (!_authenticationService.IsAuthenticated())
            {
                return Unauthorized();
            }
            
            
            //TEMPLATED FROM EF
            //return new string[] { "value1-Check", "value2" };
            int statusCode = 200;
            BaseResponse response = null;
            
            try
            {
                List<Approach> list = _approachesService.GetAllApproaches();
                if (list == null)
                {
                    statusCode = 404;
                    response = new ErrorResponse("Application Resource not found.");
                }
                else
                {
                    response = new ItemsResponse<Approach> { Items = list };
                }
            }
            catch (Exception ex)
            {
                statusCode = 500;
                _logger.LogError(ex.ToString());
                response = new ErrorResponse($"Generic Error: {ex.Message}");
            }
            return StatusCode(statusCode, response);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
