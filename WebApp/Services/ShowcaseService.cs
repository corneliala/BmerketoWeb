using WebApp.ViewModels;

namespace WebApp.Services;

public class ShowcaseService
{
    private ShowcaseViewModel showcase = new ShowcaseViewModel()
    {
        Ingress = "WELCOME TO MBERKETO SHOP",
        Title = "Exclusive Cat Collection.",
        LinkContent = "SHOP NOW",
        LinkUrl = "/products",
        ImageUrl = "images/placeholders/pexels-hat-625x627.jpg"
    };

    public ShowcaseViewModel GetLatest()
    {
        return showcase;
    }
}
