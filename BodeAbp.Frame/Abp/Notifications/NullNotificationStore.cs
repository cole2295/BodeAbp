using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.Notifications
{
    /// <summary>
    /// Null pattern implementation of <see cref="INotificationStore"/>.
    /// </summary>
    public class NullNotificationStore : INotificationStore
    {
        public Task InsertSubscriptionAsync(NotificationSubscriptionInfo subscription)
        {
            return Task.FromResult(0);
        }

        public Task DeleteSubscriptionAsync(UserIdentifier user, string notificationName, string entityTypeName, string entityId)
        {
            return Task.FromResult(0);
        }

        public Task InsertNotificationAsync(NotificationInfo notification)
        {
            return Task.FromResult(0);
        }

        public Task<NotificationInfo> GetNotificationOrNullAsync(Guid notificationId)
        {
            return Task.FromResult(null as NotificationInfo);
        }

        public Task InsertUserNotificationAsync(UserNotificationInfo userNotification)
        {
            return Task.FromResult(0);
        }

        public Task<List<NotificationSubscriptionInfo>> GetSubscriptionsAsync(string notificationName, string entityTypeName = null, string entityId = null)
        {
            return Task.FromResult(new List<NotificationSubscriptionInfo>());
        }

        public Task<List<NotificationSubscriptionInfo>> GetSubscriptionsAsync(UserIdentifier user)
        {
            return Task.FromResult(new List<NotificationSubscriptionInfo>());
        }

        public Task<bool> IsSubscribedAsync(UserIdentifier user, string notificationName, string entityTypeName, string entityId)
        {
            return Task.FromResult(false);
        }

        public Task UpdateUserNotificationStateAsync(Guid userNotificationId, UserNotificationState state)
        {
            return Task.FromResult(0);
        }

        public Task UpdateAllUserNotificationStatesAsync(UserIdentifier user, UserNotificationState state)
        {
            return Task.FromResult(0);
        }

        public Task DeleteUserNotificationAsync(Guid userNotificationId)
        {
            return Task.FromResult(0);
        }

        public Task DeleteAllUserNotificationsAsync(UserIdentifier user)
        {
            return Task.FromResult(0);
        }

        public Task<List<UserNotification>> GetUserNotificationsAsync(UserIdentifier user, UserNotificationState? state = null, int skipCount = 0, int maxResultCount = int.MaxValue)
        {
            return Task.FromResult(new List<UserNotification>());
        }

        public Task<int> GetUserNotificationCountAsync(UserIdentifier user, UserNotificationState? state = null)
        {
            return Task.FromResult(0);
        }

        public Task<UserNotification> GetUserNotificationAsync(Guid userNotificationId)
        {
            return Task.FromResult((UserNotification)null);
        }

        public Task DeleteNotificationAsync(NotificationInfo notification)
        {
            return Task.FromResult(0);
        }
    }
}