public class Product{
    public int ID { get; set; }
    public string Name { get; set; }        
    public string Description { get; set; } 
    public string ImagePath { get; set; }       
    public int Star { get; set; }
    public double  Price { get; set; }
    public Product(int ID,string Name, string Description ,string ImagePath,int Star  , double  Price  )
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
        this.ImagePath =ImagePath;
        this.Star = Star;
        this.Price = Price;
    }
}