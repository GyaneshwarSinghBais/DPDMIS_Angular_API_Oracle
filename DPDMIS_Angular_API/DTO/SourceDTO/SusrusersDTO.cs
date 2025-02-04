﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPDMIS_Angular_API.DTO.SourceDTO
{
    [Table("USRUSERS")]
    public class SusrusersDTO
    {
        [Key]
        public int USERID { get; set; }
        public string? EMAILID { get; set; }
        public string? PWD { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? LASTNAME { get; set; }
        public int? ROLEID { get; set; }
        public string? USERTYPE { get; set; }
        public string? DISPLAYNAME { get; set; }
        public string? STATUS { get; set; }
        public bool ISDELETED { get; set; }
        public string? IPADDRESS { get; set; }
        public DateTime? CREATEDDATE { get; set; }
        public int? SOURCEID { get; set; }
        public int? SCHEMEID { get; set; }
        public int? STATEID { get; set; }
        public int? DISTRICTID { get; set; }
        public int? WAREHOUSEID { get; set; }
        public int? FACILITYID { get; set; }
        public int? COUNTRYID { get; set; }
        public int? SUPPLIERID { get; set; }
        public int? PSAID { get; set; }
        public int? DIVISIONID { get; set; }
        public bool ISLOCALSUPPLIERS { get; set; }
        public string? PASSWORDRESETKEY { get; set; }
        public bool RESETPASSWORD { get; set; }
        public int? LPSUPPLIERID { get; set; }
        public int? LABID { get; set; }
        public decimal? ORDERID { get; set; }
        public string? OTP { get; set; }
        public DateTime? OTPUPDATEDT { get; set; }
        public decimal? DEPMOBILE { get; set; }
        public string? DEPEMAIL { get; set; }
        public string? ISFILE { get; set; }
        public string? ISPAYMENT { get; set; }
        public decimal? HORDER { get; set; }
        public decimal? HORDER1 { get; set; }
        public string? ADMINTYPE { get; set; }
        public double? ORDERDP { get; set; }
        public string? ISRESETPWD { get; set; }
        public string? MACADDRESS { get; set; }
        public string? ISMRCUSER { get; set; }
        public DateTime? LASTPWDCHANGEDATE { get; set; }
        public string? ISOTPUSER { get; set; }
        public string? APPROLE { get; set; }
        public string? ISCOURIERPICK { get; set; }
        public string? CPWD { get; set; }
        public int? SUBWHID { get; set; }
        public string? ISMACUSER { get; set; }
    }
}
