
namespace ShelveNamespace
{
    public class Shelve
    {
        public string LibraryShelve { get ; set; }
    

        public void ShelveBook (string shelve)
        {
            this.LibraryShelve = shelve;
        }
    }
}