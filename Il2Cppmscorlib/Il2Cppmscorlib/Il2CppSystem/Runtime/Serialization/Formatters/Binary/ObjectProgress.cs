using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000367 RID: 871
	public sealed class ObjectProgress : Object
	{
		// Token: 0x0600377C RID: 14204 RVA: 0x0010BB64 File Offset: 0x00109D64
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectProgress()
		{
			Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectProgress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr);
			ObjectProgress.NativeFieldInfoPtr_opRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "opRecordIdCount");
			ObjectProgress.NativeFieldInfoPtr_isInitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "isInitial");
			ObjectProgress.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "count");
			ObjectProgress.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedType");
			ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "expectedTypeInformation");
			ObjectProgress.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "name");
			ObjectProgress.NativeFieldInfoPtr_objectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "objectTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_memberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberValueEnum");
			ObjectProgress.NativeFieldInfoPtr_dtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "dtType");
			ObjectProgress.NativeFieldInfoPtr_numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "numItems");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnum");
			ObjectProgress.NativeFieldInfoPtr_typeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformation");
			ObjectProgress.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "nullCount");
			ObjectProgress.NativeFieldInfoPtr_memberLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberLength");
			ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "binaryTypeEnumA");
			ObjectProgress.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "typeInformationA");
			ObjectProgress.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberNames");
			ObjectProgress.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "memberTypes");
			ObjectProgress.NativeFieldInfoPtr_pr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, "pr");
			ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671760);
			ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671761);
			ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671762);
			ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr, 100671763);
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0010BD74 File Offset: 0x00109F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345185, XrefRangeEnd = 345189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectProgress>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0010BDB0 File Offset: 0x00109FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345193, RefRangeEnd = 345194, XrefRangeStart = 345189, XrefRangeEnd = 345193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0010BDE4 File Offset: 0x00109FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345194, RefRangeEnd = 345195, XrefRangeStart = 345194, XrefRangeEnd = 345194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ArrayCountIncrement(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0010BE24 File Offset: 0x0010A024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345195, RefRangeEnd = 345196, XrefRangeStart = 345195, XrefRangeEnd = 345195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out Object outTypeInformation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outBinaryTypeEnum;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectProgress.NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outTypeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0001421B File Offset: 0x0001241B
		public ObjectProgress(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06003782 RID: 14210 RVA: 0x0010BE90 File Offset: 0x0010A090
		// (set) Token: 0x06003783 RID: 14211 RVA: 0x00014224 File Offset: 0x00012424
		public unsafe static int opRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectProgress.NativeFieldInfoPtr_opRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x0010BEAC File Offset: 0x0010A0AC
		// (set) Token: 0x06003785 RID: 14213 RVA: 0x00014232 File Offset: 0x00012432
		public unsafe bool isInitial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_isInitial)) = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x0010BED4 File Offset: 0x0010A0D4
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x0001424D File Offset: 0x0001244D
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x0010BEFC File Offset: 0x0010A0FC
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x00014268 File Offset: 0x00012468
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x0010BF24 File Offset: 0x0010A124
		// (set) Token: 0x0600378B RID: 14219 RVA: 0x00014283 File Offset: 0x00012483
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x0010BF54 File Offset: 0x0010A154
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x000142A2 File Offset: 0x000124A2
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x0010BF7C File Offset: 0x0010A17C
		// (set) Token: 0x0600378F RID: 14223 RVA: 0x000142C1 File Offset: 0x000124C1
		public unsafe InternalObjectTypeE objectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_objectTypeEnum)) = value;
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x0010BFA4 File Offset: 0x0010A1A4
		// (set) Token: 0x06003791 RID: 14225 RVA: 0x000142DC File Offset: 0x000124DC
		public unsafe InternalMemberTypeE memberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypeEnum)) = value;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06003792 RID: 14226 RVA: 0x0010BFCC File Offset: 0x0010A1CC
		// (set) Token: 0x06003793 RID: 14227 RVA: 0x000142F7 File Offset: 0x000124F7
		public unsafe InternalMemberValueE memberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberValueEnum)) = value;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06003794 RID: 14228 RVA: 0x0010BFF4 File Offset: 0x0010A1F4
		// (set) Token: 0x06003795 RID: 14229 RVA: 0x00014312 File Offset: 0x00012512
		public unsafe Type dtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_dtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x06003796 RID: 14230 RVA: 0x0010C024 File Offset: 0x0010A224
		// (set) Token: 0x06003797 RID: 14231 RVA: 0x00014331 File Offset: 0x00012531
		public unsafe int numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_numItems)) = value;
			}
		}

		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06003798 RID: 14232 RVA: 0x0010C04C File Offset: 0x0010A24C
		// (set) Token: 0x06003799 RID: 14233 RVA: 0x0001434C File Offset: 0x0001254C
		public unsafe BinaryTypeEnum binaryTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnum)) = value;
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x0010C074 File Offset: 0x0010A274
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x00014367 File Offset: 0x00012567
		public unsafe Object typeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0010C0A4 File Offset: 0x0010A2A4
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x00014386 File Offset: 0x00012586
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0010C0CC File Offset: 0x0010A2CC
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x000143A1 File Offset: 0x000125A1
		public unsafe int memberLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberLength)) = value;
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x060037A0 RID: 14240 RVA: 0x0010C0F4 File Offset: 0x0010A2F4
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x000143BC File Offset: 0x000125BC
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x0010C124 File Offset: 0x0010A324
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x000143DB File Offset: 0x000125DB
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x0010C154 File Offset: 0x0010A354
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x000143FA File Offset: 0x000125FA
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x0010C184 File Offset: 0x0010A384
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x00014419 File Offset: 0x00012619
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x0010C1B4 File Offset: 0x0010A3B4
		// (set) Token: 0x060037A9 RID: 14249 RVA: 0x00014438 File Offset: 0x00012638
		public unsafe ParseRecord pr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectProgress.NativeFieldInfoPtr_pr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeFieldInfoPtr_opRecordIdCount;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeFieldInfoPtr_isInitial;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeFieldInfoPtr_objectTypeEnum;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeFieldInfoPtr_memberTypeEnum;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeFieldInfoPtr_memberValueEnum;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeFieldInfoPtr_dtType;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeFieldInfoPtr_numItems;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnum;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeFieldInfoPtr_typeInformation;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeFieldInfoPtr_memberLength;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeFieldInfoPtr_pr;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeMethodInfoPtr_ArrayCountIncrement_Internal_Void_Int32_0;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Internal_Boolean_byref_BinaryTypeEnum_byref_Object_0;
	}
}
