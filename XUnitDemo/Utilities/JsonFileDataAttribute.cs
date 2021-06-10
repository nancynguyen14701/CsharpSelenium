using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace XUnitDemo.Utilities
{
    class JsonFileDataAttribute : DataAttribute
    {
        private readonly string filePath;
        private readonly string propertyName;

        public JsonFileDataAttribute(string filePath) : this(filePath, null) { }

        public JsonFileDataAttribute(string filePath, string propertyName)
        {
            this.filePath  = filePath;
            this.propertyName = propertyName;
        }
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {

            if (testMethod == null)
            {
                throw new ArgumentNullException(nameof(testMethod));
            }

            // Get the absolute path to the JSON file
            var path = Path.IsPathRooted(filePath)
                ? this.filePath
                : Path.GetRelativePath(Directory.GetCurrentDirectory(), filePath);

            if (!File.Exists(path))
            {
                throw new ArgumentException($"Could not find file at path: {path}");
            }

            // Load the file
            var fileData = File.ReadAllText(filePath);

            if (string.IsNullOrEmpty(propertyName))
            {
                //whole file is the data
                return JsonConvert.DeserializeObject<List<object[]>>(fileData);
            }

            // Only use the specified property as the data
            var allData = JObject.Parse(fileData);
            var data = allData[propertyName];
            return data.ToObject<List<object[]>>();
        }
    }
}
