using BlazorDummyProject.Enums;

namespace BlazorDummyProject.Models
{
    public class PolicyModel
    {
        public string Reference { get; set; } = ""; 
        public DateTime StartDate { get; set; }
        public string CustomerName { get; set; } = "";
        public  PolicyType Type { get; set; }
    }
}
