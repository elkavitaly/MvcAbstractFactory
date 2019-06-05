using System.Collections.Generic;

namespace BLL.Model
{
    public class Newspaper
    {
        public int Id { get; set; }
        public List<Article> Articles { get; set; }
        public string Editor { get; set; }
    }
}