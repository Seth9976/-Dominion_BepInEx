using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000B2 RID: 178
public class TW_SearchTweetsRequest : TW_APIRequest
{
	// Token: 0x06000CED RID: 3309 RVA: 0x0004412C File Offset: 0x0004232C
	// Note: this type is marked as 'beforefieldinit'.
	static TW_SearchTweetsRequest()
	{
		Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_SearchTweetsRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr);
		TW_SearchTweetsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_SearchTweetsRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr, 100664841);
		TW_SearchTweetsRequest.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr, 100664842);
		TW_SearchTweetsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr, 100664843);
		TW_SearchTweetsRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr, 100664844);
	}

	// Token: 0x06000CEE RID: 3310 RVA: 0x000441AC File Offset: 0x000423AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176295, RefRangeEnd = 176296, XrefRangeStart = 176285, XrefRangeEnd = 176295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_SearchTweetsRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_SearchTweetsRequest.NativeMethodInfoPtr_Create_Public_Static_TW_SearchTweetsRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_SearchTweetsRequest>(intPtr3) : null;
	}

	// Token: 0x06000CEF RID: 3311 RVA: 0x000441E0 File Offset: 0x000423E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176296, XrefRangeEnd = 176298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_SearchTweetsRequest.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CF0 RID: 3312 RVA: 0x00044214 File Offset: 0x00042414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176298, XrefRangeEnd = 176427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_SearchTweetsRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CF1 RID: 3313 RVA: 0x00044264 File Offset: 0x00042464
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_SearchTweetsRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_SearchTweetsRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_SearchTweetsRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CF2 RID: 3314 RVA: 0x000073DE File Offset: 0x000055DE
	public TW_SearchTweetsRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000A0D RID: 2573
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_SearchTweetsRequest_0;

	// Token: 0x04000A0E RID: 2574
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A0F RID: 2575
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0;

	// Token: 0x04000A10 RID: 2576
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
