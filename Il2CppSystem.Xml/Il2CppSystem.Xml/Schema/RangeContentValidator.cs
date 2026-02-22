using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000087 RID: 135
	public sealed class RangeContentValidator : ContentValidator
	{
		// Token: 0x0600097E RID: 2430 RVA: 0x0003186C File Offset: 0x0002FA6C
		// Note: this type is marked as 'beforefieldinit'.
		static RangeContentValidator()
		{
			Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "RangeContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr);
			RangeContentValidator.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "firstpos");
			RangeContentValidator.NativeFieldInfoPtr_followpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "followpos");
			RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "positionsWithRangeTerminals");
			RangeContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "symbols");
			RangeContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "positions");
			RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "minMaxNodesCount");
			RangeContentValidator.NativeFieldInfoPtr_endMarkerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, "endMarkerPos");
			RangeContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr, 100664805);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003193C File Offset: 0x0002FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22025, XrefRangeEnd = 22029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeContentValidator(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contentType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positionsWithRangeTerminals);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minmaxNodesCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeContentValidator.NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000516A File Offset: 0x0000336A
		public RangeContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00031A0C File Offset: 0x0002FC0C
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00005173 File Offset: 0x00003373
		public unsafe BitSet firstpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_firstpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x00031A3C File Offset: 0x0002FC3C
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00005192 File Offset: 0x00003392
		public unsafe Il2CppReferenceArray<BitSet> followpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_followpos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_followpos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x00031A6C File Offset: 0x0002FC6C
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x000051B1 File Offset: 0x000033B1
		public unsafe BitSet positionsWithRangeTerminals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positionsWithRangeTerminals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00031A9C File Offset: 0x0002FC9C
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x000051D0 File Offset: 0x000033D0
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00031ACC File Offset: 0x0002FCCC
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x000051EF File Offset: 0x000033EF
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x00031AFC File Offset: 0x0002FCFC
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0000520E File Offset: 0x0000340E
		public unsafe int minMaxNodesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_minMaxNodesCount)) = value;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00031B24 File Offset: 0x0002FD24
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00005229 File Offset: 0x00003429
		public unsafe int endMarkerPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_endMarkerPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeContentValidator.NativeFieldInfoPtr_endMarkerPos)) = value;
			}
		}

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeFieldInfoPtr_firstpos;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeFieldInfoPtr_followpos;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeFieldInfoPtr_positionsWithRangeTerminals;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeFieldInfoPtr_minMaxNodesCount;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeFieldInfoPtr_endMarkerPos;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitSet_Il2CppReferenceArray_1_BitSet_SymbolsDictionary_Positions_Int32_XmlSchemaContentType_Boolean_BitSet_Int32_0;
	}
}
