using System.Collections.Generic;

public class ProductService{

    public List<Product> ProductList { get; set; }
    public ProductService()
    {
        ProductList = new List<Product>();
    }
    public IEnumerable<Product> GetProductList(){
        Product product1 = new Product(1,"LENOVO","ThinkPad P53 20QN002VTX07 i7-9750H 32GB 1 TB + 1TB SSD 4GB 15.6\" W10Pro Taşınabilir Bilgisayar T05445G",
                "https://cdn.dsmcdn.com//ty2/product/media/images/20200406/9/1182499/67770830/1/1_org_zoom.jpg",3,17.266);
        
        Product product2 = new Product(2,"LENOVO","ThinkPad X1 Carbon Intel i7 8550U 1.8GHz 8GB 256GB Ssd 14'' Full HD Windows 10 Pro 20KH006FTX",
                "https://cdn.dsmcdn.com//Assets/ProductImages/oa/54/4328874/1/192330780575_1_org_zoom.jpg",4,11.999);
        
        Product product3 = new Product(3,"LENOVO","ThinkPad P53 20QN002VTX02 i7-9750H 16GB 1 TB + 512 SSD 4GB 15.6\" W10Pro Taşınabilir Bilgisayar T05445B",
                "https://cdn.dsmcdn.com//ty2/product/media/images/20200406/9/1182499/67770834/1/1_org_zoom.jpg",5,16.164);
    
         Product product4 = new Product(4,"LENOVO","Thinkpad P1 20QT002CTX04 i7-9750H 64GB 512 GB SSD 15.6\" Windows 10 Pro Taşınabilir Bilgisayar T05837D",
                "https://cdn.dsmcdn.com//assets/dev/product/media/images/20200327/11/595833/66806265/1/1_org_zoom.jpg",5,19.399);
        
        ProductList.Add(product1);
        ProductList.Add(product2);
        ProductList.Add(product3);
        ProductList.Add(product4);
        return ProductList;
    }
}