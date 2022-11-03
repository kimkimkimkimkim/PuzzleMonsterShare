using PM.Enum.Item;
using System;
using System.Collections.Generic;
using System.Linq;

public static class UserDataExtensions
{
    public static UserPropertyInfo GetOrDefault(this List<UserPropertyInfo> userPropertyList, PropertyType propertyType)
    {
        return userPropertyList.FirstOrDefault(u => (PropertyType)u.propertyId == propertyType);
    }

    public static long GetNum(this List<UserPropertyInfo> userPropertyList, PropertyType propertyType)
    {
        return userPropertyList.FirstOrDefault(u => (PropertyType)u.propertyId == propertyType)?.num ?? 0;
    }

    public static int GetStack(this UserMonsterInfo userMonster)
    {
        return Math.Max(userMonster.num - 1, 0);
    }
}
