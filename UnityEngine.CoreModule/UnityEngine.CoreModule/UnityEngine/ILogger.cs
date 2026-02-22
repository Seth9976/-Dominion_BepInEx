using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	public class ILogger : Il2CppObjectBase
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x00033C7C File Offset: 0x00031E7C
		// Note: this type is marked as 'beforefieldinit'.
		static ILogger()
		{
			Il2CppClassPointerStore<ILogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ILogger");
			ILogger.NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663936);
			ILogger.NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663937);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663938);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663939);
			ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663940);
			ILogger.NativeMethodInfoPtr_LogWarning_Public_Abstract_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663941);
			ILogger.NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663942);
			ILogger.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663943);
			ILogger.NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogger>.NativeClassPtr, 100663944);
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00033D58 File Offset: 0x00031F58
		public unsafe virtual ILogHandler logHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogHandler>(intPtr3) : null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00033DA4 File Offset: 0x00031FA4
		public unsafe virtual bool logEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00033DEC File Offset: 0x00031FEC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00033E48 File Offset: 0x00032048
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00033EB8 File Offset: 0x000320B8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00033F18 File Offset: 0x00032118
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogWarning_Public_Abstract_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00033F78 File Offset: 0x00032178
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00033FD8 File Offset: 0x000321D8
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00034054 File Offset: 0x00032254
		[CallerCount(0)]
		public unsafe virtual void LogException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogger.NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00008FA7 File Offset: 0x000071A7
		public virtual void LogFormat(LogType logType, string format, params Object[] args)
		{
			this.LogFormat(logType, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00008FB7 File Offset: 0x000071B7
		public ILogger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_get_logHandler_Public_Abstract_Virtual_New_get_ILogHandler_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_get_logEnabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_LogType_Object_Object_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Object_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Abstract_Virtual_New_Void_String_Object_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Abstract_Virtual_New_Void_String_Object_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_0;
	}
}
