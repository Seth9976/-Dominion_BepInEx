using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000041 RID: 65
public class TutorialCallout : Object
{
	// Token: 0x06000B39 RID: 2873 RVA: 0x0003B158 File Offset: 0x00039358
	// Note: this type is marked as 'beforefieldinit'.
	static TutorialCallout()
	{
		Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialCallout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr);
		TutorialCallout.NativeFieldInfoPtr_m_CalloutType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutType");
		TutorialCallout.NativeFieldInfoPtr_m_CalloutIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutIndex");
		TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutInstanceType");
		TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutInstanceName");
		TutorialCallout.NativeFieldInfoPtr_m_CalloutBuildingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutBuildingIndex");
		TutorialCallout.NativeFieldInfoPtr_m_CalloutSortingLayerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, "m_CalloutSortingLayerName");
		TutorialCallout.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr, 100664085);
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x0003B214 File Offset: 0x00039414
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237505, XrefRangeEnd = 237506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialCallout(int calloutType, int calloutIndex, int calloutInstanceType = 0, string calloutInstanceName = "", int calloutBuildingIndex = 0, string calloutSortingLayerName = "")
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialCallout>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref calloutType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calloutIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calloutInstanceType;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(calloutInstanceName);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref calloutBuildingIndex;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(calloutSortingLayerName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialCallout.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00008DDE File Offset: 0x00006FDE
	public TutorialCallout(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003DE RID: 990
	// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0003B2AC File Offset: 0x000394AC
	// (set) Token: 0x06000B3D RID: 2877 RVA: 0x00008DE7 File Offset: 0x00006FE7
	public unsafe int m_CalloutType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutType)) = value;
		}
	}

	// Token: 0x170003DF RID: 991
	// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0003B2D4 File Offset: 0x000394D4
	// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00008E02 File Offset: 0x00007002
	public unsafe int m_CalloutIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutIndex)) = value;
		}
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0003B2FC File Offset: 0x000394FC
	// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00008E1D File Offset: 0x0000701D
	public unsafe int m_CalloutInstanceType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceType)) = value;
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0003B324 File Offset: 0x00039524
	// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00008E38 File Offset: 0x00007038
	public unsafe string m_CalloutInstanceName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutInstanceName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0003B34C File Offset: 0x0003954C
	// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00008E57 File Offset: 0x00007057
	public unsafe int m_CalloutBuildingIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutBuildingIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutBuildingIndex)) = value;
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0003B374 File Offset: 0x00039574
	// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00008E72 File Offset: 0x00007072
	public unsafe string m_CalloutSortingLayerName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutSortingLayerName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialCallout.NativeFieldInfoPtr_m_CalloutSortingLayerName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000707 RID: 1799
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutType;

	// Token: 0x04000708 RID: 1800
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutIndex;

	// Token: 0x04000709 RID: 1801
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutInstanceType;

	// Token: 0x0400070A RID: 1802
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutInstanceName;

	// Token: 0x0400070B RID: 1803
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutBuildingIndex;

	// Token: 0x0400070C RID: 1804
	private static readonly IntPtr NativeFieldInfoPtr_m_CalloutSortingLayerName;

	// Token: 0x0400070D RID: 1805
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_String_Int32_String_0;
}
