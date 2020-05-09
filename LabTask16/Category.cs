using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask16
{
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
      

        public Category(int id, string categoryName)
        {
            Id = id;
            CategoryName = categoryName;
        }
    }
}
