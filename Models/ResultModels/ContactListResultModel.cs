using System;
using System.Collections.Generic;

namespace UseInboxSdkAssignment.Models.ResultModels
{
    public class ContactListResultModel : BaseResultModel
    {
        public ContactListDetail ResultObject { get; set; }
    }

    public class ContactListDetail
    {
        public int DisplayCount { get; set; }
        public int TotalCount { get; set; }
        public List<ContactListItemResultModel> Items { get; set; }
    }

    public class ContactListItemResultModel
    {
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string ListName { get; set; }
        public string GroupId { get; set; }
        public int Legislation { get; set; }
        public int Count { get; set; }
    }


}
