

namespace EvoTraining.Pages
{
   public class SimplePage
    {
        public void Navigate(string url)
        {
            Browser.GoTo(url);
        }
    }
}
