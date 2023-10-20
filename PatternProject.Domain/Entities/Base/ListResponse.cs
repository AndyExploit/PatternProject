using System.Collections.Generic;

namespace PatternProject.Domain.Entities.Base
{
    public class ListResponse<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public IList<T> Items { get; set; }
    }
}
