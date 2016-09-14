namespace SecurityHeaders.HeaderConfiguration.HeaderValues
{
    public class XXssProtectionValue
    {
        private const string Name = "X-XSS-Protection";
        public bool Enabled{ get; set; }
        public bool Block { get; set; }
    }
}