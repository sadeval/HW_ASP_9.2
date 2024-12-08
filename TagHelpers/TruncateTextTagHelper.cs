using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HW_ASP_9._2.TagHelpers
{
    [HtmlTargetElement("truncate-text")]
    public class TruncateTextTagHelper : TagHelper
    {
        public string Text { get; set; } = string.Empty;
        public int Length { get; set; } = 300; 

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            string truncated = Text.Length > Length ? Text.Substring(0, Length) + "..." : Text;
            output.Content.SetContent(truncated);
        }
    }
}
