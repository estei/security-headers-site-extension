namespace SecurityHeaders.HeaderConfiguration
{
    public class HeaderConfiguration<T>
    {
        public bool HeaderEnabled { get; set; }
        public T Value { get; set; }
    }
}