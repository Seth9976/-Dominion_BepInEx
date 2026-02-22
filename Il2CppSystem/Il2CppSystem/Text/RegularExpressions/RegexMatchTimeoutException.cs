using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class RegexMatchTimeoutException : TimeoutException
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x00027A80 File Offset: 0x00025C80
		// Note: this type is marked as 'beforefieldinit'.
		static RegexMatchTimeoutException()
		{
			Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexMatchTimeoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr);
			RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "regexInput");
			RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "regexPattern");
			RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, "matchTimeout");
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664119);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664120);
			RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664121);
			RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664122);
			RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664123);
			RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr, 100664124);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00027B64 File Offset: 0x00025D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39627, XrefRangeEnd = 39634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(string regexInput, string regexPattern, TimeSpan matchTimeout)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(regexInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(regexPattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00027BD0 File Offset: 0x00025DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39634, XrefRangeEnd = 39645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00027C0C File Offset: 0x00025E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39645, XrefRangeEnd = 39660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexMatchTimeoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexMatchTimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00027C70 File Offset: 0x00025E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39660, XrefRangeEnd = 39671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo si, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(si);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00027CCC File Offset: 0x00025ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39671, XrefRangeEnd = 39677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00027D00 File Offset: 0x00025F00
		[CallerCount(0)]
		public unsafe void Init(string input, string pattern, TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexMatchTimeoutException.NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000046A0 File Offset: 0x000028A0
		public RegexMatchTimeoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00027D64 File Offset: 0x00025F64
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000046A9 File Offset: 0x000028A9
		public unsafe string regexInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexInput), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00027D8C File Offset: 0x00025F8C
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x000046C8 File Offset: 0x000028C8
		public unsafe string regexPattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_regexPattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00027DB4 File Offset: 0x00025FB4
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x000046E7 File Offset: 0x000028E7
		public unsafe TimeSpan matchTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexMatchTimeoutException.NativeFieldInfoPtr_matchTimeout)) = value;
			}
		}

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_regexInput;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_regexPattern;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_matchTimeout;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_TimeSpan_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_String_String_TimeSpan_0;
	}
}
