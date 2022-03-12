using System.ComponentModel.DataAnnotations;
using System.Reflection;


public static class GetDisplayName
{
    public static string DisplayName(Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());

        DisplayAttribute[] attributes = (DisplayAttribute[])fi.GetCustomAttributes(typeof(DisplayAttribute), false);//https://docs.microsoft.com/en-us/dotnet/api/system.reflection.memberinfo.getcustomattributes?view=net-6.0.

        if (attributes != null && attributes.Length > 0)
            return attributes[0].Name;
        else
            return value.ToString();

    }

}
