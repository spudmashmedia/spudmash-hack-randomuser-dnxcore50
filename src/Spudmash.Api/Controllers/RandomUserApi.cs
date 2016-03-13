using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using Spudmash.Api.Models;
using Spudmash.Api.Common;
using Spudmash.Api.Services;

namespace Spudmash.Api.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [Route("v1")]
    public class RandomUserApiController : Controller
    {
        /// <summary>
        /// Route: /user
        /// </summary>
        /// <remarks>Get Single Random User</remarks>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/user")]
        [SwaggerOperation("GetSingleUser")]
        [SwaggerResponse(200, type: typeof(UserResponse))]
        public async Task<IActionResult> GetSingleUser([FromQuery]string gender, [FromQuery]string nat)
        {
           Console.WriteLine("In User2get. gender:{0}, nat:{1}", gender, nat);

            var svc = new RandomUserApiService();

            var example = await svc.GetUser(gender, nat);

            return new ObjectResult(example);
        }

        /// <summary>
        /// Route: /users
        /// </summary>
        /// <remarks>Get Multiple Random User</remarks>
        /// <param name="gender">male or female</param>
        /// <param name="nat">Nationality {AU, BR, CA, CH, DE, ES, FI, FR, GB, IE, IR, NL, NZ, US}</param>
        /// <response code="200">Successful response</response>
        [HttpGet]
        [Route("/users")]
        [SwaggerOperation("GetMultipleUser")]
        [SwaggerResponse(200, type: typeof(UserResponse))]
        public async Task<IActionResult> GetMultipleUser([FromQuery]string gender, [FromQuery]string nat, [FromQuery]int count, [FromQuery]bool parallel=false)
        {
           Console.WriteLine("In User2get. gender:{0}, nat:{1}, count:{2}", gender, nat, count.ToString());

            var svc = new RandomUserApiService();

            var example = await (parallel ? svc.GetUsersParallel(gender, nat, count) : svc.GetUsers(gender, nat, count));

            return new ObjectResult(example);
        }
    }
}
