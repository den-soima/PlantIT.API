using System;

namespace PlantIT.API.Models
{
    public class Material
    {
        public int nKey { get; set; }
        public string szCode { get; set; }
        public string szDescription { get; set; }
        public int nMaterialGroupLink { get; set; }
        public int nMaterialClassLink { get; set; }
        public int nMeasurementUnitLink { get; set; }
        public string szEAN { get; set; }
        public bool bDeleted { get; set; }
        public bool bActivated { get; set; }
        public DateTime tCreated { get; set; }
        public DateTime tUpdated { get; set; }
        public int nVersion { get; set; }
        public string szUser { get; set; }
    }
}