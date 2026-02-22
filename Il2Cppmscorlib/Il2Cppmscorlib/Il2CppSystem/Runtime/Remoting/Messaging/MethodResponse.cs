using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003FF RID: 1023
	[Serializable]
	public class MethodResponse : Object
	{
		// Token: 0x0600407D RID: 16509 RVA: 0x0012B064 File Offset: 0x00129264
		// Note: this type is marked as 'beforefieldinit'.
		static MethodResponse()
		{
			Il2CppClassPointerStore<MethodResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr);
			MethodResponse.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodName");
			MethodResponse.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_uri");
			MethodResponse.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_typeName");
			MethodResponse.NativeFieldInfoPtr__methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodBase");
			MethodResponse.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_returnValue");
			MethodResponse.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_exception");
			MethodResponse.NativeFieldInfoPtr__methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_methodSignature");
			MethodResponse.NativeFieldInfoPtr__inArgInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_inArgInfo");
			MethodResponse.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_args");
			MethodResponse.NativeFieldInfoPtr__outArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_outArgs");
			MethodResponse.NativeFieldInfoPtr__callMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_callMsg");
			MethodResponse.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_callContext");
			MethodResponse.NativeFieldInfoPtr__targetIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "_targetIdentity");
			MethodResponse.NativeFieldInfoPtr_ExternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "ExternalProperties");
			MethodResponse.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, "InternalProperties");
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672719);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672720);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672721);
			MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672722);
			MethodResponse.NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672723);
			MethodResponse.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672724);
			MethodResponse.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672725);
			MethodResponse.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672726);
			MethodResponse.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672727);
			MethodResponse.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672728);
			MethodResponse.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672729);
			MethodResponse.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672730);
			MethodResponse.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672731);
			MethodResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672732);
			MethodResponse.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672733);
			MethodResponse.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672734);
			MethodResponse.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672735);
			MethodResponse.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672736);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672737);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672738);
			MethodResponse.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672739);
			MethodResponse.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672740);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672741);
			MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr, 100672742);
		}

		// Token: 0x0600407E RID: 16510 RVA: 0x0012B3A0 File Offset: 0x001295A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 355458, RefRangeEnd = 355461, XrefRangeStart = 355448, XrefRangeEnd = 355458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(Exception e, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600407F RID: 16511 RVA: 0x0012B400 File Offset: 0x00129600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355465, RefRangeEnd = 355467, XrefRangeStart = 355461, XrefRangeEnd = 355465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(Object returnValue, Il2CppReferenceArray<Object> outArgs, LogicalCallContext callCtx, IMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArgs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004080 RID: 16512 RVA: 0x0012B484 File Offset: 0x00129684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355485, RefRangeEnd = 355486, XrefRangeStart = 355467, XrefRangeEnd = 355485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(IMethodCallMessage msg, CADMethodReturnMessage retmsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(retmsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x0012B4E4 File Offset: 0x001296E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355492, RefRangeEnd = 355493, XrefRangeStart = 355486, XrefRangeEnd = 355492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodResponse(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodResponse>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x0012B548 File Offset: 0x00129748
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355512, RefRangeEnd = 355513, XrefRangeStart = 355493, XrefRangeEnd = 355512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMethodProperty(string key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x0012B59C File Offset: 0x0012979C
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x0012B5D8 File Offset: 0x001297D8
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06004085 RID: 16517 RVA: 0x0012B618 File Offset: 0x00129818
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x0012B658 File Offset: 0x00129858
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355513, XrefRangeEnd = 355517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06004087 RID: 16519 RVA: 0x0012B698 File Offset: 0x00129898
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355517, XrefRangeEnd = 355530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06004088 RID: 16520 RVA: 0x0012B6D8 File Offset: 0x001298D8
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355530, XrefRangeEnd = 355533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06004089 RID: 16521 RVA: 0x0012B710 File Offset: 0x00129910
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355533, XrefRangeEnd = 355539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600408A RID: 16522 RVA: 0x0012B750 File Offset: 0x00129950
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355539, XrefRangeEnd = 355560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600408B RID: 16523 RVA: 0x0012B790 File Offset: 0x00129990
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 355576, RefRangeEnd = 355577, XrefRangeStart = 355560, XrefRangeEnd = 355576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodResponse.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600408C RID: 16524 RVA: 0x0012B7DC File Offset: 0x001299DC
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x0600408D RID: 16525 RVA: 0x0012B81C File Offset: 0x00129A1C
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355577, XrefRangeEnd = 355580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x0012B854 File Offset: 0x00129A54
		// (set) Token: 0x0600408F RID: 16527 RVA: 0x0012B88C File Offset: 0x00129A8C
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355580, XrefRangeEnd = 355583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06004090 RID: 16528 RVA: 0x0012B8D0 File Offset: 0x00129AD0
		// (set) Token: 0x06004091 RID: 16529 RVA: 0x0012B908 File Offset: 0x00129B08
		public unsafe virtual string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0012B94C File Offset: 0x00129B4C
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x0012B998 File Offset: 0x00129B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355583, XrefRangeEnd = 355629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodResponse.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06004094 RID: 16532 RVA: 0x0012B9FC File Offset: 0x00129BFC
		// (set) Token: 0x06004095 RID: 16533 RVA: 0x0012BA3C File Offset: 0x00129C3C
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodResponse.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004096 RID: 16534 RVA: 0x000186C8 File Offset: 0x000168C8
		public MethodResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x0012BA80 File Offset: 0x00129C80
		// (set) Token: 0x06004098 RID: 16536 RVA: 0x000186D1 File Offset: 0x000168D1
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06004099 RID: 16537 RVA: 0x0012BAA8 File Offset: 0x00129CA8
		// (set) Token: 0x0600409A RID: 16538 RVA: 0x000186F0 File Offset: 0x000168F0
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x0600409B RID: 16539 RVA: 0x0012BAD0 File Offset: 0x00129CD0
		// (set) Token: 0x0600409C RID: 16540 RVA: 0x0001870F File Offset: 0x0001690F
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x0600409D RID: 16541 RVA: 0x0012BAF8 File Offset: 0x00129CF8
		// (set) Token: 0x0600409E RID: 16542 RVA: 0x0001872E File Offset: 0x0001692E
		public unsafe MethodBase _methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106C RID: 4204
		// (get) Token: 0x0600409F RID: 16543 RVA: 0x0012BB28 File Offset: 0x00129D28
		// (set) Token: 0x060040A0 RID: 16544 RVA: 0x0001874D File Offset: 0x0001694D
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x060040A1 RID: 16545 RVA: 0x0012BB58 File Offset: 0x00129D58
		// (set) Token: 0x060040A2 RID: 16546 RVA: 0x0001876C File Offset: 0x0001696C
		public unsafe Exception _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x060040A3 RID: 16547 RVA: 0x0012BB88 File Offset: 0x00129D88
		// (set) Token: 0x060040A4 RID: 16548 RVA: 0x0001878B File Offset: 0x0001698B
		public unsafe Il2CppReferenceArray<Type> _methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x060040A5 RID: 16549 RVA: 0x0012BBB8 File Offset: 0x00129DB8
		// (set) Token: 0x060040A6 RID: 16550 RVA: 0x000187AA File Offset: 0x000169AA
		public unsafe ArgInfo _inArgInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__inArgInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__inArgInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x060040A7 RID: 16551 RVA: 0x0012BBE8 File Offset: 0x00129DE8
		// (set) Token: 0x060040A8 RID: 16552 RVA: 0x000187C9 File Offset: 0x000169C9
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x0012BC18 File Offset: 0x00129E18
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x000187E8 File Offset: 0x000169E8
		public unsafe Il2CppReferenceArray<Object> _outArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__outArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__outArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x0012BC48 File Offset: 0x00129E48
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x00018807 File Offset: 0x00016A07
		public unsafe IMethodCallMessage _callMsg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callMsg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMethodCallMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callMsg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x060040AD RID: 16557 RVA: 0x0012BC78 File Offset: 0x00129E78
		// (set) Token: 0x060040AE RID: 16558 RVA: 0x00018826 File Offset: 0x00016A26
		public unsafe LogicalCallContext _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x060040AF RID: 16559 RVA: 0x0012BCA8 File Offset: 0x00129EA8
		// (set) Token: 0x060040B0 RID: 16560 RVA: 0x00018845 File Offset: 0x00016A45
		public unsafe Identity _targetIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__targetIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr__targetIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x060040B1 RID: 16561 RVA: 0x0012BCD8 File Offset: 0x00129ED8
		// (set) Token: 0x060040B2 RID: 16562 RVA: 0x00018864 File Offset: 0x00016A64
		public unsafe IDictionary ExternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_ExternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_ExternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x0012BD08 File Offset: 0x00129F08
		// (set) Token: 0x060040B4 RID: 16564 RVA: 0x00018883 File Offset: 0x00016A83
		public unsafe IDictionary InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodResponse.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeFieldInfoPtr__methodBase;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeFieldInfoPtr__methodSignature;

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeFieldInfoPtr__inArgInfo;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeFieldInfoPtr__outArgs;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeFieldInfoPtr__callMsg;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeFieldInfoPtr__targetIdentity;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeFieldInfoPtr_ExternalProperties;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_IMethodCallMessage_0;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Il2CppReferenceArray_1_Object_LogicalCallContext_IMethodCallMessage_0;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_CADMethodReturnMessage_0;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Void_String_Object_0;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;
	}
}
