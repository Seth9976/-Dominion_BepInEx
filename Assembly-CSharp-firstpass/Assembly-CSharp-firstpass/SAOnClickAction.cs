using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000FB RID: 251
public class SAOnClickAction : MonoBehaviour
{
	// Token: 0x06001180 RID: 4480 RVA: 0x0005419C File Offset: 0x0005239C
	// Note: this type is marked as 'beforefieldinit'.
	static SAOnClickAction()
	{
		Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SAOnClickAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr);
		SAOnClickAction.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr, 100665426);
		SAOnClickAction.NativeMethodInfoPtr_OnClick_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr, 100665427);
		SAOnClickAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr, 100665428);
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00054208 File Offset: 0x00052408
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181752, XrefRangeEnd = 181764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SAOnClickAction.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x0005423C File Offset: 0x0005243C
	[CallerCount(0)]
	public unsafe virtual void OnClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SAOnClickAction.NativeMethodInfoPtr_OnClick_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00054278 File Offset: 0x00052478
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SAOnClickAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SAOnClickAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SAOnClickAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00008BCA File Offset: 0x00006DCA
	public SAOnClickAction(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000D8E RID: 3470
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000D8F RID: 3471
	private static readonly IntPtr NativeMethodInfoPtr_OnClick_Protected_Abstract_Virtual_New_Void_0;

	// Token: 0x04000D90 RID: 3472
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
