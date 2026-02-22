using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200007B RID: 123
public class GP_TBM_UpdateMatchResult : GooglePlayResult
{
	// Token: 0x06000910 RID: 2320 RVA: 0x0003600C File Offset: 0x0003420C
	// Note: this type is marked as 'beforefieldinit'.
	static GP_TBM_UpdateMatchResult()
	{
		Il2CppClassPointerStore<GP_TBM_UpdateMatchResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_TBM_UpdateMatchResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_TBM_UpdateMatchResult>.NativeClassPtr);
		GP_TBM_UpdateMatchResult.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_TBM_UpdateMatchResult>.NativeClassPtr, "Match");
		GP_TBM_UpdateMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_TBM_UpdateMatchResult>.NativeClassPtr, 100664384);
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x00036064 File Offset: 0x00034264
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_TBM_UpdateMatchResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_TBM_UpdateMatchResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_TBM_UpdateMatchResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00005A86 File Offset: 0x00003C86
	public GP_TBM_UpdateMatchResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002EB RID: 747
	// (get) Token: 0x06000913 RID: 2323 RVA: 0x000360B0 File Offset: 0x000342B0
	// (set) Token: 0x06000914 RID: 2324 RVA: 0x00005A8F File Offset: 0x00003C8F
	public unsafe GP_TBM_Match Match
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_UpdateMatchResult.NativeFieldInfoPtr_Match);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_TBM_Match>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_TBM_UpdateMatchResult.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000742 RID: 1858
	private static readonly IntPtr NativeFieldInfoPtr_Match;

	// Token: 0x04000743 RID: 1859
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
