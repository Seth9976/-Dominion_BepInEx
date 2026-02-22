using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class InitializeLocalizationService : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x0001ADF4 File Offset: 0x00018FF4
	// Note: this type is marked as 'beforefieldinit'.
	static InitializeLocalizationService()
	{
		Il2CppClassPointerStore<InitializeLocalizationService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InitializeLocalizationService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeLocalizationService>.NativeClassPtr);
		InitializeLocalizationService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalizationService>.NativeClassPtr, 100663300);
		InitializeLocalizationService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeLocalizationService>.NativeClassPtr, 100663301);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0001AE4C File Offset: 0x0001904C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223819, XrefRangeEnd = 223835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalizationService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0001AE80 File Offset: 0x00019080
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InitializeLocalizationService()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeLocalizationService>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializeLocalizationService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002093 File Offset: 0x00000293
	public InitializeLocalizationService(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
