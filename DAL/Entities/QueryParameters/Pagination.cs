using System.Linq;

namespace DAL.Entities.QueryParameters
{
    public class Pagination
    {
        private const int maxPageCount = 100;
        public int Page { get; set; } = 1;
        public string Query { get; set; }
        public string OrderBy { get; set; } = "datetimecreated desc";
        private int _pageCount = 100;


        public int PageCount
        {
            get { return _pageCount; }
            set { _pageCount = (value > maxPageCount) ? maxPageCount : value; }
        }

        public bool Descending
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(OrderBy))
                {
                    return OrderBy.Split(' ').Last().ToLowerInvariant().StartsWith("desc");
                }
                return false;
            }
        }

        public bool HasQuery { get { return !string.IsNullOrEmpty(Query); } }
    }
}
