using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x0200006E RID: 110
public class GP_DeleteSnapshotResult : GooglePlayResult
{
	// Token: 0x06000862 RID: 2146 RVA: 0x00033B50 File Offset: 0x00031D50
	// Note: this type is marked as 'beforefieldinit'.
	static GP_DeleteSnapshotResult()
	{
		Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_DeleteSnapshotResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr);
		GP_DeleteSnapshotResult.NativeFieldInfoPtr__SnapshotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr, "_SnapshotId");
		GP_DeleteSnapshotResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr, 100664306);
		GP_DeleteSnapshotResult.NativeMethodInfoPtr_SetId_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr, 100664307);
		GP_DeleteSnapshotResult.NativeMethodInfoPtr_get_SnapshotId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr, 100664308);
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00033BD0 File Offset: 0x00031DD0
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_DeleteSnapshotResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_DeleteSnapshotResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_DeleteSnapshotResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00033C1C File Offset: 0x00031E1C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetId(string sid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_DeleteSnapshotResult.NativeMethodInfoPtr_SetId_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06000865 RID: 2149 RVA: 0x00033C60 File Offset: 0x00031E60
	public unsafe string SnapshotId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_DeleteSnapshotResult.NativeMethodInfoPtr_get_SnapshotId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0000562A File Offset: 0x0000382A
	public GP_DeleteSnapshotResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06000867 RID: 2151 RVA: 0x00033C98 File Offset: 0x00031E98
	// (set) Token: 0x06000868 RID: 2152 RVA: 0x00005633 File Offset: 0x00003833
	public unsafe string _SnapshotId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_DeleteSnapshotResult.NativeFieldInfoPtr__SnapshotId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_DeleteSnapshotResult.NativeFieldInfoPtr__SnapshotId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040006B9 RID: 1721
	private static readonly IntPtr NativeFieldInfoPtr__SnapshotId;

	// Token: 0x040006BA RID: 1722
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x040006BB RID: 1723
	private static readonly IntPtr NativeMethodInfoPtr_SetId_Public_Void_String_0;

	// Token: 0x040006BC RID: 1724
	private static readonly IntPtr NativeMethodInfoPtr_get_SnapshotId_Public_get_String_0;
}
