using System.Text.Json;
using System.Text.Json.Nodes;
using Usuarios_API.model;
using Usuarios_API.service;

//ApiConsummerService api = new ApiConsummerService("https://jsonplaceholder.typicode.com/", x);
var http = new HttpClient();

var resposta = await http.GetStringAsync("https://jsonplaceholder.typicode.com/users");
var usuarios = JsonSerializer.Deserialize<List<Usuario>>(resposta);

Console.WriteLine(usuarios.Count);

// Console.WriteLine(api);