using System;
using System.Collections.Generic;

namespace UseInboxSdkAssignment.Models.ResultModels
{
    public class ListNewsletterResultModel : BaseResultModel
    {
        public NewsletterDetail ResultObject { get; set; }
        
    }

    public class NewsletterDetail
    {
        public int DisplayCount { get; set; }
        public int TotalCount { get; set; }
        public List<NewsletterResultModel> Items { get; set; }
    }

    public class NewsletterResultModel
    {
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string Subject { get; set; }
        public int Type { get; set; }
        public string Language { get; set; }

    }
}
