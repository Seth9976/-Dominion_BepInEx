using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000051 RID: 81
	public sealed class RegexFCD : Object
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x00024A7C File Offset: 0x00022C7C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFCD()
		{
			Il2CppClassPointerStore<RegexFCD>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFCD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr);
			RegexFCD.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intStack");
			RegexFCD.NativeFieldInfoPtr__intDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intDepth");
			RegexFCD.NativeFieldInfoPtr__fcStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcStack");
			RegexFCD.NativeFieldInfoPtr__fcDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcDepth");
			RegexFCD.NativeFieldInfoPtr__skipAllChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipAllChildren");
			RegexFCD.NativeFieldInfoPtr__skipchild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipchild");
			RegexFCD.NativeFieldInfoPtr__failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_failed");
			RegexFCD.NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664018);
			RegexFCD.NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664019);
			RegexFCD.NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664020);
			RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664021);
			RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664022);
			RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664023);
			RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664024);
			RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664025);
			RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664026);
			RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664027);
			RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664028);
			RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664029);
			RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664030);
			RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664031);
			RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664032);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00024C64 File Offset: 0x00022E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39062, XrefRangeEnd = 39086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexPrefix FirstChars(RegexTree t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00024CA8 File Offset: 0x00022EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39102, RefRangeEnd = 39103, XrefRangeStart = 39086, XrefRangeEnd = 39102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexPrefix Prefix(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr3) : null;
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00024CEC File Offset: 0x00022EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39118, RefRangeEnd = 39119, XrefRangeStart = 39103, XrefRangeEnd = 39118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Anchors(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00024D30 File Offset: 0x00022F30
		[CallerCount(0)]
		public unsafe static int AnchorFromType(int type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00024D70 File Offset: 0x00022F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39119, XrefRangeEnd = 39126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFCD()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00024DAC File Offset: 0x00022FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39126, XrefRangeEnd = 39130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInt(int I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00024DEC File Offset: 0x00022FEC
		[CallerCount(0)]
		public unsafe bool IntIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00024E28 File Offset: 0x00023028
		[CallerCount(0)]
		public unsafe int PopInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00024E64 File Offset: 0x00023064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39135, RefRangeEnd = 39136, XrefRangeStart = 39130, XrefRangeEnd = 39135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushFC(RegexFC fc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00024EA8 File Offset: 0x000230A8
		[CallerCount(0)]
		public unsafe bool FCIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00024EE4 File Offset: 0x000230E4
		[CallerCount(0)]
		public unsafe RegexFC PopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00024F24 File Offset: 0x00023124
		[CallerCount(0)]
		public unsafe RegexFC TopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00024F64 File Offset: 0x00023164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39149, RefRangeEnd = 39151, XrefRangeStart = 39136, XrefRangeEnd = 39149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00024FB4 File Offset: 0x000231B4
		[CallerCount(0)]
		public unsafe void SkipChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00024FE8 File Offset: 0x000231E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39157, RefRangeEnd = 39160, XrefRangeStart = 39151, XrefRangeEnd = 39157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref NodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CurIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00004153 File Offset: 0x00002353
		public RegexFCD(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00025048 File Offset: 0x00023248
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000415C File Offset: 0x0000235C
		public unsafe Il2CppStructArray<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00025078 File Offset: 0x00023278
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x0000417B File Offset: 0x0000237B
		public unsafe int _intDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intDepth)) = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000250A0 File Offset: 0x000232A0
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00004196 File Offset: 0x00002396
		public unsafe Il2CppReferenceArray<RegexFC> _fcStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RegexFC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x000250D0 File Offset: 0x000232D0
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x000041B5 File Offset: 0x000023B5
		public unsafe int _fcDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcDepth)) = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x000250F8 File Offset: 0x000232F8
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x000041D0 File Offset: 0x000023D0
		public unsafe bool _skipAllChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00025120 File Offset: 0x00023320
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x000041EB File Offset: 0x000023EB
		public unsafe bool _skipchild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00025148 File Offset: 0x00023348
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00004206 File Offset: 0x00002406
		public unsafe bool _failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed)) = value;
			}
		}

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr__intDepth;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr__fcStack;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr__fcDepth;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr__skipAllChildren;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr__skipchild;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr__failed;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeMethodInfoPtr_FirstChars_Internal_Static_RegexPrefix_RegexTree_0;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeMethodInfoPtr_Prefix_Internal_Static_RegexPrefix_RegexTree_0;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeMethodInfoPtr_Anchors_Internal_Static_Int32_RegexTree_0;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeMethodInfoPtr_PushInt_Private_Void_Int32_0;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr_PopInt_Private_Int32_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_PopFC_Private_RegexFC_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_TopFC_Private_RegexFC_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_SkipChild_Private_Void_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0;
	}
}
