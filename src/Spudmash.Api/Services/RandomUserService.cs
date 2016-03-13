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

namespace Spudmash.Api.Services
{
    /// <summary>
    ///
    /// </summary>
    public class RandomUserApiService
    {
       //whack this into a configuration appsettings
       private const string ROOT_URI = "http://randomuser.me/api";

       public RandomUserApiService()
       {

       }

        public async Task<UserResponse> GetUser(string gender, string nat)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ROOT_URI);
            sb.Append("?");
            sb.Append(string.Format("gender={0}", gender ?? string.Empty));
            sb.Append(string.Format("&nat={0}", nat ?? string.Empty));

            //print URI
            Console.WriteLine("In GetUser. gender:{0}, nat:{1}", gender, nat);
            Console.WriteLine("In GetUser.URI: {0}", sb.ToString());

            string responseJson = await new RestClient()
                                              .CallEndpoint(sb.ToString());

            var result = responseJson != null
            ? JsonConvert.DeserializeObject<UserResponse>(responseJson)
            : default(UserResponse);

            return result;
        }

        public async Task<List<UserResponse>> GetUsers(string gender, string nat, int count)
        {
            List<UserResponse> results = new List<UserResponse>();

            //
            // execute sequentially
            //
            for(var i=0;i<count;i++){
                results.Add(await GetUser(gender, nat));
            }

            return results;
        }

        public async Task<List<UserResponse>> GetUsersParallel(string gender, string nat, int count)
        {
            List<Task<UserResponse>> t = new List<Task<UserResponse>>();
            List<UserResponse> result = new List<UserResponse>();

            //
            //setup up tasks
            //
            for(var i=0; i<count; i++)
            {
                t.Add(GetUser(gender, nat));
            }

            //
            //wait for tasks to finish and add results to List
            //
            foreach(var i in t){
              result.Add(await i);
            }

            return result;
        }
    }
}
