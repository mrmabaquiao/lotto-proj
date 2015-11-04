using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoProject.Common
{
    public class DrawHelper
    {
        public static List<DrawCategory> GetDrawCategories()
        {
            var drawCategories = new List<DrawCategory>()
            {
                new DrawCategory(){Id = 1,CategoryName="642"},
                new DrawCategory(){Id =2,CategoryName="645"},
                new DrawCategory(){Id =3,CategoryName="649"},
                new DrawCategory(){Id =4,CategoryName="655"},
                new DrawCategory(){Id =5,CategoryName="658"}
                

            };
            return drawCategories;
        }

    }

    public class DrawCategory
    {
        public int Id {get;set;}
        public string CategoryName { get; set; }
       


    }
}
