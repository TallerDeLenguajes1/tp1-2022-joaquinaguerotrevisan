using (System.Text.Json);
using (System.IO);
using (System.Net);

namespace Problema4
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";

            var request = (HttpWebRequest);
            
            WebRequest.Create(url);

            request.Method = "GET";

            request.ContentType = "application/json";

            request.Accept = "application/json";

            Root Lista = new Root();  

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Lista = JsonSerializer.Deserialize<Root>(responseBody);

                            Console.WriteLine("   |PROVINCIAS|");

                            foreach (Provincia Prov in Lista.Provincia)
                            {
                                Console.WriteLine("   ["+Prov.Id+"]"+ Prov.Name);
                            }
                        }
                    }
                }
            }
            catch (WebException)
            {
                Console.WriteLine("No se pudo acceder a la API...");
            }
        }
    }

    
}