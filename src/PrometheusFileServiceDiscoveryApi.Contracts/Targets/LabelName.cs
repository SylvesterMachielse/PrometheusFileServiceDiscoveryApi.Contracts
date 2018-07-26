namespace PrometheusFileServiceDiscovery.Contracts.Models
{
    //<labelname>: a string matching the regular expression [a-zA-Z_][a-zA-Z0-9_]*
    public class LabelName
    {
        private readonly string _value;

        public LabelName(string value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value;
        }
    }

}