using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200008F RID: 143
public class FB_AppInviteResult : FB_Result
{
	// Token: 0x06000A80 RID: 2688 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
	// Note: this type is marked as 'beforefieldinit'.
	static FB_AppInviteResult()
	{
		Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_AppInviteResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr);
		FB_AppInviteResult.NativeFieldInfoPtr__cancelled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr, "_cancelled");
		FB_AppInviteResult.NativeFieldInfoPtr__resultDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr, "_resultDictionary");
		FB_AppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr, 100664598);
		FB_AppInviteResult.NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr, 100664599);
		FB_AppInviteResult.NativeMethodInfoPtr_get_ResultDictionary_Public_get_IDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr, 100664600);
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x0003C448 File Offset: 0x0003A648
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173483, XrefRangeEnd = 173484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_AppInviteResult(bool cancelled, string RawData, string Error, IDictionary<string, Object> dict)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_AppInviteResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref cancelled;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(RawData);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dict);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppInviteResult.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_IDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0003C4C8 File Offset: 0x0003A6C8
	public unsafe bool Cancelled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppInviteResult.NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0003C504 File Offset: 0x0003A704
	public unsafe IDictionary<string, Object> ResultDictionary
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppInviteResult.NativeMethodInfoPtr_get_ResultDictionary_Public_get_IDictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr3) : null;
		}
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x000060D1 File Offset: 0x000042D1
	public FB_AppInviteResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0003C544 File Offset: 0x0003A744
	// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000060DA File Offset: 0x000042DA
	public unsafe bool _cancelled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppInviteResult.NativeFieldInfoPtr__cancelled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppInviteResult.NativeFieldInfoPtr__cancelled)) = value;
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0003C56C File Offset: 0x0003A76C
	// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000060F5 File Offset: 0x000042F5
	public unsafe IDictionary<string, Object> _resultDictionary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppInviteResult.NativeFieldInfoPtr__resultDictionary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppInviteResult.NativeFieldInfoPtr__resultDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000874 RID: 2164
	private static readonly IntPtr NativeFieldInfoPtr__cancelled;

	// Token: 0x04000875 RID: 2165
	private static readonly IntPtr NativeFieldInfoPtr__resultDictionary;

	// Token: 0x04000876 RID: 2166
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_IDictionary_2_String_Object_0;

	// Token: 0x04000877 RID: 2167
	private static readonly IntPtr NativeMethodInfoPtr_get_Cancelled_Public_get_Boolean_0;

	// Token: 0x04000878 RID: 2168
	private static readonly IntPtr NativeMethodInfoPtr_get_ResultDictionary_Public_get_IDictionary_2_String_Object_0;
}
