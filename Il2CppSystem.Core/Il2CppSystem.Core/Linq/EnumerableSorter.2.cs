using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq
{
	// Token: 0x0200000E RID: 14
	public class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00005A40 File Offset: 0x00003C40
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableSorter()
		{
			Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "EnumerableSorter`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr);
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "keySelector");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "comparer");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "descending");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "next");
			EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, "keys");
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663482);
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663483);
			EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr, 100663484);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005B60 File Offset: 0x00003D60
		[CallerCount(0)]
		public unsafe EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableSorter<TElement, TKey>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keySelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref descending;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58521, XrefRangeEnd = 58523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ComputeKeys(Il2CppArrayBase<TElement> elements, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elements);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005C3C File Offset: 0x00003E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58523, XrefRangeEnd = 58525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareKeys(int index1, int index2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnumerableSorter<TElement, TKey>.NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000022D8 File Offset: 0x000004D8
		public EnumerableSorter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005CA0 File Offset: 0x00003EA0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000022E1 File Offset: 0x000004E1
		public unsafe Func<TElement, TKey> keySelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TElement, TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keySelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005CD0 File Offset: 0x00003ED0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002300 File Offset: 0x00000500
		public unsafe IComparer<TKey> comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<TKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005D00 File Offset: 0x00003F00
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000231F File Offset: 0x0000051F
		public unsafe bool descending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_descending)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005D28 File Offset: 0x00003F28
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000233A File Offset: 0x0000053A
		public unsafe EnumerableSorter<TElement> next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumerableSorter<TElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005D58 File Offset: 0x00003F58
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe Il2CppArrayBase<TKey> keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys);
				return Il2CppArrayBase<TKey>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableSorter<TElement, TKey>.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_keySelector;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_descending;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_keys;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_2_TElement_TKey_IComparer_1_TKey_Boolean_EnumerableSorter_1_TElement_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_ComputeKeys_Internal_Virtual_Void_Il2CppArrayBase_1_TElement_Int32_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_CompareKeys_Internal_Virtual_Int32_Int32_Int32_0;
	}
}
