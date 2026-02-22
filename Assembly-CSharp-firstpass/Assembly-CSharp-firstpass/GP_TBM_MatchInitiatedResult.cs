using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000079 RID: 121
public class GP_TBM_MatchInitiatedResult : GooglePlayResult
{
	// Token: 0x06000905 RID: 2309 RVA: 0x00035E20 File Offset: 0x00034020
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_MatchInitiatedResult()
	{
		Il2CppClassPointerStore<GP_TBM_MatchInitiatedResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_MatchInitiatedResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_MatchInitiatedResult>.NativeClassPtr);
		GP_TBM_MatchInitiatedResult.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_MatchInitiatedResult>.NativeClassPtr, "Match");
		GP_TBM_MatchInitiatedResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_MatchInitiatedResult>.NativeClassPtr, 100664381);
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00035E78 File Offset: 0x00034078
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_MatchInitiatedResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_MatchInitiatedResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_MatchInitiatedResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00005A36 File Offset: 0x00003C36
	public GP_TBM_MatchInitiatedResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x06000908 RID: 2312 RVA: 0x00035EC4 File Offset: 0x000340C4
	// (set) Token: 0x06000909 RID: 2313 RVA: 0x00005A3F File Offset: 0x00003C3F
	public unsafe GP_TBM_Match Match
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_MatchInitiatedResult.NativeFieldInfoPtr_Match);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_TBM_Match>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_MatchInitiatedResult.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400073D RID: 1853
	private static readonly IntPtr NativeFieldInfoPtr_Match;

	// Token: 0x0400073E RID: 1854
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
