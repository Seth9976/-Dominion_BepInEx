using System;

namespace Steamworks
{
	// Token: 0x02000245 RID: 581
	[Flags]
	public enum EFriendFlags
	{
		// Token: 0x040020FC RID: 8444
		k_EFriendFlagNone = 0,
		// Token: 0x040020FD RID: 8445
		k_EFriendFlagBlocked = 1,
		// Token: 0x040020FE RID: 8446
		k_EFriendFlagFriendshipRequested = 2,
		// Token: 0x040020FF RID: 8447
		k_EFriendFlagImmediate = 4,
		// Token: 0x04002100 RID: 8448
		k_EFriendFlagClanMember = 8,
		// Token: 0x04002101 RID: 8449
		k_EFriendFlagOnGameServer = 16,
		// Token: 0x04002102 RID: 8450
		k_EFriendFlagRequestingFriendship = 128,
		// Token: 0x04002103 RID: 8451
		k_EFriendFlagRequestingInfo = 256,
		// Token: 0x04002104 RID: 8452
		k_EFriendFlagIgnored = 512,
		// Token: 0x04002105 RID: 8453
		k_EFriendFlagIgnoredFriend = 1024,
		// Token: 0x04002106 RID: 8454
		k_EFriendFlagChatMember = 4096,
		// Token: 0x04002107 RID: 8455
		k_EFriendFlagAll = 65535
	}
}
