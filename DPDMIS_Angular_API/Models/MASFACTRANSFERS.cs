using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPDMIS_Angular_API.Models
{
    [Table("MASFACTRANSFERS")]
    public class MASFACTRANSFERS
    {
        [Key]
        public Int64 INDENTID { get; set; }
        public String? INDENTNO { get; set; }
        public String? INDENTDATE { get; set; }
        public Int64? FACILITYID { get; set; }
        public Int64? FROMFACILITYID { get; set; }
        public String? DISPATCHNO { get; set; }
        public String? DISPATCHDATE { get; set; }
        public String? REMARKS { get; set; }
        public Int64? PROGRAMID { get; set; }
        public String? AUTO_CODE { get; set; }
        public String? ENTRYDATE { get; set; }
        public Int64? ACCYRSETID { get; set; }
        public String? STATUS { get; set; }

    }

   
}
