using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EE RID: 1006
	[Serializable]
	public class ConstructionCall : MethodCall
	{
		// Token: 0x06003FBA RID: 16314 RVA: 0x001280EC File Offset: 0x001262EC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCall()
		{
			Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr);
			ConstructionCall.NativeFieldInfoPtr__activator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activator");
			ConstructionCall.NativeFieldInfoPtr__activationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationAttributes");
			ConstructionCall.NativeFieldInfoPtr__contextProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_contextProperties");
			ConstructionCall.NativeFieldInfoPtr__activationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationType");
			ConstructionCall.NativeFieldInfoPtr__activationTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationTypeName");
			ConstructionCall.NativeFieldInfoPtr__isContextOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_isContextOk");
			ConstructionCall.NativeFieldInfoPtr__sourceProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_sourceProxy");
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672603);
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672604);
			ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672605);
			ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672606);
			ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672607);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672608);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672609);
			ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672610);
			ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672611);
			ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672612);
			ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672613);
			ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672614);
			ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672615);
			ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672616);
			ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672617);
			ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672618);
			ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100672619);
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x001282FC File Offset: 0x001264FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354780, RefRangeEnd = 354782, XrefRangeStart = 354779, XrefRangeEnd = 354780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FBC RID: 16316 RVA: 0x00128348 File Offset: 0x00126548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354782, XrefRangeEnd = 354783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x001283AC File Offset: 0x001265AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354783, XrefRangeEnd = 354792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06003FBE RID: 16318 RVA: 0x001283E8 File Offset: 0x001265E8
		// (set) Token: 0x06003FBF RID: 16319 RVA: 0x00128424 File Offset: 0x00126624
		public unsafe bool IsContextOk
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x00128464 File Offset: 0x00126664
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354792, XrefRangeEnd = 354803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x001284A4 File Offset: 0x001266A4
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x001284DC File Offset: 0x001266DC
		// (set) Token: 0x06003FC3 RID: 16323 RVA: 0x0012851C File Offset: 0x0012671C
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x00128560 File Offset: 0x00126760
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x001285A0 File Offset: 0x001267A0
		[CallerCount(0)]
		public unsafe void SetActivationAttributes(Il2CppReferenceArray<Object> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x001285E4 File Offset: 0x001267E4
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354803, XrefRangeEnd = 354807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00128624 File Offset: 0x00126824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354807, XrefRangeEnd = 354820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00128684 File Offset: 0x00126884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354820, XrefRangeEnd = 354840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06003FC9 RID: 16329 RVA: 0x001286E8 File Offset: 0x001268E8
		public unsafe override IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354840, XrefRangeEnd = 354841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x00128734 File Offset: 0x00126934
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x00128774 File Offset: 0x00126974
		public unsafe RemotingProxy SourceProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00018287 File Offset: 0x00016487
		public ConstructionCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101C RID: 4124
		// (get) Token: 0x06003FCD RID: 16333 RVA: 0x001287B8 File Offset: 0x001269B8
		// (set) Token: 0x06003FCE RID: 16334 RVA: 0x00018290 File Offset: 0x00016490
		public unsafe IActivator _activator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101D RID: 4125
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x001287E8 File Offset: 0x001269E8
		// (set) Token: 0x06003FD0 RID: 16336 RVA: 0x000182AF File Offset: 0x000164AF
		public unsafe Il2CppReferenceArray<Object> _activationAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101E RID: 4126
		// (get) Token: 0x06003FD1 RID: 16337 RVA: 0x00128818 File Offset: 0x00126A18
		// (set) Token: 0x06003FD2 RID: 16338 RVA: 0x000182CE File Offset: 0x000164CE
		public unsafe IList _contextProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06003FD3 RID: 16339 RVA: 0x00128848 File Offset: 0x00126A48
		// (set) Token: 0x06003FD4 RID: 16340 RVA: 0x000182ED File Offset: 0x000164ED
		public unsafe Type _activationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06003FD5 RID: 16341 RVA: 0x00128878 File Offset: 0x00126A78
		// (set) Token: 0x06003FD6 RID: 16342 RVA: 0x0001830C File Offset: 0x0001650C
		public unsafe string _activationTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06003FD7 RID: 16343 RVA: 0x001288A0 File Offset: 0x00126AA0
		// (set) Token: 0x06003FD8 RID: 16344 RVA: 0x0001832B File Offset: 0x0001652B
		public unsafe bool _isContextOk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk)) = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x001288C8 File Offset: 0x00126AC8
		// (set) Token: 0x06003FDA RID: 16346 RVA: 0x00018346 File Offset: 0x00016546
		public unsafe RemotingProxy _sourceProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeFieldInfoPtr__activator;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeFieldInfoPtr__activationAttributes;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeFieldInfoPtr__contextProperties;

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeFieldInfoPtr__activationType;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeFieldInfoPtr__activationTypeName;

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeFieldInfoPtr__isContextOk;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeFieldInfoPtr__sourceProxy;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003451 RID: 13393
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04003452 RID: 13394
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0;

		// Token: 0x04003453 RID: 13395
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003454 RID: 13396
		private static readonly IntPtr NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003455 RID: 13397
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0;

		// Token: 0x04003456 RID: 13398
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0;

		// Token: 0x04003457 RID: 13399
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003458 RID: 13400
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0;

		// Token: 0x04003459 RID: 13401
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0;

		// Token: 0x0400345A RID: 13402
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0;
	}
}
