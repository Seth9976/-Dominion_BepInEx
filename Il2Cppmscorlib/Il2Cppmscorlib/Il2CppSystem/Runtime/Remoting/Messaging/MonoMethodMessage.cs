using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000401 RID: 1025
	[Serializable]
	public class MonoMethodMessage : Object
	{
		// Token: 0x060040BC RID: 16572 RVA: 0x0012BE40 File Offset: 0x0012A040
		// Note: this type is marked as 'beforefieldinit'.
		static MonoMethodMessage()
		{
			Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MonoMethodMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr);
			MonoMethodMessage.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "method");
			MonoMethodMessage.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "args");
			MonoMethodMessage.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "names");
			MonoMethodMessage.NativeFieldInfoPtr_arg_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "arg_types");
			MonoMethodMessage.NativeFieldInfoPtr_ctx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "ctx");
			MonoMethodMessage.NativeFieldInfoPtr_rval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "rval");
			MonoMethodMessage.NativeFieldInfoPtr_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "exc");
			MonoMethodMessage.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "asyncResult");
			MonoMethodMessage.NativeFieldInfoPtr_call_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "call_type");
			MonoMethodMessage.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "uri");
			MonoMethodMessage.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "properties");
			MonoMethodMessage.NativeFieldInfoPtr_methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "methodSignature");
			MonoMethodMessage.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "identity");
			MonoMethodMessage.NativeFieldInfoPtr_CallContextKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "CallContextKey");
			MonoMethodMessage.NativeFieldInfoPtr_UriKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, "UriKey");
			MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672745);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672746);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672747);
			MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672748);
			MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672749);
			MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672750);
			MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672751);
			MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672752);
			MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672753);
			MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672754);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672755);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672756);
			MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672757);
			MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672758);
			MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672759);
			MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672760);
			MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672761);
			MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672762);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672763);
			MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672764);
			MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672765);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672766);
			MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672767);
			MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672768);
			MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672769);
			MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr, 100672770);
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0012C1A4 File Offset: 0x0012A3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355652, RefRangeEnd = 355654, XrefRangeStart = 355638, XrefRangeEnd = 355652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMessage(MonoMethod method, Il2CppReferenceArray<Object> out_args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0012C1F8 File Offset: 0x0012A3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355654, XrefRangeEnd = 355658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodBase method, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0012C258 File Offset: 0x0012A458
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355664, RefRangeEnd = 355666, XrefRangeStart = 355658, XrefRangeEnd = 355664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(MethodInfo minfo, Il2CppReferenceArray<Object> in_args, Il2CppReferenceArray<Object> out_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(minfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(out_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0012C2C8 File Offset: 0x0012A4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355666, XrefRangeEnd = 355668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetMethodInfo(Type type, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0012C320 File Offset: 0x0012A520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355668, XrefRangeEnd = 355678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoMethodMessage(Type type, string methodName, Il2CppReferenceArray<Object> in_args)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoMethodMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(in_args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x0012C390 File Offset: 0x0012A590
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355678, XrefRangeEnd = 355682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x0012C3D0 File Offset: 0x0012A5D0
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355682, XrefRangeEnd = 355686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060040C4 RID: 16580 RVA: 0x0012C40C File Offset: 0x0012A60C
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x0012C44C File Offset: 0x0012A64C
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x0012C48C File Offset: 0x0012A68C
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x0012C4D0 File Offset: 0x0012A6D0
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x0012C510 File Offset: 0x0012A710
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355686, XrefRangeEnd = 355689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x0012C548 File Offset: 0x0012A748
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355689, XrefRangeEnd = 355694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x0012C588 File Offset: 0x0012A788
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355694, XrefRangeEnd = 355697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x0012C5C0 File Offset: 0x0012A7C0
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x0012C5F8 File Offset: 0x0012A7F8
		public unsafe virtual string Uri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x0012C63C File Offset: 0x0012A83C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355697, RefRangeEnd = 355698, XrefRangeStart = 355697, XrefRangeEnd = 355697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetArg(int arg_num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg_num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x0012C688 File Offset: 0x0012A888
		public unsafe virtual Exception Exception
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x0012C6C8 File Offset: 0x0012A8C8
		public unsafe virtual int OutArgCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355698, XrefRangeEnd = 355699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x060040D0 RID: 16592 RVA: 0x0012C704 File Offset: 0x0012A904
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355699, XrefRangeEnd = 355705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x0012C744 File Offset: 0x0012A944
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x0012C784 File Offset: 0x0012A984
		// (set) Token: 0x060040D3 RID: 16595 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x0012C808 File Offset: 0x0012AA08
		public unsafe AsyncResult AsyncResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr3) : null;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x0012C848 File Offset: 0x0012AA48
		public unsafe CallType CallType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 355709, RefRangeEnd = 355713, XrefRangeStart = 355705, XrefRangeEnd = 355709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x0012C884 File Offset: 0x0012AA84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355715, RefRangeEnd = 355717, XrefRangeStart = 355713, XrefRangeEnd = 355715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NeedsOutProcessing(out int outCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoMethodMessage.NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x000188CF File Offset: 0x00016ACF
		public MonoMethodMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x060040D8 RID: 16600 RVA: 0x0012C8D0 File Offset: 0x0012AAD0
		// (set) Token: 0x060040D9 RID: 16601 RVA: 0x000188D8 File Offset: 0x00016AD8
		public unsafe MonoMethod method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x060040DA RID: 16602 RVA: 0x0012C900 File Offset: 0x0012AB00
		// (set) Token: 0x060040DB RID: 16603 RVA: 0x000188F7 File Offset: 0x00016AF7
		public unsafe Il2CppReferenceArray<Object> args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x0012C930 File Offset: 0x0012AB30
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x00018916 File Offset: 0x00016B16
		public unsafe Il2CppStringArray names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x060040DE RID: 16606 RVA: 0x0012C960 File Offset: 0x0012AB60
		// (set) Token: 0x060040DF RID: 16607 RVA: 0x00018935 File Offset: 0x00016B35
		public unsafe Il2CppStructArray<byte> arg_types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_arg_types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x0012C990 File Offset: 0x0012AB90
		// (set) Token: 0x060040E1 RID: 16609 RVA: 0x00018954 File Offset: 0x00016B54
		public unsafe LogicalCallContext ctx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_ctx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x060040E2 RID: 16610 RVA: 0x0012C9C0 File Offset: 0x0012ABC0
		// (set) Token: 0x060040E3 RID: 16611 RVA: 0x00018973 File Offset: 0x00016B73
		public unsafe Object rval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_rval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x060040E4 RID: 16612 RVA: 0x0012C9F0 File Offset: 0x0012ABF0
		// (set) Token: 0x060040E5 RID: 16613 RVA: 0x00018992 File Offset: 0x00016B92
		public unsafe Exception exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x060040E6 RID: 16614 RVA: 0x0012CA20 File Offset: 0x0012AC20
		// (set) Token: 0x060040E7 RID: 16615 RVA: 0x000189B1 File Offset: 0x00016BB1
		public unsafe AsyncResult asyncResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncResult>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x060040E8 RID: 16616 RVA: 0x0012CA50 File Offset: 0x0012AC50
		// (set) Token: 0x060040E9 RID: 16617 RVA: 0x000189D0 File Offset: 0x00016BD0
		public unsafe CallType call_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_call_type)) = value;
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x060040EA RID: 16618 RVA: 0x0012CA78 File Offset: 0x0012AC78
		// (set) Token: 0x060040EB RID: 16619 RVA: 0x000189EB File Offset: 0x00016BEB
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x0012CAA0 File Offset: 0x0012ACA0
		// (set) Token: 0x060040ED RID: 16621 RVA: 0x00018A0A File Offset: 0x00016C0A
		public unsafe MCMDictionary properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MCMDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x060040EE RID: 16622 RVA: 0x0012CAD0 File Offset: 0x0012ACD0
		// (set) Token: 0x060040EF RID: 16623 RVA: 0x00018A29 File Offset: 0x00016C29
		public unsafe Il2CppReferenceArray<Type> methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x060040F0 RID: 16624 RVA: 0x0012CB00 File Offset: 0x0012AD00
		// (set) Token: 0x060040F1 RID: 16625 RVA: 0x00018A48 File Offset: 0x00016C48
		public unsafe Identity identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoMethodMessage.NativeFieldInfoPtr_identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x060040F2 RID: 16626 RVA: 0x0012CB30 File Offset: 0x0012AD30
		// (set) Token: 0x060040F3 RID: 16627 RVA: 0x00018A67 File Offset: 0x00016C67
		public unsafe static string CallContextKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoMethodMessage.NativeFieldInfoPtr_CallContextKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoMethodMessage.NativeFieldInfoPtr_CallContextKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x060040F4 RID: 16628 RVA: 0x0012CB50 File Offset: 0x0012AD50
		// (set) Token: 0x060040F5 RID: 16629 RVA: 0x00018A79 File Offset: 0x00016C79
		public unsafe static string UriKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoMethodMessage.NativeFieldInfoPtr_UriKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoMethodMessage.NativeFieldInfoPtr_UriKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeFieldInfoPtr_names;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeFieldInfoPtr_arg_types;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeFieldInfoPtr_ctx;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeFieldInfoPtr_rval;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeFieldInfoPtr_exc;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeFieldInfoPtr_call_type;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeFieldInfoPtr_methodSignature;

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeFieldInfoPtr_CallContextKey;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeFieldInfoPtr_UriKey;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeMethodInfoPtr_InitMessage_Internal_Void_MonoMethod_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodBase_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MethodInfo_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Type_String_0;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_Final_New_get_IDictionary_0;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeMethodInfoPtr_set_LogicalCallContext_Public_set_Void_LogicalCallContext_0;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003514 RID: 13588
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04003515 RID: 13589
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x04003516 RID: 13590
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncResult_Public_get_AsyncResult_0;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeMethodInfoPtr_get_CallType_Internal_get_CallType_0;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeMethodInfoPtr_NeedsOutProcessing_Public_Boolean_byref_Int32_0;
	}
}
