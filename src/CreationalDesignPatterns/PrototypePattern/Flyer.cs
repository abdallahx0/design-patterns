namespace PrototypePattern
{
    public class Flyer : MarketingMaterial
    {
        public Flyer(string layout, string content, string color) : base(layout, content, color) { }

        public override Flyer CloneMarketingMaterial()
        {
            return new Flyer(Layout, Content, Color);
        }
    }
}
