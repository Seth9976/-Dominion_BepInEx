using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net
{
	// Token: 0x020000C0 RID: 192
	[OriginalName("System.dll", "System.Net", "FtpStatusCode")]
	public enum FtpStatusCode
	{
		// Token: 0x040008A8 RID: 2216
		Undefined,
		// Token: 0x040008A9 RID: 2217
		RestartMarker = 110,
		// Token: 0x040008AA RID: 2218
		ServiceTemporarilyNotAvailable = 120,
		// Token: 0x040008AB RID: 2219
		DataAlreadyOpen = 125,
		// Token: 0x040008AC RID: 2220
		OpeningData = 150,
		// Token: 0x040008AD RID: 2221
		CommandOK = 200,
		// Token: 0x040008AE RID: 2222
		CommandExtraneous = 202,
		// Token: 0x040008AF RID: 2223
		DirectoryStatus = 212,
		// Token: 0x040008B0 RID: 2224
		FileStatus,
		// Token: 0x040008B1 RID: 2225
		SystemType = 215,
		// Token: 0x040008B2 RID: 2226
		SendUserCommand = 220,
		// Token: 0x040008B3 RID: 2227
		ClosingControl,
		// Token: 0x040008B4 RID: 2228
		ClosingData = 226,
		// Token: 0x040008B5 RID: 2229
		EnteringPassive,
		// Token: 0x040008B6 RID: 2230
		LoggedInProceed = 230,
		// Token: 0x040008B7 RID: 2231
		ServerWantsSecureSession = 234,
		// Token: 0x040008B8 RID: 2232
		FileActionOK = 250,
		// Token: 0x040008B9 RID: 2233
		PathnameCreated = 257,
		// Token: 0x040008BA RID: 2234
		SendPasswordCommand = 331,
		// Token: 0x040008BB RID: 2235
		NeedLoginAccount,
		// Token: 0x040008BC RID: 2236
		FileCommandPending = 350,
		// Token: 0x040008BD RID: 2237
		ServiceNotAvailable = 421,
		// Token: 0x040008BE RID: 2238
		CantOpenData = 425,
		// Token: 0x040008BF RID: 2239
		ConnectionClosed,
		// Token: 0x040008C0 RID: 2240
		ActionNotTakenFileUnavailableOrBusy = 450,
		// Token: 0x040008C1 RID: 2241
		ActionAbortedLocalProcessingError,
		// Token: 0x040008C2 RID: 2242
		ActionNotTakenInsufficientSpace,
		// Token: 0x040008C3 RID: 2243
		CommandSyntaxError = 500,
		// Token: 0x040008C4 RID: 2244
		ArgumentSyntaxError,
		// Token: 0x040008C5 RID: 2245
		CommandNotImplemented,
		// Token: 0x040008C6 RID: 2246
		BadCommandSequence,
		// Token: 0x040008C7 RID: 2247
		NotLoggedIn = 530,
		// Token: 0x040008C8 RID: 2248
		AccountNeeded = 532,
		// Token: 0x040008C9 RID: 2249
		ActionNotTakenFileUnavailable = 550,
		// Token: 0x040008CA RID: 2250
		ActionAbortedUnknownPageType,
		// Token: 0x040008CB RID: 2251
		FileActionAborted,
		// Token: 0x040008CC RID: 2252
		ActionNotTakenFilenameNotAllowed
	}
}
