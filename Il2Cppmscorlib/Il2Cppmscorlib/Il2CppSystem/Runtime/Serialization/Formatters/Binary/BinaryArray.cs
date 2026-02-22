using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000361 RID: 865
	public sealed class BinaryArray : Object
	{
		// Token: 0x06003721 RID: 14113 RVA: 0x0010A754 File Offset: 0x00108954
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryArray()
		{
			Il2CppClassPointerStore<BinaryArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr);
			BinaryArray.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "objectId");
			BinaryArray.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "rank");
			BinaryArray.NativeFieldInfoPtr_lengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lengthA");
			BinaryArray.NativeFieldInfoPtr_lowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "lowerBoundA");
			BinaryArray.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryTypeEnum");
			BinaryArray.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "typeInformation");
			BinaryArray.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "assemId");
			BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryHeaderEnum");
			BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, "binaryArrayTypeEnum");
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671729);
			BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671730);
			BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671731);
			BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671732);
			BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr, 100671733);
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0010A89C File Offset: 0x00108A9C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryArray()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0010A8D8 File Offset: 0x00108AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345080, RefRangeEnd = 345081, XrefRangeStart = 345079, XrefRangeEnd = 345080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryArray>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0010A920 File Offset: 0x00108B20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345081, RefRangeEnd = 345084, XrefRangeStart = 345081, XrefRangeEnd = 345081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA, BinaryTypeEnum binaryTypeEnum, Object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryTypeEnum;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryArrayTypeEnum;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x0010A9D0 File Offset: 0x00108BD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345093, RefRangeEnd = 345096, XrefRangeStart = 345084, XrefRangeEnd = 345093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0010AA14 File Offset: 0x00108C14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345116, RefRangeEnd = 345117, XrefRangeStart = 345096, XrefRangeEnd = 345116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryArray.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00013F29 File Offset: 0x00012129
		public BinaryArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06003728 RID: 14120 RVA: 0x0010AA58 File Offset: 0x00108C58
		// (set) Token: 0x06003729 RID: 14121 RVA: 0x00013F32 File Offset: 0x00012132
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x0600372A RID: 14122 RVA: 0x0010AA80 File Offset: 0x00108C80
		// (set) Token: 0x0600372B RID: 14123 RVA: 0x00013F4D File Offset: 0x0001214D
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x0600372C RID: 14124 RVA: 0x0010AAA8 File Offset: 0x00108CA8
		// (set) Token: 0x0600372D RID: 14125 RVA: 0x00013F68 File Offset: 0x00012168
		public unsafe Il2CppStructArray<int> lengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x0600372E RID: 14126 RVA: 0x0010AAD8 File Offset: 0x00108CD8
		// (set) Token: 0x0600372F RID: 14127 RVA: 0x00013F87 File Offset: 0x00012187
		public unsafe Il2CppStructArray<int> lowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_lowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x0010AB08 File Offset: 0x00108D08
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x00013FA6 File Offset: 0x000121A6
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x0010AB30 File Offset: 0x00108D30
		// (set) Token: 0x06003733 RID: 14131 RVA: 0x00013FC1 File Offset: 0x000121C1
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003734 RID: 14132 RVA: 0x0010AB60 File Offset: 0x00108D60
		// (set) Token: 0x06003735 RID: 14133 RVA: 0x00013FE0 File Offset: 0x000121E0
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x0010AB88 File Offset: 0x00108D88
		// (set) Token: 0x06003737 RID: 14135 RVA: 0x00013FFB File Offset: 0x000121FB
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0010ABB0 File Offset: 0x00108DB0
		// (set) Token: 0x06003739 RID: 14137 RVA: 0x00014016 File Offset: 0x00012216
		public unsafe BinaryArrayTypeEnum binaryArrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryArray.NativeFieldInfoPtr_binaryArrayTypeEnum)) = value;
			}
		}

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeFieldInfoPtr_lengthA;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeFieldInfoPtr_lowerBoundA;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002E53 RID: 11859
		private static readonly IntPtr NativeFieldInfoPtr_binaryArrayTypeEnum;

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_BinaryTypeEnum_Object_BinaryArrayTypeEnum_Int32_0;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}
