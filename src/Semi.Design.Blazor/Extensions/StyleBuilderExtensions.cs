using System.Text.RegularExpressions;

namespace BlazorComponent
{
    public static class StyleBuilderExtensions
    {
        public static StyleBuilder AddColor(this StyleBuilder styleBuilder, string color, bool isText)
        {
            return styleBuilder.AddColor(color, isText, () => true);
        }

        public static StyleBuilder AddColor(this StyleBuilder styleBuilder, string color, bool isText, Func<bool> func)
        {
            if (string.IsNullOrEmpty(color) || (!color.StartsWith("#") && !color.StartsWith("rgb")))
            {
                return styleBuilder;
            }

            if (isText)
            {
                styleBuilder
                .AddIf($"color: {color}", func);
            }
            else
            {
                styleBuilder
                        .AddIf($"background-color: {color}", func);
            }

            return styleBuilder;
        }

        public static StyleBuilder AddBackgroundColor(this StyleBuilder styleBuilder, string color)
        {
            if (IsCssColor(color))
            {
                styleBuilder
                 .Add($"background-color:{color}")
                 .Add($"border-color:{color}");
            }

            return styleBuilder;
        }

        private static bool IsCssColor(string color)
        {
            return !string.IsNullOrEmpty(color) && Regex.Match(color, @"^(#|var\(--|(rgb|hsl)a?\()").Success;
        }

        public static StyleBuilder AddTextColor(this StyleBuilder styleBuilder, string color, Func<bool> func)
        {
            return styleBuilder.AddColor(color, true, func);
        }

        public static StyleBuilder AddTransition(this StyleBuilder styleBuilder, string transition)
        {
            return styleBuilder.AddIf($"transition:{transition}", () => transition != null);
        }

        public static StyleBuilder AddTextColor(this StyleBuilder styleBuilder, string color)
        {
            if (IsCssColor(color))
            {
                styleBuilder
                    .Add($"color:{color}")
                    .Add($"caret-color:{color}");
            }

            return styleBuilder;
        }
    }

}
