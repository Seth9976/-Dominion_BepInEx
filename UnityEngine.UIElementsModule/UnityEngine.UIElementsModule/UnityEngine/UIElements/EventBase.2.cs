using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005B RID: 91
	public class EventBase<T> : EventBase where T : EventBase<T>, new()
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x0001E498 File Offset: 0x0001C698
		// Note: this type is marked as 'beforefieldinit'.
		static EventBase()
		{
			Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr);
			EventBase<T>.NativeFieldInfoPtr_s_TypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "s_TypeId");
			EventBase<T>.NativeFieldInfoPtr_s_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "s_Pool");
			EventBase<T>.NativeFieldInfoPtr_m_RefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, "m_RefCount");
			EventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663784);
			EventBase<T>.NativeMethodInfoPtr_TypeId_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663785);
			EventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663786);
			EventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663787);
			EventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663788);
			EventBase<T>.NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663789);
			EventBase<T>.NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663790);
			EventBase<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663791);
			EventBase<T>.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr, 100663792);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94061, RefRangeEnd = 94062, XrefRangeStart = 94057, XrefRangeEnd = 94061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0001E630 File Offset: 0x0001C830
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 94070, RefRangeEnd = 94101, XrefRangeStart = 94062, XrefRangeEnd = 94070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TypeId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_TypeId_Public_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0001E660 File Offset: 0x0001C860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94108, RefRangeEnd = 94109, XrefRangeStart = 94101, XrefRangeEnd = 94108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0001E69C File Offset: 0x0001C89C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 94122, RefRangeEnd = 94128, XrefRangeStart = 94109, XrefRangeEnd = 94122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0001E6CC File Offset: 0x0001C8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94128, XrefRangeEnd = 94139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(EventBase e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0001E70C File Offset: 0x0001C90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94139, XrefRangeEnd = 94153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleasePooled(T evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = evt;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref evt;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0001E778 File Offset: 0x0001C978
		[CallerCount(0)]
		public unsafe override void Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94153, XrefRangeEnd = 94159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventBase<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		public unsafe override long eventTypeId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94159, XrefRangeEnd = 94163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventBase<T>.NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00004B64 File Offset: 0x00002D64
		public EventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0001E830 File Offset: 0x0001CA30
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00004B6D File Offset: 0x00002D6D
		public unsafe static long s_TypeId
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(EventBase<T>.NativeFieldInfoPtr_s_TypeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase<T>.NativeFieldInfoPtr_s_TypeId, (void*)(&value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001E84C File Offset: 0x0001CA4C
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00004B7B File Offset: 0x00002D7B
		public unsafe static ObjectPool<T> s_Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventBase<T>.NativeFieldInfoPtr_s_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<T>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventBase<T>.NativeFieldInfoPtr_s_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001E874 File Offset: 0x0001CA74
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00004B8D File Offset: 0x00002D8D
		public unsafe int m_RefCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase<T>.NativeFieldInfoPtr_m_RefCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventBase<T>.NativeFieldInfoPtr_m_RefCount)) = value;
			}
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_s_TypeId;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_s_Pool;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_RefCount;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_TypeId_Public_Static_Int64_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_T_EventBase_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePooled_Private_Static_Void_T_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_Virtual_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_get_eventTypeId_Public_Virtual_get_Int64_0;
	}
}
