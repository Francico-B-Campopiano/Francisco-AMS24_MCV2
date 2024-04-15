using System.Data;

class Product
{
    public Guid Id {get; set;}

    public string Brand {get; set;} = string.Empty;
    public Guid ColorId {get; set;}
    public Guid SizeId {get; set;}
    public double Price {get; set;}
    public string Descripition {get; set;} = string.Empty;
    public double Stock {get; set;}
    public bool IsActive {get; set;}
    public DateTime CreateBy {get; set;}
}