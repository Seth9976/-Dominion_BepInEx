using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000B0 RID: 176
public class TW_FriendsIdsRequest : TW_APIRequest
{
	// Token: 0x06000CD0 RID: 3280 RVA: 0x00043AF0 File Offset: 0x00041CF0
	// Note: this type is marked as 'beforefieldinit'.
	static TW_FriendsIdsRequest()
	{
		Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_FriendsIdsRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr);
		TW_FriendsIdsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_FriendsIdsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr, 100664828);
		TW_FriendsIdsRequest.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr, 100664829);
		TW_FriendsIdsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr, 100664830);
		TW_FriendsIdsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr, 100664831);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x00043B70 File Offset: 0x00041D70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175952, RefRangeEnd = 175953, XrefRangeStart = 175942, XrefRangeEnd = 175952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_FriendsIdsRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FriendsIdsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_FriendsIdsRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_FriendsIdsRequest>(intPtr3) : null;
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x00043BA4 File Offset: 0x00041DA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175953, XrefRangeEnd = 175955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FriendsIdsRequest.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x00043BD8 File Offset: 0x00041DD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175955, XrefRangeEnd = 175993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_FriendsIdsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x00043C28 File Offset: 0x00041E28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_FriendsIdsRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_FriendsIdsRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FriendsIdsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00007316 File Offset: 0x00005516
	public TW_FriendsIdsRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040009FA RID: 2554
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_FriendsIdsRequest_0;

	// Token: 0x040009FB RID: 2555
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040009FC RID: 2556
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0;

	// Token: 0x040009FD RID: 2557
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
