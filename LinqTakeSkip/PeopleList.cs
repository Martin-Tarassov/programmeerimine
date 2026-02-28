using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqtakeSkip
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 21,
                GenderId = Guid.Parse("8d7826f4-f769-47e9-b248-6c41ae71bd03")
            },
            new People()
            {
                Id = 2,
                Name = "Moona",
                Age = 26,
                GenderId = Guid.Parse("fa17aae9-3426-4b74-b33f-669e78f323f1")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 28,
                GenderId = Guid.Parse("7faab7ed-534c-48cf-a32c-0187747454d6")
            },
            new People()
            {
                Id = 4,
                Name = "Jhoon",
                Age = 16,
                GenderId = Guid.Parse("a10439c8-f007-4e9c-ab4b-dd55415b0650")
            },
            new People()
            {
                Id = 5,
                Name = "Grek",
                Age = 11,
                GenderId = Guid.Parse("694da92a-efa2-4705-b5cc-05a0435fd4a7")
            },
            new People
            {
                Id = 6,
                Name = "Mari",
                Age = 20,
                GenderId = Guid.NewGuid()
            },
            new People
            {
                Id = 7,
               Name = "Mari",
               Age = 54,
              GenderId = Guid.NewGuid()
            },
        };       
    }
}
