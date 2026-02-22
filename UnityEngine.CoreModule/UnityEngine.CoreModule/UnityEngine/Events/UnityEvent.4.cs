using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x0200010E RID: 270
	[Serializable]
	public class UnityEvent<T0, T1, T2> : UnityEventBase
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x00054ADC File Offset: 0x00052CDC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr);
			UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, "m_InvokeArray");
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664958);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664959);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664960);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664961);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664962);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664963);
			UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr, 100664964);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00054C0C File Offset: 0x00052E0C
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 80740, RefRangeEnd = 80778, XrefRangeStart = 80740, XrefRangeEnd = 80778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0, T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x00054C48 File Offset: 0x00052E48
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 80850, RefRangeEnd = 80895, XrefRangeStart = 80850, XrefRangeEnd = 80895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction<T0, T1, T2> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00054C8C File Offset: 0x00052E8C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 80898, RefRangeEnd = 80913, XrefRangeStart = 80898, XrefRangeEnd = 80913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(UnityAction<T0, T1, T2> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00054CD0 File Offset: 0x00052ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81116, XrefRangeEnd = 81142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo FindMethod_Impl(string name, Type targetObjType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObjType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00054D40 File Offset: 0x00052F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81142, XrefRangeEnd = 81144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00054DB0 File Offset: 0x00052FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81144, XrefRangeEnd = 81150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction<T0, T1, T2> action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00054DF4 File Offset: 0x00052FF4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 81177, RefRangeEnd = 81184, XrefRangeStart = 81150, XrefRangeEnd = 81177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0000C901 File Offset: 0x0000AB01
		public UnityEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00054EFC File Offset: 0x000530FC
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x0000C90A File Offset: 0x0000AB0A
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0, T1, T2>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_3_T0_T1_T2_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_3_T0_T1_T2_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_3_T0_T1_T2_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_T1_T2_0;
	}
}
