using System;

namespace OPA.RuleEngine.Model
{
    public class Response
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Status of the response
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}
