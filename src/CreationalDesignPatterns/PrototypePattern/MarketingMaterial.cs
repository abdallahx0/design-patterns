namespace PrototypePattern
{
    public abstract class MarketingMaterial : ICloneable
    {
        public string Layout { get; set; }
        public string Content { get; set; }
        public string Color { get; set; }

        protected MarketingMaterial(string layout, string content, string color)
        {
            Layout = layout;
            Content = content;
            Color = color;
        }

        public void Print()
        {
            Console.WriteLine("Marketing Material Configuration:");
            Console.WriteLine("Layout: " + Layout);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Printing now ...");
        }

        public abstract MarketingMaterial CloneMarketingMaterial();

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
