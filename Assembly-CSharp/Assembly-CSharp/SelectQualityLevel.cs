using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000077 RID: 119
public class SelectQualityLevel : MonoBehaviour
{
	// Token: 0x06000F23 RID: 3875 RVA: 0x00046414 File Offset: 0x00044614
	// Note: this type is marked as 'beforefieldinit'.
	static SelectQualityLevel()
	{
		Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SelectQualityLevel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr);
		SelectQualityLevel.NativeMethodInfoPtr_SetLevel_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr, 100664378);
		SelectQualityLevel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr, 100664379);
		SelectQualityLevel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr, 100664380);
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00046480 File Offset: 0x00044680
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240396, XrefRangeEnd = 240409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetLevel(string qualityLevelName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(qualityLevelName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectQualityLevel.NativeMethodInfoPtr_SetLevel_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x000464D0 File Offset: 0x000446D0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectQualityLevel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00046504 File Offset: 0x00044704
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectQualityLevel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectQualityLevel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectQualityLevel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x0000ABDD File Offset: 0x00008DDD
	public SelectQualityLevel(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000A52 RID: 2642
	private static readonly IntPtr NativeMethodInfoPtr_SetLevel_Private_Boolean_String_0;

	// Token: 0x04000A53 RID: 2643
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000A54 RID: 2644
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
