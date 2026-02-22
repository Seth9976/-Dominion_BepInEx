using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000043 RID: 67
	public class UDPReflectionUtils : Object
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000CF90 File Offset: 0x0000B190
		// Note: this type is marked as 'beforefieldinit'.
		static UDPReflectionUtils()
		{
			Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UDPReflectionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr);
			UDPReflectionUtils.NativeFieldInfoPtr_s_assemblyTypeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, "s_assemblyTypeCache");
			UDPReflectionUtils.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, "s_typeCache");
			UDPReflectionUtils.NativeFieldInfoPtr_k_whiteListedAssemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, "k_whiteListedAssemblies");
			UDPReflectionUtils.NativeMethodInfoPtr_GetTypeByName_Internal_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, 100663568);
			UDPReflectionUtils.NativeMethodInfoPtr_GetAllAssemblies_Private_Static_IEnumerable_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, 100663569);
			UDPReflectionUtils.NativeMethodInfoPtr_GetTypes_Private_Static_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, 100663570);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000D038 File Offset: 0x0000B238
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 152892, RefRangeEnd = 152900, XrefRangeStart = 152823, XrefRangeEnd = 152892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetTypeByName(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPReflectionUtils.NativeMethodInfoPtr_GetTypeByName_Internal_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000D07C File Offset: 0x0000B27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152900, XrefRangeEnd = 152903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Assembly> GetAllAssemblies()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPReflectionUtils.NativeMethodInfoPtr_GetAllAssemblies_Private_Static_IEnumerable_1_Assembly_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Assembly>>(intPtr3) : null;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152916, RefRangeEnd = 152917, XrefRangeStart = 152903, XrefRangeEnd = 152916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Type> GetTypes(Assembly assembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPReflectionUtils.NativeMethodInfoPtr_GetTypes_Private_Static_IEnumerable_1_Type_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000030DD File Offset: 0x000012DD
		public UDPReflectionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		// (set) Token: 0x06000225 RID: 549 RVA: 0x000030E6 File Offset: 0x000012E6
		public unsafe static Dictionary<Assembly, Il2CppReferenceArray<Type>> s_assemblyTypeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UDPReflectionUtils.NativeFieldInfoPtr_s_assemblyTypeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Assembly, Il2CppReferenceArray<Type>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UDPReflectionUtils.NativeFieldInfoPtr_s_assemblyTypeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000D11C File Offset: 0x0000B31C
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000030F8 File Offset: 0x000012F8
		public unsafe static Dictionary<string, Type> s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UDPReflectionUtils.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UDPReflectionUtils.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000D144 File Offset: 0x0000B344
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0000310A File Offset: 0x0000130A
		public unsafe static Il2CppStringArray k_whiteListedAssemblies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UDPReflectionUtils.NativeFieldInfoPtr_k_whiteListedAssemblies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UDPReflectionUtils.NativeFieldInfoPtr_k_whiteListedAssemblies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_s_assemblyTypeCache;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_k_whiteListedAssemblies;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeByName_Internal_Static_Type_String_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetAllAssemblies_Private_Static_IEnumerable_1_Assembly_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Private_Static_IEnumerable_1_Type_Assembly_0;

		// Token: 0x020000B0 RID: 176
		[ObfuscatedName("UnityEngine.Purchasing.UDPReflectionUtils+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06000688 RID: 1672 RVA: 0x0001B154 File Offset: 0x00019354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UDPReflectionUtils>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr);
				UDPReflectionUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr, "assembly");
				UDPReflectionUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr, 100663572);
				UDPReflectionUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__GetTypeByName_b__0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr, 100663573);
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x0001B1BC File Offset: 0x000193BC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UDPReflectionUtils.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPReflectionUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x0001B1F8 File Offset: 0x000193F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152821, XrefRangeEnd = 152823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTypeByName_b__0(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPReflectionUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__GetTypeByName_b__0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600068B RID: 1675 RVA: 0x000054F9 File Offset: 0x000036F9
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600068C RID: 1676 RVA: 0x0001B248 File Offset: 0x00019448
			// (set) Token: 0x0600068D RID: 1677 RVA: 0x00005502 File Offset: 0x00003702
			public unsafe Assembly assembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPReflectionUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_assembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPReflectionUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000446 RID: 1094
			private static readonly IntPtr NativeFieldInfoPtr_assembly;

			// Token: 0x04000447 RID: 1095
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000448 RID: 1096
			private static readonly IntPtr NativeMethodInfoPtr__GetTypeByName_b__0_Internal_Boolean_String_0;
		}
	}
}
