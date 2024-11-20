// Se https://aka.ms/new-console-template for mere information

using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("UDP Server");

using (UdpClient socket = new UdpClient()) // Opret en ny UdpClient instans
{
    socket.Client.Bind(new IPEndPoint(IPAddress.Any, 5005)); // Bind socketen til enhver IP-adresse og port 5005

    IPEndPoint clientEndpoint = null; // Initialiser en variabel til at gemme klientens endpoint
    while (true) // Uendelig løkke for at holde serveren kørende
    {
        byte[] received = socket.Receive(ref clientEndpoint); // Modtag data fra en klient

        string stringResult = Encoding.UTF8.GetString(received); // Konverter de modtagne bytes til en streng

        Console.WriteLine(stringResult); // Udskriv den modtagne besked til konsollen
    }
}