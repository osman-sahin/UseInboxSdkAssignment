namespace UseInboxSdkAssignment.Models.ResultModels
{
    public class AuthTokenResultModel : BaseResultModel
    {
        public AuthTokenDetail ResultObject { get; set; }
    }

    public class AuthTokenDetail
    {
        public string Access_Token { get; set; }
        public int Expires_In { get; set; }
        public string Token_Type { get; set; }
    }
}
