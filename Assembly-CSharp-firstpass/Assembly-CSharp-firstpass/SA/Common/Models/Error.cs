using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Common.Models
{
	// Token: 0x02000315 RID: 789
	public class Error : Object
	{
		// Token: 0x06002D66 RID: 11622 RVA: 0x000C19B4 File Offset: 0x000BFBB4
		// Note: this type is marked as 'beforefieldinit'.
		static Error()
		{
			Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
			Error.NativeFieldInfoPtr__Code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Error>.NativeClassPtr, "_Code");
			Error.NativeFieldInfoPtr__Messgae = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Error>.NativeClassPtr, "_Messgae");
			Error.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100669225);
			Error.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100669226);
			Error.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100669227);
			Error.NativeMethodInfoPtr_get_Code_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100669228);
			Error.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100669229);
		}

		// Token: 0x06002D67 RID: 11623 RVA: 0x000C1A70 File Offset: 0x000BFC70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212463, RefRangeEnd = 212466, XrefRangeStart = 212458, XrefRangeEnd = 212463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Error()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Error>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000C1AAC File Offset: 0x000BFCAC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 212469, RefRangeEnd = 212485, XrefRangeStart = 212466, XrefRangeEnd = 212469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Error(int code, string message = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Error>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000C1B08 File Offset: 0x000BFD08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212496, RefRangeEnd = 212498, XrefRangeStart = 212485, XrefRangeEnd = 212496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Error(string errorData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Error>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(errorData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000C1B54 File Offset: 0x000BFD54
		public unsafe int Code
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_get_Code_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x000C1B90 File Offset: 0x000BFD90
		public unsafe string Message
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000119D5 File Offset: 0x0000FBD5
		public Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x000C1BC8 File Offset: 0x000BFDC8
		// (set) Token: 0x06002D6E RID: 11630 RVA: 0x000119DE File Offset: 0x0000FBDE
		public unsafe int _Code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Error.NativeFieldInfoPtr__Code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Error.NativeFieldInfoPtr__Code)) = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000C1BF0 File Offset: 0x000BFDF0
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x000119F9 File Offset: 0x0000FBF9
		public unsafe string _Messgae
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Error.NativeFieldInfoPtr__Messgae);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Error.NativeFieldInfoPtr__Messgae), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeFieldInfoPtr__Code;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeFieldInfoPtr__Messgae;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_Int32_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
	}
}
