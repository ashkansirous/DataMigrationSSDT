namespace EFCodeFirst.Database
{
    public class ModuleConfiguration
    {
        public string Id { get; set; }
        public int? TemplafyLicences { get; set; }
        public int? ProductivityLicenses { get; set; }
        public int? ModuleLicenses { get; set; }
        public int? CheckLincenses { get; set; }
        public Tenant Tenant { get; set; }
    }
}
