using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x02000047 RID: 71
	public class TMP_ObjectPool<T> : Object where T : new()
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x00024F90 File Offset: 0x00023190
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_ObjectPool()
		{
			Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr);
			TMP_ObjectPool<T>.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, "m_Stack");
			TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, "m_ActionOnGet");
			TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, "m_ActionOnRelease");
			TMP_ObjectPool<T>.NativeFieldInfoPtr__countAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, "<countAll>k__BackingField");
			TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countAll_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664144);
			TMP_ObjectPool<T>.NativeMethodInfoPtr_set_countAll_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664145);
			TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countActive_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664146);
			TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countInactive_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664147);
			TMP_ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T_UnityAction_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664148);
			TMP_ObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664149);
			TMP_ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr, 100664150);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x000250D8 File Offset: 0x000232D8
		// (set) Token: 0x06000800 RID: 2048 RVA: 0x00025114 File Offset: 0x00023314
		public unsafe int countAll
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countAll_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_set_countAll_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00025154 File Offset: 0x00023354
		public unsafe int countActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countActive_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00025190 File Offset: 0x00023390
		public unsafe int countInactive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 143823, RefRangeEnd = 143825, XrefRangeStart = 143818, XrefRangeEnd = 143823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_get_countInactive_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000251CC File Offset: 0x000233CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143825, XrefRangeEnd = 143828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ObjectPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionOnGet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnRelease);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T_UnityAction_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002522C File Offset: 0x0002342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143828, XrefRangeEnd = 143829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00025268 File Offset: 0x00023468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143829, XrefRangeEnd = 143836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(T element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = element;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref element;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TMP_ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00005BC3 File Offset: 0x00003DC3
		public TMP_ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x000252E0 File Offset: 0x000234E0
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00005BCC File Offset: 0x00003DCC
		public unsafe Stack<T> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00025310 File Offset: 0x00023510
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00005BEB File Offset: 0x00003DEB
		public unsafe UnityAction<T> m_ActionOnGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00025340 File Offset: 0x00023540
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x00005C0A File Offset: 0x00003E0A
		public unsafe UnityAction<T> m_ActionOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00025370 File Offset: 0x00023570
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00005C29 File Offset: 0x00003E29
		public unsafe int _countAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr__countAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_ObjectPool<T>.NativeFieldInfoPtr__countAll_k__BackingField)) = value;
			}
		}

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnGet;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnRelease;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr__countAll_k__BackingField;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_countAll_Public_get_Int32_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_set_countAll_Private_set_Void_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_get_countActive_Public_get_Int32_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_get_countInactive_Public_get_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T_UnityAction_1_T_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_T_0;
	}
}
