using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000230 RID: 560
	public class TokenHashValue : Object
	{
		// Token: 0x060025D0 RID: 9680 RVA: 0x000C96C8 File Offset: 0x000C78C8
		// Note: this type is marked as 'beforefieldinit'.
		static TokenHashValue()
		{
			Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TokenHashValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr);
			TokenHashValue.NativeFieldInfoPtr_tokenString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenString");
			TokenHashValue.NativeFieldInfoPtr_tokenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenType");
			TokenHashValue.NativeFieldInfoPtr_tokenValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, "tokenValue");
			TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr, 100669459);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x000C9748 File Offset: 0x000C7948
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37634, RefRangeEnd = 37639, XrefRangeStart = 37634, XrefRangeEnd = 37639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenHashValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tokenString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tokenValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenHashValue.NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x0000CF95 File Offset: 0x0000B195
		public TokenHashValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060025D3 RID: 9683 RVA: 0x000C97B0 File Offset: 0x000C79B0
		// (set) Token: 0x060025D4 RID: 9684 RVA: 0x0000CF9E File Offset: 0x0000B19E
		public unsafe string tokenString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060025D5 RID: 9685 RVA: 0x000C97D8 File Offset: 0x000C79D8
		// (set) Token: 0x060025D6 RID: 9686 RVA: 0x0000CFBD File Offset: 0x0000B1BD
		public unsafe TokenType tokenType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenType)) = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060025D7 RID: 9687 RVA: 0x000C9800 File Offset: 0x000C7A00
		// (set) Token: 0x060025D8 RID: 9688 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		public unsafe int tokenValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenHashValue.NativeFieldInfoPtr_tokenValue)) = value;
			}
		}

		// Token: 0x0400218F RID: 8591
		private static readonly IntPtr NativeFieldInfoPtr_tokenString;

		// Token: 0x04002190 RID: 8592
		private static readonly IntPtr NativeFieldInfoPtr_tokenType;

		// Token: 0x04002191 RID: 8593
		private static readonly IntPtr NativeFieldInfoPtr_tokenValue;

		// Token: 0x04002192 RID: 8594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TokenType_Int32_0;
	}
}
