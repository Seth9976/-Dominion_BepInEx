using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000100 RID: 256
public class SA_Label : MonoBehaviour
{
	// Token: 0x060011AE RID: 4526 RVA: 0x00054A34 File Offset: 0x00052C34
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Label()
	{
		Il2CppClassPointerStore<SA_Label>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_Label");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Label>.NativeClassPtr);
		SA_Label.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Label>.NativeClassPtr, 100665445);
		SA_Label.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Label>.NativeClassPtr, 100665446);
		SA_Label.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Label>.NativeClassPtr, 100665447);
	}

	// Token: 0x1700053C RID: 1340
	// (get) Token: 0x060011AF RID: 4527 RVA: 0x00054AA0 File Offset: 0x00052CA0
	// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00054AD8 File Offset: 0x00052CD8
	public unsafe string text
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181911, XrefRangeEnd = 181926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Label.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 181940, RefRangeEnd = 181973, XrefRangeStart = 181926, XrefRangeEnd = 181940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Label.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00054B1C File Offset: 0x00052D1C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_Label()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Label>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Label.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00008D01 File Offset: 0x00006F01
	public SA_Label(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000DA9 RID: 3497
	private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	// Token: 0x04000DAA RID: 3498
	private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	// Token: 0x04000DAB RID: 3499
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
