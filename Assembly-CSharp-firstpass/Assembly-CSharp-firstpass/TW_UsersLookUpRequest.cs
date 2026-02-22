using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000B3 RID: 179
public class TW_UsersLookUpRequest : TW_APIRequest
{
	// Token: 0x06000CF3 RID: 3315 RVA: 0x000442A0 File Offset: 0x000424A0
	// Note: this type is marked as 'beforefieldinit'.
	static TW_UsersLookUpRequest()
	{
		Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TW_UsersLookUpRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr);
		TW_UsersLookUpRequest.NativeMethodInfoPtr_Create_Public_Static_TW_UsersLookUpRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr, 100664845);
		TW_UsersLookUpRequest.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr, 100664846);
		TW_UsersLookUpRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr, 100664847);
		TW_UsersLookUpRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr, 100664848);
	}

	// Token: 0x06000CF4 RID: 3316 RVA: 0x00044320 File Offset: 0x00042520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176427, XrefRangeEnd = 176437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TW_UsersLookUpRequest Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UsersLookUpRequest.NativeMethodInfoPtr_Create_Public_Static_TW_UsersLookUpRequest_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<TW_UsersLookUpRequest>(intPtr3) : null;
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00044354 File Offset: 0x00042554
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176437, XrefRangeEnd = 176439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UsersLookUpRequest.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CF6 RID: 3318 RVA: 0x00044388 File Offset: 0x00042588
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176439, XrefRangeEnd = 176481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnResult(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TW_UsersLookUpRequest.NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000CF7 RID: 3319 RVA: 0x000443D8 File Offset: 0x000425D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TW_UsersLookUpRequest()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TW_UsersLookUpRequest>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TW_UsersLookUpRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CF8 RID: 3320 RVA: 0x000073E7 File Offset: 0x000055E7
	public TW_UsersLookUpRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000A11 RID: 2577
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_TW_UsersLookUpRequest_0;

	// Token: 0x04000A12 RID: 2578
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A13 RID: 2579
	private static readonly IntPtr NativeMethodInfoPtr_OnResult_Protected_Virtual_Void_String_0;

	// Token: 0x04000A14 RID: 2580
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
