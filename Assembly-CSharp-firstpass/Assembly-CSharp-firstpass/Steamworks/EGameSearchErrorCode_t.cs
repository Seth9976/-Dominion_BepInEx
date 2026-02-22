using System;

namespace Steamworks
{
	// Token: 0x02000297 RID: 663
	public enum EGameSearchErrorCode_t
	{
		// Token: 0x0400256B RID: 9579
		k_EGameSearchErrorCode_OK = 1,
		// Token: 0x0400256C RID: 9580
		k_EGameSearchErrorCode_Failed_Search_Already_In_Progress,
		// Token: 0x0400256D RID: 9581
		k_EGameSearchErrorCode_Failed_No_Search_In_Progress,
		// Token: 0x0400256E RID: 9582
		k_EGameSearchErrorCode_Failed_Not_Lobby_Leader,
		// Token: 0x0400256F RID: 9583
		k_EGameSearchErrorCode_Failed_No_Host_Available,
		// Token: 0x04002570 RID: 9584
		k_EGameSearchErrorCode_Failed_Search_Params_Invalid,
		// Token: 0x04002571 RID: 9585
		k_EGameSearchErrorCode_Failed_Offline,
		// Token: 0x04002572 RID: 9586
		k_EGameSearchErrorCode_Failed_NotAuthorized,
		// Token: 0x04002573 RID: 9587
		k_EGameSearchErrorCode_Failed_Unknown_Error
	}
}
