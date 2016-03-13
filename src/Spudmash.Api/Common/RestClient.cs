using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Newtonsoft;
using System.Net.Http;

namespace Spudmash.Api.Common
{
  public sealed class RestClient{

    public RestClient() {}

    public async Task<string> CallEndpoint(string uri)
    {
        string urlContents = string.Empty;

          HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync(uri);
            urlContents = await getStringTask;

        return urlContents;
    }
  }
}
