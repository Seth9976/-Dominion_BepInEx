using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000092 RID: 146
public class FB_LikeInfo : Object
{
	// Token: 0x06000AB1 RID: 2737 RVA: 0x0003CC3C File Offset: 0x0003AE3C
	// Note: this type is marked as 'beforefieldinit'.
	static FB_LikeInfo()
	{
		Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FB_LikeInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr);
		FB_LikeInfo.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr, "Id");
		FB_LikeInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr, "Name");
		FB_LikeInfo.NativeFieldInfoPtr_CreatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr, "CreatedTime");
		FB_LikeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr, 100664609);
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x0003CCBC File Offset: 0x0003AEBC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FB_LikeInfo()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FB_LikeInfo>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FB_LikeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x000062CC File Offset: 0x000044CC
	public FB_LikeInfo(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
	// (set) Token: 0x06000AB5 RID: 2741 RVA: 0x000062D5 File Offset: 0x000044D5
	public unsafe string Id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_Id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0003CD20 File Offset: 0x0003AF20
	// (set) Token: 0x06000AB7 RID: 2743 RVA: 0x000062F4 File Offset: 0x000044F4
	public unsafe string Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0003CD48 File Offset: 0x0003AF48
	// (set) Token: 0x06000AB9 RID: 2745 RVA: 0x00006313 File Offset: 0x00004513
	public unsafe string CreatedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_CreatedTime);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FB_LikeInfo.NativeFieldInfoPtr_CreatedTime), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400088F RID: 2191
	private static readonly IntPtr NativeFieldInfoPtr_Id;

	// Token: 0x04000890 RID: 2192
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x04000891 RID: 2193
	private static readonly IntPtr NativeFieldInfoPtr_CreatedTime;

	// Token: 0x04000892 RID: 2194
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
