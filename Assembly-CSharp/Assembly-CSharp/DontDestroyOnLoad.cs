using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class DontDestroyOnLoad : MonoBehaviour
{
	// Token: 0x0600003E RID: 62 RVA: 0x0001B9E4 File Offset: 0x00019BE4
	// Note: this type is marked as 'beforefieldinit'.
	static DontDestroyOnLoad()
	{
		Il2CppClassPointerStore<global::DontDestroyOnLoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DontDestroyOnLoad");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::DontDestroyOnLoad>.NativeClassPtr);
		global::DontDestroyOnLoad.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::DontDestroyOnLoad>.NativeClassPtr, 100663329);
		global::DontDestroyOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::DontDestroyOnLoad>.NativeClassPtr, 100663330);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0001BA3C File Offset: 0x00019C3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224170, XrefRangeEnd = 224175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::DontDestroyOnLoad.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0001BA70 File Offset: 0x00019C70
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DontDestroyOnLoad()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::DontDestroyOnLoad>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::DontDestroyOnLoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002191 File Offset: 0x00000391
	public DontDestroyOnLoad(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
