namespace PrototypePattern
{
    public class Brochure : MarketingMaterial
    {
        public Brochure(string layout, string content, string color) : base(layout, content, color) { }

        public override MarketingMaterial CloneMarketingMaterial()
        {
            return new Brochure(Layout, Content, Color);
        }
    }
}
