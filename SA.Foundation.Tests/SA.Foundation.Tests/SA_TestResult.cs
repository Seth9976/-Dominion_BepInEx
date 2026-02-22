using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Foundation.Templates;

namespace SA.Foundation.Tests
{
	// Token: 0x02000008 RID: 8
	public class SA_TestResult : Object
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002C08 File Offset: 0x00000E08
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestResult()
		{
			Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr);
			SA_TestResult.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, "<Status>k__BackingField");
			SA_TestResult.NativeFieldInfoPtr__Message_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, "<Message>k__BackingField");
			SA_TestResult.NativeMethodInfoPtr_get_Status_Public_get_TestResultStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663316);
			SA_TestResult.NativeMethodInfoPtr_set_Status_Private_set_Void_TestResultStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663317);
			SA_TestResult.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663318);
			SA_TestResult.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663319);
			SA_TestResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663320);
			SA_TestResult.NativeMethodInfoPtr_get_OK_Public_Static_get_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663321);
			SA_TestResult.NativeMethodInfoPtr_get_TIMEOUT_Public_Static_get_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663322);
			SA_TestResult.NativeMethodInfoPtr__ctor_Private_Void_TestResultStatus_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663323);
			SA_TestResult.NativeMethodInfoPtr_WithError_Public_Static_SA_TestResult_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663324);
			SA_TestResult.NativeMethodInfoPtr_FromSAResult_Public_Static_SA_TestResult_SA_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr, 100663325);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002D28 File Offset: 0x00000F28
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002D64 File Offset: 0x00000F64
		public unsafe SA_TestResult.TestResultStatus Status
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_get_Status_Public_get_TestResultStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_set_Status_Private_set_Void_TestResultStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002DA4 File Offset: 0x00000FA4
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002DDC File Offset: 0x00000FDC
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_set_Message_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002E20 File Offset: 0x00001020
		public unsafe bool IsFailed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00002E5C File Offset: 0x0000105C
		public unsafe static SA_TestResult OK
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 158707, RefRangeEnd = 158711, XrefRangeStart = 158701, XrefRangeEnd = 158707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_get_OK_Public_Static_get_SA_TestResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_TestResult>(intPtr3) : null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002E90 File Offset: 0x00001090
		public unsafe static SA_TestResult TIMEOUT
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158711, XrefRangeEnd = 158717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_get_TIMEOUT_Public_Static_get_SA_TestResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_TestResult>(intPtr3) : null;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002EC4 File Offset: 0x000010C4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 50515, RefRangeEnd = 50526, XrefRangeStart = 50515, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestResult(SA_TestResult.TestResultStatus status, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr__ctor_Private_Void_TestResultStatus_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002F20 File Offset: 0x00001120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 158721, RefRangeEnd = 158724, XrefRangeStart = 158717, XrefRangeEnd = 158721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SA_TestResult WithError(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_WithError_Public_Static_SA_TestResult_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_TestResult>(intPtr3) : null;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002F64 File Offset: 0x00001164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158724, XrefRangeEnd = 158734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SA_TestResult FromSAResult(SA_Result result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResult.NativeMethodInfoPtr_FromSAResult_Public_Static_SA_TestResult_SA_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_TestResult>(intPtr3) : null;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002157 File Offset: 0x00000357
		public SA_TestResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002FA8 File Offset: 0x000011A8
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002160 File Offset: 0x00000360
		public unsafe SA_TestResult.TestResultStatus _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResult.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResult.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002FD0 File Offset: 0x000011D0
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0000217B File Offset: 0x0000037B
		public unsafe string _Message_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResult.NativeFieldInfoPtr__Message_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResult.NativeFieldInfoPtr__Message_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__Message_k__BackingField;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_TestResultStatus_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Private_set_Void_TestResultStatus_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_set_Message_Private_set_Void_String_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFailed_Public_get_Boolean_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_OK_Public_Static_get_SA_TestResult_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_TIMEOUT_Public_Static_get_SA_TestResult_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_TestResultStatus_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_WithError_Public_Static_SA_TestResult_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_FromSAResult_Public_Static_SA_TestResult_SA_Result_0;

		// Token: 0x0200000D RID: 13
		public enum TestResultStatus
		{
			// Token: 0x04000044 RID: 68
			Ok,
			// Token: 0x04000045 RID: 69
			Timeout,
			// Token: 0x04000046 RID: 70
			Error
		}
	}
}
