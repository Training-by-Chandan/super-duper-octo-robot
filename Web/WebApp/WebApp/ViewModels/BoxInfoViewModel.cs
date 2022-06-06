namespace WebApp.ViewModels
{
    public class BoxInfoViewModel
    {
        public string Number { get; set; }
        public string Title { get; set; }
        public string BoxType { get; set; }
        public string BoxIcon { get; set; }
    }

    public class HomeIndexViewModel
    {
        public List<BoxInfoViewModel> Boxes { get; set; }
    }
}