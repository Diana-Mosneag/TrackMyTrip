using System;
using TestClient.ServiceReference1;

namespace TestClient
{
    class Program
    {
        static void Main()
        {
            Service1Client client=new Service1Client();

            Console.WriteLine(client.GetData(int.Parse(Console.ReadLine())));

            client.Close();

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
