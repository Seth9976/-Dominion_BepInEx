using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200009B RID: 155
public class FB_Result : Object
{
	// Token: 0x06000B44 RID: 2884 RVA: 0x0003E8EC File Offset: 0x0003CAEC
	// Note: this type is marked as 'beforefieldinit'.
	static FB_Result()
	{
		Il2CppClassPointerStore<FB_Result>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_Result");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_Result>.NativeClassPtr);
		FB_Result.NativeFieldInfoPtr__RawData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, "_RawData");
		FB_Result.NativeFieldInfoPtr__Error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, "_Error");
		FB_Result.NativeFieldInfoPtr__IsSucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, "_IsSucceeded");
		FB_Result.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, 100664662);
		FB_Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, 100664663);
		FB_Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, 100664664);
		FB_Result.NativeMethodInfoPtr_get_RawData_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, 100664665);
		FB_Result.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_Result>.NativeClassPtr, 100664666);
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0003E9BC File Offset: 0x0003CBBC
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 174236, RefRangeEnd = 174245, XrefRangeStart = 174230, XrefRangeEnd = 174236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_Result(string RawData, string Error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_Result>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RawData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Result.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0003EA1C File Offset: 0x0003CC1C
	public unsafe bool IsSucceeded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Result.NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0003EA58 File Offset: 0x0003CC58
	public unsafe bool IsFailed
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 174245, RefRangeEnd = 174253, XrefRangeStart = 174245, XrefRangeEnd = 174245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Result.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0003EA94 File Offset: 0x0003CC94
	public unsafe string RawData
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Result.NativeMethodInfoPtr_get_RawData_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0003EACC File Offset: 0x0003CCCC
	public unsafe string Error
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_Result.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000B4A RID: 2890 RVA: 0x000067B5 File Offset: 0x000049B5
	public FB_Result(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0003EB04 File Offset: 0x0003CD04
	// (set) Token: 0x06000B4C RID: 2892 RVA: 0x000067BE File Offset: 0x000049BE
	public unsafe string _RawData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__RawData);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__RawData), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700039A RID: 922
	// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0003EB2C File Offset: 0x0003CD2C
	// (set) Token: 0x06000B4E RID: 2894 RVA: 0x000067DD File Offset: 0x000049DD
	public unsafe string _Error
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__Error);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__Error), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0003EB54 File Offset: 0x0003CD54
	// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000067FC File Offset: 0x000049FC
	public unsafe bool _IsSucceeded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__IsSucceeded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_Result.NativeFieldInfoPtr__IsSucceeded)) = value;
		}
	}

	// Token: 0x040008F0 RID: 2288
	private static readonly IntPtr NativeFieldInfoPtr__RawData;

	// Token: 0x040008F1 RID: 2289
	private static readonly IntPtr NativeFieldInfoPtr__Error;

	// Token: 0x040008F2 RID: 2290
	private static readonly IntPtr NativeFieldInfoPtr__IsSucceeded;

	// Token: 0x040008F3 RID: 2291
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x040008F4 RID: 2292
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSucceeded_Public_get_Boolean_0;

	// Token: 0x040008F5 RID: 2293
	private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;

	// Token: 0x040008F6 RID: 2294
	private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_get_String_0;

	// Token: 0x040008F7 RID: 2295
	private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;
}
