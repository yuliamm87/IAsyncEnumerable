using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Test_Console_App
{
    public static class JsonHelper
    {
        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            var settings = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = false,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            }; 
            return settings;
        }

        public static StringContent PrepareStringContent(object model)
        {
            var settings = GetJsonSerializerOptions();
            var content = JsonSerializer.Serialize(model, settings);

            return new StringContent(content, Encoding.UTF8, "application/json");
        }

        public static StringContent PrepareStringContent(object model, string dispositionType)
        {
            var settings = GetJsonSerializerOptions();
            var json = JsonSerializer.Serialize(model, settings);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue(dispositionType)
            {
                Name = "metadata"
            };
            content.Headers.Remove("Content-Type");
            content.Headers.Add("Content-Type", "application/json; boundary=----XXX");
            return content;
        }

        public static byte[] ReadBytes(Stream stream)
        {
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);
            return memoryStream.ToArray();
        }

        public static ByteArrayContent PrepareByteArrayContent(Stream stream, string fileName)
        {
            var content = new ByteArrayContent(ReadBytes(stream));
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = Path.GetFileNameWithoutExtension(fileName),
                FileName = fileName
            };
            content.Headers.Remove("Content-Type");
            content.Headers.Add("Content-Type", $"application/{Path.GetExtension(fileName)}; boundary=----XXX");
            return content;
        }

        public static MultipartContent PrepareMultipartFormDataContent(object model, Stream stream, string fileName)
        {
            var formDataContent = new MultipartFormDataContent("XXX")
            {
                { PrepareStringContent(model, "form-data"), "metadata" },
                { PrepareByteArrayContent(stream, fileName), "content", fileName }
            };
            return formDataContent;
        }
    }
}
