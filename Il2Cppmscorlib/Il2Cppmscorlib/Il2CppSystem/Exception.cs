using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Diagnostics;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000A3 RID: 163
	[Serializable]
	public class Exception : Object
	{
		// Token: 0x06000B70 RID: 2928 RVA: 0x00055D40 File Offset: 0x00053F40
		// Note: this type is marked as 'beforefieldinit'.
		static Exception()
		{
			Il2CppClassPointerStore<Exception>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Exception");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Exception>.NativeClassPtr);
			Exception.NativeFieldInfoPtr_s_EDILock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "s_EDILock");
			Exception.NativeFieldInfoPtr__className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_className");
			Exception.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_message");
			Exception.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_data");
			Exception.NativeFieldInfoPtr__innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_innerException");
			Exception.NativeFieldInfoPtr__helpURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_helpURL");
			Exception.NativeFieldInfoPtr__stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTrace");
			Exception.NativeFieldInfoPtr__stackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_stackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackTraceString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackTraceString");
			Exception.NativeFieldInfoPtr__remoteStackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_remoteStackIndex");
			Exception.NativeFieldInfoPtr__dynamicMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_dynamicMethods");
			Exception.NativeFieldInfoPtr__HResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_HResult");
			Exception.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_source");
			Exception.NativeFieldInfoPtr__safeSerializationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_safeSerializationManager");
			Exception.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "captured_traces");
			Exception.NativeFieldInfoPtr_native_trace_ips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "native_trace_ips");
			Exception.NativeFieldInfoPtr__COMPlusExceptionCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Exception>.NativeClassPtr, "_COMPlusExceptionCode");
			Exception.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665231);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665232);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665233);
			Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665234);
			Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665235);
			Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665236);
			Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665237);
			Exception.NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665238);
			Exception.NativeMethodInfoPtr_GetClassName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665239);
			Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665240);
			Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665241);
			Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665242);
			Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665243);
			Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665244);
			Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665245);
			Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665246);
			Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665247);
			Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665248);
			Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665249);
			Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665250);
			Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665251);
			Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665252);
			Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665253);
			Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665254);
			Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665255);
			Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Exception>.NativeClassPtr, 100665256);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x000560CC File Offset: 0x000542CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283207, XrefRangeEnd = 283211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00056100 File Offset: 0x00054300
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 283216, RefRangeEnd = 283223, XrefRangeStart = 283211, XrefRangeEnd = 283216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0005613C File Offset: 0x0005433C
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 283228, RefRangeEnd = 283257, XrefRangeStart = 283223, XrefRangeEnd = 283228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00056188 File Offset: 0x00054388
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 283262, RefRangeEnd = 283272, XrefRangeStart = 283257, XrefRangeEnd = 283262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x000561E8 File Offset: 0x000543E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 283328, RefRangeEnd = 283339, XrefRangeStart = 283272, XrefRangeEnd = 283328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Exception>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0005624C File Offset: 0x0005444C
		public unsafe virtual string Message
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 283347, RefRangeEnd = 283357, XrefRangeStart = 283339, XrefRangeEnd = 283347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00056290 File Offset: 0x00054490
		public unsafe virtual IDictionary Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283357, XrefRangeEnd = 283365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x000562DC File Offset: 0x000544DC
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsImmutableAgileException(Exception e)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00056320 File Offset: 0x00054520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283365, XrefRangeEnd = 283366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetClassName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetClassName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00056358 File Offset: 0x00054558
		public unsafe virtual Exception InnerException
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x00056398 File Offset: 0x00054598
		public unsafe virtual string StackTrace
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283368, RefRangeEnd = 283369, XrefRangeStart = 283366, XrefRangeEnd = 283368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000563DC File Offset: 0x000545DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283369, XrefRangeEnd = 283371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStackTrace(bool needFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00056420 File Offset: 0x00054620
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetErrorCode(int hr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00056460 File Offset: 0x00054660
		public unsafe virtual string Source
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283371, XrefRangeEnd = 283376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x000564A4 File Offset: 0x000546A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283383, RefRangeEnd = 283385, XrefRangeStart = 283376, XrefRangeEnd = 283383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x000564E8 File Offset: 0x000546E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283416, RefRangeEnd = 283418, XrefRangeStart = 283385, XrefRangeEnd = 283416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(bool needFileLineInfo, bool needMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needFileLineInfo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needMessage;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0005653C File Offset: 0x0005473C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 283491, RefRangeEnd = 283514, XrefRangeStart = 283418, XrefRangeEnd = 283491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Exception.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x000565A0 File Offset: 0x000547A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283514, XrefRangeEnd = 283519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000565E8 File Offset: 0x000547E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23543, RefRangeEnd = 23544, XrefRangeStart = 23543, XrefRangeEnd = 23544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string StripFileInfo(string stackTrace, bool isRemoteStackTrace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRemoteStackTrace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00056640 File Offset: 0x00054840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283523, RefRangeEnd = 283524, XrefRangeStart = 283519, XrefRangeEnd = 283523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionDispatchInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00056684 File Offset: 0x00054884
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x000566C0 File Offset: 0x000548C0
		public unsafe int HResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_get_HResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00056700 File Offset: 0x00054900
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 283525, RefRangeEnd = 283532, XrefRangeStart = 283524, XrefRangeEnd = 283525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe virtual Type GetIl2CppType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00056740 File Offset: 0x00054940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283536, RefRangeEnd = 283539, XrefRangeStart = 283532, XrefRangeEnd = 283536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessageFromNativeResources(Exception.ExceptionMessageKind kind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00056778 File Offset: 0x00054978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283549, RefRangeEnd = 283550, XrefRangeStart = 283539, XrefRangeEnd = 283549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception FixRemotingException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000567B8 File Offset: 0x000549B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283551, RefRangeEnd = 283552, XrefRangeStart = 283550, XrefRangeEnd = 283551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportUnhandledException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Exception.NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00004EA9 File Offset: 0x000030A9
		public Exception(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x000567F0 File Offset: 0x000549F0
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x00004EB2 File Offset: 0x000030B2
		public unsafe static Object s_EDILock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr_s_EDILock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr_s_EDILock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x00056818 File Offset: 0x00054A18
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x00004EC4 File Offset: 0x000030C4
		public unsafe string _className
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__className), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x00056840 File Offset: 0x00054A40
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00004EE3 File Offset: 0x000030E3
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x00056868 File Offset: 0x00054A68
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x00004F02 File Offset: 0x00003102
		public unsafe IDictionary _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x00056898 File Offset: 0x00054A98
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x00004F21 File Offset: 0x00003121
		public unsafe Exception _innerException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__innerException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000568C8 File Offset: 0x00054AC8
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00004F40 File Offset: 0x00003140
		public unsafe string _helpURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__helpURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000568F0 File Offset: 0x00054AF0
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00004F5F File Offset: 0x0000315F
		public unsafe Object _stackTrace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTrace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00056920 File Offset: 0x00054B20
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00004F7E File Offset: 0x0000317E
		public unsafe string _stackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__stackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x00056948 File Offset: 0x00054B48
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x00004F9D File Offset: 0x0000319D
		public unsafe string _remoteStackTraceString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackTraceString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x00056970 File Offset: 0x00054B70
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x00004FBC File Offset: 0x000031BC
		public unsafe int _remoteStackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__remoteStackIndex)) = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x00056998 File Offset: 0x00054B98
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x00004FD7 File Offset: 0x000031D7
		public unsafe Object _dynamicMethods
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__dynamicMethods), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000569C8 File Offset: 0x00054BC8
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x00004FF6 File Offset: 0x000031F6
		public unsafe int _HResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__HResult)) = value;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x000569F0 File Offset: 0x00054BF0
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x00005011 File Offset: 0x00003211
		public unsafe string _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__source), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x00056A18 File Offset: 0x00054C18
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x00005030 File Offset: 0x00003230
		public unsafe SafeSerializationManager _safeSerializationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeSerializationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr__safeSerializationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x00056A48 File Offset: 0x00054C48
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0000504F File Offset: 0x0000324F
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x00056A78 File Offset: 0x00054C78
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0000506E File Offset: 0x0000326E
		public unsafe Il2CppStructArray<IntPtr> native_trace_ips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Exception.NativeFieldInfoPtr_native_trace_ips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x00056AA8 File Offset: 0x00054CA8
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0000508D File Offset: 0x0000328D
		public unsafe static int _COMPlusExceptionCode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Exception.NativeFieldInfoPtr__COMPlusExceptionCode, (void*)(&value));
			}
		}

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeFieldInfoPtr_s_EDILock;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr__className;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeFieldInfoPtr__innerException;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr__helpURL;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr__stackTrace;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr__stackTraceString;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackTraceString;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr__remoteStackIndex;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr__dynamicMethods;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr__HResult;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr__safeSerializationManager;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeFieldInfoPtr_native_trace_ips;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeFieldInfoPtr__COMPlusExceptionCode;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_New_get_String_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_IsImmutableAgileException_Private_Static_Boolean_Exception_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_GetClassName_Private_String_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerException_Public_Virtual_Final_New_get_Exception_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Virtual_New_get_String_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Private_String_Boolean_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorCode_Internal_Void_Int32_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_Virtual_New_get_String_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Private_String_Boolean_Boolean_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_StripFileInfo_Private_String_String_Boolean_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_RestoreExceptionDispatchInfo_Internal_Void_ExceptionDispatchInfo_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_get_HResult_Public_get_Int32_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_set_HResult_Protected_set_Void_Int32_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_GetIl2CppType_Public_Virtual_Final_New_Type_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageFromNativeResources_Internal_Static_String_ExceptionMessageKind_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_FixRemotingException_Internal_Exception_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_ReportUnhandledException_Internal_Static_Void_Exception_0;

		// Token: 0x02000592 RID: 1426
		public enum ExceptionMessageKind
		{
			// Token: 0x04003FC0 RID: 16320
			ThreadAbort = 1,
			// Token: 0x04003FC1 RID: 16321
			ThreadInterrupted,
			// Token: 0x04003FC2 RID: 16322
			OutOfMemory
		}
	}
}
