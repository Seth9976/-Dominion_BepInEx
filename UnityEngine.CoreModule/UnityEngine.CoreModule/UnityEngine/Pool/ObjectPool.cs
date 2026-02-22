using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Pool
{
	// Token: 0x02000128 RID: 296
	public class ObjectPool<T> : Object where T : class
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x000574A8 File Offset: 0x000556A8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectPool()
		{
			Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
			ObjectPool<T>.NativeFieldInfoPtr_m_Stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_Stack");
			ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CreateFunc");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnGet");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnRelease");
			ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_ActionOnDestroy");
			ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_MaxSize");
			ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "m_CollectionCheck");
			ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "<CountAll>k__BackingField");
			ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665030);
			ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665031);
			ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665032);
			ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665033);
			ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665034);
			ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665035);
			ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665036);
			ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100665037);
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00057654 File Offset: 0x00055854
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00057690 File Offset: 0x00055890
		public unsafe int CountAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000576D0 File Offset: 0x000558D0
		public unsafe virtual int CountInactive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81680, XrefRangeEnd = 81681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0005770C File Offset: 0x0005590C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81681, XrefRangeEnd = 81684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int defaultCapacity = 10, int maxSize = 10000)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(createFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnGet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnRelease);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actionOnDestroy);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref collectionCheck;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultCapacity;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000577B8 File Offset: 0x000559B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81685, RefRangeEnd = 81688, XrefRangeStart = 81684, XrefRangeEnd = 81685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x000577F4 File Offset: 0x000559F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81688, RefRangeEnd = 81692, XrefRangeStart = 81688, XrefRangeEnd = 81688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(T element)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0005786C File Offset: 0x00055A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81692, XrefRangeEnd = 81702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x000578A0 File Offset: 0x00055AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81702, XrefRangeEnd = 81703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0000D0BB File Offset: 0x0000B2BB
		public ObjectPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x000578D4 File Offset: 0x00055AD4
		// (set) Token: 0x06001740 RID: 5952 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public unsafe Stack<T> m_Stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_Stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_Stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00057904 File Offset: 0x00055B04
		// (set) Token: 0x06001742 RID: 5954 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
		public unsafe Func<T> m_CreateFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x00057934 File Offset: 0x00055B34
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x0000D102 File Offset: 0x0000B302
		public unsafe Action<T> m_ActionOnGet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00057964 File Offset: 0x00055B64
		// (set) Token: 0x06001746 RID: 5958 RVA: 0x0000D121 File Offset: 0x0000B321
		public unsafe Action<T> m_ActionOnRelease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x00057994 File Offset: 0x00055B94
		// (set) Token: 0x06001748 RID: 5960 RVA: 0x0000D140 File Offset: 0x0000B340
		public unsafe Action<T> m_ActionOnDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x000579C4 File Offset: 0x00055BC4
		// (set) Token: 0x0600174A RID: 5962 RVA: 0x0000D15F File Offset: 0x0000B35F
		public unsafe int m_MaxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x000579EC File Offset: 0x00055BEC
		// (set) Token: 0x0600174C RID: 5964 RVA: 0x0000D17A File Offset: 0x0000B37A
		public unsafe bool m_CollectionCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck)) = value;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00057A14 File Offset: 0x00055C14
		// (set) Token: 0x0600174E RID: 5966 RVA: 0x0000D195 File Offset: 0x0000B395
		public unsafe int _CountAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x00057A3C File Offset: 0x00055C3C
		public int CountActive
		{
			get
			{
				return this.CountAll - this.CountInactive;
			}
		}

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeFieldInfoPtr_m_Stack;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateFunc;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnGet;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnRelease;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionOnDestroy;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxSize;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectionCheck;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeFieldInfoPtr__CountAll_k__BackingField;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
