using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000B4 RID: 180
public class TW_UserTimeLineRequest : TW_APIRequest
{
	// Token: 0x06000CF9 RID: 3321 RVA: 0x00044414 File Offset: 0x00042614
	// Note: this type is marked as 'beforefieldinit'.
	static TW_UserTimeLineRequest()
	{
		Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_UserTimeLineRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr);
		TW_UserTimeLineRequest.NativeMethodInfoPtr_Create_Public_Static_TW_UserTimeLineRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr, 100664849);
		TW_UserTimeLineRequest.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr, 100664850);
		TW_UserTimeLineRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr, 100664851);
		TW_UserTimeLineRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr, 100664852);
	}

	// Token: 0x06000CFA RID: 3322 RVA: 0x00044494 File Offset: 0x00042694
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 176491, RefRangeEnd = 176492, XrefRangeStart = 176481, XrefRangeEnd = 176491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_UserTimeLineRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UserTimeLineRequest.NativeMethodInfoPtr_Create_Public_Static_TW_UserTimeLineRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_UserTimeLineRequest>(intPtr3) : null;
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x000444C8 File Offset: 0x000426C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176492, XrefRangeEnd = 176494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UserTimeLineRequest.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x000444FC File Offset: 0x000426FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176494, XrefRangeEnd = 176618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_UserTimeLineRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x0004454C File Offset: 0x0004274C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_UserTimeLineRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_UserTimeLineRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UserTimeLineRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CFE RID: 3326 RVA: 0x000073F0 File Offset: 0x000055F0
	public TW_UserTimeLineRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000A15 RID: 2581
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_UserTimeLineRequest_0;

	// Token: 0x04000A16 RID: 2582
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A17 RID: 2583
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0;

	// Token: 0x04000A18 RID: 2584
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
