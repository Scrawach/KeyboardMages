using System;

namespace CodeBase.Common.Extensions
{
    public static class FunctionalExtensions
    {
        public static TObject With<TObject>(this TObject self, Action<TObject> action)
        {
            action?.Invoke(self);
            return self;
        }

        public static TObject With<TObject>(this TObject self, Action<TObject> action, bool when)
        {
            if (when)
                action?.Invoke(self);
            
            return self;
        }
    }
}