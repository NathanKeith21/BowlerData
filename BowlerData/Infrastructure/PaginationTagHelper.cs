using BowlerData.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//This file builds the page number links at the bottom of the page
namespace BowlerData.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-info")]
    public class PaginationTagHelper : TagHelper
    {
        private IUrlHelperFactory urlInfo;
        public PaginationTagHelper(IUrlHelperFactory uh)
        {
            urlInfo = uh;
        }
        public PageNumberingInfo PageInfo { get; set; }
        public string TeamName { get; set; }
        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        public string PageClass { get; set; }
        public string PageClassSelected { get; set; }
        public string PageClassNormal { get; set; }
        //This method builds the page number buttons on the bottom of the page, including styling
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelp = urlInfo.GetUrlHelper(ViewContext);
            TagBuilder finishedTag = new TagBuilder("div");
            for (int i = 1; i <= PageInfo.NumPages; i++)
            {
                TagBuilder individualTag = new TagBuilder("a");

                KeyValuePairs["pageNum"] = i;
                individualTag.Attributes["href"] = urlHelp.Action("Index", KeyValuePairs);
                individualTag.AddCssClass(PageClass);
                individualTag.AddCssClass(i == PageInfo.CurrentPage ? PageClassSelected : PageClassNormal);
                individualTag.InnerHtml.Append(i.ToString());
                finishedTag.InnerHtml.AppendHtml(individualTag);
            }
            output.Content.AppendHtml(finishedTag.InnerHtml);
        }
    }
}
