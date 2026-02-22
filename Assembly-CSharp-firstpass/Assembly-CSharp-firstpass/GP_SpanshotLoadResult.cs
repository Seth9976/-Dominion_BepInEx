using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000058 RID: 88
public class GP_SpanshotLoadResult : GooglePlayResult
{
	// Token: 0x060006D9 RID: 1753 RVA: 0x0002E61C File Offset: 0x0002C81C
	// Note: this type is marked as 'beforefieldinit'.
	static GP_SpanshotLoadResult()
	{
		Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_SpanshotLoadResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr);
		GP_SpanshotLoadResult.NativeFieldInfoPtr__snapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr, "_snapshot");
		GP_SpanshotLoadResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr, 100664121);
		GP_SpanshotLoadResult.NativeMethodInfoPtr_SetSnapShot_Public_Void_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr, 100664122);
		GP_SpanshotLoadResult.NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr, 100664123);
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002E69C File Offset: 0x0002C89C
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_SpanshotLoadResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_SpanshotLoadResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SpanshotLoadResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0002E6E8 File Offset: 0x0002C8E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSnapShot(GP_Snapshot s)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SpanshotLoadResult.NativeMethodInfoPtr_SetSnapShot_Public_Void_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x060006DC RID: 1756 RVA: 0x0002E72C File Offset: 0x0002C92C
	public unsafe GP_Snapshot Snapshot
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_SpanshotLoadResult.NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr3) : null;
		}
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00004CAC File Offset: 0x00002EAC
	public GP_SpanshotLoadResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000259 RID: 601
	// (get) Token: 0x060006DE RID: 1758 RVA: 0x0002E76C File Offset: 0x0002C96C
	// (set) Token: 0x060006DF RID: 1759 RVA: 0x00004CB5 File Offset: 0x00002EB5
	public unsafe GP_Snapshot _snapshot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SpanshotLoadResult.NativeFieldInfoPtr__snapshot);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_Snapshot>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_SpanshotLoadResult.NativeFieldInfoPtr__snapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000584 RID: 1412
	private static readonly IntPtr NativeFieldInfoPtr__snapshot;

	// Token: 0x04000585 RID: 1413
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000586 RID: 1414
	private static readonly IntPtr NativeMethodInfoPtr_SetSnapShot_Public_Void_GP_Snapshot_0;

	// Token: 0x04000587 RID: 1415
	private static readonly IntPtr NativeMethodInfoPtr_get_Snapshot_Public_get_GP_Snapshot_0;
}
