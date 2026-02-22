using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000076 RID: 118
public class GP_TBM_LeaveMatchResult : GooglePlayResult
{
	// Token: 0x060008F6 RID: 2294 RVA: 0x00035BAC File Offset: 0x00033DAC
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_LeaveMatchResult()
	{
		Il2CppClassPointerStore<GP_TBM_LeaveMatchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_LeaveMatchResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_LeaveMatchResult>.NativeClassPtr);
		GP_TBM_LeaveMatchResult.NativeFieldInfoPtr_MatchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_LeaveMatchResult>.NativeClassPtr, "MatchId");
		GP_TBM_LeaveMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_LeaveMatchResult>.NativeClassPtr, 100664378);
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00035C04 File Offset: 0x00033E04
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_LeaveMatchResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_LeaveMatchResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_LeaveMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x000059BE File Offset: 0x00003BBE
	public GP_TBM_LeaveMatchResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00035C50 File Offset: 0x00033E50
	// (set) Token: 0x060008FA RID: 2298 RVA: 0x000059C7 File Offset: 0x00003BC7
	public unsafe string MatchId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LeaveMatchResult.NativeFieldInfoPtr_MatchId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LeaveMatchResult.NativeFieldInfoPtr_MatchId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000737 RID: 1847
	private static readonly IntPtr NativeFieldInfoPtr_MatchId;

	// Token: 0x04000738 RID: 1848
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
