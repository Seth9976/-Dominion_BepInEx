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
	// Token: 0x020003FC RID: 1020
	[Serializable]
	public class MethodCall : Object
	{
		// Token: 0x06004028 RID: 16424 RVA: 0x00129B0C File Offset: 0x00127D0C
		// Note: this type is marked as 'beforefieldinit'.
		static MethodCall()
		{
			Il2CppClassPointerStore<MethodCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MethodCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodCall>.NativeClassPtr);
			MethodCall.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_uri");
			MethodCall.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_typeName");
			MethodCall.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodName");
			MethodCall.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_args");
			MethodCall.NativeFieldInfoPtr__methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodSignature");
			MethodCall.NativeFieldInfoPtr__methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_methodBase");
			MethodCall.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_callContext");
			MethodCall.NativeFieldInfoPtr__targetIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_targetIdentity");
			MethodCall.NativeFieldInfoPtr__genericArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "_genericArguments");
			MethodCall.NativeFieldInfoPtr_ExternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "ExternalProperties");
			MethodCall.NativeFieldInfoPtr_InternalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, "InternalProperties");
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672664);
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672665);
			MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672666);
			MethodCall.NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672667);
			MethodCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672668);
			MethodCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672669);
			MethodCall.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672670);
			MethodCall.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672671);
			MethodCall.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672672);
			MethodCall.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672673);
			MethodCall.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672674);
			MethodCall.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672675);
			MethodCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672676);
			MethodCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672677);
			MethodCall.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672678);
			MethodCall.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672679);
			MethodCall.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672680);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672681);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672682);
			MethodCall.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672683);
			MethodCall.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672684);
			MethodCall.NativeMethodInfoPtr_ResolveMethod_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672685);
			MethodCall.NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672686);
			MethodCall.NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672687);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672688);
			MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672689);
			MethodCall.NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodCall>.NativeClassPtr, 100672690);
		}

		// Token: 0x06004029 RID: 16425 RVA: 0x00129E34 File Offset: 0x00128034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355030, RefRangeEnd = 355031, XrefRangeStart = 355025, XrefRangeEnd = 355030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600402A RID: 16426 RVA: 0x00129E98 File Offset: 0x00128098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355042, RefRangeEnd = 355043, XrefRangeStart = 355031, XrefRangeEnd = 355042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall(CADMethodCallMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402B RID: 16427 RVA: 0x00129EE4 File Offset: 0x001280E4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodCall()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodCall>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00129F20 File Offset: 0x00128120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355066, RefRangeEnd = 355068, XrefRangeStart = 355043, XrefRangeEnd = 355066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyFrom(IMethodMessage call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00129F64 File Offset: 0x00128164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355068, XrefRangeEnd = 355084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitMethodProperty(string key, Object value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00129FC4 File Offset: 0x001281C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355127, RefRangeEnd = 355128, XrefRangeStart = 355084, XrefRangeEnd = 355127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x0012A028 File Offset: 0x00128228
		public unsafe virtual int ArgCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06004030 RID: 16432 RVA: 0x0012A064 File Offset: 0x00128264
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06004031 RID: 16433 RVA: 0x0012A0A4 File Offset: 0x001282A4
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355128, XrefRangeEnd = 355132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x0012A0E4 File Offset: 0x001282E4
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 355135, RefRangeEnd = 355136, XrefRangeStart = 355132, XrefRangeEnd = 355135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x0012A124 File Offset: 0x00128324
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x0012A15C File Offset: 0x0012835C
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355136, XrefRangeEnd = 355143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x0012A19C File Offset: 0x0012839C
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 355143, RefRangeEnd = 355144, XrefRangeStart = 355143, XrefRangeEnd = 355143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x0012A1E8 File Offset: 0x001283E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355144, XrefRangeEnd = 355149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06004037 RID: 16439 RVA: 0x0012A224 File Offset: 0x00128424
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x0012A25C File Offset: 0x0012845C
		// (set) Token: 0x06004039 RID: 16441 RVA: 0x0012A294 File Offset: 0x00128494
		public unsafe virtual string Uri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x0012A2D8 File Offset: 0x001284D8
		// (set) Token: 0x0600403B RID: 16443 RVA: 0x0012A310 File Offset: 0x00128510
		public unsafe virtual string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x0012A354 File Offset: 0x00128554
		[CallerCount(0)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0012A3A0 File Offset: 0x001285A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodCall.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0012A3DC File Offset: 0x001285DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355185, RefRangeEnd = 355186, XrefRangeStart = 355149, XrefRangeEnd = 355185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_ResolveMethod_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0012A410 File Offset: 0x00128610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355199, RefRangeEnd = 355200, XrefRangeStart = 355186, XrefRangeEnd = 355199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type CastTo(string clientType, Type serverType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clientType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0012A474 File Offset: 0x00128674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355200, XrefRangeEnd = 355207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeNameFromAssemblyQualifiedName(string aqname)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aqname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06004041 RID: 16449 RVA: 0x0012A4B0 File Offset: 0x001286B0
		// (set) Token: 0x06004042 RID: 16450 RVA: 0x0012A4F0 File Offset: 0x001286F0
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x06004043 RID: 16451 RVA: 0x0012A534 File Offset: 0x00128734
		public unsafe Il2CppReferenceArray<Type> GenericArguments
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 355208, RefRangeEnd = 355210, XrefRangeStart = 355207, XrefRangeEnd = 355208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodCall.NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000184CE File Offset: 0x000166CE
		public MethodCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06004045 RID: 16453 RVA: 0x0012A574 File Offset: 0x00128774
		// (set) Token: 0x06004046 RID: 16454 RVA: 0x000184D7 File Offset: 0x000166D7
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06004047 RID: 16455 RVA: 0x0012A59C File Offset: 0x0012879C
		// (set) Token: 0x06004048 RID: 16456 RVA: 0x000184F6 File Offset: 0x000166F6
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x06004049 RID: 16457 RVA: 0x0012A5C4 File Offset: 0x001287C4
		// (set) Token: 0x0600404A RID: 16458 RVA: 0x00018515 File Offset: 0x00016715
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x0012A5EC File Offset: 0x001287EC
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x00018534 File Offset: 0x00016734
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600404D RID: 16461 RVA: 0x0012A61C File Offset: 0x0012881C
		// (set) Token: 0x0600404E RID: 16462 RVA: 0x00018553 File Offset: 0x00016753
		public unsafe Il2CppReferenceArray<Type> _methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x0012A64C File Offset: 0x0012884C
		// (set) Token: 0x06004050 RID: 16464 RVA: 0x00018572 File Offset: 0x00016772
		public unsafe MethodBase _methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x0012A67C File Offset: 0x0012887C
		// (set) Token: 0x06004052 RID: 16466 RVA: 0x00018591 File Offset: 0x00016791
		public unsafe LogicalCallContext _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x0012A6AC File Offset: 0x001288AC
		// (set) Token: 0x06004054 RID: 16468 RVA: 0x000185B0 File Offset: 0x000167B0
		public unsafe Identity _targetIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__targetIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__targetIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x0012A6DC File Offset: 0x001288DC
		// (set) Token: 0x06004056 RID: 16470 RVA: 0x000185CF File Offset: 0x000167CF
		public unsafe Il2CppReferenceArray<Type> _genericArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__genericArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr__genericArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x0012A70C File Offset: 0x0012890C
		// (set) Token: 0x06004058 RID: 16472 RVA: 0x000185EE File Offset: 0x000167EE
		public unsafe IDictionary ExternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_ExternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_ExternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x0012A73C File Offset: 0x0012893C
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x0001860D File Offset: 0x0001680D
		public unsafe IDictionary InternalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_InternalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethodCall.NativeFieldInfoPtr_InternalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003488 RID: 13448
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x04003489 RID: 13449
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x0400348A RID: 13450
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x0400348B RID: 13451
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x0400348C RID: 13452
		private static readonly IntPtr NativeFieldInfoPtr__methodSignature;

		// Token: 0x0400348D RID: 13453
		private static readonly IntPtr NativeFieldInfoPtr__methodBase;

		// Token: 0x0400348E RID: 13454
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x0400348F RID: 13455
		private static readonly IntPtr NativeFieldInfoPtr__targetIdentity;

		// Token: 0x04003490 RID: 13456
		private static readonly IntPtr NativeFieldInfoPtr__genericArguments;

		// Token: 0x04003491 RID: 13457
		private static readonly IntPtr NativeFieldInfoPtr_ExternalProperties;

		// Token: 0x04003492 RID: 13458
		private static readonly IntPtr NativeFieldInfoPtr_InternalProperties;

		// Token: 0x04003493 RID: 13459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CADMethodCallMessage_0;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeMethodInfoPtr_CopyFrom_Internal_Void_IMethodMessage_0;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_New_Void_String_Object_0;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x0400349C RID: 13468
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x0400349D RID: 13469
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400349E RID: 13470
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeMethodInfoPtr_InitDictionary_Internal_Virtual_New_Void_0;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_0;

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeMethodInfoPtr_ResolveMethod_Public_Void_0;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeMethodInfoPtr_CastTo_Private_Type_String_Type_0;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeNameFromAssemblyQualifiedName_Private_Static_String_String_0;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericArguments_Private_get_Il2CppReferenceArray_1_Type_0;
	}
}
