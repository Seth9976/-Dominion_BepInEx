using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200007C RID: 124
	public class InteriorNode : SyntaxTreeNode
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		// Note: this type is marked as 'beforefieldinit'.
		static InteriorNode()
		{
			Il2CppClassPointerStore<InteriorNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "InteriorNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr);
			InteriorNode.NativeFieldInfoPtr_leftChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "leftChild");
			InteriorNode.NativeFieldInfoPtr_rightChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, "rightChild");
			InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664746);
			InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664747);
			InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664748);
			InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664749);
			InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664750);
			InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664751);
			InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr, 100664752);
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0002FB18 File Offset: 0x0002DD18
		public unsafe SyntaxTreeNode LeftChild
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0002FB5C File Offset: 0x0002DD5C
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0002FB9C File Offset: 0x0002DD9C
		public unsafe SyntaxTreeNode RightChild
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21604, RefRangeEnd = 21606, XrefRangeStart = 21583, XrefRangeEnd = 21604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002FC48 File Offset: 0x0002DE48
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteriorNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0002FCBC File Offset: 0x0002DEBC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteriorNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteriorNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteriorNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00004E39 File Offset: 0x00003039
		public InteriorNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002FCF8 File Offset: 0x0002DEF8
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00004E42 File Offset: 0x00003042
		public unsafe SyntaxTreeNode leftChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_leftChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002FD28 File Offset: 0x0002DF28
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00004E61 File Offset: 0x00003061
		public unsafe SyntaxTreeNode rightChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InteriorNode.NativeFieldInfoPtr_rightChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr_leftChild;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr_rightChild;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_RightChild_Public_get_SyntaxTreeNode_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_set_RightChild_Public_set_Void_SyntaxTreeNode_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTreeNoRecursive_Protected_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
