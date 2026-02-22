using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class PersistentCall : Object
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x00052690 File Offset: 0x00050890
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentCall()
		{
			Il2CppClassPointerStore<PersistentCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr);
			PersistentCall.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Target");
			PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_TargetAssemblyTypeName");
			PersistentCall.NativeFieldInfoPtr_m_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_MethodName");
			PersistentCall.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Mode");
			PersistentCall.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_Arguments");
			PersistentCall.NativeFieldInfoPtr_m_CallState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, "m_CallState");
			PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664897);
			PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664898);
			PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664899);
			PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664900);
			PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664901);
			PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664902);
			PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664903);
			PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664904);
			PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664905);
			PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664906);
			PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100664907);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00052814 File Offset: 0x00050A14
		public unsafe Object target
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00052854 File Offset: 0x00050A54
		public unsafe string targetAssemblyTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80222, RefRangeEnd = 80223, XrefRangeStart = 80206, XrefRangeEnd = 80222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0005288C File Offset: 0x00050A8C
		public unsafe string methodName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x000528C4 File Offset: 0x00050AC4
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0000C5D3 File Offset: 0x0000A7D3
		public unsafe PersistentListenerMode mode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80226, RefRangeEnd = 80229, XrefRangeStart = 80226, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Mode = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00052900 File Offset: 0x00050B00
		public unsafe ArgumentCache arguments
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 80229, RefRangeEnd = 80231, XrefRangeStart = 80229, XrefRangeEnd = 80229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr3) : null;
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00052940 File Offset: 0x00050B40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80249, RefRangeEnd = 80250, XrefRangeStart = 80231, XrefRangeEnd = 80249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0005297C File Offset: 0x00050B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80302, RefRangeEnd = 80303, XrefRangeStart = 80250, XrefRangeEnd = 80302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(theEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000529CC File Offset: 0x00050BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80365, RefRangeEnd = 80366, XrefRangeStart = 80303, XrefRangeEnd = 80365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInvokableCall>(intPtr3) : null;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00052A34 File Offset: 0x00050C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00052A68 File Offset: 0x00050C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00052A9C File Offset: 0x00050C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80366, XrefRangeEnd = 80371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0000C518 File Offset: 0x0000A718
		public PersistentCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00052AD8 File Offset: 0x00050CD8
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0000C521 File Offset: 0x0000A721
		public unsafe Object m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00052B08 File Offset: 0x00050D08
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x0000C540 File Offset: 0x0000A740
		public unsafe string m_TargetAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x00052B30 File Offset: 0x00050D30
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x0000C55F File Offset: 0x0000A75F
		public unsafe string m_MethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00052B58 File Offset: 0x00050D58
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x0000C57E File Offset: 0x0000A77E
		public unsafe PersistentListenerMode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00052B80 File Offset: 0x00050D80
		// (set) Token: 0x060015B3 RID: 5555 RVA: 0x0000C599 File Offset: 0x0000A799
		public unsafe ArgumentCache m_Arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgumentCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00052BB0 File Offset: 0x00050DB0
		// (set) Token: 0x060015B5 RID: 5557 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		public unsafe UnityEventCallState m_CallState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState)) = value;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x00052BD8 File Offset: 0x00050DD8
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0000C5DD File Offset: 0x0000A7DD
		public UnityEventCallState callState
		{
			get
			{
				return this.m_CallState;
			}
			set
			{
				this.m_CallState = value;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0000C5E7 File Offset: 0x0000A7E7
		public void RegisterPersistentListener(Object ttarget, Type targetType, string mmethodName)
		{
			this.m_Target = ttarget;
			this.m_TargetAssemblyTypeName = UnityEventTools.TidyAssemblyTypeName(targetType.AssemblyQualifiedName);
			this.m_MethodName = mmethodName;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x0000C609 File Offset: 0x0000A809
		public void UnregisterPersistentListener()
		{
			this.m_MethodName = String.Empty;
			this.m_Target = null;
			this.m_TargetAssemblyTypeName = String.Empty;
		}

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetAssemblyTypeName;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeFieldInfoPtr_m_MethodName;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_m_Arguments;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_m_CallState;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_Object_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_get_methodName_Public_get_String_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
