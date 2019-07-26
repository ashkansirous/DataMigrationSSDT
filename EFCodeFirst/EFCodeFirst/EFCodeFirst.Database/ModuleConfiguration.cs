namespace EFCodeFirst.Database
{
    public class ModuleConfiguration
    {
        public string Id { get; set; }
        public int? TemplafyLicences { get; set; }
        public int? SlideProofLicenses { get; set; }
        public string ModuleLicenses { get; set; }

        public Tenant Tenant { get; set; }
    }
}
