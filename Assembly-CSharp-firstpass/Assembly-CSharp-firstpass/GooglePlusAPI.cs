using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Pattern;

// Token: 0x02000024 RID: 36
public class GooglePlusAPI : Singleton<GooglePlusAPI>
{
	// Token: 0x06000408 RID: 1032 RVA: 0x00024340 File Offset: 0x00022540
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlusAPI()
	{
		Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlusAPI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr);
		GooglePlusAPI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr, 100663749);
		GooglePlusAPI.NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr, 100663750);
		GooglePlusAPI.NativeMethodInfoPtr_ClearDefaultAccount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr, 100663751);
		GooglePlusAPI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr, 100663752);
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x000243C0 File Offset: 0x000225C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163173, XrefRangeEnd = 163178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusAPI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000243F4 File Offset: 0x000225F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163178, XrefRangeEnd = 163179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void clearDefaultAccount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusAPI.NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00024428 File Offset: 0x00022628
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 163191, RefRangeEnd = 163193, XrefRangeStart = 163179, XrefRangeEnd = 163191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearDefaultAccount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusAPI.NativeMethodInfoPtr_ClearDefaultAccount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x0002445C File Offset: 0x0002265C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163193, XrefRangeEnd = 163199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlusAPI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlusAPI>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlusAPI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00003C7D File Offset: 0x00001E7D
	public GooglePlusAPI(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000302 RID: 770
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000303 RID: 771
	private static readonly IntPtr NativeMethodInfoPtr_clearDefaultAccount_Public_Void_0;

	// Token: 0x04000304 RID: 772
	private static readonly IntPtr NativeMethodInfoPtr_ClearDefaultAccount_Public_Void_0;

	// Token: 0x04000305 RID: 773
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
