using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace UnityEngine
{
	// Token: 0x020000BF RID: 191
	public static class StackTraceUtility : Object
	{
		// Token: 0x06001100 RID: 4352 RVA: 0x0004553C File Offset: 0x0004373C
		// Note: this type is marked as 'beforefieldinit'.
		static StackTraceUtility()
		{
			Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "StackTraceUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
			StackTraceUtility.NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, "projectFolder");
			StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664460);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664461);
			StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664462);
			StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100664463);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000455D0 File Offset: 0x000437D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72406, XrefRangeEnd = 72421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProjectFolder(string folder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00045608 File Offset: 0x00043808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72421, XrefRangeEnd = 72438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractStackTrace()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00045634 File Offset: 0x00043834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72438, XrefRangeEnd = 72479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExtractStringFromExceptionInternal(Object exceptiono, out string message, out string stackTrace)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptiono);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			message = IL2CPP.Il2CppStringToManaged(intPtr);
			stackTrace = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000456A0 File Offset: 0x000438A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72568, RefRangeEnd = 72570, XrefRangeStart = 72479, XrefRangeEnd = 72568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stackTrace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTraceUtility.NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0000A532 File Offset: 0x00008732
		public StackTraceUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x000456DC File Offset: 0x000438DC
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x0000A53B File Offset: 0x0000873B
		public unsafe static string projectFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTraceUtility.NativeFieldInfoPtr_projectFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x000456FC File Offset: 0x000438FC
		public static string ExtractStringFromException(Object exception)
		{
			string text;
			string text2;
			StackTraceUtility.ExtractStringFromExceptionInternal(exception, out text, out text2);
			return String.Concat(text, "\n", text2);
		}

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_projectFolder;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;
	}
}
