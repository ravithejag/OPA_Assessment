namespace OPA.RuleEngine.Model
{
    public class EmailDto
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string ToAddress { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }

        /// Add smtp details
    }
}
