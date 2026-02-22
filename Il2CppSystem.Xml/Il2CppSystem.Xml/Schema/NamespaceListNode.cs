using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200007B RID: 123
	public class NamespaceListNode : SyntaxTreeNode
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x0002F6EC File Offset: 0x0002D8EC
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceListNode()
		{
			Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "NamespaceListNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr);
			NamespaceListNode.NativeFieldInfoPtr_namespaceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, "namespaceList");
			NamespaceListNode.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, "particle");
			NamespaceListNode.NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100664741);
			NamespaceListNode.NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100664742);
			NamespaceListNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100664743);
			NamespaceListNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100664744);
			NamespaceListNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr, 100664745);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0002F7A8 File Offset: 0x0002D9A8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceListNode(NamespaceList namespaceList, Object particle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceListNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceListNode.NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0002F808 File Offset: 0x0002DA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21541, XrefRangeEnd = 21543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0002F864 File Offset: 0x0002DA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21543, XrefRangeEnd = 21573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21573, XrefRangeEnd = 21578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002F94C File Offset: 0x0002DB4C
		public unsafe override bool IsNullable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21578, XrefRangeEnd = 21583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NamespaceListNode.NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public NamespaceListNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0002F994 File Offset: 0x0002DB94
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00004DFB File Offset: 0x00002FFB
		public unsafe NamespaceList namespaceList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_namespaceList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamespaceList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_namespaceList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00004E1A File Offset: 0x0000301A
		public unsafe Object particle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_particle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceListNode.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr_namespaceList;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeFieldInfoPtr_particle;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NamespaceList_Object_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_GetResolvedSymbols_Public_Virtual_New_ICollection_SymbolsDictionary_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_ExpandTree_Public_Virtual_Void_InteriorNode_SymbolsDictionary_Positions_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_ConstructPos_Public_Virtual_Void_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_Virtual_get_Boolean_0;
	}
}
