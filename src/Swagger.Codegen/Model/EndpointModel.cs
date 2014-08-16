﻿using System.Collections.Generic;

namespace Swagger.Codegen.Model
{
    public class EndpointModel
    {
        public string BasePath { get; set; }

        public string BaseUrl
        {
            get { return BasePath + ResourcePath; }
        }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ResourcePath { get; set; }

        public IList<RouteModel> Routes { get; set; }
    }
}