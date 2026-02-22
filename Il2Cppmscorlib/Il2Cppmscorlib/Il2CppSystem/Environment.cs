using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000106 RID: 262
	public static class Environment : Object
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x0007BA24 File Offset: 0x00079C24
		// Note: this type is marked as 'beforefieldinit'.
		static Environment()
		{
			Il2CppClassPointerStore<Environment>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Environment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment>.NativeClassPtr);
			Environment.NativeFieldInfoPtr_mono_corlib_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "mono_corlib_version");
			Environment.NativeFieldInfoPtr_nl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "nl");
			Environment.NativeFieldInfoPtr_os = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "os");
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666652);
			Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666653);
			Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666654);
			Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666655);
			Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666656);
			Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666657);
			Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666658);
			Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666659);
			Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666660);
			Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666661);
			Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666662);
			Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666663);
			Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666664);
			Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666665);
			Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666666);
			Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666667);
			Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666668);
			Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666669);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666670);
			Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666671);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666672);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666673);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666674);
			Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666675);
			Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666676);
			Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666677);
			Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666678);
			Environment.NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666679);
			Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666680);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666681);
			Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666682);
			Environment.NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666683);
			Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666684);
			Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666685);
			Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666686);
			Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666687);
			Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666688);
			Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666689);
			Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666690);
			Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100666691);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x0007BDB0 File Offset: 0x00079FB0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0007BDEC File Offset: 0x00079FEC
		[CallerCount(111)]
		[CachedScanResults(RefRangeStart = 303855, RefRangeEnd = 303966, XrefRangeStart = 303850, XrefRangeEnd = 303855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string key, [Optional] Il2CppReferenceArray<Object> values)
		{
			if (values == null)
			{
				values = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0007BE48 File Offset: 0x0007A048
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303975, RefRangeEnd = 303976, XrefRangeStart = 303966, XrefRangeEnd = 303975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceStringEncodingName(int codePage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref codePage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x0007BE80 File Offset: 0x0007A080
		public unsafe static int CurrentManagedThreadId
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 303979, RefRangeEnd = 304007, XrefRangeStart = 303976, XrefRangeEnd = 303979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x0007BEB0 File Offset: 0x0007A0B0
		public unsafe static bool HasShutdownStarted
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 304008, RefRangeEnd = 304010, XrefRangeStart = 304007, XrefRangeEnd = 304008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		public unsafe static string MachineName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 304011, RefRangeEnd = 304014, XrefRangeStart = 304010, XrefRangeEnd = 304011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x0007BF0C File Offset: 0x0007A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304014, XrefRangeEnd = 304015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNewLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetNewLine_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x0007BF38 File Offset: 0x0007A138
		public unsafe static string NewLine
		{
			[CallerCount(62)]
			[CachedScanResults(RefRangeStart = 304020, RefRangeEnd = 304082, XrefRangeStart = 304015, XrefRangeEnd = 304020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x0007BF64 File Offset: 0x0007A164
		public unsafe static PlatformID Platform
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304082, XrefRangeEnd = 304083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x0007BF94 File Offset: 0x0007A194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304083, XrefRangeEnd = 304084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetOSVersionString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x0007BFC0 File Offset: 0x0007A1C0
		public unsafe static OperatingSystem OSVersion
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 304095, RefRangeEnd = 304108, XrefRangeStart = 304084, XrefRangeEnd = 304095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr3) : null;
			}
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x0007BFF4 File Offset: 0x0007A1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304129, RefRangeEnd = 304130, XrefRangeStart = 304108, XrefRangeEnd = 304129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Version CreateVersionFromString(string info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Version>(intPtr3) : null;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0007C038 File Offset: 0x0007A238
		public unsafe static string StackTrace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304130, XrefRangeEnd = 304135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0007C064 File Offset: 0x0007A264
		public unsafe static int TickCount
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 304136, RefRangeEnd = 304159, XrefRangeStart = 304135, XrefRangeEnd = 304136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x0007C094 File Offset: 0x0007A294
		public unsafe static string UserDomainName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 304011, RefRangeEnd = 304014, XrefRangeStart = 304011, XrefRangeEnd = 304014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x0007C0C0 File Offset: 0x0007A2C0
		public unsafe static string UserName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 304160, RefRangeEnd = 304161, XrefRangeStart = 304159, XrefRangeEnd = 304160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0007C0EC File Offset: 0x0007A2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304162, RefRangeEnd = 304163, XrefRangeStart = 304161, XrefRangeEnd = 304162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Exit(int exitCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref exitCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0007C120 File Offset: 0x0007A320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304163, XrefRangeEnd = 304195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExpandEnvironmentVariables(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0007C15C File Offset: 0x0007A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304195, XrefRangeEnd = 304196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable_native(IntPtr variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref variable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0007C194 File Offset: 0x0007A394
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 304202, RefRangeEnd = 304210, XrefRangeStart = 304196, XrefRangeEnd = 304202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 304211, RefRangeEnd = 304217, XrefRangeStart = 304210, XrefRangeEnd = 304211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEnvironmentVariable(string variable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0007C20C File Offset: 0x0007A40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304217, XrefRangeEnd = 304226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Hashtable GetEnvironmentVariablesNoCase()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr3) : null;
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x0007C240 File Offset: 0x0007A440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304230, RefRangeEnd = 304233, XrefRangeStart = 304226, XrefRangeEnd = 304230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0007C278 File Offset: 0x0007A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304233, XrefRangeEnd = 304234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWindowsFolderPath(int folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0007C2B0 File Offset: 0x0007A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304234, XrefRangeEnd = 304238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0007C2F8 File Offset: 0x0007A4F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304249, RefRangeEnd = 304250, XrefRangeStart = 304238, XrefRangeEnd = 304249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(config_dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(home_dir);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0007C36C File Offset: 0x0007A56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304305, RefRangeEnd = 304307, XrefRangeStart = 304250, XrefRangeEnd = 304305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnixGetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref folder;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref option;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0007C3B4 File Offset: 0x0007A5B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 304340, RefRangeEnd = 304343, XrefRangeStart = 304307, XrefRangeEnd = 304340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEnvironmentVariable(string variable, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0007C3FC File Offset: 0x0007A5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304343, XrefRangeEnd = 304344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalSetEnvironmentVariable(string variable, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0007C444 File Offset: 0x0007A644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304349, RefRangeEnd = 304350, XrefRangeStart = 304344, XrefRangeEnd = 304349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0007C47C File Offset: 0x0007A67C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304355, RefRangeEnd = 304356, XrefRangeStart = 304350, XrefRangeEnd = 304355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FailFast(string message, Exception exception)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x0007C4C4 File Offset: 0x0007A6C4
		public unsafe static bool Is64BitProcess
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 304357, RefRangeEnd = 304359, XrefRangeStart = 304356, XrefRangeEnd = 304357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0007C4F4 File Offset: 0x0007A6F4
		public unsafe static int ProcessorCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 304360, RefRangeEnd = 304362, XrefRangeStart = 304359, XrefRangeEnd = 304360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0007C524 File Offset: 0x0007A724
		public unsafe static bool IsRunningOnWindows
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 304363, RefRangeEnd = 304381, XrefRangeStart = 304362, XrefRangeEnd = 304363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0007C554 File Offset: 0x0007A754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304381, XrefRangeEnd = 304382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStringArray GetEnvironmentVariableNames()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0007C588 File Offset: 0x0007A788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304383, RefRangeEnd = 304385, XrefRangeStart = 304382, XrefRangeEnd = 304383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMachineConfigPath()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0007C5B4 File Offset: 0x0007A7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304385, XrefRangeEnd = 304386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string internalGetHome()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0007C5E0 File Offset: 0x0007A7E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304387, RefRangeEnd = 304389, XrefRangeStart = 304386, XrefRangeEnd = 304387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPageSize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0007C610 File Offset: 0x0007A810
		public unsafe static bool IsUnix
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 304390, RefRangeEnd = 304393, XrefRangeStart = 304389, XrefRangeEnd = 304390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0007C640 File Offset: 0x0007A840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 304401, RefRangeEnd = 304405, XrefRangeStart = 304393, XrefRangeEnd = 304401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStackTrace(Exception e, bool needFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Environment.NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x00006B67 File Offset: 0x00004D67
		public static string GetResourceString(string key, params Object[] values)
		{
			return Environment.GetResourceString(key, new Il2CppReferenceArray<Object>(values));
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x00006B75 File Offset: 0x00004D75
		public Environment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0007C68C File Offset: 0x0007A88C
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00006B7E File Offset: 0x00004D7E
		public unsafe static int mono_corlib_version
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_mono_corlib_version, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_mono_corlib_version, (void*)(&value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00006B8C File Offset: 0x00004D8C
		public unsafe static string nl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_nl, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_nl, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0007C6C8 File Offset: 0x0007A8C8
		// (set) Token: 0x06001392 RID: 5010 RVA: 0x00006B9E File Offset: 0x00004D9E
		public unsafe static OperatingSystem os
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Environment.NativeFieldInfoPtr_os, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Environment.NativeFieldInfoPtr_os, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeFieldInfoPtr_mono_corlib_version;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeFieldInfoPtr_nl;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeFieldInfoPtr_os;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0;

		// Token: 0x040010B9 RID: 4281
		private static readonly IntPtr NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0;

		// Token: 0x040010BA RID: 4282
		private static readonly IntPtr NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0;

		// Token: 0x040010BB RID: 4283
		private static readonly IntPtr NativeMethodInfoPtr_GetNewLine_Private_Static_String_0;

		// Token: 0x040010BC RID: 4284
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0;

		// Token: 0x040010BD RID: 4285
		private static readonly IntPtr NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0;

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr_SetEnvironmentVariable_Public_Static_Void_String_String_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetEnvironmentVariable_Internal_Static_Void_String_String_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_get_Is64BitProcess_Public_Static_get_Boolean_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0;

		// Token: 0x020005A6 RID: 1446
		public enum SpecialFolder
		{
			// Token: 0x040040A9 RID: 16553
			MyDocuments = 5,
			// Token: 0x040040AA RID: 16554
			Desktop = 0,
			// Token: 0x040040AB RID: 16555
			MyComputer = 17,
			// Token: 0x040040AC RID: 16556
			Programs = 2,
			// Token: 0x040040AD RID: 16557
			Personal = 5,
			// Token: 0x040040AE RID: 16558
			Favorites,
			// Token: 0x040040AF RID: 16559
			Startup,
			// Token: 0x040040B0 RID: 16560
			Recent,
			// Token: 0x040040B1 RID: 16561
			SendTo,
			// Token: 0x040040B2 RID: 16562
			StartMenu = 11,
			// Token: 0x040040B3 RID: 16563
			MyMusic = 13,
			// Token: 0x040040B4 RID: 16564
			DesktopDirectory = 16,
			// Token: 0x040040B5 RID: 16565
			Templates = 21,
			// Token: 0x040040B6 RID: 16566
			ApplicationData = 26,
			// Token: 0x040040B7 RID: 16567
			LocalApplicationData = 28,
			// Token: 0x040040B8 RID: 16568
			InternetCache = 32,
			// Token: 0x040040B9 RID: 16569
			Cookies,
			// Token: 0x040040BA RID: 16570
			History,
			// Token: 0x040040BB RID: 16571
			CommonApplicationData,
			// Token: 0x040040BC RID: 16572
			System = 37,
			// Token: 0x040040BD RID: 16573
			ProgramFiles,
			// Token: 0x040040BE RID: 16574
			MyPictures,
			// Token: 0x040040BF RID: 16575
			CommonProgramFiles = 43,
			// Token: 0x040040C0 RID: 16576
			MyVideos = 14,
			// Token: 0x040040C1 RID: 16577
			NetworkShortcuts = 19,
			// Token: 0x040040C2 RID: 16578
			Fonts,
			// Token: 0x040040C3 RID: 16579
			CommonStartMenu = 22,
			// Token: 0x040040C4 RID: 16580
			CommonPrograms,
			// Token: 0x040040C5 RID: 16581
			CommonStartup,
			// Token: 0x040040C6 RID: 16582
			CommonDesktopDirectory,
			// Token: 0x040040C7 RID: 16583
			PrinterShortcuts = 27,
			// Token: 0x040040C8 RID: 16584
			Windows = 36,
			// Token: 0x040040C9 RID: 16585
			UserProfile = 40,
			// Token: 0x040040CA RID: 16586
			SystemX86,
			// Token: 0x040040CB RID: 16587
			ProgramFilesX86,
			// Token: 0x040040CC RID: 16588
			CommonProgramFilesX86 = 44,
			// Token: 0x040040CD RID: 16589
			CommonTemplates,
			// Token: 0x040040CE RID: 16590
			CommonDocuments,
			// Token: 0x040040CF RID: 16591
			CommonAdminTools,
			// Token: 0x040040D0 RID: 16592
			AdminTools,
			// Token: 0x040040D1 RID: 16593
			CommonMusic = 53,
			// Token: 0x040040D2 RID: 16594
			CommonPictures,
			// Token: 0x040040D3 RID: 16595
			CommonVideos,
			// Token: 0x040040D4 RID: 16596
			Resources,
			// Token: 0x040040D5 RID: 16597
			LocalizedResources,
			// Token: 0x040040D6 RID: 16598
			CommonOemLinks,
			// Token: 0x040040D7 RID: 16599
			CDBurning
		}

		// Token: 0x020005A7 RID: 1447
		public enum SpecialFolderOption
		{
			// Token: 0x040040D9 RID: 16601
			None,
			// Token: 0x040040DA RID: 16602
			DoNotVerify = 16384,
			// Token: 0x040040DB RID: 16603
			Create = 32768
		}
	}
}
