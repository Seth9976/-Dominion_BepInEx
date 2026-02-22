using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000091 RID: 145
public class FB_AppRequestResult : FB_Result
{
	// Token: 0x06000AA7 RID: 2727 RVA: 0x0003C9F4 File Offset: 0x0003ABF4
	// Note: this type is marked as 'beforefieldinit'.
	static FB_AppRequestResult()
	{
		Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_AppRequestResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr);
		FB_AppRequestResult.NativeFieldInfoPtr__ReuqestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, "_ReuqestId");
		FB_AppRequestResult.NativeFieldInfoPtr__Recipients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, "_Recipients");
		FB_AppRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, 100664605);
		FB_AppRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, 100664606);
		FB_AppRequestResult.NativeMethodInfoPtr_get_ReuqestId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, 100664607);
		FB_AppRequestResult.NativeMethodInfoPtr_get_Recipients_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr, 100664608);
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0003CA9C File Offset: 0x0003AC9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173598, RefRangeEnd = 173599, XrefRangeStart = 173529, XrefRangeEnd = 173598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_AppRequestResult(string RawData, string Error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RawData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x0003CAFC File Offset: 0x0003ACFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 173608, RefRangeEnd = 173609, XrefRangeStart = 173599, XrefRangeEnd = 173608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_AppRequestResult(string requestId, List<string> _recipients, string RawData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_AppRequestResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(requestId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_recipients);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(RawData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequestResult.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0003CB6C File Offset: 0x0003AD6C
	public unsafe string ReuqestId
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequestResult.NativeMethodInfoPtr_get_ReuqestId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0003CBA4 File Offset: 0x0003ADA4
	public unsafe List<string> Recipients
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_AppRequestResult.NativeMethodInfoPtr_get_Recipients_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00006285 File Offset: 0x00004485
	public FB_AppRequestResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0003CBE4 File Offset: 0x0003ADE4
	// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000628E File Offset: 0x0000448E
	public unsafe string _ReuqestId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequestResult.NativeFieldInfoPtr__ReuqestId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequestResult.NativeFieldInfoPtr__ReuqestId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0003CC0C File Offset: 0x0003AE0C
	// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x000062AD File Offset: 0x000044AD
	public unsafe List<string> _Recipients
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequestResult.NativeFieldInfoPtr__Recipients);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_AppRequestResult.NativeFieldInfoPtr__Recipients), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000889 RID: 2185
	private static readonly IntPtr NativeFieldInfoPtr__ReuqestId;

	// Token: 0x0400088A RID: 2186
	private static readonly IntPtr NativeFieldInfoPtr__Recipients;

	// Token: 0x0400088B RID: 2187
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x0400088C RID: 2188
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_String_0;

	// Token: 0x0400088D RID: 2189
	private static readonly IntPtr NativeMethodInfoPtr_get_ReuqestId_Public_get_String_0;

	// Token: 0x0400088E RID: 2190
	private static readonly IntPtr NativeMethodInfoPtr_get_Recipients_Public_get_List_1_String_0;
}
