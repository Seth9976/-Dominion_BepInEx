using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x02000139 RID: 313
	public class IPGlobalProperties : Object
	{
		// Token: 0x060014D1 RID: 5329 RVA: 0x0005F128 File Offset: 0x0005D328
		// Note: this type is marked as 'beforefieldinit'.
		static IPGlobalProperties()
		{
			Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "IPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr);
			IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, "<PlatformNeedsLibCWorkaround>k__BackingField");
			IPGlobalProperties.NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666223);
			IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666224);
			IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666225);
			IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666226);
			IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr, 100666227);
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060014D2 RID: 5330 RVA: 0x0005F1D0 File Offset: 0x0005D3D0
		public unsafe static bool PlatformNeedsLibCWorkaround
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57440, XrefRangeEnd = 57442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0005F200 File Offset: 0x0005D400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57442, XrefRangeEnd = 57452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties GetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0005F234 File Offset: 0x0005D434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 57462, RefRangeEnd = 57465, XrefRangeStart = 57452, XrefRangeEnd = 57462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPGlobalProperties InternalGetIPGlobalProperties()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPGlobalProperties>(intPtr3) : null;
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060014D5 RID: 5333 RVA: 0x0005F268 File Offset: 0x0005D468
		public unsafe virtual string DomainName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0005F2AC File Offset: 0x0005D4AC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0000A78E File Offset: 0x0000898E
		public IPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0005F2E8 File Offset: 0x0005D4E8
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0000A797 File Offset: 0x00008997
		public unsafe static bool _PlatformNeedsLibCWorkaround_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPGlobalProperties.NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr__PlatformNeedsLibCWorkaround_k__BackingField;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_PlatformNeedsLibCWorkaround_Private_Static_get_Boolean_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_GetIPGlobalProperties_Public_Static_IPGlobalProperties_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetIPGlobalProperties_Internal_Static_IPGlobalProperties_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
