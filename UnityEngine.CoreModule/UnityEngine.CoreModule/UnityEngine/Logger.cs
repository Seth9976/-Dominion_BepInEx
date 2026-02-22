using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	public class Logger : Object
	{
		// Token: 0x06000C42 RID: 3138 RVA: 0x000341E4 File Offset: 0x000323E4
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Logger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger>.NativeClassPtr);
			Logger.NativeFieldInfoPtr__logHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logHandler>k__BackingField");
			Logger.NativeFieldInfoPtr__logEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logEnabled>k__BackingField");
			Logger.NativeFieldInfoPtr__filterLogType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<filterLogType>k__BackingField");
			Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663947);
			Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663948);
			Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663949);
			Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663950);
			Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663951);
			Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663952);
			Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663953);
			Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663954);
			Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663955);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663956);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663957);
			Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663958);
			Logger.NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663959);
			Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663960);
			Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663961);
			Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663962);
			Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663963);
			Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663964);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x000343B8 File Offset: 0x000325B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64726, XrefRangeEnd = 64727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Logger(ILogHandler logHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00034404 File Offset: 0x00032604
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00034444 File Offset: 0x00032644
		public unsafe virtual ILogHandler logHandler
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00034488 File Offset: 0x00032688
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x000344C4 File Offset: 0x000326C4
		public unsafe virtual bool logEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00034504 File Offset: 0x00032704
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00034540 File Offset: 0x00032740
		public unsafe virtual LogType filterLogType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00034580 File Offset: 0x00032780
		[CallerCount(0)]
		public unsafe virtual bool IsLogTypeAllowed(LogType logType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000345CC File Offset: 0x000327CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 64732, RefRangeEnd = 64737, XrefRangeStart = 64727, XrefRangeEnd = 64732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00034608 File Offset: 0x00032808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64737, XrefRangeEnd = 64747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00034658 File Offset: 0x00032858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64747, XrefRangeEnd = 64757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(LogType logType, Object message, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x000346BC File Offset: 0x000328BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64757, XrefRangeEnd = 64768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Log(string tag, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00034710 File Offset: 0x00032910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64768, XrefRangeEnd = 64779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogWarning(string tag, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00034764 File Offset: 0x00032964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64779, XrefRangeEnd = 64790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogError(string tag, Object message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000347B8 File Offset: 0x000329B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64790, XrefRangeEnd = 64793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000347FC File Offset: 0x000329FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64793, XrefRangeEnd = 64796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogException(Exception exception, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00034850 File Offset: 0x00032A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64796, XrefRangeEnd = 64799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogFormat(LogType logType, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000348C0 File Offset: 0x00032AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64799, XrefRangeEnd = 64802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LogFormat(LogType logType, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00008FDB File Offset: 0x000071DB
		public virtual void LogFormat(LogType logType, string format, params Object[] args)
		{
			this.LogFormat(logType, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00008FEB File Offset: 0x000071EB
		public virtual void LogFormat(LogType logType, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x00008FFD File Offset: 0x000071FD
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00034944 File Offset: 0x00032B44
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x00009006 File Offset: 0x00007206
		public unsafe ILogHandler _logHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00034974 File Offset: 0x00032B74
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x00009025 File Offset: 0x00007225
		public unsafe bool _logEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003499C File Offset: 0x00032B9C
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00009040 File Offset: 0x00007240
		public unsafe LogType _filterLogType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField)) = value;
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0000905B File Offset: 0x0000725B
		public void Log(LogType logType, string tag, Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00009068 File Offset: 0x00007268
		public void Log(LogType logType, string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00009075 File Offset: 0x00007275
		public void Log(Object message)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00009082 File Offset: 0x00007282
		public void Log(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0000908F File Offset: 0x0000728F
		public void LogWarning(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0000909C File Offset: 0x0000729C
		public void LogError(string tag, Object message, Object context)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeFieldInfoPtr__logHandler_k__BackingField;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeFieldInfoPtr__logEnabled_k__BackingField;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeFieldInfoPtr__filterLogType_k__BackingField;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_Object_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040009EB RID: 2539
		public const string kNoTagFormat = "{0}";

		// Token: 0x040009EC RID: 2540
		public const string kTagFormat = "{0}: {1}";
	}
}
