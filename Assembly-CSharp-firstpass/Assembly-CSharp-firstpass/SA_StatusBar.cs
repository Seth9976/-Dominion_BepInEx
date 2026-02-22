using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000102 RID: 258
public class SA_StatusBar : MonoBehaviour
{
	// Token: 0x060011C4 RID: 4548 RVA: 0x00054E10 File Offset: 0x00053010
	// Note: this type is marked as 'beforefieldinit'.
	static SA_StatusBar()
	{
		Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_StatusBar");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr);
		SA_StatusBar.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, "title");
		SA_StatusBar.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, "shadow");
		SA_StatusBar.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, 100665451);
		SA_StatusBar.NativeMethodInfoPtr_get_text_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, 100665452);
		SA_StatusBar.NativeMethodInfoPtr_set_text_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, 100665453);
		SA_StatusBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr, 100665454);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x00054EB8 File Offset: 0x000530B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182030, XrefRangeEnd = 182033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetText(string text)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StatusBar.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000545 RID: 1349
	// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00054EFC File Offset: 0x000530FC
	// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00054F28 File Offset: 0x00053128
	public unsafe static string text
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182043, RefRangeEnd = 182044, XrefRangeStart = 182033, XrefRangeEnd = 182043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StatusBar.NativeMethodInfoPtr_get_text_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(107)]
		[CachedScanResults(RefRangeStart = 182053, RefRangeEnd = 182160, XrefRangeStart = 182044, XrefRangeEnd = 182053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StatusBar.NativeMethodInfoPtr_set_text_Public_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x00054F60 File Offset: 0x00053160
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_StatusBar()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_StatusBar>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_StatusBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x00008DCD File Offset: 0x00006FCD
	public SA_StatusBar(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000543 RID: 1347
	// (get) Token: 0x060011CA RID: 4554 RVA: 0x00054F9C File Offset: 0x0005319C
	// (set) Token: 0x060011CB RID: 4555 RVA: 0x00008DD6 File Offset: 0x00006FD6
	public unsafe TextMesh title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_StatusBar.NativeFieldInfoPtr_title);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_StatusBar.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000544 RID: 1348
	// (get) Token: 0x060011CC RID: 4556 RVA: 0x00054FCC File Offset: 0x000531CC
	// (set) Token: 0x060011CD RID: 4557 RVA: 0x00008DF5 File Offset: 0x00006FF5
	public unsafe TextMesh shadow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_StatusBar.NativeFieldInfoPtr_shadow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMesh>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_StatusBar.NativeFieldInfoPtr_shadow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000DB5 RID: 3509
	private static readonly IntPtr NativeFieldInfoPtr_title;

	// Token: 0x04000DB6 RID: 3510
	private static readonly IntPtr NativeFieldInfoPtr_shadow;

	// Token: 0x04000DB7 RID: 3511
	private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

	// Token: 0x04000DB8 RID: 3512
	private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_Static_get_String_0;

	// Token: 0x04000DB9 RID: 3513
	private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_Static_set_Void_String_0;

	// Token: 0x04000DBA RID: 3514
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
