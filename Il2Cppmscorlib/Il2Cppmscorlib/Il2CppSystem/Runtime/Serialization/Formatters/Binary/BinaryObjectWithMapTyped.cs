using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000360 RID: 864
	public sealed class BinaryObjectWithMapTyped : Object
	{
		// Token: 0x06003708 RID: 14088 RVA: 0x0010A2C0 File Offset: 0x001084C0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObjectWithMapTyped()
		{
			Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObjectWithMapTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr);
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryHeaderEnum");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "objectId");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "name");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "numMembers");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberNames");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "binaryTypeEnumA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "typeInformationA");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "memberAssemIds");
			BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, "assemId");
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671724);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671725);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671726);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671727);
			BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr, 100671728);
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x0010A408 File Offset: 0x00108608
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMapTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x0010A444 File Offset: 0x00108644
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObjectWithMapTyped>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x0010A48C File Offset: 0x0010868C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345045, RefRangeEnd = 345046, XrefRangeStart = 345045, XrefRangeEnd = 345045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int objectId, string name, int numMembers, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, int assemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0010A544 File Offset: 0x00108744
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345054, RefRangeEnd = 345055, XrefRangeStart = 345046, XrefRangeEnd = 345054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x0010A588 File Offset: 0x00108788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345078, RefRangeEnd = 345079, XrefRangeStart = 345055, XrefRangeEnd = 345078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObjectWithMapTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00013E19 File Offset: 0x00012019
		public BinaryObjectWithMapTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0010A5CC File Offset: 0x001087CC
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x00013E22 File Offset: 0x00012022
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0010A5F4 File Offset: 0x001087F4
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x00013E3D File Offset: 0x0001203D
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0010A61C File Offset: 0x0010881C
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x00013E58 File Offset: 0x00012058
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x0010A644 File Offset: 0x00108844
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x00013E77 File Offset: 0x00012077
		public unsafe int numMembers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_numMembers)) = value;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x0010A66C File Offset: 0x0010886C
		// (set) Token: 0x06003718 RID: 14104 RVA: 0x00013E92 File Offset: 0x00012092
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x0010A69C File Offset: 0x0010889C
		// (set) Token: 0x0600371A RID: 14106 RVA: 0x00013EB1 File Offset: 0x000120B1
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0010A6CC File Offset: 0x001088CC
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x00013ED0 File Offset: 0x000120D0
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x0010A6FC File Offset: 0x001088FC
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x00013EEF File Offset: 0x000120EF
		public unsafe Il2CppStructArray<int> memberAssemIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_memberAssemIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x0010A72C File Offset: 0x0010892C
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x00013F0E File Offset: 0x0001210E
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObjectWithMapTyped.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeFieldInfoPtr_numMembers;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeFieldInfoPtr_memberAssemIds;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_String_Int32_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;
	}
}
