using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000008 RID: 8
public static class AndroidAdMob : Object
{
	// Token: 0x06000046 RID: 70 RVA: 0x00017C24 File Offset: 0x00015E24
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidAdMob()
	{
		Il2CppClassPointerStore<AndroidAdMob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidAdMob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAdMob>.NativeClassPtr);
		AndroidAdMob.NativeFieldInfoPtr__Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMob>.NativeClassPtr, "_Client");
		AndroidAdMob.NativeMethodInfoPtr_get_Client_Public_Static_get_GoogleMobileAdInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMob>.NativeClassPtr, 100663349);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000047 RID: 71 RVA: 0x00017C7C File Offset: 0x00015E7C
	public unsafe static GoogleMobileAdInterface Client
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 159765, RefRangeEnd = 159782, XrefRangeStart = 159740, XrefRangeEnd = 159765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMob.NativeMethodInfoPtr_get_Client_Public_Static_get_GoogleMobileAdInterface_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdInterface>(intPtr3) : null;
		}
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000020E1 File Offset: 0x000002E1
	public AndroidAdMob(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00017CB0 File Offset: 0x00015EB0
	// (set) Token: 0x0600004A RID: 74 RVA: 0x000020EA File Offset: 0x000002EA
	public unsafe static GoogleMobileAdInterface _Client
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidAdMob.NativeFieldInfoPtr__Client, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleMobileAdInterface>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidAdMob.NativeFieldInfoPtr__Client, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeFieldInfoPtr__Client;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr_get_Client_Public_Static_get_GoogleMobileAdInterface_0;
}
