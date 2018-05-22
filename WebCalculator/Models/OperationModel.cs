using Newtonsoft.Json;
using WebCalculator.Services;

namespace WebCalculator.Models
{
    public class OperationModel
    {
        [JsonProperty(Required = Required.Always)]
        public double FirstOperand { get; set; }
        [JsonProperty(Required = Required.Always)]
        public double SecondOperand { get; set; }
        [JsonProperty(Required = Required.Always)]
        public OperationType Operation { get; set; }

    }
}
