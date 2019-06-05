using System;

namespace BLL.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public DateTime DateTime { get; set; }
        public string Author { get; set; }
    }
}