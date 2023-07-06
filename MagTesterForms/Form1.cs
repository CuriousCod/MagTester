using MagTesterForms;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace MagTesterForms;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeBlazor();
    }

    private void InitializeBlazor()
    {
        var services = new ServiceCollection();
        services.AddWindowsFormsBlazorWebView();
        webView.HostPage = "wwwroot\\index.html";
        webView.Services = services.BuildServiceProvider();
        webView.RootComponents.Add<Feeder>("#app");
    }
}