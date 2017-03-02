using System.Collections.Generic;

namespace ModelBindingToCollection.Models
{
    public class VehicleNestedCollection
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int? Year { get; set; }
        public List<SafetyFeature> SafetyFeatures { get; set; }
    }    
}
