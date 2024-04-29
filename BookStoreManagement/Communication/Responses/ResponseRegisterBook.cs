namespace BookStoreManagement.Communication.Responses;

public class ResponseRegisterBook
{
    public String Title { get; set; } = string.Empty;
    public String Author { get; set; } = string.Empty;
    public String Genre { get; set; } = string.Empty;
    public Double Price { get; set; }
}
