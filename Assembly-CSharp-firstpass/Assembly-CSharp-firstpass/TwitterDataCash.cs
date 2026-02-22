using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x020000A4 RID: 164
public static class TwitterDataCash : Object
{
	// Token: 0x06000BE3 RID: 3043 RVA: 0x00040B38 File Offset: 0x0003ED38
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterDataCash()
	{
		Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterDataCash");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr);
		TwitterDataCash.NativeFieldInfoPtr_tweets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, "tweets");
		TwitterDataCash.NativeFieldInfoPtr_users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, "users");
		TwitterDataCash.NativeMethodInfoPtr_AddTweet_Public_Static_Void_TweetTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, 100664736);
		TwitterDataCash.NativeMethodInfoPtr_GetTweetsById_Public_Static_TweetTemplate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, 100664737);
		TwitterDataCash.NativeMethodInfoPtr_AddUser_Public_Static_Void_TwitterUserInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, 100664738);
		TwitterDataCash.NativeMethodInfoPtr_GetUserById_Public_Static_TwitterUserInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterDataCash>.NativeClassPtr, 100664739);
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00040BE0 File Offset: 0x0003EDE0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 175090, RefRangeEnd = 175092, XrefRangeStart = 175077, XrefRangeEnd = 175090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddTweet(TweetTemplate t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterDataCash.NativeMethodInfoPtr_AddTweet_Public_Static_Void_TweetTemplate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00040C18 File Offset: 0x0003EE18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175092, XrefRangeEnd = 175100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TweetTemplate GetTweetsById(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterDataCash.NativeMethodInfoPtr_GetTweetsById_Public_Static_TweetTemplate_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TweetTemplate>(intPtr3) : null;
		}
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00040C5C File Offset: 0x0003EE5C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 175113, RefRangeEnd = 175116, XrefRangeStart = 175100, XrefRangeEnd = 175113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddUser(TwitterUserInfo u)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(u);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterDataCash.NativeMethodInfoPtr_AddUser_Public_Static_Void_TwitterUserInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x00040C94 File Offset: 0x0003EE94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175116, XrefRangeEnd = 175124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TwitterUserInfo GetUserById(string id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterDataCash.NativeMethodInfoPtr_GetUserById_Public_Static_TwitterUserInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TwitterUserInfo>(intPtr3) : null;
		}
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00006BE0 File Offset: 0x00004DE0
	public TwitterDataCash(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00040CD8 File Offset: 0x0003EED8
	// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00006BE9 File Offset: 0x00004DE9
	public unsafe static Dictionary<string, TweetTemplate> tweets
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterDataCash.NativeFieldInfoPtr_tweets, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TweetTemplate>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterDataCash.NativeFieldInfoPtr_tweets, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00040D00 File Offset: 0x0003EF00
	// (set) Token: 0x06000BEC RID: 3052 RVA: 0x00006BFB File Offset: 0x00004DFB
	public unsafe static Dictionary<string, TwitterUserInfo> users
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TwitterDataCash.NativeFieldInfoPtr_users, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TwitterUserInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TwitterDataCash.NativeFieldInfoPtr_users, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000962 RID: 2402
	private static readonly IntPtr NativeFieldInfoPtr_tweets;

	// Token: 0x04000963 RID: 2403
	private static readonly IntPtr NativeFieldInfoPtr_users;

	// Token: 0x04000964 RID: 2404
	private static readonly IntPtr NativeMethodInfoPtr_AddTweet_Public_Static_Void_TweetTemplate_0;

	// Token: 0x04000965 RID: 2405
	private static readonly IntPtr NativeMethodInfoPtr_GetTweetsById_Public_Static_TweetTemplate_String_0;

	// Token: 0x04000966 RID: 2406
	private static readonly IntPtr NativeMethodInfoPtr_AddUser_Public_Static_Void_TwitterUserInfo_0;

	// Token: 0x04000967 RID: 2407
	private static readonly IntPtr NativeMethodInfoPtr_GetUserById_Public_Static_TwitterUserInfo_String_0;
}
