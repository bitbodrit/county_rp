using System.Collections.Generic;

namespace CountyRP.Services.Forum.Infrastructure.Models
{
    public class PagedFilterResult<T>
    {
        public int AllCount { get; }

        public int Page { get; }

        public int MaxPages { get; }

        public IEnumerable<T> Items { get; }

        public PagedFilterResult(
            int allCount,
            int page,
            int maxPages,
            IEnumerable<T> items
        )
        {
            AllCount = allCount;
            Page = page;
            MaxPages = maxPages;
            Items = items;
        }
    }
}
