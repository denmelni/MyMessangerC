using Newtonsoft.Json;

namespace MyMessanger
{
    class Progaram
    {
        static void Main(string[] args)
        {
            Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2023-01-11T23:18:15.7437725Z"}
            //RusAl < 11.01.2023 23:18:15 >: Privet
        }
    }
}