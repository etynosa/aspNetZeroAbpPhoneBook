﻿using System.Threading.Tasks;
using Abp.Application.Services;
using CCPDemo.Friendships.Dto;

namespace CCPDemo.Friendships
{
    public interface IFriendshipAppService : IApplicationService
    {
        Task<FriendDto> CreateFriendshipRequest(CreateFriendshipRequestInput input);

        Task<FriendDto> CreateFriendshipRequestByUserName(CreateFriendshipRequestByUserNameInput input);

        Task BlockUser(BlockUserInput input);

        Task UnblockUser(UnblockUserInput input);

        Task AcceptFriendshipRequest(AcceptFriendshipRequestInput input);

        Task RemoveFriend(RemoveFriendInput input);
    }
}
