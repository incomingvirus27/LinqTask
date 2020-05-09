using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask16
{
    class Article
    {
        //Autoimplemented properties
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        //constructor

        public Article(int id, int categoryId, string title, string body)
        {
            Id = id;
            CategoryId = categoryId;
            Title = title;
            Body = body;
        }
    }
}
