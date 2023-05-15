using Etarna.Models;

namespace Etarna.ViewModel.Home
{
    public class HomeVM
    {
        public IEnumerable<Featured> Featureds { get; set; }
        public IEnumerable<Service> Services { get; set; }
    }
}
