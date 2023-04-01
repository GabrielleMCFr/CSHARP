using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivityTracker.Pages
{
  public class ProgressCirclePartialModel : PageModel
  {
    public string BackgroundStroke { get; set; }
    public string ForegroundStroke { get; set; }
    public double PercentProgress { get; set; }
    public double DisplayNumber { get; set; }
    public string Unit { get; set; }
    public string IconUrl { get; set; }
  }
}