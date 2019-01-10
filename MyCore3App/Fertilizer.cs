using System;

namespace MyCore3App
{
    public class Fertilizer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int? MoistureContent { get; set; }

        public int? CNParity { get; set; }

        public float? HumusContent { get; set; }

        public string Notes { get; set; }

        public string Formula { get; set; }

        public string Storage { get; set; }

        public bool IsSoilImprover { get; set; }

        public string Registry { get; set; }

        public int? Pureness { get; set; }

        public bool IsOrganic { get; set; }

        public bool IsInStock { get; set; }

        public int? FertilizerReactionID { get; set; }

        public string ShortAnnualCropApplicationTime { get; set; }

        public string IntermediateAnnualCropApplicationTime { get; set; }

        public string LongAnnualCropApplicationTime { get; set; }

        public string HerbaceousPerennialCropApplicationTime { get; set; }

        public string WoodyPerennialCropApplicationTime { get; set; }

        public int? FertilizerTypeID { get; set; }

        public int? FertilizerAvailabilityID { get; set; }

        public int? FertilizerPresentationID { get; set; }

        public Guid? MediaID { get; set; }

        public Guid ClientID { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? UnitID { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
