HttpClient httpClient = new HttpClient();
string url = "http://localhost:5039/api/v1/produtos/CadastrarProduto";
var objSerializado = JsonSerializer.Serialize(obj);
var conteudoRequest = new StringContent(objSerializado, Encoding.UTF8, "application/json");
var resposta = await httpClient.PostAsync(url, conteudoRequest);