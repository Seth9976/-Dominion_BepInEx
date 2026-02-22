using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000086 RID: 134
	public sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x06000971 RID: 2417 RVA: 0x00031620 File Offset: 0x0002F820
		// Note: this type is marked as 'beforefieldinit'.
		static NfaContentValidator()
		{
			Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NfaContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr);
			NfaContentValidator.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "firstpos");
			NfaContentValidator.NativeFieldInfoPtr_followpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "followpos");
			NfaContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "symbols");
			NfaContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "positions");
			NfaContentValidator.NativeFieldInfoPtr_endMarkerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, "endMarkerPos");
			NfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr, 100664804);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000316C8 File Offset: 0x0002F8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22021, XrefRangeEnd = 22025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NfaContentValidator(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NfaContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NfaContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000050CA File Offset: 0x000032CA
		public NfaContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00031784 File Offset: 0x0002F984
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x000050D3 File Offset: 0x000032D3
		public unsafe BitSet firstpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_firstpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x000317B4 File Offset: 0x0002F9B4
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000050F2 File Offset: 0x000032F2
		public unsafe Il2CppReferenceArray<BitSet> followpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_followpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_followpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x000317E4 File Offset: 0x0002F9E4
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00005111 File Offset: 0x00003311
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x00031814 File Offset: 0x0002FA14
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00005130 File Offset: 0x00003330
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00031844 File Offset: 0x0002FA44
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0000514F File Offset: 0x0000334F
		public unsafe int endMarkerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_endMarkerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NfaContentValidator.NativeFieldInfoPtr_endMarkerPos)) = value;
			}
		}

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr_firstpos;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr_followpos;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeFieldInfoPtr_endMarkerPos;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_Boolean_0;
	}
}
