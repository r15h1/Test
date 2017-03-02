using System.Collections.Generic;

namespace ModelBindingToCollection.Models
{
    public class VehicleNestedProperty
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public SafetyFeature SafetyFeature { get; set; }
    }
}
