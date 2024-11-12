namespace PrototypePattern
{
    public class Poster : MarketingMaterial
    {
        public Poster(string layout, string content, string color) : base(layout, content, color) { }

        public override Poster CloneMarketingMaterial()
        {
            return new Poster(Layout, Content, Color);
        }
    }
}
