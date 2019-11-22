﻿using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace BracketPairColorizer.Core.Settings
{
    public static class CommonExtensions
    {
        public static bool Has<T>(this IPropertyOwner owner)
        {
            return owner.Properties.ContainsProperty(typeof(T));
        }

        public static T Get<T>(this IPropertyOwner owner) where T : class
        {
            if (owner.Properties.TryGetProperty(typeof(T), out T t)) { return t; }

            return null;
        }

        public static void Set<T>(this IPropertyOwner owner, T value)
        {
            owner.Properties.AddProperty(typeof(T), value);
        }

        public static bool IsPeekTextWindow(this ITextView textView)
        {
            return textView.Roles.Contains(ViewRoles.EmbeddedPeekTextView);
        }
    }
}
