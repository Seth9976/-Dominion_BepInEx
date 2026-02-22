using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x0200007C RID: 124
public class GooglePlayUtils : Singleton<GooglePlayUtils>
{
	// Token: 0x06000915 RID: 2325 RVA: 0x000360E0 File Offset: 0x000342E0
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayUtils()
	{
		Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr);
		GooglePlayUtils.NativeFieldInfoPtr_ActionAdvertisingIdLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, "ActionAdvertisingIdLoaded");
		GooglePlayUtils.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, 100664385);
		GooglePlayUtils.NativeMethodInfoPtr_GetAdvertisingId_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, 100664386);
		GooglePlayUtils.NativeMethodInfoPtr_OnAdvertisingIdLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, 100664387);
		GooglePlayUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, 100664388);
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00036174 File Offset: 0x00034374
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170240, XrefRangeEnd = 170245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x000361A8 File Offset: 0x000343A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170245, XrefRangeEnd = 170246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetAdvertisingId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.NativeMethodInfoPtr_GetAdvertisingId_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x000361DC File Offset: 0x000343DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170246, XrefRangeEnd = 170297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAdvertisingIdLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.NativeMethodInfoPtr_OnAdvertisingIdLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00036220 File Offset: 0x00034420
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170297, XrefRangeEnd = 170303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayUtils()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00005AAE File Offset: 0x00003CAE
	public GooglePlayUtils(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x0600091B RID: 2331 RVA: 0x0003625C File Offset: 0x0003445C
	// (set) Token: 0x0600091C RID: 2332 RVA: 0x00005AB7 File Offset: 0x00003CB7
	public unsafe static Action<GP_AdvertisingIdLoadResult> ActionAdvertisingIdLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayUtils.NativeFieldInfoPtr_ActionAdvertisingIdLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_AdvertisingIdLoadResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayUtils.NativeFieldInfoPtr_ActionAdvertisingIdLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000744 RID: 1860
	private static readonly IntPtr NativeFieldInfoPtr_ActionAdvertisingIdLoaded;

	// Token: 0x04000745 RID: 1861
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000746 RID: 1862
	private static readonly IntPtr NativeMethodInfoPtr_GetAdvertisingId_Public_Void_0;

	// Token: 0x04000747 RID: 1863
	private static readonly IntPtr NativeMethodInfoPtr_OnAdvertisingIdLoaded_Private_Void_String_0;

	// Token: 0x04000748 RID: 1864
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000378 RID: 888
	[ObfuscatedName("GooglePlayUtils+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003527 RID: 13607 RVA: 0x000DB804 File Offset: 0x000D9A04
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayUtils>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr);
			GooglePlayUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr, "<>9");
			GooglePlayUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr, 100670081);
			GooglePlayUtils.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_GP_AdvertisingIdLoadResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr, 100670082);
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x000DB86C File Offset: 0x000D9A6C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayUtils.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x000DB8A8 File Offset: 0x000D9AA8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__5_0(GP_AdvertisingIdLoadResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayUtils.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_GP_AdvertisingIdLoadResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00014A18 File Offset: 0x00012C18
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600352B RID: 13611 RVA: 0x000DB8EC File Offset: 0x000D9AEC
		// (set) Token: 0x0600352C RID: 13612 RVA: 0x00014A21 File Offset: 0x00012C21
		public unsafe static GooglePlayUtils.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayUtils.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003109 RID: 12553
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400310A RID: 12554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400310B RID: 12555
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_Void_GP_AdvertisingIdLoadResult_0;
	}
}
