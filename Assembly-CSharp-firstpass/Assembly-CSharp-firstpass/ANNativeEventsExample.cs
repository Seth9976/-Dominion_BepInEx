using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200011D RID: 285
public class ANNativeEventsExample : MonoBehaviour
{
	// Token: 0x0600139C RID: 5020 RVA: 0x0005A93C File Offset: 0x00058B3C
	// Note: this type is marked as 'beforefieldinit'.
	static ANNativeEventsExample()
	{
		Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "ANNativeEventsExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr);
		ANNativeEventsExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665645);
		ANNativeEventsExample.NativeMethodInfoPtr_OnStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665646);
		ANNativeEventsExample.NativeMethodInfoPtr_OnStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665647);
		ANNativeEventsExample.NativeMethodInfoPtr_OnNewIntent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665648);
		ANNativeEventsExample.NativeMethodInfoPtr_OnActivityResult_Private_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665649);
		ANNativeEventsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr, 100665650);
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0005A9E4 File Offset: 0x00058BE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184803, XrefRangeEnd = 184819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0005AA18 File Offset: 0x00058C18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184819, XrefRangeEnd = 184825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr_OnStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x0005AA4C File Offset: 0x00058C4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184825, XrefRangeEnd = 184831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr_OnStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x0005AA80 File Offset: 0x00058C80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184831, XrefRangeEnd = 184837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNewIntent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr_OnNewIntent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0005AAB4 File Offset: 0x00058CB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184837, XrefRangeEnd = 184856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnActivityResult(AndroidActivityResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr_OnActivityResult_Private_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0005AAF8 File Offset: 0x00058CF8
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ANNativeEventsExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ANNativeEventsExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ANNativeEventsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00009B9D File Offset: 0x00007D9D
	public ANNativeEventsExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000EF0 RID: 3824
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000EF1 RID: 3825
	private static readonly IntPtr NativeMethodInfoPtr_OnStop_Private_Void_0;

	// Token: 0x04000EF2 RID: 3826
	private static readonly IntPtr NativeMethodInfoPtr_OnStart_Private_Void_0;

	// Token: 0x04000EF3 RID: 3827
	private static readonly IntPtr NativeMethodInfoPtr_OnNewIntent_Private_Void_0;

	// Token: 0x04000EF4 RID: 3828
	private static readonly IntPtr NativeMethodInfoPtr_OnActivityResult_Private_Void_AndroidActivityResult_0;

	// Token: 0x04000EF5 RID: 3829
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
