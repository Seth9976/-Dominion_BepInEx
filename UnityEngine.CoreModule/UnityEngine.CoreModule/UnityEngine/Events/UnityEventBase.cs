using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000106 RID: 262
	[Serializable]
	public class UnityEventBase : Object
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x00053300 File Offset: 0x00051500
		// Note: this type is marked as 'beforefieldinit'.
		static UnityEventBase()
		{
			Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityEventBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr);
			UnityEventBase.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_Calls");
			UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_PersistentCalls");
			UnityEventBase.NativeFieldInfoPtr_m_CallsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, "m_CallsDirty");
			UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664916);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664917);
			UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664918);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664919);
			UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664920);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664921);
			UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664922);
			UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664923);
			UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664924);
			UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664925);
			UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664926);
			UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664927);
			UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664928);
			UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr, 100664929);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00053484 File Offset: 0x00051684
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80476, RefRangeEnd = 80480, XrefRangeStart = 80467, XrefRangeEnd = 80476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEventBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000534C0 File Offset: 0x000516C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80480, XrefRangeEnd = 80481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000534F4 File Offset: 0x000516F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00053528 File Offset: 0x00051728
		[CallerCount(0)]
		public unsafe virtual MethodInfo FindMethod_Impl(string name, Type targetObjType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00053598 File Offset: 0x00051798
		[CallerCount(0)]
		public unsafe virtual BaseInvokableCall GetDelegate(Object target, MethodInfo theFunction)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00053608 File Offset: 0x00051808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80520, RefRangeEnd = 80521, XrefRangeStart = 80481, XrefRangeEnd = 80520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(PersistentCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00053658 File Offset: 0x00051858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80574, RefRangeEnd = 80575, XrefRangeStart = 80521, XrefRangeEnd = 80574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listenerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000536DC File Offset: 0x000518DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DirtyPersistentCalls()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00053710 File Offset: 0x00051910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80575, XrefRangeEnd = 80576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildPersistentCallsIfNeeded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00053744 File Offset: 0x00051944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80578, RefRangeEnd = 80581, XrefRangeStart = 80576, XrefRangeEnd = 80578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00053788 File Offset: 0x00051988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80583, RefRangeEnd = 80586, XrefRangeStart = 80581, XrefRangeEnd = 80583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000537DC File Offset: 0x000519DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80589, RefRangeEnd = 80592, XrefRangeStart = 80586, XrefRangeEnd = 80589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0005381C File Offset: 0x00051A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80592, XrefRangeEnd = 80598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityEventBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00053860 File Offset: 0x00051A60
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 80609, RefRangeEnd = 80638, XrefRangeStart = 80598, XrefRangeEnd = 80609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(functionName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityEventBase.NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0000C72B File Offset: 0x0000A92B
		public UnityEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000538C8 File Offset: 0x00051AC8
		// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000C734 File Offset: 0x0000A934
		public unsafe InvokableCallList m_Calls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokableCallList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000538F8 File Offset: 0x00051AF8
		// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000C753 File Offset: 0x0000A953
		public unsafe PersistentCallGroup m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentCallGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00053928 File Offset: 0x00051B28
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000C772 File Offset: 0x0000A972
		public unsafe bool m_CallsDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityEventBase.NativeFieldInfoPtr_m_CallsDirty)) = value;
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00053950 File Offset: 0x00051B50
		public MethodInfo FindMethod_Impl(string name, Object targetObj)
		{
			return this.FindMethod_Impl(name, targetObj.GetType());
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00053970 File Offset: 0x00051B70
		public int GetPersistentEventCount()
		{
			return this.m_PersistentCalls.Count;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00053990 File Offset: 0x00051B90
		public Object GetPersistentTarget(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener != null) ? listener.target : null;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000539BC File Offset: 0x00051BBC
		public string GetPersistentMethodName(int index)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			return (listener != null) ? listener.methodName : String.Empty;
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x000539EC File Offset: 0x00051BEC
		public void SetPersistentListenerState(int index, UnityEventCallState state)
		{
			PersistentCall listener = this.m_PersistentCalls.GetListener(index);
			bool flag = listener != null;
			if (flag)
			{
				listener.callState = state;
			}
			this.DirtyPersistentCalls();
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0000C78D File Offset: 0x0000A98D
		public void AddListener(Object targetObj, MethodInfo method)
		{
			this.m_Calls.AddListener(this.GetDelegate(targetObj, method));
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public void RemoveAllListeners()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00053A20 File Offset: 0x00051C20
		public void Invoke(Il2CppReferenceArray<Object> parameters)
		{
			List<BaseInvokableCall> list = this.PrepareInvoke();
			for (int i = 0; i < list.Count; i++)
			{
				list[i].Invoke(parameters);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00053A58 File Offset: 0x00051C58
		public static MethodInfo GetValidMethodInfo(Object obj, string functionName, Il2CppReferenceArray<Type> argumentTypes)
		{
			return UnityEventBase.GetValidMethodInfo(obj.GetType(), functionName, argumentTypes);
		}

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_m_Calls;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeFieldInfoPtr_m_CallsDirty;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Abstract_Virtual_New_MethodInfo_String_Type_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Abstract_Virtual_New_BaseInvokableCall_Object_MethodInfo_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_PersistentCall_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_FindMethod_Internal_MethodInfo_String_Type_PersistentListenerMode_Type_0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeMethodInfoPtr_DirtyPersistentCalls_Private_Void_0;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeMethodInfoPtr_RebuildPersistentCallsIfNeeded_Private_Void_0;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeMethodInfoPtr_AddCall_Internal_Void_BaseInvokableCall_0;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Protected_Void_Object_MethodInfo_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Internal_List_1_BaseInvokableCall_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr_GetValidMethodInfo_Public_Static_MethodInfo_Type_String_Il2CppReferenceArray_1_Type_0;
	}
}
