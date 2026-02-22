using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000078 RID: 120
public class GP_TBM_LoadMatchResult : GooglePlayResult
{
	// Token: 0x06000900 RID: 2304 RVA: 0x00035D4C File Offset: 0x00033F4C
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_LoadMatchResult()
	{
		Il2CppClassPointerStore<GP_TBM_LoadMatchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_LoadMatchResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_LoadMatchResult>.NativeClassPtr);
		GP_TBM_LoadMatchResult.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_LoadMatchResult>.NativeClassPtr, "Match");
		GP_TBM_LoadMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_LoadMatchResult>.NativeClassPtr, 100664380);
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00035DA4 File Offset: 0x00033FA4
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_LoadMatchResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_LoadMatchResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_LoadMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00005A0E File Offset: 0x00003C0E
	public GP_TBM_LoadMatchResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x06000903 RID: 2307 RVA: 0x00035DF0 File Offset: 0x00033FF0
	// (set) Token: 0x06000904 RID: 2308 RVA: 0x00005A17 File Offset: 0x00003C17
	public unsafe GP_TBM_Match Match
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LoadMatchResult.NativeFieldInfoPtr_Match);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_TBM_Match>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_LoadMatchResult.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400073B RID: 1851
	private static readonly IntPtr NativeFieldInfoPtr_Match;

	// Token: 0x0400073C RID: 1852
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
