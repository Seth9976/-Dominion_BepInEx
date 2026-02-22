using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000407 RID: 1031
	public class ReturnMessage : Object
	{
		// Token: 0x0600410E RID: 16654 RVA: 0x0012D104 File Offset: 0x0012B304
		// Note: this type is marked as 'beforefieldinit'.
		static ReturnMessage()
		{
			Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ReturnMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr);
			ReturnMessage.NativeFieldInfoPtr__outArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_outArgs");
			ReturnMessage.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_args");
			ReturnMessage.NativeFieldInfoPtr__callCtx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_callCtx");
			ReturnMessage.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_returnValue");
			ReturnMessage.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_uri");
			ReturnMessage.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_exception");
			ReturnMessage.NativeFieldInfoPtr__methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_methodBase");
			ReturnMessage.NativeFieldInfoPtr__methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_methodName");
			ReturnMessage.NativeFieldInfoPtr__methodSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_methodSignature");
			ReturnMessage.NativeFieldInfoPtr__typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_typeName");
			ReturnMessage.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_properties");
			ReturnMessage.NativeFieldInfoPtr__targetIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_targetIdentity");
			ReturnMessage.NativeFieldInfoPtr__inArgInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, "_inArgInfo");
			ReturnMessage.NativeMethodInfoPtr__ctor_Public_Void_Object_Il2CppReferenceArray_1_Object_Int32_LogicalCallContext_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672781);
			ReturnMessage.NativeMethodInfoPtr__ctor_Public_Void_Exception_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672782);
			ReturnMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672783);
			ReturnMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672784);
			ReturnMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672785);
			ReturnMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672786);
			ReturnMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672787);
			ReturnMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672788);
			ReturnMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672789);
			ReturnMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672790);
			ReturnMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672791);
			ReturnMessage.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672792);
			ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672793);
			ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672794);
			ReturnMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672795);
			ReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672796);
			ReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672797);
			ReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672798);
			ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672799);
			ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr, 100672800);
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x0012D3C8 File Offset: 0x0012B5C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 355763, RefRangeEnd = 355765, XrefRangeStart = 355754, XrefRangeEnd = 355763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnMessage(Object ret, Il2CppReferenceArray<Object> outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ret);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outArgs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outArgsCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callCtx);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mcm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr__ctor_Public_Void_Object_Il2CppReferenceArray_1_Object_Int32_LogicalCallContext_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x0012D45C File Offset: 0x0012B65C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 355774, RefRangeEnd = 355781, XrefRangeStart = 355765, XrefRangeEnd = 355774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnMessage(Exception e, IMethodCallMessage mcm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReturnMessage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mcm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr__ctor_Public_Void_Exception_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06004111 RID: 16657 RVA: 0x0012D4BC File Offset: 0x0012B6BC
		public unsafe virtual int ArgCount
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 290346, RefRangeEnd = 290357, XrefRangeStart = 290346, XrefRangeEnd = 290357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06004112 RID: 16658 RVA: 0x0012D4F8 File Offset: 0x0012B6F8
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x0012D538 File Offset: 0x0012B738
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355781, XrefRangeEnd = 355785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x06004114 RID: 16660 RVA: 0x0012D578 File Offset: 0x0012B778
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x170010BB RID: 4283
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0012D5B8 File Offset: 0x0012B7B8
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355785, XrefRangeEnd = 355786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BC RID: 4284
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x0012D5F0 File Offset: 0x0012B7F0
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355786, XrefRangeEnd = 355792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010BD RID: 4285
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x0012D630 File Offset: 0x0012B830
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355792, XrefRangeEnd = 355796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0012D67C File Offset: 0x0012B87C
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355796, XrefRangeEnd = 355797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x0012D6B4 File Offset: 0x0012B8B4
		// (set) Token: 0x0600411A RID: 16666 RVA: 0x0012D6EC File Offset: 0x0012B8EC
		public unsafe virtual string Uri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x0012D730 File Offset: 0x0012B930
		// (set) Token: 0x0600411C RID: 16668 RVA: 0x0012D768 File Offset: 0x0012B968
		public unsafe virtual string System.Runtime.Remoting.Messaging.IInternalMessage.Uri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x0012D7AC File Offset: 0x0012B9AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237093, RefRangeEnd = 237095, XrefRangeStart = 237093, XrefRangeEnd = 237095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetArg(int argNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x0012D7F8 File Offset: 0x0012B9F8
		public unsafe virtual Exception Exception
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x0012D838 File Offset: 0x0012BA38
		public unsafe virtual Il2CppReferenceArray<Object> OutArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355797, XrefRangeEnd = 355802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x0012D878 File Offset: 0x0012BA78
		public unsafe virtual Object ReturnValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReturnMessage.NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06004121 RID: 16673 RVA: 0x0012D8C4 File Offset: 0x0012BAC4
		// (set) Token: 0x06004122 RID: 16674 RVA: 0x0012D904 File Offset: 0x0012BB04
		public unsafe virtual Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReturnMessage.NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00018B29 File Offset: 0x00016D29
		public ReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x0012D948 File Offset: 0x0012BB48
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x00018B32 File Offset: 0x00016D32
		public unsafe Il2CppReferenceArray<Object> _outArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__outArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__outArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x0012D978 File Offset: 0x0012BB78
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x00018B51 File Offset: 0x00016D51
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x0012D9A8 File Offset: 0x0012BBA8
		// (set) Token: 0x06004129 RID: 16681 RVA: 0x00018B70 File Offset: 0x00016D70
		public unsafe LogicalCallContext _callCtx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__callCtx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__callCtx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x0012D9D8 File Offset: 0x0012BBD8
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x00018B8F File Offset: 0x00016D8F
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0012DA08 File Offset: 0x0012BC08
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x00018BAE File Offset: 0x00016DAE
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x0012DA30 File Offset: 0x0012BC30
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x00018BCD File Offset: 0x00016DCD
		public unsafe Exception _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x0012DA60 File Offset: 0x0012BC60
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x00018BEC File Offset: 0x00016DEC
		public unsafe MethodBase _methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x0012DA90 File Offset: 0x0012BC90
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x00018C0B File Offset: 0x00016E0B
		public unsafe string _methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x0012DAB8 File Offset: 0x0012BCB8
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x00018C2A File Offset: 0x00016E2A
		public unsafe Il2CppReferenceArray<Type> _methodSignature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodSignature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__methodSignature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x0012DAE8 File Offset: 0x0012BCE8
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00018C49 File Offset: 0x00016E49
		public unsafe string _typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x0012DB10 File Offset: 0x0012BD10
		// (set) Token: 0x06004139 RID: 16697 RVA: 0x00018C68 File Offset: 0x00016E68
		public unsafe MethodReturnDictionary _properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodReturnDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x0012DB40 File Offset: 0x0012BD40
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x00018C87 File Offset: 0x00016E87
		public unsafe Identity _targetIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__targetIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__targetIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x0012DB70 File Offset: 0x0012BD70
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x00018CA6 File Offset: 0x00016EA6
		public unsafe ArgInfo _inArgInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__inArgInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArgInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReturnMessage.NativeFieldInfoPtr__inArgInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400352B RID: 13611
		private static readonly IntPtr NativeFieldInfoPtr__outArgs;

		// Token: 0x0400352C RID: 13612
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x0400352D RID: 13613
		private static readonly IntPtr NativeFieldInfoPtr__callCtx;

		// Token: 0x0400352E RID: 13614
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x0400352F RID: 13615
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x04003530 RID: 13616
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x04003531 RID: 13617
		private static readonly IntPtr NativeFieldInfoPtr__methodBase;

		// Token: 0x04003532 RID: 13618
		private static readonly IntPtr NativeFieldInfoPtr__methodName;

		// Token: 0x04003533 RID: 13619
		private static readonly IntPtr NativeFieldInfoPtr__methodSignature;

		// Token: 0x04003534 RID: 13620
		private static readonly IntPtr NativeFieldInfoPtr__typeName;

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeFieldInfoPtr__properties;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeFieldInfoPtr__targetIdentity;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeFieldInfoPtr__inArgInfo;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Il2CppReferenceArray_1_Object_Int32_LogicalCallContext_IMethodCallMessage_0;

		// Token: 0x04003539 RID: 13625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_IMethodCallMessage_0;

		// Token: 0x0400353A RID: 13626
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400353B RID: 13627
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400353C RID: 13628
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003542 RID: 13634
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003543 RID: 13635
		private static readonly IntPtr NativeMethodInfoPtr_set_Uri_Public_set_Void_String_0;

		// Token: 0x04003544 RID: 13636
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_Uri_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04003545 RID: 13637
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_Uri_Private_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04003546 RID: 13638
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x04003547 RID: 13639
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x04003548 RID: 13640
		private static readonly IntPtr NativeMethodInfoPtr_get_OutArgs_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003549 RID: 13641
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnValue_Public_Virtual_New_get_Object_0;

		// Token: 0x0400354A RID: 13642
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_get_TargetIdentity_Private_Virtual_Final_New_get_Identity_0;

		// Token: 0x0400354B RID: 13643
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Remoting_Messaging_IInternalMessage_set_TargetIdentity_Private_Virtual_Final_New_set_Void_Identity_0;
	}
}
