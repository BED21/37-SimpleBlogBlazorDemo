using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Shared.Post
{
    public interface ISlugValidator
    {
        Task<bool> IsUnique(string slug);
    }
}
