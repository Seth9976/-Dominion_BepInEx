using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000250 RID: 592
	public sealed class IdnMapping : Object
	{
		// Token: 0x0600290E RID: 10510 RVA: 0x000D5F04 File Offset: 0x000D4104
		// Note: this type is marked as 'beforefieldinit'.
		static IdnMapping()
		{
			Il2CppClassPointerStore<IdnMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "IdnMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr);
			IdnMapping.NativeFieldInfoPtr_allow_unassigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "allow_unassigned");
			IdnMapping.NativeFieldInfoPtr_use_std3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "use_std3");
			IdnMapping.NativeFieldInfoPtr_puny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, "puny");
			IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669869);
			IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669870);
			IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669871);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669872);
			IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669873);
			IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669874);
			IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669875);
			IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669876);
			IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669877);
			IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669878);
			IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669879);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669880);
			IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669881);
			IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr, 100669882);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x000D6088 File Offset: 0x000D4288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329783, RefRangeEnd = 329786, XrefRangeStart = 329778, XrefRangeEnd = 329783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdnMapping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdnMapping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x000D60C4 File Offset: 0x000D42C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329786, XrefRangeEnd = 329788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000D6114 File Offset: 0x000D4314
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x000D6150 File Offset: 0x000D4350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329789, RefRangeEnd = 329791, XrefRangeStart = 329788, XrefRangeEnd = 329789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000D6198 File Offset: 0x000D4398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329791, XrefRangeEnd = 329792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAscii(string unicode, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(unicode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000D61FC File Offset: 0x000D43FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329829, RefRangeEnd = 329833, XrefRangeStart = 329792, XrefRangeEnd = 329829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Convert(string input, int index, int count, bool toAscii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref toAscii;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x000D6270 File Offset: 0x000D4470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329847, RefRangeEnd = 329849, XrefRangeStart = 329833, XrefRangeEnd = 329847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToAscii(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x000D62C8 File Offset: 0x000D44C8
		[CallerCount(0)]
		public unsafe void VerifyLength(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000D6318 File Offset: 0x000D4518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329856, RefRangeEnd = 329858, XrefRangeStart = 329849, XrefRangeEnd = 329856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string NamePrep(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000D6370 File Offset: 0x000D4570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329868, RefRangeEnd = 329869, XrefRangeStart = 329858, XrefRangeEnd = 329868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyProhibitedCharacters(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x000D63C0 File Offset: 0x000D45C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329873, RefRangeEnd = 329874, XrefRangeStart = 329869, XrefRangeEnd = 329873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyStd3AsciiRules(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x000D6410 File Offset: 0x000D4610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329875, RefRangeEnd = 329878, XrefRangeStart = 329874, XrefRangeEnd = 329875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000D6458 File Offset: 0x000D4658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329878, XrefRangeEnd = 329879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnicode(string ascii, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ascii);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000D64BC File Offset: 0x000D46BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329894, RefRangeEnd = 329895, XrefRangeStart = 329879, XrefRangeEnd = 329894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUnicode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdnMapping.NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x0000E400 File Offset: 0x0000C600
		public IdnMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600291E RID: 10526 RVA: 0x000D6514 File Offset: 0x000D4714
		// (set) Token: 0x0600291F RID: 10527 RVA: 0x0000E409 File Offset: 0x0000C609
		public unsafe bool allow_unassigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_allow_unassigned)) = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002920 RID: 10528 RVA: 0x000D653C File Offset: 0x000D473C
		// (set) Token: 0x06002921 RID: 10529 RVA: 0x0000E424 File Offset: 0x0000C624
		public unsafe bool use_std3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_use_std3)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002922 RID: 10530 RVA: 0x000D6564 File Offset: 0x000D4764
		// (set) Token: 0x06002923 RID: 10531 RVA: 0x0000E43F File Offset: 0x0000C63F
		public unsafe Punycode puny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Punycode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IdnMapping.NativeFieldInfoPtr_puny), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002442 RID: 9282
		private static readonly IntPtr NativeFieldInfoPtr_allow_unassigned;

		// Token: 0x04002443 RID: 9283
		private static readonly IntPtr NativeFieldInfoPtr_use_std3;

		// Token: 0x04002444 RID: 9284
		private static readonly IntPtr NativeFieldInfoPtr_puny;

		// Token: 0x04002445 RID: 9285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002446 RID: 9286
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_0;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeMethodInfoPtr_GetAscii_Public_String_String_Int32_Int32_0;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Private_String_String_Int32_Int32_Boolean_0;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeMethodInfoPtr_ToAscii_Private_String_String_Int32_0;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeMethodInfoPtr_VerifyLength_Private_Void_String_Int32_0;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeMethodInfoPtr_NamePrep_Private_String_String_Int32_0;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeMethodInfoPtr_VerifyProhibitedCharacters_Private_Void_String_Int32_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeMethodInfoPtr_VerifyStd3AsciiRules_Private_Void_String_Int32_0;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_GetUnicode_Public_String_String_Int32_Int32_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_ToUnicode_Private_String_String_Int32_0;
	}
}
