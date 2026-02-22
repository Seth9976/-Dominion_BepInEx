using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000084 RID: 132
	public sealed class ParticleContentValidator : ContentValidator
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00030ACC File Offset: 0x0002ECCC
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleContentValidator()
		{
			Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ParticleContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr);
			ParticleContentValidator.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "symbols");
			ParticleContentValidator.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "positions");
			ParticleContentValidator.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "stack");
			ParticleContentValidator.NativeFieldInfoPtr_contentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "contentNode");
			ParticleContentValidator.NativeFieldInfoPtr_isPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "isPartial");
			ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "minMaxNodesCount");
			ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, "enableUpaCheck");
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664781);
			ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664782);
			ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664783);
			ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664784);
			ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664785);
			ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664786);
			ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664787);
			ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664788);
			ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664789);
			ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664790);
			ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664791);
			ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664792);
			ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664793);
			ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664794);
			ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664795);
			ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664796);
			ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664797);
			ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664798);
			ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664799);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664800);
			ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664801);
			ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr, 100664802);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00030D40 File Offset: 0x0002EF40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21731, RefRangeEnd = 21734, XrefRangeStart = 21727, XrefRangeEnd = 21731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00030D88 File Offset: 0x0002EF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21734, XrefRangeEnd = 21738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableUpaCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21762, RefRangeEnd = 21765, XrefRangeStart = 21738, XrefRangeEnd = 21762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00030E14 File Offset: 0x0002F014
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21766, RefRangeEnd = 21770, XrefRangeStart = 21765, XrefRangeEnd = 21766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_OpenGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00030E48 File Offset: 0x0002F048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21775, RefRangeEnd = 21778, XrefRangeStart = 21770, XrefRangeEnd = 21775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CloseGroup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00030E7C File Offset: 0x0002F07C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21778, RefRangeEnd = 21779, XrefRangeStart = 21778, XrefRangeEnd = 21778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exists(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00030ECC File Offset: 0x0002F0CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21787, RefRangeEnd = 21789, XrefRangeStart = 21779, XrefRangeEnd = 21787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(XmlQualifiedName name, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00030F20 File Offset: 0x0002F120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21796, RefRangeEnd = 21797, XrefRangeStart = 21789, XrefRangeEnd = 21796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespaceList(NamespaceList namespaceList, Object particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(namespaceList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00030F74 File Offset: 0x0002F174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21799, RefRangeEnd = 21801, XrefRangeStart = 21797, XrefRangeEnd = 21799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeafNode(SyntaxTreeNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00030FB8 File Offset: 0x0002F1B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21810, RefRangeEnd = 21812, XrefRangeStart = 21801, XrefRangeEnd = 21810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddChoice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00030FEC File Offset: 0x0002F1EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21821, RefRangeEnd = 21822, XrefRangeStart = 21812, XrefRangeEnd = 21821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSequence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00031020 File Offset: 0x0002F220
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21827, RefRangeEnd = 21830, XrefRangeStart = 21822, XrefRangeEnd = 21827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddStar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00031054 File Offset: 0x0002F254
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21835, RefRangeEnd = 21838, XrefRangeStart = 21830, XrefRangeEnd = 21835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddPlus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00031088 File Offset: 0x0002F288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21843, RefRangeEnd = 21845, XrefRangeStart = 21838, XrefRangeEnd = 21843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddQMark()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_AddQMark_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x000310BC File Offset: 0x0002F2BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21847, RefRangeEnd = 21850, XrefRangeStart = 21845, XrefRangeEnd = 21847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Closure(InteriorNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00031100 File Offset: 0x0002F300
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21894, RefRangeEnd = 21897, XrefRangeStart = 21850, XrefRangeEnd = 21894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator Finish(bool useDFA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useDFA;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003114C File Offset: 0x0002F34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21897, XrefRangeEnd = 21926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<BitSet> CalculateTotalFollowposForRangeNodes(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, out BitSet posWithRangeTerminals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			posWithRangeTerminals = ((intPtr4 == 0) ? null : new BitSet(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BitSet>>(intPtr5) : null;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x000311D4 File Offset: 0x0002F3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21926, XrefRangeEnd = 21935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCMUPAWithLeafRangeNodes(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00031218 File Offset: 0x0002F418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21935, XrefRangeEnd = 21951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, Il2CppReferenceArray<BitSet> minmaxFollowPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(posWithRangeTerminals);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minmaxFollowPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BitSet>(intPtr3) : null;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x0003128C File Offset: 0x0002F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21951, XrefRangeEnd = 21954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000312E0 File Offset: 0x0002F4E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 21966, RefRangeEnd = 21970, XrefRangeStart = 21954, XrefRangeEnd = 21966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckUniqueParticleAttribution(BitSet curpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(curpos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00031324 File Offset: 0x0002F524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 22016, RefRangeEnd = 22017, XrefRangeStart = 21970, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Il2CppStructArray<int>> BuildTransitionTable(BitSet firstpos, Il2CppReferenceArray<BitSet> followpos, int endMarkerPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstpos);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(followpos);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkerPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleContentValidator.NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr3) : null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00004FAD File Offset: 0x000031AD
		public ParticleContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00031394 File Offset: 0x0002F594
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x00004FB6 File Offset: 0x000031B6
		public unsafe SymbolsDictionary symbols
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolsDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x000313C4 File Offset: 0x0002F5C4
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x00004FD5 File Offset: 0x000031D5
		public unsafe Positions positions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Positions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000313F4 File Offset: 0x0002F5F4
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x00004FF4 File Offset: 0x000031F4
		public unsafe Stack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00031424 File Offset: 0x0002F624
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00005013 File Offset: 0x00003213
		public unsafe SyntaxTreeNode contentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyntaxTreeNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_contentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00031454 File Offset: 0x0002F654
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00005032 File Offset: 0x00003232
		public unsafe bool isPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_isPartial)) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0003147C File Offset: 0x0002F67C
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0000504D File Offset: 0x0000324D
		public unsafe int minMaxNodesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_minMaxNodesCount)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x000314A4 File Offset: 0x0002F6A4
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x00005068 File Offset: 0x00003268
		public unsafe bool enableUpaCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleContentValidator.NativeFieldInfoPtr_enableUpaCheck)) = value;
			}
		}

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeFieldInfoPtr_symbols;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeFieldInfoPtr_positions;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeFieldInfoPtr_contentNode;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeFieldInfoPtr_isPartial;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeFieldInfoPtr_minMaxNodesCount;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeFieldInfoPtr_enableUpaCheck;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_Boolean_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_OpenGroup_Public_Void_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_CloseGroup_Public_Void_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Public_Void_XmlQualifiedName_Object_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespaceList_Public_Void_NamespaceList_Object_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_AddLeafNode_Private_Void_SyntaxTreeNode_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_AddChoice_Public_Void_0;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeMethodInfoPtr_AddSequence_Public_Void_0;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeMethodInfoPtr_AddStar_Public_Void_0;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeMethodInfoPtr_AddPlus_Public_Void_0;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeMethodInfoPtr_AddQMark_Public_Void_0;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeMethodInfoPtr_Closure_Private_Void_InteriorNode_0;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_ContentValidator_Boolean_0;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTotalFollowposForRangeNodes_Private_Il2CppReferenceArray_1_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_byref_BitSet_0;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeMethodInfoPtr_CheckCMUPAWithLeafRangeNodes_Private_Void_BitSet_0;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicableMinMaxFollowPos_Private_BitSet_BitSet_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_Il2CppReferenceArray_1_BitSet_0;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeMethodInfoPtr_CheckUniqueParticleAttribution_Private_Void_BitSet_0;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeMethodInfoPtr_BuildTransitionTable_Private_Il2CppReferenceArray_1_Il2CppStructArray_1_Int32_BitSet_Il2CppReferenceArray_1_BitSet_Int32_0;
	}
}
