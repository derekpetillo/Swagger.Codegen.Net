﻿using Newtonsoft.Json;

namespace Swagger.Codegen.Web.Models
{
    public class CodegenProcessorModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}