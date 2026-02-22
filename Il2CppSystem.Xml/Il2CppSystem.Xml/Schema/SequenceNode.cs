using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200007D RID: 125
	public sealed class SequenceNode : InteriorNode
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x0002FD58 File Offset: 0x0002DF58
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceNode()
		{
			Il2CppClassPointerStore<SequenceNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SequenceNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr);
			SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100664753);
			SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100664754);
			SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100664755);
			SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, 100664756);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21608, XrefRangeEnd = 21643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002FE40 File Offset: 0x0002E040
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21643, XrefRangeEnd = 21651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002FE7C File Offset: 0x0002E07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21651, XrefRangeEnd = 21652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(positions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0002FEE4 File Offset: 0x0002E0E4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00004E80 File Offset: 0x00003080
		public SequenceNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200012E RID: 302
		public sealed class SequenceConstructPosContext : ValueType
		{
			// Token: 0x060012A9 RID: 4777 RVA: 0x00055560 File Offset: 0x00053760
			// Note: this type is marked as 'beforefieldinit'.
			static SequenceConstructPosContext()
			{
				Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SequenceNode>.NativeClassPtr, "SequenceConstructPosContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr);
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "this_");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastpos");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "lastposLeft");
				SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, "firstposRight");
				SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr, 100664757);
			}

			// Token: 0x060012AA RID: 4778 RVA: 0x00055604 File Offset: 0x00053804
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21606, RefRangeEnd = 21608, XrefRangeStart = 21606, XrefRangeEnd = 21606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceNode.SequenceConstructPosContext.NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012AB RID: 4779 RVA: 0x000085A7 File Offset: 0x000067A7
			public SequenceConstructPosContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060012AC RID: 4780 RVA: 0x000085B0 File Offset: 0x000067B0
			public SequenceConstructPosContext()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceNode.SequenceConstructPosContext>.NativeClassPtr))
			{
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x060012AD RID: 4781 RVA: 0x00055678 File Offset: 0x00053878
			// (set) Token: 0x060012AE RID: 4782 RVA: 0x000085C2 File Offset: 0x000067C2
			public unsafe SequenceNode this_
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_this_), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x060012AF RID: 4783 RVA: 0x000556A8 File Offset: 0x000538A8
			// (set) Token: 0x060012B0 RID: 4784 RVA: 0x000085E1 File Offset: 0x000067E1
			public unsafe BitSet firstpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000556D8 File Offset: 0x000538D8
			// (set) Token: 0x060012B2 RID: 4786 RVA: 0x00008600 File Offset: 0x00006800
			public unsafe BitSet lastpos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastpos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00055708 File Offset: 0x00053908
			// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000861F File Offset: 0x0000681F
			public unsafe BitSet lastposLeft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_lastposLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00055738 File Offset: 0x00053938
			// (set) Token: 0x060012B6 RID: 4790 RVA: 0x0000863E File Offset: 0x0000683E
			public unsafe BitSet firstposRight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceNode.SequenceConstructPosContext.NativeFieldInfoPtr_firstposRight), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000EAB RID: 3755
			private static readonly IntPtr NativeFieldInfoPtr_this_;

			// Token: 0x04000EAC RID: 3756
			private static readonly IntPtr NativeFieldInfoPtr_firstpos;

			// Token: 0x04000EAD RID: 3757
			private static readonly IntPtr NativeFieldInfoPtr_lastpos;

			// Token: 0x04000EAE RID: 3758
			private static readonly IntPtr NativeFieldInfoPtr_lastposLeft;

			// Token: 0x04000EAF RID: 3759
			private static readonly IntPtr NativeFieldInfoPtr_firstposRight;

			// Token: 0x04000EB0 RID: 3760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SequenceNode_BitSet_BitSet_0;
		}
	}
}
