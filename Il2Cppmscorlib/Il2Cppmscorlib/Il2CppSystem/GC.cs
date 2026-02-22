using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem
{
	// Token: 0x020000A8 RID: 168
	public static class GC : Object
	{
		// Token: 0x06000BC2 RID: 3010 RVA: 0x00056FF0 File Offset: 0x000551F0
		// Note: this type is marked as 'beforefieldinit'.
		static GC()
		{
			Il2CppClassPointerStore<GC>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "GC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GC>.NativeClassPtr);
			GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GC>.NativeClassPtr, "EPHEMERON_TOMBSTONE");
			GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665270);
			GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665271);
			GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665272);
			GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665273);
			GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665274);
			GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665275);
			GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665276);
			GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665277);
			GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665278);
			GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GC>.NativeClassPtr, 100665279);
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000570FC File Offset: 0x000552FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283594, XrefRangeEnd = 283595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecordPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00057130 File Offset: 0x00055330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283600, RefRangeEnd = 283603, XrefRangeStart = 283595, XrefRangeEnd = 283600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void register_ephemeron_array(Il2CppReferenceArray<Ephemeron> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00057168 File Offset: 0x00055368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283603, XrefRangeEnd = 283604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object get_ephemeron_tombstone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0005719C File Offset: 0x0005539C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283625, RefRangeEnd = 283627, XrefRangeStart = 283604, XrefRangeEnd = 283625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000571D0 File Offset: 0x000553D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283648, RefRangeEnd = 283649, XrefRangeStart = 283627, XrefRangeEnd = 283648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveMemoryPressure(long bytesAllocated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytesAllocated;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00057204 File Offset: 0x00055404
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void KeepAlive(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0005723C File Offset: 0x0005543C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283649, XrefRangeEnd = 283653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SuppressFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00057274 File Offset: 0x00055474
		[CallerCount(85)]
		[CachedScanResults(RefRangeStart = 283663, RefRangeEnd = 283748, XrefRangeStart = 283653, XrefRangeEnd = 283663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SuppressFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000572AC File Offset: 0x000554AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283748, XrefRangeEnd = 283749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _ReRegisterForFinalize(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000572E4 File Offset: 0x000554E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283759, RefRangeEnd = 283760, XrefRangeStart = 283749, XrefRangeEnd = 283759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReRegisterForFinalize(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GC.NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000050F8 File Offset: 0x000032F8
		public GC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0005731C File Offset: 0x0005551C
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00005101 File Offset: 0x00003301
		public unsafe static Object EPHEMERON_TOMBSTONE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GC.NativeFieldInfoPtr_EPHEMERON_TOMBSTONE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_EPHEMERON_TOMBSTONE;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_RecordPressure_Private_Static_Void_Int64_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_register_ephemeron_array_Internal_Static_Void_Il2CppReferenceArray_1_Ephemeron_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_ephemeron_tombstone_Private_Static_Object_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_AddMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_RemoveMemoryPressure_Public_Static_Void_Int64_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_KeepAlive_Public_Static_Void_Object_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr__SuppressFinalize_Private_Static_Void_Object_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_SuppressFinalize_Public_Static_Void_Object_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr__ReRegisterForFinalize_Private_Static_Void_Object_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_ReRegisterForFinalize_Public_Static_Void_Object_0;
	}
}
