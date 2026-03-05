using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Usuarios_API.model;
using static System.Net.WebRequestMethods;

namespace Usuarios_API.service;

public class ApiConsummerService
{
    private readonly HttpClient _httpClient;

    
    public ApiConsummerService(string url, Uri uri)
    {
        _httpClient = new HttpClient();
        uri =
            _httpClient.BaseAddress = new Uri(url);
        // https://jsonplaceholder.typicode.com/
    }


}
