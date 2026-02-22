using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000057 RID: 87
public class GP_ScoreResult : GooglePlayResult
{
	// Token: 0x060006D4 RID: 1748 RVA: 0x0002E548 File Offset: 0x0002C748
	// Note: this type is marked as 'beforefieldinit'.
	static GP_ScoreResult()
	{
		Il2CppClassPointerStore<GP_ScoreResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_ScoreResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_ScoreResult>.NativeClassPtr);
		GP_ScoreResult.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_ScoreResult>.NativeClassPtr, "score");
		GP_ScoreResult.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_ScoreResult>.NativeClassPtr, 100664120);
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 163765, RefRangeEnd = 163780, XrefRangeStart = 163765, XrefRangeEnd = 163780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_ScoreResult(string code)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_ScoreResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_ScoreResult.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00004C84 File Offset: 0x00002E84
	public GP_ScoreResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000258 RID: 600
	// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002E5EC File Offset: 0x0002C7EC
	// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00004C8D File Offset: 0x00002E8D
	public unsafe GPScore score
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ScoreResult.NativeFieldInfoPtr_score);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GPScore>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_ScoreResult.NativeFieldInfoPtr_score), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000582 RID: 1410
	private static readonly IntPtr NativeFieldInfoPtr_score;

	// Token: 0x04000583 RID: 1411
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
