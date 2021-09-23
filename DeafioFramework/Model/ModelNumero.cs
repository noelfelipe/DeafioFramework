using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeafioFramework.Model
{
    public class ModelNumero
    {
        [JsonProperty("mensagem")]
        public int Numero { get; set; }
    }
}
