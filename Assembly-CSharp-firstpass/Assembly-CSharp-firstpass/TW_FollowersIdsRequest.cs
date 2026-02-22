using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000AF RID: 175
public class TW_FollowersIdsRequest : TW_APIRequest
{
	// Token: 0x06000CCA RID: 3274 RVA: 0x0004397C File Offset: 0x00041B7C
	// Note: this type is marked as 'beforefieldinit'.
	static TW_FollowersIdsRequest()
	{
		Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_FollowersIdsRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr);
		TW_FollowersIdsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_FollowersIdsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr, 100664824);
		TW_FollowersIdsRequest.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr, 100664825);
		TW_FollowersIdsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr, 100664826);
		TW_FollowersIdsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr, 100664827);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x000439FC File Offset: 0x00041BFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 175900, RefRangeEnd = 175901, XrefRangeStart = 175890, XrefRangeEnd = 175900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_FollowersIdsRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FollowersIdsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_FollowersIdsRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_FollowersIdsRequest>(intPtr3) : null;
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x00043A30 File Offset: 0x00041C30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175901, XrefRangeEnd = 175903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FollowersIdsRequest.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x00043A64 File Offset: 0x00041C64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175903, XrefRangeEnd = 175941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_FollowersIdsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x00043AB4 File Offset: 0x00041CB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175941, XrefRangeEnd = 175942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_FollowersIdsRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_FollowersIdsRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_FollowersIdsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0000730D File Offset: 0x0000550D
	public TW_FollowersIdsRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x040009F6 RID: 2550
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_FollowersIdsRequest_0;

	// Token: 0x040009F7 RID: 2551
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040009F8 RID: 2552
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0;

	// Token: 0x040009F9 RID: 2553
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
