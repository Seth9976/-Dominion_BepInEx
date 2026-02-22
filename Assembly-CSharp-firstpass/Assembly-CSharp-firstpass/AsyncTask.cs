using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x020000A1 RID: 161
public class AsyncTask : MonoBehaviour
{
	// Token: 0x06000B8A RID: 2954 RVA: 0x0003F6E8 File Offset: 0x0003D8E8
	// Note: this type is marked as 'beforefieldinit'.
	static AsyncTask()
	{
		Il2CppClassPointerStore<AsyncTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AsyncTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTask>.NativeClassPtr);
		AsyncTask.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTask>.NativeClassPtr, 100664689);
		AsyncTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTask>.NativeClassPtr, 100664690);
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x0003F740 File Offset: 0x0003D940
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174552, XrefRangeEnd = 174557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTask.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x0003F774 File Offset: 0x0003D974
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AsyncTask()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncTask>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x000069C6 File Offset: 0x00004BC6
	public AsyncTask(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000921 RID: 2337
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000922 RID: 2338
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
