using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200025D RID: 605
	public class SparselyPopulatedArrayFragment<T> : Object where T : class
	{
		// Token: 0x06002A05 RID: 10757 RVA: 0x000D97A4 File Offset: 0x000D79A4
		// Note: this type is marked as 'beforefieldinit'.
		static SparselyPopulatedArrayFragment()
		{
			Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayFragment`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr);
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_elements");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_freeCount");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_next");
			SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, "m_prev");
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669984);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669985);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669986);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669987);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669988);
			SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr, 100669989);
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x000D98D8 File Offset: 0x000D7AD8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 309492, RefRangeEnd = 309502, XrefRangeStart = 309492, XrefRangeEnd = 309502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000D9920 File Offset: 0x000D7B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330565, XrefRangeEnd = 330570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparselyPopulatedArrayFragment(int size, SparselyPopulatedArrayFragment<T> prev)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayFragment<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prev);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009FB RID: 2555
		public unsafe T this[int index]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 330571, RefRangeEnd = 330572, XrefRangeStart = 330570, XrefRangeEnd = 330571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000D99C4 File Offset: 0x000D7BC4
		public unsafe int Length
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 275445, RefRangeEnd = 275457, XrefRangeStart = 275445, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Length_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000D9A00 File Offset: 0x000D7C00
		public unsafe SparselyPopulatedArrayFragment<T> Prev
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 24994, RefRangeEnd = 25005, XrefRangeStart = 24994, XrefRangeEnd = 25005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000D9A40 File Offset: 0x000D7C40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330573, RefRangeEnd = 330576, XrefRangeStart = 330572, XrefRangeEnd = 330573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T SafeAtomicRemove(int index, T expectedElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = expectedElement;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref expectedElement;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SparselyPopulatedArrayFragment<T>.NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x0000EA9D File Offset: 0x0000CC9D
		public SparselyPopulatedArrayFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000D9AD0 File Offset: 0x000D7CD0
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x0000EAA6 File Offset: 0x0000CCA6
		public unsafe Il2CppArrayBase<T> m_elements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000D9AF8 File Offset: 0x000D7CF8
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x0000EAC5 File Offset: 0x0000CCC5
		public unsafe int m_freeCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_freeCount)) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000D9B20 File Offset: 0x000D7D20
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public unsafe SparselyPopulatedArrayFragment<T> m_next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000D9B50 File Offset: 0x000D7D50
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0000EAFF File Offset: 0x0000CCFF
		public unsafe SparselyPopulatedArrayFragment<T> m_prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SparselyPopulatedArrayFragment<T>.NativeFieldInfoPtr_m_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeFieldInfoPtr_m_elements;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeFieldInfoPtr_m_freeCount;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeFieldInfoPtr_m_next;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeFieldInfoPtr_m_prev;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_T_Int32_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Internal_get_Int32_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_get_Prev_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_SafeAtomicRemove_Internal_T_Int32_T_0;
	}
}
