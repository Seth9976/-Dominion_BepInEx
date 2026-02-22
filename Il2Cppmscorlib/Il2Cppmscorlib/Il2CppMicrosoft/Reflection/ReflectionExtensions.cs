using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Reflection
{
	// Token: 0x0200003C RID: 60
	public static class ReflectionExtensions : Object
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x00032188 File Offset: 0x00030388
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionExtensions()
		{
			Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Reflection", "ReflectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr);
			ReflectionExtensions.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663872);
			ReflectionExtensions.NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663873);
			ReflectionExtensions.NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663874);
			ReflectionExtensions.NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663875);
			ReflectionExtensions.NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663876);
			ReflectionExtensions.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663877);
			ReflectionExtensions.NativeMethodInfoPtr_ReflectionOnly_Public_Static_Boolean_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionExtensions>.NativeClassPtr, 100663878);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00032244 File Offset: 0x00030444
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264622, RefRangeEnd = 264627, XrefRangeStart = 264621, XrefRangeEnd = 264622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00032288 File Offset: 0x00030488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264629, RefRangeEnd = 264631, XrefRangeStart = 264627, XrefRangeEnd = 264629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAbstract(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000322CC File Offset: 0x000304CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264631, XrefRangeEnd = 264633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSealed(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00032310 File Offset: 0x00030510
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264634, RefRangeEnd = 264636, XrefRangeStart = 264633, XrefRangeEnd = 264634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type BaseType(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00032354 File Offset: 0x00030554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264637, RefRangeEnd = 264639, XrefRangeStart = 264636, XrefRangeEnd = 264637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly Assembly(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00032398 File Offset: 0x00030598
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264643, RefRangeEnd = 264644, XrefRangeStart = 264639, XrefRangeEnd = 264643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode GetTypeCode(this Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000323DC File Offset: 0x000305DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264637, RefRangeEnd = 264639, XrefRangeStart = 264637, XrefRangeEnd = 264639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReflectionOnly(this Assembly assm)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionExtensions.NativeMethodInfoPtr_ReflectionOnly_Public_Static_Boolean_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00003A9E File Offset: 0x00001C9E
		public ReflectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_IsSealed_Public_Static_Boolean_Type_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_Assembly_Public_Static_Assembly_Type_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Static_TypeCode_Type_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_ReflectionOnly_Public_Static_Boolean_Assembly_0;
	}
}
