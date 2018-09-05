using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace checkUpdate
{
    class xulyJSON
    {
        private JObject jo = null;
        public xulyJSON()
        {
             jo = JObject.Parse(File.ReadAllText("config.json"));
        }
        public string ReadJSON(string key)
        {
            return (string)jo[key];
        }
        public void UpdatevalueJSON(string key, string valuenew)
        {
            jo[key] = valuenew;
        }
    }
}
