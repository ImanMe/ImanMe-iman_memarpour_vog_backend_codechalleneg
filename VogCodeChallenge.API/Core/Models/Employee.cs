using System.Text.Json.Serialization;

namespace VogCodeChallenge.API.Core.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
        [JsonIgnore]
        public int DepartmentId { get; set; }
    }
}
