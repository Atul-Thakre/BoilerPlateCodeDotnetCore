namespace CourseAppWebApi.DTO.User
{
    public class AuthresponseDto
    {
        public string UserId { get; set; }
        public string Token { get; set; }

        public string RefreshToken { get; set; }
    }
}
