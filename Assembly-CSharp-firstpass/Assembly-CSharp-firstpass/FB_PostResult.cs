using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200009A RID: 154
public class FB_PostResult : FB_Result
{
	// Token: 0x06000B3E RID: 2878 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
	// Note: this type is marked as 'beforefieldinit'.
	static FB_PostResult()
	{
		Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_PostResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr);
		FB_PostResult.NativeFieldInfoPtr__PostId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr, "_PostId");
		FB_PostResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr, 100664660);
		FB_PostResult.NativeMethodInfoPtr_get_PostId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr, 100664661);
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x0003E82C File Offset: 0x0003CA2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 174228, RefRangeEnd = 174230, XrefRangeStart = 174205, XrefRangeEnd = 174228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_PostResult(string RawData, string Error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_PostResult>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(RawData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(Error);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostResult.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0003E88C File Offset: 0x0003CA8C
	public unsafe string PostId
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_PostResult.NativeMethodInfoPtr_get_PostId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0000678D File Offset: 0x0000498D
	public FB_PostResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
	// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00006796 File Offset: 0x00004996
	public unsafe string _PostId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostResult.NativeFieldInfoPtr__PostId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_PostResult.NativeFieldInfoPtr__PostId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040008ED RID: 2285
	private static readonly IntPtr NativeFieldInfoPtr__PostId;

	// Token: 0x040008EE RID: 2286
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	// Token: 0x040008EF RID: 2287
	private static readonly IntPtr NativeMethodInfoPtr_get_PostId_Public_get_String_0;
}
