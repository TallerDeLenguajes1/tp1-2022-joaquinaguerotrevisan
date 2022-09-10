// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using (System.Text.Json.Serialization);
namespace Problema4;
public class Provincia
{
    public string id { get; set; }
    public string nombre { get; set; }
}