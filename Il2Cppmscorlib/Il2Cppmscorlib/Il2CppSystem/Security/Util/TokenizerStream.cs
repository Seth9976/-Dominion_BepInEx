using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x020002CB RID: 715
	public sealed class TokenizerStream : Object
	{
		// Token: 0x06002F90 RID: 12176 RVA: 0x000EEE14 File Offset: 0x000ED014
		// Note: this type is marked as 'beforefieldinit'.
		static TokenizerStream()
		{
			Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "TokenizerStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr);
			TokenizerStream.NativeFieldInfoPtr_m_countTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_countTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headTokens");
			TokenizerStream.NativeFieldInfoPtr_m_lastTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_lastTokens");
			TokenizerStream.NativeFieldInfoPtr_m_currentTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentTokens");
			TokenizerStream.NativeFieldInfoPtr_m_indexTokens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexTokens");
			TokenizerStream.NativeFieldInfoPtr_m_headStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_headStrings");
			TokenizerStream.NativeFieldInfoPtr_m_currentStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_currentStrings");
			TokenizerStream.NativeFieldInfoPtr_m_indexStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, "m_indexStrings");
			TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670818);
			TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670819);
			TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670820);
			TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670821);
			TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670822);
			TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670823);
			TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670824);
			TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670825);
			TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670826);
			TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670827);
			TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr, 100670828);
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x000EEFC0 File Offset: 0x000ED1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338085, RefRangeEnd = 338086, XrefRangeStart = 338073, XrefRangeEnd = 338085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TokenizerStream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TokenizerStream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000EEFFC File Offset: 0x000ED1FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338093, RefRangeEnd = 338095, XrefRangeStart = 338086, XrefRangeEnd = 338093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToken(short token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x000EF03C File Offset: 0x000ED23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 338100, RefRangeEnd = 338101, XrefRangeStart = 338095, XrefRangeEnd = 338100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddString(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_AddString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x000EF080 File Offset: 0x000ED280
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 338101, RefRangeEnd = 338104, XrefRangeStart = 338101, XrefRangeEnd = 338101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x000EF0B4 File Offset: 0x000ED2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338104, RefRangeEnd = 338106, XrefRangeStart = 338104, XrefRangeEnd = 338104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextFullToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x000EF0F0 File Offset: 0x000ED2F0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 338106, RefRangeEnd = 338118, XrefRangeStart = 338106, XrefRangeEnd = 338106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short GetNextToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextToken_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000EF12C File Offset: 0x000ED32C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 338118, RefRangeEnd = 338129, XrefRangeStart = 338118, XrefRangeEnd = 338118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetNextString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x000EF164 File Offset: 0x000ED364
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 338129, RefRangeEnd = 338135, XrefRangeStart = 338129, XrefRangeEnd = 338129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowAwayNextString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x000EF198 File Offset: 0x000ED398
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 338135, RefRangeEnd = 338144, XrefRangeStart = 338135, XrefRangeEnd = 338135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TagLastToken(short tag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x000EF1D8 File Offset: 0x000ED3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTokenCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x000EF214 File Offset: 0x000ED414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338145, RefRangeEnd = 338147, XrefRangeStart = 338144, XrefRangeEnd = 338145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoToPosition(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TokenizerStream.NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00010B19 File Offset: 0x0000ED19
		public TokenizerStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x000EF254 File Offset: 0x000ED454
		// (set) Token: 0x06002F9E RID: 12190 RVA: 0x00010B22 File Offset: 0x0000ED22
		public unsafe int m_countTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_countTokens)) = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002F9F RID: 12191 RVA: 0x000EF27C File Offset: 0x000ED47C
		// (set) Token: 0x06002FA0 RID: 12192 RVA: 0x00010B3D File Offset: 0x0000ED3D
		public unsafe TokenizerShortBlock m_headTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002FA1 RID: 12193 RVA: 0x000EF2AC File Offset: 0x000ED4AC
		// (set) Token: 0x06002FA2 RID: 12194 RVA: 0x00010B5C File Offset: 0x0000ED5C
		public unsafe TokenizerShortBlock m_lastTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_lastTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002FA3 RID: 12195 RVA: 0x000EF2DC File Offset: 0x000ED4DC
		// (set) Token: 0x06002FA4 RID: 12196 RVA: 0x00010B7B File Offset: 0x0000ED7B
		public unsafe TokenizerShortBlock m_currentTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerShortBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentTokens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002FA5 RID: 12197 RVA: 0x000EF30C File Offset: 0x000ED50C
		// (set) Token: 0x06002FA6 RID: 12198 RVA: 0x00010B9A File Offset: 0x0000ED9A
		public unsafe int m_indexTokens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexTokens)) = value;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002FA7 RID: 12199 RVA: 0x000EF334 File Offset: 0x000ED534
		// (set) Token: 0x06002FA8 RID: 12200 RVA: 0x00010BB5 File Offset: 0x0000EDB5
		public unsafe TokenizerStringBlock m_headStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_headStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002FA9 RID: 12201 RVA: 0x000EF364 File Offset: 0x000ED564
		// (set) Token: 0x06002FAA RID: 12202 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public unsafe TokenizerStringBlock m_currentStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TokenizerStringBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_currentStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002FAB RID: 12203 RVA: 0x000EF394 File Offset: 0x000ED594
		// (set) Token: 0x06002FAC RID: 12204 RVA: 0x00010BF3 File Offset: 0x0000EDF3
		public unsafe int m_indexStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TokenizerStream.NativeFieldInfoPtr_m_indexStrings)) = value;
			}
		}

		// Token: 0x0400290E RID: 10510
		private static readonly IntPtr NativeFieldInfoPtr_m_countTokens;

		// Token: 0x0400290F RID: 10511
		private static readonly IntPtr NativeFieldInfoPtr_m_headTokens;

		// Token: 0x04002910 RID: 10512
		private static readonly IntPtr NativeFieldInfoPtr_m_lastTokens;

		// Token: 0x04002911 RID: 10513
		private static readonly IntPtr NativeFieldInfoPtr_m_currentTokens;

		// Token: 0x04002912 RID: 10514
		private static readonly IntPtr NativeFieldInfoPtr_m_indexTokens;

		// Token: 0x04002913 RID: 10515
		private static readonly IntPtr NativeFieldInfoPtr_m_headStrings;

		// Token: 0x04002914 RID: 10516
		private static readonly IntPtr NativeFieldInfoPtr_m_currentStrings;

		// Token: 0x04002915 RID: 10517
		private static readonly IntPtr NativeFieldInfoPtr_m_indexStrings;

		// Token: 0x04002916 RID: 10518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002917 RID: 10519
		private static readonly IntPtr NativeMethodInfoPtr_AddToken_Internal_Void_Int16_0;

		// Token: 0x04002918 RID: 10520
		private static readonly IntPtr NativeMethodInfoPtr_AddString_Internal_Void_String_0;

		// Token: 0x04002919 RID: 10521
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeMethodInfoPtr_GetNextFullToken_Internal_Int16_0;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_GetNextToken_Internal_Int16_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr_GetNextString_Internal_String_0;

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAwayNextString_Internal_Void_0;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_TagLastToken_Internal_Void_Int16_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr_GetTokenCount_Internal_Int32_0;

		// Token: 0x04002920 RID: 10528
		private static readonly IntPtr NativeMethodInfoPtr_GoToPosition_Internal_Void_Int32_0;
	}
}
