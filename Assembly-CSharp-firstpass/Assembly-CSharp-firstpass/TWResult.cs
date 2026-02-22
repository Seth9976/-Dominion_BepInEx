using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x020000AA RID: 170
public class TWResult : Object
{
	// Token: 0x06000C84 RID: 3204 RVA: 0x00042AF4 File Offset: 0x00040CF4
	// Note: this type is marked as 'beforefieldinit'.
	static TWResult()
	{
		Il2CppClassPointerStore<TWResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "TWResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TWResult>.NativeClassPtr);
		TWResult.NativeFieldInfoPtr__IsSucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TWResult>.NativeClassPtr, "_IsSucceeded");
		TWResult.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TWResult>.NativeClassPtr, "_data");
		TWResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWResult>.NativeClassPtr, 100664796);
		TWResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWResult>.NativeClassPtr, 100664797);
		TWResult.NativeMethodInfoPtr_get_data_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TWResult>.NativeClassPtr, 100664798);
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00042B88 File Offset: 0x00040D88
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 175479, RefRangeEnd = 175492, XrefRangeStart = 175476, XrefRangeEnd = 175479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TWResult(bool IsResSucceeded, string resData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TWResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsResSucceeded;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00042BE4 File Offset: 0x00040DE4
	public unsafe bool IsSucceeded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWResult.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00042C20 File Offset: 0x00040E20
	public unsafe string data
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TWResult.NativeMethodInfoPtr_get_data_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x000070FC File Offset: 0x000052FC
	public TWResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00042C58 File Offset: 0x00040E58
	// (set) Token: 0x06000C8A RID: 3210 RVA: 0x00007105 File Offset: 0x00005305
	public unsafe bool _IsSucceeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TWResult.NativeFieldInfoPtr__IsSucceeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TWResult.NativeFieldInfoPtr__IsSucceeded)) = value;
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x06000C8B RID: 3211 RVA: 0x00042C80 File Offset: 0x00040E80
	// (set) Token: 0x06000C8C RID: 3212 RVA: 0x00007120 File Offset: 0x00005320
	public unsafe string _data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TWResult.NativeFieldInfoPtr__data);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TWResult.NativeFieldInfoPtr__data), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040009CA RID: 2506
	private static readonly IntPtr NativeFieldInfoPtr__IsSucceeded;

	// Token: 0x040009CB RID: 2507
	private static readonly IntPtr NativeFieldInfoPtr__data;

	// Token: 0x040009CC RID: 2508
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

	// Token: 0x040009CD RID: 2509
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

	// Token: 0x040009CE RID: 2510
	private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_String_0;
}
