using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Customer 
{
    public int CustomerId {get; set;}

    [Required]
    public String CompanyName {get; set;}
    
    public String Address {get; set;}

    public String City {get; set;}
    public String Region {get; set;}
    public String PostalCode {get; set;}
    public String Country {get; set;}
    public String Phone {get; set;}
    public String Fax {get; set;}
}