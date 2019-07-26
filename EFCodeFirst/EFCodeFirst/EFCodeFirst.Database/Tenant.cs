namespace EFCodeFirst.Database
{
    public class Tenant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Partner { get; set; }
        public ModuleConfiguration ModuleConfiguration { get; set; }
    }
}
