﻿using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CCPDemo.Notifications.Dto;

namespace CCPDemo.Notifications
{
    public interface INotificationAppService : IApplicationService
    {
        Task<GetNotificationsOutput> GetUserNotifications(GetUserNotificationsInput input);
        
        Task SetAllNotificationsAsRead();

        Task<SetNotificationAsReadOutput> SetNotificationAsRead(EntityDto<Guid> input);

        Task<GetNotificationSettingsOutput> GetNotificationSettings();

        Task UpdateNotificationSettings(UpdateNotificationSettingsInput input);

        Task DeleteNotification(EntityDto<Guid> input);

        Task DeleteAllUserNotifications(DeleteAllUserNotificationsInput input);
    }
}
