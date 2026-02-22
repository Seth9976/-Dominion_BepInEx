using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

// Token: 0x0200009A RID: 154
public class TrayToggle_DisableScrollWhenClosed : TrayToggle
{
	// Token: 0x06001269 RID: 4713 RVA: 0x000517A4 File Offset: 0x0004F9A4
	// Note: this type is marked as 'beforefieldinit'.
	static TrayToggle_DisableScrollWhenClosed()
	{
		Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrayToggle_DisableScrollWhenClosed");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr);
		TrayToggle_DisableScrollWhenClosed.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr, "scrollRect");
		TrayToggle_DisableScrollWhenClosed.NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr, 100664733);
		TrayToggle_DisableScrollWhenClosed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr, 100664734);
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x00051810 File Offset: 0x0004FA10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243421, XrefRangeEnd = 243427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateTrayState(bool bPlayAudio = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bPlayAudio;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrayToggle_DisableScrollWhenClosed.NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x0005185C File Offset: 0x0004FA5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrayToggle_DisableScrollWhenClosed()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrayToggle_DisableScrollWhenClosed>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrayToggle_DisableScrollWhenClosed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x0000C42C File Offset: 0x0000A62C
	public TrayToggle_DisableScrollWhenClosed(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005E9 RID: 1513
	// (get) Token: 0x0600126D RID: 4717 RVA: 0x00051898 File Offset: 0x0004FA98
	// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000C435 File Offset: 0x0000A635
	public unsafe ScrollRect scrollRect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle_DisableScrollWhenClosed.NativeFieldInfoPtr_scrollRect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrayToggle_DisableScrollWhenClosed.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000CE2 RID: 3298
	private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

	// Token: 0x04000CE3 RID: 3299
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTrayState_Protected_Virtual_Void_Boolean_0;

	// Token: 0x04000CE4 RID: 3300
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
