using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200010D RID: 269
public class AndroidNativeExampleBase : MonoBehaviour
{
	// Token: 0x06001292 RID: 4754 RVA: 0x00057660 File Offset: 0x00055860
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidNativeExampleBase()
	{
		Il2CppClassPointerStore<AndroidNativeExampleBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidNativeExampleBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidNativeExampleBase>.NativeClassPtr);
		AndroidNativeExampleBase.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeExampleBase>.NativeClassPtr, 100665535);
		AndroidNativeExampleBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidNativeExampleBase>.NativeClassPtr, 100665536);
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x000576B8 File Offset: 0x000558B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182961, XrefRangeEnd = 182968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidNativeExampleBase.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x000576F4 File Offset: 0x000558F4
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidNativeExampleBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidNativeExampleBase>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidNativeExampleBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x000093F5 File Offset: 0x000075F5
	public AndroidNativeExampleBase(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000E45 RID: 3653
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

	// Token: 0x04000E46 RID: 3654
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
