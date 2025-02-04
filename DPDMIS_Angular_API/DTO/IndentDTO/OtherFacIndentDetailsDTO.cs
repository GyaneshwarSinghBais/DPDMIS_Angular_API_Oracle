﻿using System.ComponentModel.DataAnnotations;

namespace DPDMIS_Angular_API.DTO.IndentDTO
{
    public class OtherFacIndentDetailsDTO
    {
        [Key]
        public Int32 SR { get; set; }
        public Int32? ITEMID { get; set; }
        public string? ITEMCODE { get; set; }
        public string? ITEMTYPENAME { get; set; }
        public string? ITEMNAME { get; set; }
        public string? STRENGTH1 { get; set; }
        public string? MULTIPLE { get; set; }
        public Int32? UNITCOUNT { get; set; }
        public Int32? INDENTQTY { get; set; }
        public string? INDENTNO { get; set; }
        public string? INDENTDATE { get; set; }
        public string? TOFACILITY { get; set; }
    }
   
}
