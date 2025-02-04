using DPDMIS_Angular_API.MariadbDTO;
using DPDMIS_Angular_API.MariadbDTO.DestinationDTO;
using Microsoft.EntityFrameworkCore;

namespace DPDMIS_Angular_API.Data
{
    public class MariaDbContext : DbContext
    {
        public MariaDbContext(DbContextOptions<MariaDbContext> options) : base(options) { }

        public DbSet<GetAllFacilityTypesDTO> GetAllFacilityTypesDbSet { get; set; } // Replace MariaDbEntity with your actual entity
        public DbSet<DmasitemsDTO> DmasitemsDbSet { get; set; }
        public DbSet<DmasdistrictsDTO> DmasdistrictsDbSet { get; set; }
        public DbSet<DmasitemtypesDTO> DmasitemtypesDbSet { get; set; }
        public DbSet<DmasitemcategoriesDTO> DmasitemcategoriesDbSet { get; set; }
        public DbSet<DmasfacilitytypesDTO> DmasfacilitytypesDbSet { get; set; }
        public DbSet<DmasfacilitiesDTO> DmasfacilitiesDbSet { get; set; }
        public DbSet<DusrusersDTO> DusrusersDbSet { get; set; }
        public DbSet<DmasfacilitywhDTO> DmasfacilitywhDbSet { get; set; }
        public DbSet<DmaswarehousesDTO> DmaswarehousesDbSet { get; set; }
        public DbSet<DmasitemmaincategoryDTO> DmasitemmaincategoryDbSet { get; set; }
        public DbSet<DmasitemgroupsDTO> DmasitemgroupsDbSet { get; set; }
        public DbSet<DmasfacilitywardsDTO> DmasfacilitywardsDbSet { get; set; }
        public DbSet<DmasprogramDTO> DmasprogramDbSet { get; set; }
        public DbSet<DmasaccyearsettingsDTO> DmasaccyearsettingsDbSet { get; set; }
        public DbSet<DmaslocationsDTO> DmaslocationsDbSet { get; set; }
        public DbSet<DusrrolesDTO> DusrrolesDbSet { get; set; }
        public DbSet<DmasedlDTO> DmasedlDbSet { get; set; }
        public DbSet<DmasfacheaderfooterDTO> DmasfacheaderfooterDbSet { get; set; }
        

















    }
}
