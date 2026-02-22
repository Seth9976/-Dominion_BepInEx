using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000096 RID: 150
	public class PropertyNameUtils : Object
	{
		// Token: 0x06000F48 RID: 3912 RVA: 0x0003FB34 File Offset: 0x0003DD34
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyNameUtils()
		{
			Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyNameUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100664265);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100664266);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x0003FB8C File Offset: 0x0003DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67901, XrefRangeEnd = 67903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyName PropertyNameFromString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0003FBD0 File Offset: 0x0003DDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67903, XrefRangeEnd = 67905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropertyNameFromString_Injected(string name, out PropertyName ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00009B2B File Offset: 0x00007D2B
		public PropertyNameUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BC2 RID: 3010
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;

		// Token: 0x04000BC3 RID: 3011
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0;
	}
}
