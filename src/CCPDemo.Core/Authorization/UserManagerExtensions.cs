﻿using System.Threading.Tasks;
using Abp.Authorization.Users;
using CCPDemo.Authorization.Users;

namespace CCPDemo.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
