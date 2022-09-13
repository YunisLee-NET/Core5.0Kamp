using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetListWithCategory();

        List<Blog> Last5Post(int id);
        List<Blog> Last3PostFooter();
        List<Blog> GetBlogListByWriter(int id);
    }
}
