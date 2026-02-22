using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x020000AB RID: 171
public class TW_APIRequstResult : Object
{
	// Token: 0x06000C8D RID: 3213 RVA: 0x00042CA8 File Offset: 0x00040EA8
	// Note: this type is marked as 'beforefieldinit'.
	static TW_APIRequstResult()
	{
		Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_APIRequstResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr);
		TW_APIRequstResult.NativeFieldInfoPtr_tweets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, "tweets");
		TW_APIRequstResult.NativeFieldInfoPtr_users = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, "users");
		TW_APIRequstResult.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, "ids");
		TW_APIRequstResult.NativeFieldInfoPtr__IsSucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, "_IsSucceeded");
		TW_APIRequstResult.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, "_data");
		TW_APIRequstResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, 100664799);
		TW_APIRequstResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, 100664800);
		TW_APIRequstResult.NativeMethodInfoPtr_get_responce_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr, 100664801);
	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x00042D78 File Offset: 0x00040F78
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 175513, RefRangeEnd = 175521, XrefRangeStart = 175492, XrefRangeEnd = 175513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_APIRequstResult(bool IsResSucceeded, string resData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_APIRequstResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsResSucceeded;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequstResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00042DD4 File Offset: 0x00040FD4
	public unsafe bool IsSucceeded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequstResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00042E10 File Offset: 0x00041010
	public unsafe string responce
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_APIRequstResult.NativeMethodInfoPtr_get_responce_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0000713F File Offset: 0x0000533F
	public TW_APIRequstResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00042E48 File Offset: 0x00041048
	// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00007148 File Offset: 0x00005348
	public unsafe List<TweetTemplate> tweets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_tweets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TweetTemplate>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_tweets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00042E78 File Offset: 0x00041078
	// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00007167 File Offset: 0x00005367
	public unsafe List<TwitterUserInfo> users
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_users);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TwitterUserInfo>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_users), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00042EA8 File Offset: 0x000410A8
	// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00007186 File Offset: 0x00005386
	public unsafe List<string> ids
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_ids);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr_ids), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00042ED8 File Offset: 0x000410D8
	// (set) Token: 0x06000C99 RID: 3225 RVA: 0x000071A5 File Offset: 0x000053A5
	public unsafe bool _IsSucceeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr__IsSucceeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr__IsSucceeded)) = value;
		}
	}

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00042F00 File Offset: 0x00041100
	// (set) Token: 0x06000C9B RID: 3227 RVA: 0x000071C0 File Offset: 0x000053C0
	public unsafe string _data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr__data);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TW_APIRequstResult.NativeFieldInfoPtr__data), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040009CF RID: 2511
	private static readonly IntPtr NativeFieldInfoPtr_tweets;

	// Token: 0x040009D0 RID: 2512
	private static readonly IntPtr NativeFieldInfoPtr_users;

	// Token: 0x040009D1 RID: 2513
	private static readonly IntPtr NativeFieldInfoPtr_ids;

	// Token: 0x040009D2 RID: 2514
	private static readonly IntPtr NativeFieldInfoPtr__IsSucceeded;

	// Token: 0x040009D3 RID: 2515
	private static readonly IntPtr NativeFieldInfoPtr__data;

	// Token: 0x040009D4 RID: 2516
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

	// Token: 0x040009D5 RID: 2517
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

	// Token: 0x040009D6 RID: 2518
	private static readonly IntPtr NativeMethodInfoPtr_get_responce_Public_get_String_0;
}
