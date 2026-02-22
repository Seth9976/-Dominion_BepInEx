using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Net.NetworkInformation
{
	// Token: 0x0200013D RID: 317
	public class CommonUnixIPGlobalProperties : IPGlobalProperties
	{
		// Token: 0x060014DE RID: 5342 RVA: 0x0005F3FC File Offset: 0x0005D5FC
		// Note: this type is marked as 'beforefieldinit'.
		static CommonUnixIPGlobalProperties()
		{
			Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "CommonUnixIPGlobalProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666230);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666231);
			CommonUnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr, 100666232);
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x0005F468 File Offset: 0x0005D668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57477, XrefRangeEnd = 57479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int getdomainname(Il2CppStructArray<byte> name, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonUnixIPGlobalProperties.NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0005F4B8 File Offset: 0x0005D6B8
		public unsafe override string DomainName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57479, XrefRangeEnd = 57488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommonUnixIPGlobalProperties.NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0005F4FC File Offset: 0x0005D6FC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommonUnixIPGlobalProperties()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonUnixIPGlobalProperties>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommonUnixIPGlobalProperties.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0000A7AE File Offset: 0x000089AE
		public CommonUnixIPGlobalProperties(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_getdomainname_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainName_Public_Virtual_get_String_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
