using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000108 RID: 264
	[Serializable]
	public class UnityEvent : UnityEventBase
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x00053B58 File Offset: 0x00051D58
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEvent()
		{
			Il2CppClassPointerStore<UnityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr);
			UnityEvent.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, "m_InvokeArray");
			UnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664932);
			UnityEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664933);
			UnityEvent.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664934);
			UnityEvent.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664935);
			UnityEvent.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664936);
			UnityEvent.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100664937);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00053C14 File Offset: 0x00051E14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80647, RefRangeEnd = 80649, XrefRangeStart = 80638, XrefRangeEnd = 80647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00053C50 File Offset: 0x00051E50
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 80655, RefRangeEnd = 80660, XrefRangeStart = 80649, XrefRangeEnd = 80655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(UnityAction call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00053C94 File Offset: 0x00051E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80660, XrefRangeEnd = 80664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00053D04 File Offset: 0x00051F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80664, XrefRangeEnd = 80668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEvent.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00053D74 File Offset: 0x00051F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80668, XrefRangeEnd = 80672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetDelegate(UnityAction action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00053DB8 File Offset: 0x00051FB8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 80692, RefRangeEnd = 80697, XrefRangeStart = 80672, XrefRangeEnd = 80692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0000C7E3 File Offset: 0x0000A9E3
		public UnityEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00053DEC File Offset: 0x00051FEC
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		public unsafe Il2CppReferenceArray<Object> m_InvokeArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent.NativeFieldInfoPtr_m_InvokeArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEvent.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x0000C80B File Offset: 0x0000AA0B
		public void RemoveListener(UnityAction call)
		{
			base.RemoveListener(call.Target, call.Method);
		}

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeFieldInfoPtr_m_InvokeArray;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
	}
}
