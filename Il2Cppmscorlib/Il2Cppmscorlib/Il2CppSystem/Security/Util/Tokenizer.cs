using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002C8 RID: 712
	public sealed class Tokenizer : Object
	{
		// Token: 0x06002F5A RID: 12122 RVA: 0x000EE5DC File Offset: 0x000EC7DC
		// Note: this type is marked as 'beforefieldinit'.
		static Tokenizer()
		{
			Il2CppClassPointerStore<Tokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Tokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr);
			Tokenizer.NativeFieldInfoPtr_LineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "LineNo");
			Tokenizer.NativeFieldInfoPtr__inProcessingTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inProcessingTag");
			Tokenizer.NativeFieldInfoPtr__inBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inBytes");
			Tokenizer.NativeFieldInfoPtr__inChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inChars");
			Tokenizer.NativeFieldInfoPtr__inString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inString");
			Tokenizer.NativeFieldInfoPtr__inIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inIndex");
			Tokenizer.NativeFieldInfoPtr__inSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSize");
			Tokenizer.NativeFieldInfoPtr__inSavedCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inSavedCharacter");
			Tokenizer.NativeFieldInfoPtr__inTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenSource");
			Tokenizer.NativeFieldInfoPtr__inTokenReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inTokenReader");
			Tokenizer.NativeFieldInfoPtr__maker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_maker");
			Tokenizer.NativeFieldInfoPtr__searchStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_searchStrings");
			Tokenizer.NativeFieldInfoPtr__replaceStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_replaceStrings");
			Tokenizer.NativeFieldInfoPtr__inNestedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedIndex");
			Tokenizer.NativeFieldInfoPtr__inNestedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedSize");
			Tokenizer.NativeFieldInfoPtr__inNestedString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "_inNestedString");
			Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670801);
			Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670802);
			Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670803);
			Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670804);
			Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670805);
			Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, 100670806);
		}

		// Token: 0x06002F5B RID: 12123 RVA: 0x000EE7C4 File Offset: 0x000EC9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338014, XrefRangeEnd = 338018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BasicInitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_BasicInitialization_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5C RID: 12124 RVA: 0x000EE7F8 File Offset: 0x000EC9F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338022, RefRangeEnd = 338023, XrefRangeStart = 338018, XrefRangeEnd = 338022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recycle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_Recycle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F5D RID: 12125 RVA: 0x000EE82C File Offset: 0x000ECA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338028, RefRangeEnd = 338029, XrefRangeStart = 338023, XrefRangeEnd = 338028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tokenizer(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x000EE878 File Offset: 0x000ECA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338036, XrefRangeStart = 338029, XrefRangeEnd = 338035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeFormat(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F5F RID: 12127 RVA: 0x000EE8BC File Offset: 0x000ECABC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338058, RefRangeEnd = 338061, XrefRangeStart = 338036, XrefRangeEnd = 338058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAfterKet;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x000EE91C File Offset: 0x000ECB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338061, XrefRangeEnd = 338063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStringToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.NativeMethodInfoPtr_GetStringToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x000108B2 File Offset: 0x0000EAB2
		public Tokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x000EE954 File Offset: 0x000ECB54
		// (set) Token: 0x06002F63 RID: 12131 RVA: 0x000108BB File Offset: 0x0000EABB
		public unsafe int LineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr_LineNo)) = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002F64 RID: 12132 RVA: 0x000EE97C File Offset: 0x000ECB7C
		// (set) Token: 0x06002F65 RID: 12133 RVA: 0x000108D6 File Offset: 0x0000EAD6
		public unsafe int _inProcessingTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inProcessingTag)) = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x000108F1 File Offset: 0x0000EAF1
		public unsafe Il2CppStructArray<byte> _inBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x000EE9D4 File Offset: 0x000ECBD4
		// (set) Token: 0x06002F69 RID: 12137 RVA: 0x00010910 File Offset: 0x0000EB10
		public unsafe Il2CppStructArray<char> _inChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inChars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000EEA04 File Offset: 0x000ECC04
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x0001092F File Offset: 0x0000EB2F
		public unsafe string _inString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x000EEA2C File Offset: 0x000ECC2C
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x0001094E File Offset: 0x0000EB4E
		public unsafe int _inIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inIndex)) = value;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x000EEA54 File Offset: 0x000ECC54
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x00010969 File Offset: 0x0000EB69
		public unsafe int _inSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSize)) = value;
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000EEA7C File Offset: 0x000ECC7C
		// (set) Token: 0x06002F71 RID: 12145 RVA: 0x00010984 File Offset: 0x0000EB84
		public unsafe int _inSavedCharacter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inSavedCharacter)) = value;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002F72 RID: 12146 RVA: 0x000EEAA4 File Offset: 0x000ECCA4
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x0001099F File Offset: 0x0000EB9F
		public unsafe Tokenizer.TokenSource _inTokenSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenSource)) = value;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x000EEACC File Offset: 0x000ECCCC
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000109BA File Offset: 0x0000EBBA
		public unsafe Tokenizer.ITokenReader _inTokenReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.ITokenReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inTokenReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000EEAFC File Offset: 0x000ECCFC
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x000109D9 File Offset: 0x0000EBD9
		public unsafe Tokenizer.StringMaker _maker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer.StringMaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__maker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000EEB2C File Offset: 0x000ECD2C
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x000109F8 File Offset: 0x0000EBF8
		public unsafe Il2CppStringArray _searchStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__searchStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002F7A RID: 12154 RVA: 0x000EEB5C File Offset: 0x000ECD5C
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00010A17 File Offset: 0x0000EC17
		public unsafe Il2CppStringArray _replaceStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__replaceStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000EEB8C File Offset: 0x000ECD8C
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x00010A36 File Offset: 0x0000EC36
		public unsafe int _inNestedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedIndex)) = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002F7E RID: 12158 RVA: 0x000EEBB4 File Offset: 0x000ECDB4
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x00010A51 File Offset: 0x0000EC51
		public unsafe int _inNestedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedSize)) = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000EEBDC File Offset: 0x000ECDDC
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00010A6C File Offset: 0x0000EC6C
		public unsafe string _inNestedString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.NativeFieldInfoPtr__inNestedString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeFieldInfoPtr_LineNo;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeFieldInfoPtr__inProcessingTag;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeFieldInfoPtr__inBytes;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeFieldInfoPtr__inChars;

		// Token: 0x040028F6 RID: 10486
		private static readonly IntPtr NativeFieldInfoPtr__inString;

		// Token: 0x040028F7 RID: 10487
		private static readonly IntPtr NativeFieldInfoPtr__inIndex;

		// Token: 0x040028F8 RID: 10488
		private static readonly IntPtr NativeFieldInfoPtr__inSize;

		// Token: 0x040028F9 RID: 10489
		private static readonly IntPtr NativeFieldInfoPtr__inSavedCharacter;

		// Token: 0x040028FA RID: 10490
		private static readonly IntPtr NativeFieldInfoPtr__inTokenSource;

		// Token: 0x040028FB RID: 10491
		private static readonly IntPtr NativeFieldInfoPtr__inTokenReader;

		// Token: 0x040028FC RID: 10492
		private static readonly IntPtr NativeFieldInfoPtr__maker;

		// Token: 0x040028FD RID: 10493
		private static readonly IntPtr NativeFieldInfoPtr__searchStrings;

		// Token: 0x040028FE RID: 10494
		private static readonly IntPtr NativeFieldInfoPtr__replaceStrings;

		// Token: 0x040028FF RID: 10495
		private static readonly IntPtr NativeFieldInfoPtr__inNestedIndex;

		// Token: 0x04002900 RID: 10496
		private static readonly IntPtr NativeFieldInfoPtr__inNestedSize;

		// Token: 0x04002901 RID: 10497
		private static readonly IntPtr NativeFieldInfoPtr__inNestedString;

		// Token: 0x04002902 RID: 10498
		private static readonly IntPtr NativeMethodInfoPtr_BasicInitialization_Internal_Void_0;

		// Token: 0x04002903 RID: 10499
		private static readonly IntPtr NativeMethodInfoPtr_Recycle_Public_Void_0;

		// Token: 0x04002904 RID: 10500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04002905 RID: 10501
		private static readonly IntPtr NativeMethodInfoPtr_ChangeFormat_Internal_Void_Encoding_0;

		// Token: 0x04002906 RID: 10502
		private static readonly IntPtr NativeMethodInfoPtr_GetTokens_Internal_Void_TokenizerStream_Int32_Boolean_0;

		// Token: 0x04002907 RID: 10503
		private static readonly IntPtr NativeMethodInfoPtr_GetStringToken_Private_String_0;

		// Token: 0x0200061E RID: 1566
		public enum TokenSource
		{
			// Token: 0x04004381 RID: 17281
			UnicodeByteArray,
			// Token: 0x04004382 RID: 17282
			UTF8ByteArray,
			// Token: 0x04004383 RID: 17283
			ASCIIByteArray,
			// Token: 0x04004384 RID: 17284
			CharArray,
			// Token: 0x04004385 RID: 17285
			String,
			// Token: 0x04004386 RID: 17286
			NestedStrings,
			// Token: 0x04004387 RID: 17287
			Other
		}

		// Token: 0x0200061F RID: 1567
		[Serializable]
		public sealed class StringMaker : Object
		{
			// Token: 0x06005397 RID: 21399 RVA: 0x00173590 File Offset: 0x00171790
			// Note: this type is marked as 'beforefieldinit'.
			static StringMaker()
			{
				Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StringMaker");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr);
				Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "aStrings");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsMax");
				Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "cStringsUsed");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outStringBuilder");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outChars");
				Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, "_outIndex");
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100670807);
				Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100670808);
				Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100670809);
				Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100670810);
				Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr, 100670811);
			}

			// Token: 0x06005398 RID: 21400 RVA: 0x00173698 File Offset: 0x00171898
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337994, RefRangeEnd = 337995, XrefRangeStart = 337993, XrefRangeEnd = 337994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint HashString(string str)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005399 RID: 21401 RVA: 0x001736DC File Offset: 0x001718DC
			[CallerCount(0)]
			public unsafe static uint HashCharArray(Il2CppStructArray<char> a, int l)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600539A RID: 21402 RVA: 0x0017372C File Offset: 0x0017192C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 338002, RefRangeEnd = 338003, XrefRangeStart = 337995, XrefRangeEnd = 338002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringMaker()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StringMaker>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600539B RID: 21403 RVA: 0x00173768 File Offset: 0x00171968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 338003, XrefRangeEnd = 338004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool CompareStringAndChars(string str, Il2CppStructArray<char> a, int l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600539C RID: 21404 RVA: 0x001737D8 File Offset: 0x001719D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 338011, RefRangeEnd = 338014, XrefRangeStart = 338004, XrefRangeEnd = 338011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string MakeString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StringMaker.NativeMethodInfoPtr_MakeString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600539D RID: 21405 RVA: 0x00020098 File Offset: 0x0001E298
			public StringMaker(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700155C RID: 5468
			// (get) Token: 0x0600539E RID: 21406 RVA: 0x00173810 File Offset: 0x00171A10
			// (set) Token: 0x0600539F RID: 21407 RVA: 0x000200A1 File Offset: 0x0001E2A1
			public unsafe Il2CppStringArray aStrings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_aStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700155D RID: 5469
			// (get) Token: 0x060053A0 RID: 21408 RVA: 0x00173840 File Offset: 0x00171A40
			// (set) Token: 0x060053A1 RID: 21409 RVA: 0x000200C0 File Offset: 0x0001E2C0
			public unsafe uint cStringsMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsMax)) = value;
				}
			}

			// Token: 0x1700155E RID: 5470
			// (get) Token: 0x060053A2 RID: 21410 RVA: 0x00173868 File Offset: 0x00171A68
			// (set) Token: 0x060053A3 RID: 21411 RVA: 0x000200DB File Offset: 0x0001E2DB
			public unsafe uint cStringsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr_cStringsUsed)) = value;
				}
			}

			// Token: 0x1700155F RID: 5471
			// (get) Token: 0x060053A4 RID: 21412 RVA: 0x00173890 File Offset: 0x00171A90
			// (set) Token: 0x060053A5 RID: 21413 RVA: 0x000200F6 File Offset: 0x0001E2F6
			public unsafe StringBuilder _outStringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001560 RID: 5472
			// (get) Token: 0x060053A6 RID: 21414 RVA: 0x001738C0 File Offset: 0x00171AC0
			// (set) Token: 0x060053A7 RID: 21415 RVA: 0x00020115 File Offset: 0x0001E315
			public unsafe Il2CppStructArray<char> _outChars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outChars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001561 RID: 5473
			// (get) Token: 0x060053A8 RID: 21416 RVA: 0x001738F0 File Offset: 0x00171AF0
			// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00020134 File Offset: 0x0001E334
			public unsafe int _outIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StringMaker.NativeFieldInfoPtr__outIndex)) = value;
				}
			}

			// Token: 0x04004388 RID: 17288
			private static readonly IntPtr NativeFieldInfoPtr_aStrings;

			// Token: 0x04004389 RID: 17289
			private static readonly IntPtr NativeFieldInfoPtr_cStringsMax;

			// Token: 0x0400438A RID: 17290
			private static readonly IntPtr NativeFieldInfoPtr_cStringsUsed;

			// Token: 0x0400438B RID: 17291
			private static readonly IntPtr NativeFieldInfoPtr__outStringBuilder;

			// Token: 0x0400438C RID: 17292
			private static readonly IntPtr NativeFieldInfoPtr__outChars;

			// Token: 0x0400438D RID: 17293
			private static readonly IntPtr NativeFieldInfoPtr__outIndex;

			// Token: 0x0400438E RID: 17294
			private static readonly IntPtr NativeMethodInfoPtr_HashString_Private_Static_UInt32_String_0;

			// Token: 0x0400438F RID: 17295
			private static readonly IntPtr NativeMethodInfoPtr_HashCharArray_Private_Static_UInt32_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x04004390 RID: 17296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004391 RID: 17297
			private static readonly IntPtr NativeMethodInfoPtr_CompareStringAndChars_Private_Boolean_String_Il2CppStructArray_1_Char_Int32_0;

			// Token: 0x04004392 RID: 17298
			private static readonly IntPtr NativeMethodInfoPtr_MakeString_Public_String_0;
		}

		// Token: 0x02000620 RID: 1568
		public class ITokenReader : Il2CppObjectBase
		{
			// Token: 0x060053AA RID: 21418 RVA: 0x0002014F File Offset: 0x0001E34F
			// Note: this type is marked as 'beforefieldinit'.
			static ITokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "ITokenReader");
				Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.ITokenReader>.NativeClassPtr, 100670812);
			}

			// Token: 0x060053AB RID: 21419 RVA: 0x00173918 File Offset: 0x00171B18
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.ITokenReader.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053AC RID: 21420 RVA: 0x00020179 File Offset: 0x0001E379
			public ITokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004393 RID: 17299
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_0;
		}

		// Token: 0x02000621 RID: 1569
		public class StreamTokenReader : Object
		{
			// Token: 0x060053AD RID: 21421 RVA: 0x00173960 File Offset: 0x00171B60
			// Note: this type is marked as 'beforefieldinit'.
			static StreamTokenReader()
			{
				Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tokenizer>.NativeClassPtr, "StreamTokenReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr);
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_in");
				Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, "_numCharRead");
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100670813);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100670814);
				Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr, 100670815);
			}

			// Token: 0x060053AE RID: 21422 RVA: 0x001739F0 File Offset: 0x00171BF0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 223791, RefRangeEnd = 223792, XrefRangeStart = 223791, XrefRangeEnd = 223792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StreamTokenReader(StreamReader input)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tokenizer.StreamTokenReader>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053AF RID: 21423 RVA: 0x00173A3C File Offset: 0x00171C3C
			[CallerCount(0)]
			public unsafe virtual int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tokenizer.StreamTokenReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001564 RID: 5476
			// (get) Token: 0x060053B0 RID: 21424 RVA: 0x00173A84 File Offset: 0x00171C84
			public unsafe int NumCharEncountered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tokenizer.StreamTokenReader.NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060053B1 RID: 21425 RVA: 0x00020182 File Offset: 0x0001E382
			public StreamTokenReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001562 RID: 5474
			// (get) Token: 0x060053B2 RID: 21426 RVA: 0x00173AC0 File Offset: 0x00171CC0
			// (set) Token: 0x060053B3 RID: 21427 RVA: 0x0002018B File Offset: 0x0001E38B
			public unsafe StreamReader _in
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__in), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001563 RID: 5475
			// (get) Token: 0x060053B4 RID: 21428 RVA: 0x00173AF0 File Offset: 0x00171CF0
			// (set) Token: 0x060053B5 RID: 21429 RVA: 0x000201AA File Offset: 0x0001E3AA
			public unsafe int _numCharRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tokenizer.StreamTokenReader.NativeFieldInfoPtr__numCharRead)) = value;
				}
			}

			// Token: 0x04004394 RID: 17300
			private static readonly IntPtr NativeFieldInfoPtr__in;

			// Token: 0x04004395 RID: 17301
			private static readonly IntPtr NativeFieldInfoPtr__numCharRead;

			// Token: 0x04004396 RID: 17302
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StreamReader_0;

			// Token: 0x04004397 RID: 17303
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

			// Token: 0x04004398 RID: 17304
			private static readonly IntPtr NativeMethodInfoPtr_get_NumCharEncountered_Internal_get_Int32_0;
		}
	}
}
