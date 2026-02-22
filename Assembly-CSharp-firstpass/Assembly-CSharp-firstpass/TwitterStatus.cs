using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x020000A8 RID: 168
public class TwitterStatus : Object
{
	// Token: 0x06000C31 RID: 3121 RVA: 0x00041A80 File Offset: 0x0003FC80
	// Note: this type is marked as 'beforefieldinit'.
	static TwitterStatus()
	{
		Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TwitterStatus");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr);
		TwitterStatus.NativeFieldInfoPtr__rawJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, "_rawJSON");
		TwitterStatus.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, "_text");
		TwitterStatus.NativeFieldInfoPtr__geo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, "_geo");
		TwitterStatus.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, 100664763);
		TwitterStatus.NativeMethodInfoPtr_get_rawJSON_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, 100664764);
		TwitterStatus.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, 100664765);
		TwitterStatus.NativeMethodInfoPtr_get_geo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr, 100664766);
	}

	// Token: 0x06000C32 RID: 3122 RVA: 0x00041B3C File Offset: 0x0003FD3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175124, XrefRangeEnd = 175140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TwitterStatus(IDictionary JSON)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwitterStatus>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(JSON);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterStatus.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170003E3 RID: 995
	// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00041B88 File Offset: 0x0003FD88
	public unsafe string rawJSON
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterStatus.NativeMethodInfoPtr_get_rawJSON_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003E4 RID: 996
	// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00041BC0 File Offset: 0x0003FDC0
	public unsafe string text
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterStatus.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x170003E5 RID: 997
	// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00041BF8 File Offset: 0x0003FDF8
	public unsafe string geo
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwitterStatus.NativeMethodInfoPtr_get_geo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000C36 RID: 3126 RVA: 0x00006E31 File Offset: 0x00005031
	public TwitterStatus(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003E0 RID: 992
	// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00041C30 File Offset: 0x0003FE30
	// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00006E3A File Offset: 0x0000503A
	public unsafe string _rawJSON
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__rawJSON);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__rawJSON), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003E1 RID: 993
	// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00041C58 File Offset: 0x0003FE58
	// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00006E59 File Offset: 0x00005059
	public unsafe string _text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__text);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__text), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003E2 RID: 994
	// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00041C80 File Offset: 0x0003FE80
	// (set) Token: 0x06000C3C RID: 3132 RVA: 0x00006E78 File Offset: 0x00005078
	public unsafe string _geo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__geo);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwitterStatus.NativeFieldInfoPtr__geo), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000992 RID: 2450
	private static readonly IntPtr NativeFieldInfoPtr__rawJSON;

	// Token: 0x04000993 RID: 2451
	private static readonly IntPtr NativeFieldInfoPtr__text;

	// Token: 0x04000994 RID: 2452
	private static readonly IntPtr NativeFieldInfoPtr__geo;

	// Token: 0x04000995 RID: 2453
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_0;

	// Token: 0x04000996 RID: 2454
	private static readonly IntPtr NativeMethodInfoPtr_get_rawJSON_Public_get_String_0;

	// Token: 0x04000997 RID: 2455
	private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	// Token: 0x04000998 RID: 2456
	private static readonly IntPtr NativeMethodInfoPtr_get_geo_Public_get_String_0;
}
