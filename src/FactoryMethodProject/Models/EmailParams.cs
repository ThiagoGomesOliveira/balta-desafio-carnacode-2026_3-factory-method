
namespace FactoryMethodProject.Models;

public class EmailParams
{
    public string Recipient { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsHtml { get; set; }
}
