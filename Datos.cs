using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System;

namespace ecobici
{
    class Datos
    {
        protected string ruta = "https://pubsbapi.smartbike.com";

        private string client_id = "1048_26hbqve1esbo4k0ok0oggckg4ss48sggcgcw4sww0kw4css04o";
        private string client_secret = "4hatvf10cni8wsw8skk4ks0ss0wksckc8oocsw8sss0s4kwsgs";
        private string grant_type = "client_credentials";

        HttpClient client = new HttpClient();
        public Datos()
        {
        }

        public async Task<string> getAccessToken()
        {
            string token = "?access_token=";
            string rutaToken = "/oauth/v2/token";
            var response = await client.GetStringAsync(
                ruta + 
                rutaToken + 
                "?client_id=" + 
                client_id + 
                "&client_secret" + 
                client_secret + 
                "&grant_type=" +
                grant_type
            );
            var objetos = JsonConvert.DeserializeObject<ModeloToken>(response);
            return token + objetos.access_token;
        }

        public async Task<List<Todo>> GetTodoItemsAsync()
        {
            string estaciones = "/api/v1/stations.json";
            var response = await client.GetStringAsync(ruta + estaciones + getAccessToken());
            var todoItems = JsonConvert.DeserializeObject<List<Todo>>(response);
            return todoItems;
        }
    }
}
