using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x020000CC RID: 204
public class AN_LicenseManager : Singleton<AN_LicenseManager>
{
	// Token: 0x06000E93 RID: 3731 RVA: 0x0004B0A0 File Offset: 0x000492A0
	// Note: this type is marked as 'beforefieldinit'.
	static AN_LicenseManager()
	{
		Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_LicenseManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr);
		AN_LicenseManager.NativeFieldInfoPtr_OnLicenseRequestResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, "OnLicenseRequestResult");
		AN_LicenseManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, 100665138);
		AN_LicenseManager.NativeMethodInfoPtr_StartLicenseRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, 100665139);
		AN_LicenseManager.NativeMethodInfoPtr_StartLicenseRequest_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, 100665140);
		AN_LicenseManager.NativeMethodInfoPtr_OnLicenseRequestRes_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, 100665141);
		AN_LicenseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, 100665142);
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0004B148 File Offset: 0x00049348
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178894, XrefRangeEnd = 178899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x0004B17C File Offset: 0x0004937C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178899, XrefRangeEnd = 178919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartLicenseRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.NativeMethodInfoPtr_StartLicenseRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0004B1B0 File Offset: 0x000493B0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 178925, RefRangeEnd = 178928, XrefRangeStart = 178919, XrefRangeEnd = 178925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartLicenseRequest(string base64PublicKey)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64PublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.NativeMethodInfoPtr_StartLicenseRequest_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0004B1F4 File Offset: 0x000493F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178928, XrefRangeEnd = 178985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLicenseRequestRes(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.NativeMethodInfoPtr_OnLicenseRequestRes_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x0004B238 File Offset: 0x00049438
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178985, XrefRangeEnd = 178991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_LicenseManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x000077E0 File Offset: 0x000059E0
	public AN_LicenseManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000440 RID: 1088
	// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0004B274 File Offset: 0x00049474
	// (set) Token: 0x06000E9B RID: 3739 RVA: 0x000077E9 File Offset: 0x000059E9
	public unsafe static Action<AN_LicenseRequestResult> OnLicenseRequestResult
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_LicenseManager.NativeFieldInfoPtr_OnLicenseRequestResult, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AN_LicenseRequestResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_LicenseManager.NativeFieldInfoPtr_OnLicenseRequestResult, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B5A RID: 2906
	private static readonly IntPtr NativeFieldInfoPtr_OnLicenseRequestResult;

	// Token: 0x04000B5B RID: 2907
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000B5C RID: 2908
	private static readonly IntPtr NativeMethodInfoPtr_StartLicenseRequest_Public_Void_0;

	// Token: 0x04000B5D RID: 2909
	private static readonly IntPtr NativeMethodInfoPtr_StartLicenseRequest_Public_Void_String_0;

	// Token: 0x04000B5E RID: 2910
	private static readonly IntPtr NativeMethodInfoPtr_OnLicenseRequestRes_Private_Void_String_0;

	// Token: 0x04000B5F RID: 2911
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200038B RID: 907
	[ObfuscatedName("AN_LicenseManager+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003602 RID: 13826 RVA: 0x000DE134 File Offset: 0x000DC334
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_LicenseManager>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr);
			AN_LicenseManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr, "<>9");
			AN_LicenseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr, 100670176);
			AN_LicenseManager.__c.NativeMethodInfoPtr___cctor_b__6_0_Internal_Void_AN_LicenseRequestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr, 100670177);
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x000DE19C File Offset: 0x000DC39C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_LicenseManager.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x000DE1D8 File Offset: 0x000DC3D8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__6_0(AN_LicenseRequestResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManager.__c.NativeMethodInfoPtr___cctor_b__6_0_Internal_Void_AN_LicenseRequestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00014EEC File Offset: 0x000130EC
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x000DE21C File Offset: 0x000DC41C
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x00014EF5 File Offset: 0x000130F5
		public unsafe static AN_LicenseManager.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_LicenseManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_LicenseManager.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_LicenseManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400318C RID: 12684
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__6_0_Internal_Void_AN_LicenseRequestResult_0;
	}
}
