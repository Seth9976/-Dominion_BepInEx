using System;

namespace Steamworks
{
	// Token: 0x0200028C RID: 652
	public enum EChatRoomEnterResponse
	{
		// Token: 0x040024D9 RID: 9433
		k_EChatRoomEnterResponseSuccess = 1,
		// Token: 0x040024DA RID: 9434
		k_EChatRoomEnterResponseDoesntExist,
		// Token: 0x040024DB RID: 9435
		k_EChatRoomEnterResponseNotAllowed,
		// Token: 0x040024DC RID: 9436
		k_EChatRoomEnterResponseFull,
		// Token: 0x040024DD RID: 9437
		k_EChatRoomEnterResponseError,
		// Token: 0x040024DE RID: 9438
		k_EChatRoomEnterResponseBanned,
		// Token: 0x040024DF RID: 9439
		k_EChatRoomEnterResponseLimited,
		// Token: 0x040024E0 RID: 9440
		k_EChatRoomEnterResponseClanDisabled,
		// Token: 0x040024E1 RID: 9441
		k_EChatRoomEnterResponseCommunityBan,
		// Token: 0x040024E2 RID: 9442
		k_EChatRoomEnterResponseMemberBlockedYou,
		// Token: 0x040024E3 RID: 9443
		k_EChatRoomEnterResponseYouBlockedMember,
		// Token: 0x040024E4 RID: 9444
		k_EChatRoomEnterResponseRatelimitExceeded = 15
	}
}
