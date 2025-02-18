﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPDMIS_Angular_API.DTO.SourceDTO
{
    [Table("MASITEMS")]
    public class SmasitemsDTO
    {
        [Key]
        public int? ITEMID { get; set; }
        public string? ITEMCODE { get; set; }
        public string? ITEMNAME { get; set; }
        public int? ITEMTYPEID { get; set; }
        public int? CATEGORYID { get; set; }
        public int? GROUPID { get; set; }
        public string? UNIT { get; set; }
        public int? STOCKSTATUSID { get; set; }
        public int? VENID { get; set; }
        public string? STRENGTH1 { get; set; }
        public string? STRENGTH2 { get; set; }
        public string? PACKING1 { get; set; }
        public string? PACKING2 { get; set; }
        public string? PACKCARTON { get; set; }
        public int? PACKINGQTY { get; set; }
        public int? QTYIND { get; set; }
        public string? QCTEST { get; set; }
        public int? TESTQTY { get; set; }
        public int? EXPINDICATID { get; set; }
        public string? ACTIVEFLAG { get; set; }
        public decimal? RATE { get; set; }
        public int? QCMINQTY { get; set; }
        public int? MINLVL { get; set; }
        public int? MAXLVL { get; set; }
        public int? REORDLVL { get; set; }
        public int? EMERLVL { get; set; }
        public string? REF_REQ { get; set; }
        public int? SUBGROUPID { get; set; }
        public int? HIGHLIGHTNULLBATCHES { get; set; }
        public int? UNSPSCID { get; set; }
        public string? ECRIID { get; set; }
        public string? DGSDID { get; set; }
        public string? GS1PRODUCTCODE { get; set; }
        public string? ITEMCLASSIFICATION { get; set; }
        public int? REFITEMID { get; set; }
        public string? BRANDNAME { get; set; }
        public int ISEDL { get; set; }
        public int SHELFLIFEINMONTHS { get; set; }
        public int SHELFLIFEINPERCENT { get; set; }
        public string? PHARMACOPOEIA { get; set; }
        public string? COMPOSITION { get; set; }
        public int? UNITCOUNT { get; set; }
        public int? MULTIPLE { get; set; }
        public int? QCTESTINGESTDAY { get; set; }
        public int? EDLCAT { get; set; }
        public string? ITEMNAME_HINDI { get; set; }
        public string? STRENGTH_HINDI { get; set; }
        public int? TREAT_ID { get; set; }
        public int? HSNCODE { get; set; }
        public int? GSTRATE { get; set; }
        public decimal? ROWNO { get; set; }
        public int? EDLITEMID { get; set; }
        public string? ISMITANINDRUG { get; set; }
        public DateTime? GDT_ENTRY_DATE { get; set; }
        public string? QCTESTBK { get; set; }
        public int? TESTQTYBK { get; set; }
        public int? PRIORITYD { get; set; }
        public int? PRIORITY100 { get; set; }
        public decimal? APRXRATE { get; set; }
        public string? UHCSHC { get; set; }
        public string? UHCDH { get; set; }
        public string? UHCCHC { get; set; }
        public string? UHCPHC_HWC { get; set; }
        public int? UHCEDL { get; set; }
        public string? RCEXTANDABLE { get; set; }
        public string? ISPSU { get; set; }
        public decimal? PSURATE { get; set; }
        public string? ISOTHERCORP { get; set; }
        public int? SHCGMSC_MIN { get; set; }
        public string? DHSCGMSC { get; set; }
        public string? HWC { get; set; }
        public int? DHSFM { get; set; }
        public int? ISMITANIN { get; set; }
        public int? ISIMPD { get; set; }
        public string? IMPTYPE { get; set; }
        public decimal? BPRIORITY { get; set; }
        public int? SECMAM { get; set; }
        public int? MINBUFFQTY { get; set; }
        public int? MAXBUFFQTY { get; set; }
        public string? ISEDL2019 { get; set; }
        public int? OLDEDLCAT { get; set; }
        public int? DHSBUFFERSTOCK { get; set; }
        public int? ISNEDL { get; set; }
        public int? OLDDHFM { get; set; }
        public int? OLDDHSBUFFERSTOCK { get; set; }
        public string? RATESOURCH { get; set; }
        public string? ISFREEZED { get; set; }
        public string? PROGRAMDRU { get; set; }
        public string? REMARKS { get; set; }
        public string? ISDVDMSMAPPED { get; set; }
        public string? ISHIDE { get; set; }
        public string? PITEMCODE { get; set; }
        public string? COVIDFLAG { get; set; }
        public string? COVIDD { get; set; }
        public int? COVIDORDER { get; set; }
        public int? OLDDHFM2 { get; set; }
        public string? SPTENDER { get; set; }
        public string? CITEMCODE { get; set; }
        public string? COVIDC_POFLAG { get; set; }
        public string? LITEMCODE { get; set; }
        public string? ISCOVIDINDENT { get; set; }
        public int? TESTID { get; set; }
        public string? ISCOVIDINDFLAG { get; set; }
        public string? PCODE { get; set; }
        public string? ISNONEDL { get; set; }
        public string? ISQCCHECK { get; set; }
        public int? TARGET1 { get; set; }
        public int? CSNO { get; set; }
        public string? AIREF { get; set; }
        public string? ONLYCOVIDAI { get; set; }
        public string? ISCONEDL2013 { get; set; }
        public string? ISEDL2021 { get; set; }
        public int? BUFFERSTOCK21 { get; set; }
        public int? EDLCATUPTO2019 { get; set; }
        public string? EDL2021REMARK { get; set; }
        public string? ISGOVD { get; set; }
        public string? TESTCOMOFORREPORT { get; set; }
        public string? VIRLABCREPOR { get; set; }
        public decimal? PERLABPERTEST { get; set; }
        public int? BRODID { get; set; }
        public string? NABLREQ { get; set; }
        public DateTime? NABLENTRYDT { get; set; }
        public int? EMSITEMID { get; set; }
        public int? EMSMACHINEID { get; set; }
        public int? PMACHINEID { get; set; }
        public string? EMSITEMCODE { get; set; }
        public DateTime? LASTUPDATEDT { get; set; }
        public int? PITEMID { get; set; }
        public string? ISBANNED { get; set; }
        public DateTime? ITPRENTRYDT { get; set; }
        public string? ITPRREMARKS { get; set; }
        public string? ISFREEZ_ITPR { get; set; }
        public int? ITPR_OTP { get; set; }
        public string? RCVALIDCODE { get; set; }
        public string? ISSTERILITY { get; set; }
        public DateTime? STERILITYENTRYDT { get; set; }
        public int? SUBCATID { get; set; }
        public int? AYUSHAIORDER { get; set; }
        public int? INSERTEDBY { get; set; }
        public string? ISRFORLP { get; set; }
        public string? ISDEDL { get; set; }
        public int? ISWHREPORT { get; set; }
        public string? MAKE { get; set; }
        public string? MODEL { get; set; }
        public int? MMID { get; set; }
        public int? DISPENSETYPEID { get; set; }
        public string? ISMCITEMS { get; set; }
        public string? MATERIAL_ID { get; set; }
        public string? CTRCALB { get; set; }
        public int? TESTUNITONREAG { get; set; }
        public string? SHC { get; set; }
    }
}
