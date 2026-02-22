using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200009D RID: 157
public class FB_PostingTask : AsyncTask
{
	// Token: 0x06000B5F RID: 2911 RVA: 0x0003EED8 File Offset: 0x0003D0D8
	// Note: this type is marked as 'beforefieldinit'.
	static FB_PostingTask()
	{
		Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_PostingTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr);
		FB_PostingTask.NativeFieldInfoPtr__toId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_toId");
		FB_PostingTask.NativeFieldInfoPtr__link = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_link");
		FB_PostingTask.NativeFieldInfoPtr__linkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_linkName");
		FB_PostingTask.NativeFieldInfoPtr__linkCaption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_linkCaption");
		FB_PostingTask.NativeFieldInfoPtr__linkDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_linkDescription");
		FB_PostingTask.NativeFieldInfoPtr__picture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_picture");
		FB_PostingTask.NativeFieldInfoPtr__actionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_actionName");
		FB_PostingTask.NativeFieldInfoPtr__actionLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_actionLink");
		FB_PostingTask.NativeFieldInfoPtr__reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, "_reference");
		FB_PostingTask.NativeMethodInfoPtr_Cretae_Public_Static_FB_PostingTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, 100664675);
		FB_PostingTask.NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, 100664676);
		FB_PostingTask.NativeMethodInfoPtr_OnFBInited_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, 100664677);
		FB_PostingTask.NativeMethodInfoPtr_OnFBAuth_Private_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, 100664678);
		FB_PostingTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr, 100664679);
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x0003F020 File Offset: 0x0003D220
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174358, RefRangeEnd = 174359, XrefRangeStart = 174348, XrefRangeEnd = 174358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FB_PostingTask Cretae()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostingTask.NativeMethodInfoPtr_Cretae_Public_Static_FB_PostingTask_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<FB_PostingTask>(intPtr3) : null;
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x0003F054 File Offset: 0x0003D254
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174380, RefRangeEnd = 174381, XrefRangeStart = 174359, XrefRangeEnd = 174380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FeedShare(string toId = "", string link = "", string linkName = "", string linkCaption = "", string linkDescription = "", string picture = "", string actionName = "", string actionLink = "", string reference = "")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(toId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(link);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkName);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkCaption);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkDescription);
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(picture);
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionName);
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionLink);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostingTask.NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x0003F130 File Offset: 0x0003D330
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174381, XrefRangeEnd = 174416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFBInited()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostingTask.NativeMethodInfoPtr_OnFBInited_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x0003F164 File Offset: 0x0003D364
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 174464, RefRangeEnd = 174465, XrefRangeStart = 174416, XrefRangeEnd = 174464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFBAuth(FB_Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostingTask.NativeMethodInfoPtr_OnFBAuth_Private_Void_FB_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174465, XrefRangeEnd = 174476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_PostingTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_PostingTask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostingTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x0000685E File Offset: 0x00004A5E
	public FB_PostingTask(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170003A3 RID: 931
	// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0003F1E4 File Offset: 0x0003D3E4
	// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00006867 File Offset: 0x00004A67
	public unsafe string _toId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__toId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__toId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A4 RID: 932
	// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0003F20C File Offset: 0x0003D40C
	// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00006886 File Offset: 0x00004A86
	public unsafe string _link
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__link);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__link), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A5 RID: 933
	// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0003F234 File Offset: 0x0003D434
	// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000068A5 File Offset: 0x00004AA5
	public unsafe string _linkName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0003F25C File Offset: 0x0003D45C
	// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000068C4 File Offset: 0x00004AC4
	public unsafe string _linkCaption
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkCaption);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkCaption), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0003F284 File Offset: 0x0003D484
	// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000068E3 File Offset: 0x00004AE3
	public unsafe string _linkDescription
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkDescription);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__linkDescription), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0003F2AC File Offset: 0x0003D4AC
	// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00006902 File Offset: 0x00004B02
	public unsafe string _picture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__picture);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__picture), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0003F2D4 File Offset: 0x0003D4D4
	// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00006921 File Offset: 0x00004B21
	public unsafe string _actionName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__actionName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__actionName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0003F2FC File Offset: 0x0003D4FC
	// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00006940 File Offset: 0x00004B40
	public unsafe string _actionLink
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__actionLink);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__actionLink), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003AB RID: 939
	// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0003F324 File Offset: 0x0003D524
	// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0000695F File Offset: 0x00004B5F
	public unsafe string _reference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__reference);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostingTask.NativeFieldInfoPtr__reference), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000902 RID: 2306
	private static readonly IntPtr NativeFieldInfoPtr__toId;

	// Token: 0x04000903 RID: 2307
	private static readonly IntPtr NativeFieldInfoPtr__link;

	// Token: 0x04000904 RID: 2308
	private static readonly IntPtr NativeFieldInfoPtr__linkName;

	// Token: 0x04000905 RID: 2309
	private static readonly IntPtr NativeFieldInfoPtr__linkCaption;

	// Token: 0x04000906 RID: 2310
	private static readonly IntPtr NativeFieldInfoPtr__linkDescription;

	// Token: 0x04000907 RID: 2311
	private static readonly IntPtr NativeFieldInfoPtr__picture;

	// Token: 0x04000908 RID: 2312
	private static readonly IntPtr NativeFieldInfoPtr__actionName;

	// Token: 0x04000909 RID: 2313
	private static readonly IntPtr NativeFieldInfoPtr__actionLink;

	// Token: 0x0400090A RID: 2314
	private static readonly IntPtr NativeFieldInfoPtr__reference;

	// Token: 0x0400090B RID: 2315
	private static readonly IntPtr NativeMethodInfoPtr_Cretae_Public_Static_FB_PostingTask_0;

	// Token: 0x0400090C RID: 2316
	private static readonly IntPtr NativeMethodInfoPtr_FeedShare_Public_Void_String_String_String_String_String_String_String_String_String_0;

	// Token: 0x0400090D RID: 2317
	private static readonly IntPtr NativeMethodInfoPtr_OnFBInited_Private_Void_0;

	// Token: 0x0400090E RID: 2318
	private static readonly IntPtr NativeMethodInfoPtr_OnFBAuth_Private_Void_FB_Result_0;

	// Token: 0x0400090F RID: 2319
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
