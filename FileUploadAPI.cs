namespace Core_API_APIKey
{
    public class FileUploadAPI
    {
        public int ImgID { get; set; }
        //public string? Customers { get; set; }
        public IFormFile? files { get; set; }
        public string ImgName { get; set; }
    }
}
