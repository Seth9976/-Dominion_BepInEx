using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000174 RID: 372
	public class AssertionMessageUtil : Object
	{
		// Token: 0x06001B91 RID: 7057 RVA: 0x00061450 File Offset: 0x0005F650
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionMessageUtil()
		{
			Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionMessageUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100665301);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100665302);
			AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100665303);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000614BC File Offset: 0x0005F6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83287, XrefRangeEnd = 83307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000614F8 File Offset: 0x0005F6F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83357, RefRangeEnd = 83359, XrefRangeStart = 83307, XrefRangeEnd = 83357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage, string expected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00061548 File Offset: 0x0005F748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83359, XrefRangeEnd = 83365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BooleanFailureMessage(bool expected)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0000F163 File Offset: 0x0000D363
		public AssertionMessageUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0000F16C File Offset: 0x0000D36C
		public static string GetEqualityMessage(Object actual, Object expected, bool expectEqual)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0000F179 File Offset: 0x0000D379
		public static string NullFailureMessage(Object value, bool expectNull)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0;

		// Token: 0x0400152F RID: 5423
		public const string k_Expected = "Expected:";

		// Token: 0x04001530 RID: 5424
		public const string k_AssertionFailed = "Assertion failure.";
	}
}
