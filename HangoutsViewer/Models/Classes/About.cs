using HangoutsViewer.Models.Interfaces;
using HangoutsViewer.Properties;

namespace HangoutsViewer.Models.Classes
{
    public class About : IAbout
    {
        public string AboutText => Resources.About;
    }
}
