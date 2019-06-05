using System.Collections.Generic;

namespace DAL.Model
{
    public class NewspaperIdentity
    {
        public int NewspaperIdentityId { get; set; }
        public virtual List<ArticleIdentity> Articles { get; set; }
        public string Editor { get; set; }
    }
}