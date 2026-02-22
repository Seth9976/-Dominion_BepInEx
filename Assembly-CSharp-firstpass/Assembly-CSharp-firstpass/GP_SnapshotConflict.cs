using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200004D RID: 77
public class GP_SnapshotConflict : Object
{
	// Token: 0x06000676 RID: 1654 RVA: 0x0002D180 File Offset: 0x0002B380
	// Note: this type is marked as 'beforefieldinit'.
	static GP_SnapshotConflict()
	{
		Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_SnapshotConflict");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr);
		GP_SnapshotConflict.NativeFieldInfoPtr__s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, "_s1");
		GP_SnapshotConflict.NativeFieldInfoPtr__s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, "_s2");
		GP_SnapshotConflict.NativeMethodInfoPtr__ctor_Public_Void_GP_Snapshot_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, 100664080);
		GP_SnapshotConflict.NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, 100664081);
		GP_SnapshotConflict.NativeMethodInfoPtr_get_ConflictingSnapshot_Public_get_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, 100664082);
		GP_SnapshotConflict.NativeMethodInfoPtr_Resolve_Public_Void_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr, 100664083);
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x0002D228 File Offset: 0x0002B428
	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_SnapshotConflict(GP_Snapshot s1, GP_Snapshot s2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_SnapshotConflict>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s1);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s2);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SnapshotConflict.NativeMethodInfoPtr__ctor_Public_Void_GP_Snapshot_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06000678 RID: 1656 RVA: 0x0002D288 File Offset: 0x0002B488
	public unsafe GP_Snapshot Snapshot
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SnapshotConflict.NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr3) : null;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06000679 RID: 1657 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
	public unsafe GP_Snapshot ConflictingSnapshot
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SnapshotConflict.NativeMethodInfoPtr_get_ConflictingSnapshot_Public_get_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr3) : null;
		}
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x0002D308 File Offset: 0x0002B508
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166613, RefRangeEnd = 166614, XrefRangeStart = 166610, XrefRangeEnd = 166613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resolve(GP_Snapshot snapshot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(snapshot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SnapshotConflict.NativeMethodInfoPtr_Resolve_Public_Void_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00004A47 File Offset: 0x00002C47
	public GP_SnapshotConflict(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700022F RID: 559
	// (get) Token: 0x0600067C RID: 1660 RVA: 0x0002D34C File Offset: 0x0002B54C
	// (set) Token: 0x0600067D RID: 1661 RVA: 0x00004A50 File Offset: 0x00002C50
	public unsafe GP_Snapshot _s1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotConflict.NativeFieldInfoPtr__s1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotConflict.NativeFieldInfoPtr__s1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x0600067E RID: 1662 RVA: 0x0002D37C File Offset: 0x0002B57C
	// (set) Token: 0x0600067F RID: 1663 RVA: 0x00004A6F File Offset: 0x00002C6F
	public unsafe GP_Snapshot _s2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotConflict.NativeFieldInfoPtr__s2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SnapshotConflict.NativeFieldInfoPtr__s2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000549 RID: 1353
	private static readonly IntPtr NativeFieldInfoPtr__s1;

	// Token: 0x0400054A RID: 1354
	private static readonly IntPtr NativeFieldInfoPtr__s2;

	// Token: 0x0400054B RID: 1355
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GP_Snapshot_GP_Snapshot_0;

	// Token: 0x0400054C RID: 1356
	private static readonly IntPtr NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0;

	// Token: 0x0400054D RID: 1357
	private static readonly IntPtr NativeMethodInfoPtr_get_ConflictingSnapshot_Public_get_GP_Snapshot_0;

	// Token: 0x0400054E RID: 1358
	private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Void_GP_Snapshot_0;
}
