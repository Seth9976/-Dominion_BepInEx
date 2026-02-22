using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000075 RID: 117
public class GP_TBM_CancelMatchResult : GooglePlayResult
{
	// Token: 0x060008F1 RID: 2289 RVA: 0x00035AE0 File Offset: 0x00033CE0
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_CancelMatchResult()
	{
		Il2CppClassPointerStore<GP_TBM_CancelMatchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_CancelMatchResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_CancelMatchResult>.NativeClassPtr);
		GP_TBM_CancelMatchResult.NativeFieldInfoPtr_MatchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_CancelMatchResult>.NativeClassPtr, "MatchId");
		GP_TBM_CancelMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_CancelMatchResult>.NativeClassPtr, 100664377);
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00035B38 File Offset: 0x00033D38
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_CancelMatchResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_CancelMatchResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_CancelMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00005996 File Offset: 0x00003B96
	public GP_TBM_CancelMatchResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00035B84 File Offset: 0x00033D84
	// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0000599F File Offset: 0x00003B9F
	public unsafe string MatchId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_CancelMatchResult.NativeFieldInfoPtr_MatchId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_CancelMatchResult.NativeFieldInfoPtr_MatchId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000735 RID: 1845
	private static readonly IntPtr NativeFieldInfoPtr_MatchId;

	// Token: 0x04000736 RID: 1846
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
