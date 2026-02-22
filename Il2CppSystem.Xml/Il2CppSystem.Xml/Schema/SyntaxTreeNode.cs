using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000079 RID: 121
	public class SyntaxTreeNode : Object
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x0002F1CC File Offset: 0x0002D3CC
		// Note: this type is marked as 'beforefieldinit'.
		static SyntaxTreeNode()
		{
			Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SyntaxTreeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr);
			SyntaxTreeNode.NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100664730);
			SyntaxTreeNode.NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100664731);
			SyntaxTreeNode.NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100664732);
			SyntaxTreeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100664733);
			SyntaxTreeNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr, 100664734);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0002F260 File Offset: 0x0002D460
		[CallerCount(0)]
		public unsafe virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0002F2D4 File Offset: 0x0002D4D4
		[CallerCount(0)]
		public unsafe virtual void ConstructPos(BitSet firstpos, BitSet lastpos, Il2CppReferenceArray<BitSet> followpos)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002F348 File Offset: 0x0002D548
		public unsafe virtual bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0002F390 File Offset: 0x0002D590
		public unsafe virtual bool IsRangeNode
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SyntaxTreeNode.NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0002F3D8 File Offset: 0x0002D5D8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SyntaxTreeNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyntaxTreeNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyntaxTreeNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public SyntaxTreeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Abstract_Virtual_New_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Abstract_Virtual_New_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRangeNode_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
