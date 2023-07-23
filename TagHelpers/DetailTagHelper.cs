using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TestApp.TagHelpers
{
    [HtmlTargetElement("detail")]
    public class DetailTagHelper : TagHelper
    {
        public string Caption { get; set; } = string.Empty;
        public List<string> ButtonImages { get; set; } = new();
        public string ContentAttributes { get; set; } = string.Empty;
        public string TagId { get; set; } = string.Empty;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var childContext = output.GetChildContentAsync().Result;
            var content = childContext.GetContent();

            var buttons = string.Concat(ButtonImages.Select(x => $@"
                <button type=""button"" class=""btn btn-outline-light shadow-none"">
                    <img src=""{x}""/>
                </button>
            "));

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "container detail");
            output.Attributes.SetAttribute("id", TagId);

            output.Content.AppendHtml($@"
                <div class=""row justify-content-between mt-1 mb-2"">
                    <div class=""col-auto d-flex align-items-center"">
                        <h6>{Caption}<h6/>
                    </div>
                    <div class=""col-auto btn-group"" role=""group"">
                        {buttons}
                    </div>
                </div>
                <div class=""mb-4 {ContentAttributes}"">
                    {content}
                </div>
            ");
        }
    }
}
