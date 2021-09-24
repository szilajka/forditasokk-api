using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace AuthServer.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string Error { get; set; }

        public string ErrorDescription { get; set; }

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;

            // If the error was not caused by an invalid
            // OIDC request, display a generic error page.
            var response = HttpContext.GetOpenIddictServerResponse();
            if (response != null)
            {
                Error = response.Error;
                ErrorDescription = response.ErrorDescription;
            }
        }
    }
}
