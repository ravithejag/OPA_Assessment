using System;

namespace OPA.RuleEngine.Model
{
    public class Response
    {
        /// <summary>
        /// Code
        /// </summary>
        public double TotalCost { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Status of the response
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Order Id
        /// </summary>
        public int OrderId { get; set; }
    }
}
