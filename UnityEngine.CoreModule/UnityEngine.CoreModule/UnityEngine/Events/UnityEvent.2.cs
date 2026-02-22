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
	// Token: 0x0200010A RID: 266
	[Serializable]
	public class UnityEvent<T0> : UnityEventBase
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x00053F7C File Offset: 0x0005217C
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr);
			UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, "m_InvokeArray");
			UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664940);
			UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664941);
			UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664942);
			UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664943);
			UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664944);
			UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664945);
			UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr, 100664946);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x00054088 File Offset: 0x00052288
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 80740, RefRangeEnd = 80778, XrefRangeStart = 80719, XrefRangeEnd = 80740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent<T0>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000540C4 File Offset: 0x000522C4
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 80850, RefRangeEnd = 80895, XrefRangeStart = 80778, XrefRangeEnd = 80850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction<T0> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x00054108 File Offset: 0x00052308
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 80898, RefRangeEnd = 80913, XrefRangeStart = 80895, XrefRangeEnd = 80898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(UnityAction<T0> call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x0005414C File Offset: 0x0005234C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80913, XrefRangeEnd = 80941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0>.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000541BC File Offset: 0x000523BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80941, XrefRangeEnd = 80943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0005422C File Offset: 0x0005242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80943, XrefRangeEnd = 80949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction<T0> action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
			}
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00054270 File Offset: 0x00052470
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 80970, RefRangeEnd = 80997, XrefRangeStart = 80949, XrefRangeEnd = 80970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UnityEvent<T0>.NativeMethodInfoPtr_Invoke_Public_Void_T0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x0000C851 File Offset: 0x0000AA51
		public UnityEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000542E8 File Offset: 0x000524E8
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000C85A File Offset: 0x0000AA5A
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent<T0>.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_T0_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_1_T0_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_1_T0_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T0_0;
	}
}
