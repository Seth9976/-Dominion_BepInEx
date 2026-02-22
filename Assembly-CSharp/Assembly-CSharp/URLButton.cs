using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000C3 RID: 195
public class URLButton : MonoBehaviour
{
	// Token: 0x06001775 RID: 6005 RVA: 0x00060E30 File Offset: 0x0005F030
	// Note: this type is marked as 'beforefieldinit'.
	static URLButton()
	{
		Il2CppClassPointerStore<URLButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "URLButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<URLButton>.NativeClassPtr);
		URLButton.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<URLButton>.NativeClassPtr, "URL");
		URLButton.NativeMethodInfoPtr_GoToURL_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLButton>.NativeClassPtr, 100665171);
		URLButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<URLButton>.NativeClassPtr, 100665172);
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00060E9C File Offset: 0x0005F09C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248354, XrefRangeEnd = 248356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToURL()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLButton.NativeMethodInfoPtr_GoToURL_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00060ED0 File Offset: 0x0005F0D0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe URLButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<URLButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(URLButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x0000F1E1 File Offset: 0x0000D3E1
	public URLButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000775 RID: 1909
	// (get) Token: 0x06001779 RID: 6009 RVA: 0x00060F0C File Offset: 0x0005F10C
	// (set) Token: 0x0600177A RID: 6010 RVA: 0x0000F1EA File Offset: 0x0000D3EA
	public unsafe string URL
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLButton.NativeFieldInfoPtr_URL);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(URLButton.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400101C RID: 4124
	private static readonly IntPtr NativeFieldInfoPtr_URL;

	// Token: 0x0400101D RID: 4125
	private static readonly IntPtr NativeMethodInfoPtr_GoToURL_Public_Void_0;

	// Token: 0x0400101E RID: 4126
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
