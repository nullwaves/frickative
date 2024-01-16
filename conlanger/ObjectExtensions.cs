namespace conlanger
{
    public static class ObjectExtensions
    {
        /**
         * Sergii Bogomolov
         * modified by nullwaves
         * CC BY-SA 4.0
         * https://stackoverflow.com/a/18375526/21429966
         */
        public static bool InheritsFromOrIs(this Type type, Type baseType)
        {
            // null does not have base type
            if (type == null)
            {
                return false;
            }

            // only interface or object can have null base type
            if (baseType == null)
            {
                return type.IsInterface || type == typeof(object);
            }

            if (type == baseType) return true;

            // check implemented interfaces
            if (baseType.IsInterface)
            {
                return type.GetInterfaces().Contains(baseType);
            }

            // check all base types
            var currentType = type;
            while (currentType != null)
            {
                if (currentType.BaseType == baseType)
                {
                    return true;
                }

                currentType = currentType.BaseType;
            }

            return false;
        }
    }
}
