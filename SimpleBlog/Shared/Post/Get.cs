using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Shared.Post
{
    public class Get
    {
        public class Query : IRequest<Model>
        {
            public int Id { get; set; }
        }

        public class Model
        {
            public int Id { get; set; }
            public string Slug { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
    }
}
