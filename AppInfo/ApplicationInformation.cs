namespace AppInfo
{
    public class ApplicationInformation
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Copyright { get; set; }
        public string Product { get; set; }
        public string VersionString { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} - {2}\n{3}",
                                 Title, VersionString, Description, Copyright);
        }
    }
}