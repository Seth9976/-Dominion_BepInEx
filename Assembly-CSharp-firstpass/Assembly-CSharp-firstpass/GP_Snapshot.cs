using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200006C RID: 108
public class GP_Snapshot : Object
{
	// Token: 0x0600084C RID: 2124 RVA: 0x00033860 File Offset: 0x00031A60
	// Note: this type is marked as 'beforefieldinit'.
	static GP_Snapshot()
	{
		Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_Snapshot");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr);
		GP_Snapshot.NativeFieldInfoPtr_meta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr, "meta");
		GP_Snapshot.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr, "bytes");
		GP_Snapshot.NativeFieldInfoPtr_stringData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr, "stringData");
		GP_Snapshot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr, 100664304);
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x000338E0 File Offset: 0x00031AE0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 169277, RefRangeEnd = 169281, XrefRangeStart = 169272, XrefRangeEnd = 169277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_Snapshot()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_Snapshot>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_Snapshot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x00005528 File Offset: 0x00003728
	public GP_Snapshot(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x0600084F RID: 2127 RVA: 0x0003391C File Offset: 0x00031B1C
	// (set) Token: 0x06000850 RID: 2128 RVA: 0x00005531 File Offset: 0x00003731
	public unsafe GP_SnapshotMeta meta
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_meta);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_SnapshotMeta>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_meta), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06000851 RID: 2129 RVA: 0x0003394C File Offset: 0x00031B4C
	// (set) Token: 0x06000852 RID: 2130 RVA: 0x00005550 File Offset: 0x00003750
	public unsafe Il2CppStructArray<byte> bytes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_bytes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06000853 RID: 2131 RVA: 0x0003397C File Offset: 0x00031B7C
	// (set) Token: 0x06000854 RID: 2132 RVA: 0x0000556F File Offset: 0x0000376F
	public unsafe string stringData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_stringData);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_Snapshot.NativeFieldInfoPtr_stringData), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040006AF RID: 1711
	private static readonly IntPtr NativeFieldInfoPtr_meta;

	// Token: 0x040006B0 RID: 1712
	private static readonly IntPtr NativeFieldInfoPtr_bytes;

	// Token: 0x040006B1 RID: 1713
	private static readonly IntPtr NativeFieldInfoPtr_stringData;

	// Token: 0x040006B2 RID: 1714
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
