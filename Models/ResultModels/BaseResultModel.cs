namespace UseInboxSdkAssignment.Models.ResultModels
{
    public abstract class BaseResultModel
    {
        public string Version { get; set; }
        public bool ResultStatus { get; set; }
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}
