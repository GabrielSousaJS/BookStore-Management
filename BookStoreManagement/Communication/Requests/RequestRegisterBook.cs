namespace BookStoreManagement.Communication.Requests;

public class RequestRegisterBook
{
    public String Title { get; set; } = string.Empty;
    public String Author { get; set; } = string.Empty;
    public String Genre { get; set; } = string.Empty;
    public Double Price { get; set; }
    public Double QuantityStock { get; set; }
}
