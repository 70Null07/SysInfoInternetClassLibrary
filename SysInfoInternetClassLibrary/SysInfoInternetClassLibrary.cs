using PluginBase;
using System.Net;

namespace SysInfoInternetClassLibrary
{
    public class SysInfoInternetCommand : ICommand
    {
        public string Name { get => "SysInfoInternet"; }

        public string Description { get => "SysInfoInternet"; }

        public double Version { get => 1.0; }

        public List<string> Execute()
        {
            List<string> result = new List<string>();

            string host = Dns.GetHostName();

            result.Add($"Имя компьютера: {host}");

            IPAddress[] addresses = Dns.GetHostAddresses(host);

            foreach (IPAddress address in addresses)
            {
                result.Add($"Адрес: {address} Семейство: {address.AddressFamily}");
            }

            return result;
        }
    }
}