using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200003F RID: 63
	public class Debug : Object
	{
		// Token: 0x0600039A RID: 922 RVA: 0x0001E558 File Offset: 0x0001C758
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeFieldInfoPtr_s_DefaultLogger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_DefaultLogger");
			Debug.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Debug>.NativeClassPtr, "s_Logger");
			Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663455);
			Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663456);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663457);
			Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663458);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663459);
			Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663460);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663461);
			Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663462);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663463);
			Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663464);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663465);
			Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663466);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663467);
			Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663468);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663469);
			Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663470);
			Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663471);
			Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663472);
			Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663473);
			Debug.BreakDelegateField = IL2CPP.ResolveICall<Debug.BreakDelegate>("UnityEngine.Debug::Break");
			Debug.DebugBreakDelegateField = IL2CPP.ResolveICall<Debug.DebugBreakDelegate>("UnityEngine.Debug::DebugBreak");
			Debug.ClearDeveloperConsoleDelegateField = IL2CPP.ResolveICall<Debug.ClearDeveloperConsoleDelegate>("UnityEngine.Debug::ClearDeveloperConsole");
			Debug.get_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.get_developerConsoleVisibleDelegate>("UnityEngine.Debug::get_developerConsoleVisible");
			Debug.set_developerConsoleVisibleDelegateField = IL2CPP.ResolveICall<Debug.set_developerConsoleVisibleDelegate>("UnityEngine.Debug::set_developerConsoleVisible");
			Debug.get_isDebugBuildDelegateField = IL2CPP.ResolveICall<Debug.get_isDebugBuildDelegate>("UnityEngine.Debug::get_isDebugBuild");
			Debug.OpenConsoleFileDelegateField = IL2CPP.ResolveICall<Debug.OpenConsoleFileDelegate>("UnityEngine.Debug::OpenConsoleFile");
			Debug.GetDiagnosticSwitchDelegateField = IL2CPP.ResolveICall<Debug.GetDiagnosticSwitchDelegate>("UnityEngine.Debug::GetDiagnosticSwitch");
			Debug.SetDiagnosticSwitchDelegateField = IL2CPP.ResolveICall<Debug.SetDiagnosticSwitchDelegate>("UnityEngine.Debug::SetDiagnosticSwitch");
			Debug.DrawLine_InjectedDelegateField = IL2CPP.ResolveICall<Debug.DrawLine_InjectedDelegate>("UnityEngine.Debug::DrawLine_Injected");
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0001E7C4 File Offset: 0x0001C9C4
		public unsafe static ILogger unityLogger
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60162, XrefRangeEnd = 60166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr3) : null;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0001E7F8 File Offset: 0x0001C9F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60168, RefRangeEnd = 60169, XrefRangeStart = 60166, XrefRangeEnd = 60168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(projectFolder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001E854 File Offset: 0x0001CA54
		[CallerCount(387)]
		[CachedScanResults(RefRangeStart = 60180, RefRangeEnd = 60567, XrefRangeStart = 60169, XrefRangeEnd = 60180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001E88C File Offset: 0x0001CA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 60578, RefRangeEnd = 60581, XrefRangeStart = 60567, XrefRangeEnd = 60578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		[CallerCount(112)]
		[CachedScanResults(RefRangeStart = 60592, RefRangeEnd = 60704, XrefRangeStart = 60581, XrefRangeEnd = 60592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0001E90C File Offset: 0x0001CB0C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 60715, RefRangeEnd = 60723, XrefRangeStart = 60704, XrefRangeEnd = 60715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0001E954 File Offset: 0x0001CB54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60734, RefRangeEnd = 60735, XrefRangeStart = 60723, XrefRangeEnd = 60734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001E9AC File Offset: 0x0001CBAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60746, RefRangeEnd = 60748, XrefRangeStart = 60735, XrefRangeEnd = 60746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogErrorFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001EA14 File Offset: 0x0001CC14
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 60759, RefRangeEnd = 60768, XrefRangeStart = 60748, XrefRangeEnd = 60759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001EA4C File Offset: 0x0001CC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60779, RefRangeEnd = 60781, XrefRangeStart = 60768, XrefRangeEnd = 60779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception exception, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001EA94 File Offset: 0x0001CC94
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 60792, RefRangeEnd = 60884, XrefRangeStart = 60781, XrefRangeEnd = 60792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001EACC File Offset: 0x0001CCCC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 60895, RefRangeEnd = 60908, XrefRangeStart = 60884, XrefRangeEnd = 60895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(Object message, Object context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001EB14 File Offset: 0x0001CD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60919, RefRangeEnd = 60920, XrefRangeStart = 60908, XrefRangeEnd = 60919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0001EB6C File Offset: 0x0001CD6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60931, RefRangeEnd = 60933, XrefRangeStart = 60920, XrefRangeEnd = 60931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarningFormat(Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0001EBD4 File Offset: 0x0001CDD4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 60946, RefRangeEnd = 60962, XrefRangeStart = 60933, XrefRangeEnd = 60946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0001EC08 File Offset: 0x0001CE08
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 60973, RefRangeEnd = 60980, XrefRangeStart = 60962, XrefRangeEnd = 60973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assert(bool condition, string message)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60980, XrefRangeEnd = 60991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogAssertion(Object message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0001EC84 File Offset: 0x0001CE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60991, XrefRangeEnd = 61014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61014, XrefRangeEnd = 61040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoggingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000045D4 File Offset: 0x000027D4
		public static void LogErrorFormat(string format, params Object[] args)
		{
			Debug.LogErrorFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000045E2 File Offset: 0x000027E2
		public static void LogErrorFormat(Object context, string format, params Object[] args)
		{
			Debug.LogErrorFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000045F1 File Offset: 0x000027F1
		public static void LogWarningFormat(string format, params Object[] args)
		{
			Debug.LogWarningFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000045FF File Offset: 0x000027FF
		public static void LogWarningFormat(Object context, string format, params Object[] args)
		{
			Debug.LogWarningFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000460E File Offset: 0x0000280E
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0001ED08 File Offset: 0x0001CF08
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00004617 File Offset: 0x00002817
		public unsafe static ILogger s_DefaultLogger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_DefaultLogger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0001ED30 File Offset: 0x0001CF30
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00004629 File Offset: 0x00002829
		public unsafe static ILogger s_Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Debug.NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Debug.NativeFieldInfoPtr_s_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001ED58 File Offset: 0x0001CF58
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawLine(start, end, color, duration, flag);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
			bool flag = true;
			float num = 0f;
			Debug.DrawLine(start, end, color, num, flag);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0001ED98 File Offset: 0x0001CF98
		public static void DrawLine(Vector3 start, Vector3 end)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawLine(start, end, white, num, flag);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000463B File Offset: 0x0000283B
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest)
		{
			Debug.DrawLine_Injected(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
			bool flag = true;
			Debug.DrawRay(start, dir, color, duration, flag);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0001EDDC File Offset: 0x0001CFDC
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
			bool flag = true;
			float num = 0f;
			Debug.DrawRay(start, dir, color, num, flag);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0001EE00 File Offset: 0x0001D000
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
			bool flag = true;
			float num = 0f;
			Color white = Color.white;
			Debug.DrawRay(start, dir, white, num, flag);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000464B File Offset: 0x0000284B
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
		{
			Debug.DrawLine(start, start + dir, color, duration, depthTest);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00004660 File Offset: 0x00002860
		public static void Break()
		{
			Debug.BreakDelegateField();
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000466C File Offset: 0x0000286C
		public static void DebugBreak()
		{
			Debug.DebugBreakDelegateField();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00004678 File Offset: 0x00002878
		public static void LogFormat(string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, format, args);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00004689 File Offset: 0x00002889
		public static void LogFormat(string format, params Object[] args)
		{
			Debug.LogFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00004697 File Offset: 0x00002897
		public static void LogFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Log, context, format, args);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000046A9 File Offset: 0x000028A9
		public static void LogFormat(Object context, string format, params Object[] args)
		{
			Debug.LogFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0001EE28 File Offset: 0x0001D028
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			DebugLogHandler debugLogHandler = Debug.unityLogger.logHandler.TryCast<DebugLogHandler>();
			bool flag = debugLogHandler == null;
			if (flag)
			{
				Debug.unityLogger.LogFormat(logType, context, format, args);
			}
			else
			{
				debugLogHandler.LogFormat(logType, logOptions, context, format, args);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000046B8 File Offset: 0x000028B8
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			Debug.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000046CA File Offset: 0x000028CA
		public static void ClearDeveloperConsole()
		{
			Debug.ClearDeveloperConsoleDelegateField();
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000046D6 File Offset: 0x000028D6
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000046E2 File Offset: 0x000028E2
		public static bool developerConsoleVisible
		{
			get
			{
				return Debug.get_developerConsoleVisibleDelegateField();
			}
			set
			{
				Debug.set_developerConsoleVisibleDelegateField(value);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0001EE70 File Offset: 0x0001D070
		public static void Assert(bool condition, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, "Assertion failed", context);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001EE98 File Offset: 0x0001D098
		public static void Assert(bool condition, Object message)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0001EEBC File Offset: 0x0001D0BC
		public static void Assert(bool condition, Object message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0001EEE0 File Offset: 0x0001D0E0
		public static void Assert(bool condition, string message, Object context)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.Log(LogType.Assert, message, context);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0001EF04 File Offset: 0x0001D104
		public static void AssertFormat(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000046EF File Offset: 0x000028EF
		public static void AssertFormat(bool condition, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0001EF28 File Offset: 0x0001D128
		public static void AssertFormat(bool condition, Object context, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000046FE File Offset: 0x000028FE
		public static void AssertFormat(bool condition, Object context, string format, params Object[] args)
		{
			Debug.AssertFormat(condition, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000470E File Offset: 0x0000290E
		public static void LogAssertion(Object message, Object context)
		{
			Debug.unityLogger.Log(LogType.Assert, message, context);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000471F File Offset: 0x0000291F
		public static void LogAssertionFormat(string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, format, args);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00004730 File Offset: 0x00002930
		public static void LogAssertionFormat(string format, params Object[] args)
		{
			Debug.LogAssertionFormat(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000473E File Offset: 0x0000293E
		public static void LogAssertionFormat(Object context, string format, Il2CppReferenceArray<Object> args)
		{
			Debug.unityLogger.LogFormat(LogType.Assert, context, format, args);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00004750 File Offset: 0x00002950
		public static void LogAssertionFormat(Object context, string format, params Object[] args)
		{
			Debug.LogAssertionFormat(context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000475F File Offset: 0x0000295F
		public static bool isDebugBuild
		{
			get
			{
				return Debug.get_isDebugBuildDelegateField();
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000476B File Offset: 0x0000296B
		public static void OpenConsoleFile()
		{
			Debug.OpenConsoleFileDelegateField();
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001EF50 File Offset: 0x0001D150
		public static Object GetDiagnosticSwitch(string name)
		{
			IntPtr intPtr = Debug.GetDiagnosticSwitchDelegateField(IL2CPP.ManagedStringToIl2Cpp(name));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00004777 File Offset: 0x00002977
		public static void SetDiagnosticSwitch(string name, Object value, bool setPersistent)
		{
			Debug.SetDiagnosticSwitchDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(value), setPersistent);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001EF7C File Offset: 0x0001D17C
		public static void Assert(bool condition, string format, Il2CppReferenceArray<Object> args)
		{
			bool flag = !condition;
			if (flag)
			{
				Debug.unityLogger.LogFormat(LogType.Assert, format, args);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00004790 File Offset: 0x00002990
		public static void Assert(bool condition, string format, params Object[] args)
		{
			Debug.Assert(condition, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0001EFA0 File Offset: 0x0001D1A0
		public static ILogger logger
		{
			get
			{
				return Debug.s_Logger;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000479F File Offset: 0x0000299F
		public static void DrawLine_Injected(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest)
		{
			Debug.DrawLine_InjectedDelegateField(ref start, ref end, ref color, duration, depthTest);
		}

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultLogger;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_s_Logger;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_get_unityLogger_Public_Static_get_ILogger_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTraceNoAlloc_Public_Static_Int32_ptr_Byte_Int32_String_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_Object_Object_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Object_Object_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_LogErrorFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_Object_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_Object_Object_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr_LogWarningFormat_Public_Static_Void_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_Assert_Public_Static_Void_Boolean_String_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_LogAssertion_Public_Static_Void_Object_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_CallOverridenDebugHandler_Internal_Static_Boolean_Exception_Object_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_IsLoggingEnabled_Internal_Static_Boolean_0;

		// Token: 0x040002A3 RID: 675
		private static readonly Debug.BreakDelegate BreakDelegateField;

		// Token: 0x040002A4 RID: 676
		private static readonly Debug.DebugBreakDelegate DebugBreakDelegateField;

		// Token: 0x040002A5 RID: 677
		private static readonly Debug.ClearDeveloperConsoleDelegate ClearDeveloperConsoleDelegateField;

		// Token: 0x040002A6 RID: 678
		private static readonly Debug.get_developerConsoleVisibleDelegate get_developerConsoleVisibleDelegateField;

		// Token: 0x040002A7 RID: 679
		private static readonly Debug.set_developerConsoleVisibleDelegate set_developerConsoleVisibleDelegateField;

		// Token: 0x040002A8 RID: 680
		private static readonly Debug.get_isDebugBuildDelegate get_isDebugBuildDelegateField;

		// Token: 0x040002A9 RID: 681
		private static readonly Debug.OpenConsoleFileDelegate OpenConsoleFileDelegateField;

		// Token: 0x040002AA RID: 682
		private static readonly Debug.GetDiagnosticSwitchDelegate GetDiagnosticSwitchDelegateField;

		// Token: 0x040002AB RID: 683
		private static readonly Debug.SetDiagnosticSwitchDelegate SetDiagnosticSwitchDelegateField;

		// Token: 0x040002AC RID: 684
		private static readonly Debug.DrawLine_InjectedDelegate DrawLine_InjectedDelegateField;

		// Token: 0x02000429 RID: 1065
		// (Invoke) Token: 0x06002619 RID: 9753
		private delegate void BreakDelegate();

		// Token: 0x0200042A RID: 1066
		// (Invoke) Token: 0x0600261B RID: 9755
		private delegate void DebugBreakDelegate();

		// Token: 0x0200042B RID: 1067
		// (Invoke) Token: 0x0600261D RID: 9757
		private delegate void ClearDeveloperConsoleDelegate();

		// Token: 0x0200042C RID: 1068
		// (Invoke) Token: 0x0600261F RID: 9759
		private delegate bool get_developerConsoleVisibleDelegate();

		// Token: 0x0200042D RID: 1069
		// (Invoke) Token: 0x06002621 RID: 9761
		private delegate void set_developerConsoleVisibleDelegate(bool value);

		// Token: 0x0200042E RID: 1070
		// (Invoke) Token: 0x06002623 RID: 9763
		private delegate bool get_isDebugBuildDelegate();

		// Token: 0x0200042F RID: 1071
		// (Invoke) Token: 0x06002625 RID: 9765
		private delegate void OpenConsoleFileDelegate();

		// Token: 0x02000430 RID: 1072
		// (Invoke) Token: 0x06002627 RID: 9767
		private delegate IntPtr GetDiagnosticSwitchDelegate(IntPtr name);

		// Token: 0x02000431 RID: 1073
		// (Invoke) Token: 0x06002629 RID: 9769
		private delegate void SetDiagnosticSwitchDelegate(IntPtr name, IntPtr value, bool setPersistent);

		// Token: 0x02000432 RID: 1074
		// (Invoke) Token: 0x0600262B RID: 9771
		private delegate void DrawLine_InjectedDelegate(IntPtr start, IntPtr end, IntPtr color, float duration, bool depthTest);
	}
}
