using System.ComponentModel.DataAnnotations;

namespace DPDMIS_Angular_API.DTO.CGMSCStockDTO
{
    public class getDistrictAchivementStatusDTO
    {
        [Key]
        public Int64 DISTRICTID { get; set; }
        public String? DISTRICTNAME { get; set; }
        public String? TARGET { get; set; }
        public String? ACHIVEMENT { get; set; }
        public String? PER { get; set; }
    }
   
}
