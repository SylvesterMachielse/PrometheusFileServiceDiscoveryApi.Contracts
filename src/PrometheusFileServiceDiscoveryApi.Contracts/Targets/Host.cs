namespace PrometheusFileServiceDiscovery.Contracts.Models
{
    //<host>: a valid string consisting of a hostname or IP followed by an optional port number
    public class Host 
    {
        private readonly string _value;

        public Host(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }

}