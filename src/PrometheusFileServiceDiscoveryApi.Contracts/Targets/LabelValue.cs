namespace PrometheusFileServiceDiscovery.Contracts.Models
{
    public class LabelValue
    {
        private readonly string _value;

        public LabelValue(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }

}