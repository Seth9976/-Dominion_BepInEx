using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using SA.Common.Models;

// Token: 0x020000EE RID: 238
public class GP_AdvertisingIdLoadResult : Result
{
	// Token: 0x060010F0 RID: 4336 RVA: 0x00052808 File Offset: 0x00050A08
	// Note: this type is marked as 'beforefieldinit'.
	static GP_AdvertisingIdLoadResult()
	{
		Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GP_AdvertisingIdLoadResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr);
		GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr, "id");
		GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_isLimitAdTrackingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr, "isLimitAdTrackingEnabled");
		GP_AdvertisingIdLoadResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr, 100665384);
		GP_AdvertisingIdLoadResult.NativeMethodInfoPtr__ctor_Public_Void_Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr, 100665385);
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00052888 File Offset: 0x00050A88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181467, RefRangeEnd = 181468, XrefRangeStart = 181464, XrefRangeEnd = 181467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AdvertisingIdLoadResult()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AdvertisingIdLoadResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x000528C4 File Offset: 0x00050AC4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 181471, RefRangeEnd = 181472, XrefRangeStart = 181468, XrefRangeEnd = 181471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GP_AdvertisingIdLoadResult(Error error)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GP_AdvertisingIdLoadResult>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GP_AdvertisingIdLoadResult.NativeMethodInfoPtr__ctor_Public_Void_Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x000086C3 File Offset: 0x000068C3
	public GP_AdvertisingIdLoadResult(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00052910 File Offset: 0x00050B10
	// (set) Token: 0x060010F5 RID: 4341 RVA: 0x000086CC File Offset: 0x000068CC
	public unsafe string id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00052938 File Offset: 0x00050B38
	// (set) Token: 0x060010F7 RID: 4343 RVA: 0x000086EB File Offset: 0x000068EB
	public unsafe bool isLimitAdTrackingEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_isLimitAdTrackingEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GP_AdvertisingIdLoadResult.NativeFieldInfoPtr_isLimitAdTrackingEnabled)) = value;
		}
	}

	// Token: 0x04000D3E RID: 3390
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000D3F RID: 3391
	private static readonly IntPtr NativeFieldInfoPtr_isLimitAdTrackingEnabled;

	// Token: 0x04000D40 RID: 3392
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000D41 RID: 3393
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Error_0;
}
