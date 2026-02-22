using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

// Token: 0x02000019 RID: 25
public class AscensionCardCount : CardOverlay
{
	// Token: 0x06000414 RID: 1044 RVA: 0x0002654C File Offset: 0x0002474C
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCardCount()
	{
		Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCardCount");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr);
		AscensionCardCount.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr, "m_text");
		AscensionCardCount.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr, 100663579);
		AscensionCardCount.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr, 100663580);
		AscensionCardCount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr, 100663581);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x000265CC File Offset: 0x000247CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227625, XrefRangeEnd = 227629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetData(int data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCardCount.NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00026618 File Offset: 0x00024818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227629, XrefRangeEnd = 227630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardCount.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x0002665C File Offset: 0x0002485C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardCount()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCardCount>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardCount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00004558 File Offset: 0x00002758
	public AscensionCardCount(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000419 RID: 1049 RVA: 0x00026698 File Offset: 0x00024898
	// (set) Token: 0x0600041A RID: 1050 RVA: 0x00004561 File Offset: 0x00002761
	public unsafe TextMeshProUGUI m_text
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardCount.NativeFieldInfoPtr_m_text);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardCount.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400028F RID: 655
	private static readonly IntPtr NativeFieldInfoPtr_m_text;

	// Token: 0x04000290 RID: 656
	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Virtual_Void_Int32_0;

	// Token: 0x04000291 RID: 657
	private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

	// Token: 0x04000292 RID: 658
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
