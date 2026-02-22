using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025C RID: 604
	public sealed class SparselyPopulatedArrayAddInfo<T> : ValueType where T : class
	{
		// Token: 0x060029FB RID: 10747 RVA: 0x000D9594 File Offset: 0x000D7794
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayAddInfo()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayAddInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr);
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "m_source");
			SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "m_index");
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100669981);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100669982);
			SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100669983);
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000D9664 File Offset: 0x000D7864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11679, RefRangeEnd = 11680, XrefRangeStart = 11679, XrefRangeEnd = 11680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x000D96C4 File Offset: 0x000D78C4
		public unsafe SparselyPopulatedArrayFragment<T> Source
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x000D9708 File Offset: 0x000D7908
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayAddInfo<T>.NativeMethodInfoPtr_get_Index_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0000EA48 File Offset: 0x0000CC48
		public SparselyPopulatedArrayAddInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x0000EA51 File Offset: 0x0000CC51
		public SparselyPopulatedArrayAddInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
		{
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x000D974C File Offset: 0x000D794C
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x0000EA63 File Offset: 0x0000CC63
		public unsafe SparselyPopulatedArrayFragment<T> m_source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000D977C File Offset: 0x000D797C
		// (set) Token: 0x06002A04 RID: 10756 RVA: 0x0000EA82 File Offset: 0x0000CC82
		public unsafe int m_index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayAddInfo<T>.NativeFieldInfoPtr_m_index)) = value;
			}
		}

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeFieldInfoPtr_m_source;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeFieldInfoPtr_m_index;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Internal_get_Int32_0;
	}
}
