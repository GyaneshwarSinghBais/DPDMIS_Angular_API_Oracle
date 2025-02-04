using System.ComponentModel.DataAnnotations;

namespace DPDMIS_Angular_API.DTO.IndentDTO
{
    public class getIndentTimlineDTO
    {
        [Key]
        public Int64 FACILITYID { get; set; }
        public string? LOCATIONNAME { get; set; }
        public string? FACILITYNAME { get; set; }
        public string? CONTACTPERSONNAME { get; set; }
        public string? PHONE1 { get; set; }
        public string? PHC_ID { get; set; }
        public string? PHCNAME { get; set; }
        public string? SYSDATE { get; set; }
        public string? FIRSTINDENTOPENING { get; set; }
        public string? FIRSTINDENTCLOSING { get; set; }
        public string? LASTINDENTDATE { get; set; }      
        public string? INDENTOPENINGDATE { get; set; }
        public string? INDENTCLOSINGDATE { get; set; }
        public string? REGULAROPENINGCASE { get; set; }
    }

  
}
