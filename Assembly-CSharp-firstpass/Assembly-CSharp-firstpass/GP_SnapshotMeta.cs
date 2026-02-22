using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200006D RID: 109
public class GP_SnapshotMeta : Object
{
	// Token: 0x06000855 RID: 2133 RVA: 0x000339A4 File Offset: 0x00031BA4
	// Note: this type is marked as 'beforefieldinit'.
	static GP_SnapshotMeta()
	{
		Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_SnapshotMeta");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr);
		GP_SnapshotMeta.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, "Title");
		GP_SnapshotMeta.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, "Description");
		GP_SnapshotMeta.NativeFieldInfoPtr_CoverImageUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, "CoverImageUrl");
		GP_SnapshotMeta.NativeFieldInfoPtr_LastModifiedTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, "LastModifiedTimestamp");
		GP_SnapshotMeta.NativeFieldInfoPtr_TotalPlayedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, "TotalPlayedTime");
		GP_SnapshotMeta.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr, 100664305);
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x00033A4C File Offset: 0x00031C4C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_SnapshotMeta()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_SnapshotMeta>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SnapshotMeta.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0000558E File Offset: 0x0000378E
	public GP_SnapshotMeta(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06000858 RID: 2136 RVA: 0x00033A88 File Offset: 0x00031C88
	// (set) Token: 0x06000859 RID: 2137 RVA: 0x00005597 File Offset: 0x00003797
	public unsafe string Title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_Title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x0600085A RID: 2138 RVA: 0x00033AB0 File Offset: 0x00031CB0
	// (set) Token: 0x0600085B RID: 2139 RVA: 0x000055B6 File Offset: 0x000037B6
	public unsafe string Description
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_Description);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x0600085C RID: 2140 RVA: 0x00033AD8 File Offset: 0x00031CD8
	// (set) Token: 0x0600085D RID: 2141 RVA: 0x000055D5 File Offset: 0x000037D5
	public unsafe string CoverImageUrl
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_CoverImageUrl);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_CoverImageUrl), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600085E RID: 2142 RVA: 0x00033B00 File Offset: 0x00031D00
	// (set) Token: 0x0600085F RID: 2143 RVA: 0x000055F4 File Offset: 0x000037F4
	public unsafe long LastModifiedTimestamp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_LastModifiedTimestamp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_LastModifiedTimestamp)) = value;
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x06000860 RID: 2144 RVA: 0x00033B28 File Offset: 0x00031D28
	// (set) Token: 0x06000861 RID: 2145 RVA: 0x0000560F File Offset: 0x0000380F
	public unsafe long TotalPlayedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_TotalPlayedTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotMeta.NativeFieldInfoPtr_TotalPlayedTime)) = value;
		}
	}

	// Token: 0x040006B3 RID: 1715
	private static readonly IntPtr NativeFieldInfoPtr_Title;

	// Token: 0x040006B4 RID: 1716
	private static readonly IntPtr NativeFieldInfoPtr_Description;

	// Token: 0x040006B5 RID: 1717
	private static readonly IntPtr NativeFieldInfoPtr_CoverImageUrl;

	// Token: 0x040006B6 RID: 1718
	private static readonly IntPtr NativeFieldInfoPtr_LastModifiedTimestamp;

	// Token: 0x040006B7 RID: 1719
	private static readonly IntPtr NativeFieldInfoPtr_TotalPlayedTime;

	// Token: 0x040006B8 RID: 1720
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
