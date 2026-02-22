using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x0200007A RID: 122
public class GP_TBM_MatchRemovedResult : Object
{
	// Token: 0x0600090A RID: 2314 RVA: 0x00035EF4 File Offset: 0x000340F4
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_MatchRemovedResult()
	{
		Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_MatchRemovedResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr);
		GP_TBM_MatchRemovedResult.NativeFieldInfoPtr__MatchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr, "_MatchId");
		GP_TBM_MatchRemovedResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr, 100664382);
		GP_TBM_MatchRemovedResult.NativeMethodInfoPtr_get_MatchId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr, 100664383);
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x00035F60 File Offset: 0x00034160
	[CallerCount(50)]
	[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_MatchRemovedResult(string mId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_MatchRemovedResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_MatchRemovedResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x0600090C RID: 2316 RVA: 0x00035FAC File Offset: 0x000341AC
	public unsafe string MatchId
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_MatchRemovedResult.NativeMethodInfoPtr_get_MatchId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00005A5E File Offset: 0x00003C5E
	public GP_TBM_MatchRemovedResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x0600090E RID: 2318 RVA: 0x00035FE4 File Offset: 0x000341E4
	// (set) Token: 0x0600090F RID: 2319 RVA: 0x00005A67 File Offset: 0x00003C67
	public unsafe string _MatchId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_MatchRemovedResult.NativeFieldInfoPtr__MatchId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_MatchRemovedResult.NativeFieldInfoPtr__MatchId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400073F RID: 1855
	private static readonly IntPtr NativeFieldInfoPtr__MatchId;

	// Token: 0x04000740 RID: 1856
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	// Token: 0x04000741 RID: 1857
	private static readonly IntPtr NativeMethodInfoPtr_get_MatchId_Public_get_String_0;
}
