using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatHosts.DAL
{
    internal class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public CategoryModel(int id,string name)
        { 
            CategoryId = id;
            CategoryName = name;
        }
        public CategoryModel(DataRow dr)
        {
            CategoryId = (int)dr["CategoryID"];
            CategoryName = dr["CategorhName"].ToString();
        }
    }
}
