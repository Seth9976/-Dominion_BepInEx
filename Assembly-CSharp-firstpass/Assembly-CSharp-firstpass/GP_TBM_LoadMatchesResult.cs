using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000077 RID: 119
public class GP_TBM_LoadMatchesResult : GooglePlayResult
{
	// Token: 0x060008FB RID: 2299 RVA: 0x00035C78 File Offset: 0x00033E78
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_LoadMatchesResult()
	{
		Il2CppClassPointerStore<GP_TBM_LoadMatchesResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_LoadMatchesResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_LoadMatchesResult>.NativeClassPtr);
		GP_TBM_LoadMatchesResult.NativeFieldInfoPtr_LoadedMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_LoadMatchesResult>.NativeClassPtr, "LoadedMatches");
		GP_TBM_LoadMatchesResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_LoadMatchesResult>.NativeClassPtr, 100664379);
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00035CD0 File Offset: 0x00033ED0
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_LoadMatchesResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_LoadMatchesResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_LoadMatchesResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x000059E6 File Offset: 0x00003BE6
	public GP_TBM_LoadMatchesResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x060008FE RID: 2302 RVA: 0x00035D1C File Offset: 0x00033F1C
	// (set) Token: 0x060008FF RID: 2303 RVA: 0x000059EF File Offset: 0x00003BEF
	public unsafe Dictionary<string, GP_TBM_Match> LoadedMatches
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LoadMatchesResult.NativeFieldInfoPtr_LoadedMatches);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GP_TBM_Match>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LoadMatchesResult.NativeFieldInfoPtr_LoadedMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000739 RID: 1849
	private static readonly IntPtr NativeFieldInfoPtr_LoadedMatches;

	// Token: 0x0400073A RID: 1850
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
