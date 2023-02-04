using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Smileys.TagHelpers
{
    public class CardHeaderSmileyTagHelper : TagHelper
    {
        public int SmileyId { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "img";
            output.Attributes.SetAttribute("class", "img-fluid rounded-start");
            output.Attributes.SetAttribute("width", "100%");
            output.Attributes.SetAttribute("height", "100%");
            switch (SmileyId)
            {
                case 1:
                    output.Attributes.SetAttribute("src", "../../images/Smiley1.jpg");
                    output.Attributes.SetAttribute("alt", "Happy Smiley");
                    break;
                case 2:
                    output.Attributes.SetAttribute("src", "../../images/Smiley2.jpg");
                    output.Attributes.SetAttribute("alt", "Neutral Smiley");
                    break;
                case 3:
                    output.Attributes.SetAttribute("src", "../../images/Smiley3.jpg");
                    output.Attributes.SetAttribute("alt", "Sad Smiley");
                    break;
            }
        }
    }
}
