using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace DiabsolutTestProject.WebApi
{
    public class AssetController : ApiController
    {
        //GET Assets
        public List<string> GetAsset() {
            return new List<string>() {
                "HE","ge"
            };
        }
    }
}
