using OpenQA.Selenium.Support.UI;
using SeleniumHelperClasses.ElementTypes;

namespace SeleniumHelperClasses.Extensions
{
    public static class ControlExtensions
    {
        public static bool IsVisible(this ElementSe target)
        {
            if (target.Style.ToLower().Trim() == "block")
            {
                return true;
            }

            if (target.ClassName.ToLower().Contains("lightbox") && target.Style.ToLower().Trim() != "block")
            {
                return false;
            }

            if (target.Style.ToLower().Trim() == "none" || target.ClassName.ToLower().Contains("hidden"))
            {
                return false;
            }

            return true;
        }

        public static void SelectListItem(this SelectListSe target, string value)
        {
            SelectElement selectElement = new SelectElement(target);
            selectElement.SelectByText(value);
        }
    }
}