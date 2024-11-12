

using PrototypePattern;

Flyer flyer = new Flyer("Layout A4", "Hello world", "green");
Flyer flyer2 = flyer.CloneMarketingMaterial();
flyer2.Color = "red";

Poster poster = new Poster("Layout A3", "Hello world 2", "yellow");
Poster poster2 = poster.CloneMarketingMaterial();
poster2.Color = "blue";

flyer.Print();
flyer2.Print();
poster.Print();
poster2.Print();