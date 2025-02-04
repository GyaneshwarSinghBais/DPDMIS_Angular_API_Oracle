using System.ComponentModel.DataAnnotations;

namespace DPDMIS_Angular_API.DTO.IndentDTO
{
    public class OtherFacilityIndentDTO
    {
        [Key]
        public String? INDENTNO { get; set; }
        public String? INDENTDATE { get; set; }
        public String? FACILITYNAME { get; set; }
        public String? FACILITYID { get; set; }
        public String? FROMFACILITYID { get; set; }
        public String? INDENTID { get; set; }
        public String? STATUS { get; set; }
    }

    
}
