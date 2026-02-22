using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000045 RID: 69
public class TutorialSteps1 : Object
{
	// Token: 0x06000BAC RID: 2988 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
	// Note: this type is marked as 'beforefieldinit'.
	static TutorialSteps1()
	{
		Il2CppClassPointerStore<TutorialSteps1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TutorialSteps1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialSteps1>.NativeClassPtr);
		TutorialSteps1.NativeFieldInfoPtr_m_TutorialSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialSteps1>.NativeClassPtr, "m_TutorialSteps");
		TutorialSteps1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialSteps1>.NativeClassPtr, 100664103);
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x0003C2FC File Offset: 0x0003A4FC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TutorialSteps1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialSteps1>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialSteps1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x000091D4 File Offset: 0x000073D4
	public TutorialSteps1(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06000BAF RID: 2991 RVA: 0x0003C338 File Offset: 0x0003A538
	// (set) Token: 0x06000BB0 RID: 2992 RVA: 0x000091DD File Offset: 0x000073DD
	public unsafe static Il2CppReferenceArray<TutorialStep> m_TutorialSteps
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(TutorialSteps1.NativeFieldInfoPtr_m_TutorialSteps, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialStep>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(TutorialSteps1.NativeFieldInfoPtr_m_TutorialSteps, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000745 RID: 1861
	private static readonly IntPtr NativeFieldInfoPtr_m_TutorialSteps;

	// Token: 0x04000746 RID: 1862
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
