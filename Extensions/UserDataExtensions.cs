using PM.Enum.Item;
using System.Collections.Generic;
using System.Linq;

public static class UserDataExtensions
{
    public static UserPropertyInfo GetOrDefault(this List<UserPropertyInfo> userPropertyList, PropertyType propertyType)
    {
        return userPropertyList.FirstOrDefault(u => (PropertyType)u.propertyId == propertyType);
    }

    public static int GetNum(this List<UserPropertyInfo> userPropertyList, PropertyType propertyType)
    {
        return userPropertyList.FirstOrDefault(u => (PropertyType)u.propertyId == propertyType)?.num ?? 0;
    }
}
