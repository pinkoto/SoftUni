using System.Reflection;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj
                .GetType()
                .GetProperties();

            foreach (PropertyInfo property in properties)
            {
                MyValdationAttribute valdationAttribute = (MyValdationAttribute)property
                    .GetCustomAttribute(typeof(MyValdationAttribute), false);

                bool isValid = valdationAttribute.IsValid(property.GetValue(obj));

                if (!isValid)
                {
                    return false;
                }
            }

            return true;
        }
    }
}