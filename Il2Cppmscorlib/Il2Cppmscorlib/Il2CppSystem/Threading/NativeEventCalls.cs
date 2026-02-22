using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028E RID: 654
	public static class NativeEventCalls : Object
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x000E27E0 File Offset: 0x000E09E0
		// Note: this type is marked as 'beforefieldinit'.
		static NativeEventCalls()
		{
			Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "NativeEventCalls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr);
			NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670350);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670351);
			NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670352);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670353);
			NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670354);
			NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeEventCalls>.NativeClassPtr, 100670355);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000E2888 File Offset: 0x000E0A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333729, RefRangeEnd = 333730, XrefRangeStart = 333728, XrefRangeEnd = 333729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref manual;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errorCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000E28F4 File Offset: 0x000E0AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333734, RefRangeEnd = 333737, XrefRangeStart = 333730, XrefRangeEnd = 333734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x000E2938 File Offset: 0x000E0B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333737, XrefRangeEnd = 333738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x000E2978 File Offset: 0x000E0B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333742, RefRangeEnd = 333743, XrefRangeStart = 333738, XrefRangeEnd = 333742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetEvent(SafeWaitHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x000E29BC File Offset: 0x000E0BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333743, XrefRangeEnd = 333744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000E29FC File Offset: 0x000E0BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333745, RefRangeEnd = 333746, XrefRangeStart = 333744, XrefRangeEnd = 333745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseEvent_internal(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeEventCalls.NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x0000F6F5 File Offset: 0x0000D8F5
		public NativeEventCalls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_internal_Public_Static_IntPtr_Boolean_Boolean_String_byref_Int32_0;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeMethodInfoPtr_SetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_Public_Static_Boolean_SafeWaitHandle_0;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_ResetEvent_internal_Private_Static_Boolean_IntPtr_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_CloseEvent_internal_Public_Static_Void_IntPtr_0;
	}
}
