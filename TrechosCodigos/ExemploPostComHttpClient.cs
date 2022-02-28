HttpClient httpClient = new HttpClient();
string url = "url";
var objSerializado = JsonSerializer.Serialize(obj);
var conteudoRequest = new StringContent(objSerializado, Encoding.UTF8, "application/json");
var resposta = await httpClient.PostAsync(url, conteudoRequest);
