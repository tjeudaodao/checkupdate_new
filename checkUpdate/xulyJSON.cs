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
             jo = JObject.Parse(File.ReadAllText("capnhat.json"));
        }
        public string ReadJSON(string key)
        {
            return (string)jo[key];
        }
        public void UpdatevalueJSON(string key, string valuenew)
        {
            jo[key] = valuenew;
            string output = JsonConvert.SerializeObject(jo, Formatting.Indented);
            File.WriteAllText("capnhat.json", output);
        }
        public void UpdatevalueJSON(string[,] mangNx2)
        {
            for (int i = 0; i < mangNx2.GetLength(0); i++)
            {
                string key = mangNx2[i, 0];
                string value = mangNx2[i, 1];
                jo[key] = value;
            }
            string output = JsonConvert.SerializeObject(jo, Formatting.Indented);
            File.WriteAllText("capnhat.json", output);
        }
    }
}
