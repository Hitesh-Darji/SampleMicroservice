namespace SampleMicroservice.UserManagement.Application.Dto
{
    public class ExceptionDetail
    {
        public int StatusCode { get; set; }
        public string? Details { get; set; }

        public ExceptionDetail(int statusCode, string? details = null)
        {
            StatusCode = statusCode;
            Details = details;
        }
    }
}
