namespace BlazorDummyProject.Models
{
    public class DevicePolicyModel : PolicyModel
    {
        public string Manufacturer { get; set; } = "";
        public string Model { get; set; } = "";
        public bool Tablet { get; set; }
    }
}
