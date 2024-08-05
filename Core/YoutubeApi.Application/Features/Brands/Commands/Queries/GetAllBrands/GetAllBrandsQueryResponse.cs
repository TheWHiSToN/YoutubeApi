using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Features.Brands.Commands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryResponse
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
