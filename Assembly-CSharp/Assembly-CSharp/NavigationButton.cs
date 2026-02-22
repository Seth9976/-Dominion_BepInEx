using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000A2 RID: 162
public class NavigationButton : MonoBehaviour
{
	// Token: 0x06001315 RID: 4885 RVA: 0x000538B4 File Offset: 0x00051AB4
	// Note: this type is marked as 'beforefieldinit'.
	static NavigationButton()
	{
		Il2CppClassPointerStore<NavigationButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "NavigationButton");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr);
		NavigationButton.NativeFieldInfoPtr_targetScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, "targetScene");
		NavigationButton.NativeFieldInfoPtr_disconnectOnTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, "disconnectOnTransition");
		NavigationButton.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, "name");
		NavigationButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664796);
		NavigationButton.NativeMethodInfoPtr_PushScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664797);
		NavigationButton.NativeMethodInfoPtr_PopScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664798);
		NavigationButton.NativeMethodInfoPtr_GoToScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664799);
		NavigationButton.NativeMethodInfoPtr_GoToSceneWithAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664800);
		NavigationButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr, 100664801);
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x00053998 File Offset: 0x00051B98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244058, XrefRangeEnd = 244063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x000539CC File Offset: 0x00051BCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244063, XrefRangeEnd = 244072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr_PushScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x00053A00 File Offset: 0x00051C00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244072, XrefRangeEnd = 244081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr_PopScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00053A34 File Offset: 0x00051C34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244081, XrefRangeEnd = 244090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr_GoToScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00053A68 File Offset: 0x00051C68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244090, XrefRangeEnd = 244099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GoToSceneWithAnimation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr_GoToSceneWithAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00053A9C File Offset: 0x00051C9C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NavigationButton()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationButton>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x0000C9CC File Offset: 0x0000ABCC
	public NavigationButton(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000619 RID: 1561
	// (get) Token: 0x0600131D RID: 4893 RVA: 0x00053AD8 File Offset: 0x00051CD8
	// (set) Token: 0x0600131E RID: 4894 RVA: 0x0000C9D5 File Offset: 0x0000ABD5
	public unsafe string targetScene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_targetScene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_targetScene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700061A RID: 1562
	// (get) Token: 0x0600131F RID: 4895 RVA: 0x00053B00 File Offset: 0x00051D00
	// (set) Token: 0x06001320 RID: 4896 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
	public unsafe bool disconnectOnTransition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_disconnectOnTransition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_disconnectOnTransition)) = value;
		}
	}

	// Token: 0x1700061B RID: 1563
	// (get) Token: 0x06001321 RID: 4897 RVA: 0x00053B28 File Offset: 0x00051D28
	// (set) Token: 0x06001322 RID: 4898 RVA: 0x0000CA0F File Offset: 0x0000AC0F
	public new unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationButton.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000D4F RID: 3407
	private static readonly IntPtr NativeFieldInfoPtr_targetScene;

	// Token: 0x04000D50 RID: 3408
	private static readonly IntPtr NativeFieldInfoPtr_disconnectOnTransition;

	// Token: 0x04000D51 RID: 3409
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x04000D52 RID: 3410
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D53 RID: 3411
	private static readonly IntPtr NativeMethodInfoPtr_PushScene_Public_Void_0;

	// Token: 0x04000D54 RID: 3412
	private static readonly IntPtr NativeMethodInfoPtr_PopScene_Public_Void_0;

	// Token: 0x04000D55 RID: 3413
	private static readonly IntPtr NativeMethodInfoPtr_GoToScene_Public_Void_0;

	// Token: 0x04000D56 RID: 3414
	private static readonly IntPtr NativeMethodInfoPtr_GoToSceneWithAnimation_Public_Void_0;

	// Token: 0x04000D57 RID: 3415
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
