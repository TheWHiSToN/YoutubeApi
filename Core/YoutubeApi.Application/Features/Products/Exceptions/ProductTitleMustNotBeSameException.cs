using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Application.Bases;

namespace YoutubeApi.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException : BasesExceptions
    {
        public ProductTitleMustNotBeSameException() : base("Ürün başlığı zaten var!") { }
        
    }
}
