using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem;

namespace Il2CppMono.Unity
{
	// Token: 0x02000005 RID: 5
	public static class Debug : Object
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00010B68 File Offset: 0x0000ED68
		// Note: this type is marked as 'beforefieldinit'.
		static Debug()
		{
			Il2CppClassPointerStore<Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "Debug");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Debug>.NativeClassPtr);
			Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663305);
			Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Debug>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00010BC0 File Offset: 0x0000EDC0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 31650, RefRangeEnd = 31655, XrefRangeStart = 31650, XrefRangeEnd = 31650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00010C14 File Offset: 0x0000EE14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31655, RefRangeEnd = 31656, XrefRangeStart = 31655, XrefRangeEnd = 31655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = AlertDescription.InternalError)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultAlert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Debug.NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020C1 File Offset: 0x000002C1
		public Debug(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_String_AlertDescription_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_CheckAndThrow_Public_Static_Void_unitytls_errorstate_unitytls_x509verify_result_String_AlertDescription_0;
	}
}
