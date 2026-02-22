using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005B RID: 91
	public sealed class RegexNode : Object
	{
		// Token: 0x0600064A RID: 1610 RVA: 0x00027DDC File Offset: 0x00025FDC
		// Note: this type is marked as 'beforefieldinit'.
		static RegexNode()
		{
			Il2CppClassPointerStore<RegexNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexNode>.NativeClassPtr);
			RegexNode.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_type");
			RegexNode.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_children");
			RegexNode.NativeFieldInfoPtr__str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_str");
			RegexNode.NativeFieldInfoPtr__ch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_ch");
			RegexNode.NativeFieldInfoPtr__m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_m");
			RegexNode.NativeFieldInfoPtr__n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_n");
			RegexNode.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_options");
			RegexNode.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "_next");
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664125);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664126);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664127);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664128);
			RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664129);
			RegexNode.NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664130);
			RegexNode.NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664131);
			RegexNode.NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664132);
			RegexNode.NativeMethodInfoPtr_Reduce_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664133);
			RegexNode.NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664134);
			RegexNode.NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664135);
			RegexNode.NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664136);
			RegexNode.NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664137);
			RegexNode.NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664138);
			RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664139);
			RegexNode.NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664140);
			RegexNode.NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664141);
			RegexNode.NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664142);
			RegexNode.NativeMethodInfoPtr_ChildCount_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664143);
			RegexNode.NativeMethodInfoPtr_Type_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664144);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0002803C File Offset: 0x0002623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39677, XrefRangeEnd = 39678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00028094 File Offset: 0x00026294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39678, XrefRangeEnd = 39679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, char ch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000280F8 File Offset: 0x000262F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39679, XrefRangeEnd = 39680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00028160 File Offset: 0x00026360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39680, XrefRangeEnd = 39681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, int m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x000281C4 File Offset: 0x000263C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39681, XrefRangeEnd = 39682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, int m, int n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00028238 File Offset: 0x00026438
		[CallerCount(0)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00028274 File Offset: 0x00026474
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39686, RefRangeEnd = 39688, XrefRangeStart = 39682, XrefRangeEnd = 39686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReverseLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x000282B4 File Offset: 0x000264B4
		[CallerCount(0)]
		public unsafe void MakeRep(int type, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00028310 File Offset: 0x00026510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39689, RefRangeEnd = 39690, XrefRangeStart = 39688, XrefRangeEnd = 39689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Reduce_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00028350 File Offset: 0x00026550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39694, RefRangeEnd = 39696, XrefRangeStart = 39690, XrefRangeEnd = 39694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode StripEnation(int emptyType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emptyType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0002839C File Offset: 0x0002659C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39696, XrefRangeEnd = 39699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x000283DC File Offset: 0x000265DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39699, XrefRangeEnd = 39710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceRep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0002841C File Offset: 0x0002661C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39710, XrefRangeEnd = 39727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0002845C File Offset: 0x0002665C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39777, RefRangeEnd = 39778, XrefRangeStart = 39727, XrefRangeEnd = 39777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceAlternation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0002849C File Offset: 0x0002669C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39778, XrefRangeEnd = 39821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceConcatenation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000284DC File Offset: 0x000266DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39821, XrefRangeEnd = 39831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00028544 File Offset: 0x00026744
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 39841, RefRangeEnd = 39852, XrefRangeStart = 39831, XrefRangeEnd = 39841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(RegexNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00028588 File Offset: 0x00026788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39852, XrefRangeEnd = 39854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Child(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000285D4 File Offset: 0x000267D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39854, XrefRangeEnd = 39855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ChildCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ChildCount_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00028610 File Offset: 0x00026810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Type()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Type_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00004702 File Offset: 0x00002902
		public RegexNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0002864C File Offset: 0x0002684C
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x0000470B File Offset: 0x0000290B
		public unsafe int _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00028674 File Offset: 0x00026874
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00004726 File Offset: 0x00002926
		public unsafe List<RegexNode> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x000286A4 File Offset: 0x000268A4
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00004745 File Offset: 0x00002945
		public unsafe string _str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000286CC File Offset: 0x000268CC
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00004764 File Offset: 0x00002964
		public unsafe char _ch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__ch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__ch)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000286F4 File Offset: 0x000268F4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x0000477F File Offset: 0x0000297F
		public unsafe int _m
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__m);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__m)) = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002871C File Offset: 0x0002691C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x0000479A File Offset: 0x0000299A
		public unsafe int _n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__n);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__n)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00028744 File Offset: 0x00026944
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000047B5 File Offset: 0x000029B5
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0002876C File Offset: 0x0002696C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x000047D0 File Offset: 0x000029D0
		public unsafe RegexNode _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr__str;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr__ch;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr__m;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr__n;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_0;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Char_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_String_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RegexOptions_Int32_Int32_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_Internal_Boolean_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_ReverseLeft_Internal_RegexNode_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_MakeRep_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeMethodInfoPtr_Reduce_Internal_RegexNode_0;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeMethodInfoPtr_StripEnation_Internal_RegexNode_Int32_0;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_ReduceGroup_Internal_RegexNode_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_ReduceRep_Internal_RegexNode_0;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_ReduceSet_Internal_RegexNode_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_ReduceAlternation_Internal_RegexNode_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_ReduceConcatenation_Internal_RegexNode_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_MakeQuantifier_Internal_RegexNode_Boolean_Int32_Int32_0;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Internal_Void_RegexNode_0;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeMethodInfoPtr_Child_Internal_RegexNode_Int32_0;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeMethodInfoPtr_ChildCount_Internal_Int32_0;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeMethodInfoPtr_Type_Internal_Int32_0;
	}
}
