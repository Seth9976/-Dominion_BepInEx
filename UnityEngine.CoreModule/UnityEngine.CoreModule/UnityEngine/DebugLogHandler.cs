using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200003E RID: 62
	public sealed class DebugLogHandler : Object
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0001E304 File Offset: 0x0001C504
		// Note: this type is marked as 'beforefieldinit'.
		static DebugLogHandler()
		{
			Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DebugLogHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr);
			DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100663450);
			DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100663451);
			DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100663452);
			DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100663453);
			DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100663454);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0001E398 File Offset: 0x0001C598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60147, XrefRangeEnd = 60149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Log(LogType level, LogOption options, string msg, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0001E3FC File Offset: 0x0001C5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60149, XrefRangeEnd = 60151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_LogException(Exception ex, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0001E444 File Offset: 0x0001C644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60151, XrefRangeEnd = 60154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFormat(LogType logType, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60154, XrefRangeEnd = 60162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogException(Exception exception, Object context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0001E51C File Offset: 0x0001C71C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugLogHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00004590 File Offset: 0x00002790
		public void LogFormat(LogType logType, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000045A2 File Offset: 0x000027A2
		public DebugLogHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000045AB File Offset: 0x000027AB
		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			DebugLogHandler.Internal_Log(logType, logOptions, String.Format(format, args), context);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000045C0 File Offset: 0x000027C0
		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
