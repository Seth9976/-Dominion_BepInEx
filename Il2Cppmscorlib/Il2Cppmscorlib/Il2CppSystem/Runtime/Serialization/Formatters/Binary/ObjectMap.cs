using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000366 RID: 870
	public sealed class ObjectMap : Object
	{
		// Token: 0x0600375F RID: 14175 RVA: 0x0010B474 File Offset: 0x00109674
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectMap()
		{
			Il2CppClassPointerStore<ObjectMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr);
			ObjectMap.NativeFieldInfoPtr_objectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectName");
			ObjectMap.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectType");
			ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "binaryTypeEnumA");
			ObjectMap.NativeFieldInfoPtr_typeInformationA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "typeInformationA");
			ObjectMap.NativeFieldInfoPtr_memberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "memberTypes");
			ObjectMap.NativeFieldInfoPtr_memberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "memberNames");
			ObjectMap.NativeFieldInfoPtr_objectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectInfo");
			ObjectMap.NativeFieldInfoPtr_isInitObjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "isInitObjectInfo");
			ObjectMap.NativeFieldInfoPtr_objectReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectReader");
			ObjectMap.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "objectId");
			ObjectMap.NativeFieldInfoPtr_assemblyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, "assemblyInfo");
			ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671755);
			ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671756);
			ObjectMap.NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671757);
			ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671758);
			ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr, 100671759);
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x0010B5E4 File Offset: 0x001097E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345152, RefRangeEnd = 345153, XrefRangeStart = 345141, XrefRangeEnd = 345152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap(string objectName, Type objectType, Il2CppStringArray memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0010B688 File Offset: 0x00109888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345165, RefRangeEnd = 345166, XrefRangeStart = 345153, XrefRangeEnd = 345165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectMap(string objectName, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemIdToAssemblyTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x0010B768 File Offset: 0x00109968
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 345168, RefRangeEnd = 345173, XrefRangeStart = 345166, XrefRangeEnd = 345168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr7) : null;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x0010B7F8 File Offset: 0x001099F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345177, RefRangeEnd = 345179, XrefRangeStart = 345173, XrefRangeEnd = 345177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectMap Create(string name, Type objectType, Il2CppStringArray memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x0010B894 File Offset: 0x00109A94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345183, RefRangeEnd = 345185, XrefRangeStart = 345179, XrefRangeEnd = 345183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjectMap Create(string name, Il2CppStringArray memberNames, Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA, Il2CppReferenceArray<Object> typeInformationA, Il2CppStructArray<int> memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binaryTypeEnumA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformationA);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberAssemIds);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemIdToAssemblyTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectMap.NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectMap>(intPtr3) : null;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000140C5 File Offset: 0x000122C5
		public ObjectMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003766 RID: 14182 RVA: 0x0010B96C File Offset: 0x00109B6C
		// (set) Token: 0x06003767 RID: 14183 RVA: 0x000140CE File Offset: 0x000122CE
		public unsafe string objectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06003768 RID: 14184 RVA: 0x0010B994 File Offset: 0x00109B94
		// (set) Token: 0x06003769 RID: 14185 RVA: 0x000140ED File Offset: 0x000122ED
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600376A RID: 14186 RVA: 0x0010B9C4 File Offset: 0x00109BC4
		// (set) Token: 0x0600376B RID: 14187 RVA: 0x0001410C File Offset: 0x0001230C
		public unsafe Il2CppStructArray<BinaryTypeEnum> binaryTypeEnumA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<BinaryTypeEnum>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_binaryTypeEnumA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600376C RID: 14188 RVA: 0x0010B9F4 File Offset: 0x00109BF4
		// (set) Token: 0x0600376D RID: 14189 RVA: 0x0001412B File Offset: 0x0001232B
		public unsafe Il2CppReferenceArray<Object> typeInformationA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_typeInformationA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_typeInformationA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x0600376E RID: 14190 RVA: 0x0010BA24 File Offset: 0x00109C24
		// (set) Token: 0x0600376F RID: 14191 RVA: 0x0001414A File Offset: 0x0001234A
		public unsafe Il2CppReferenceArray<Type> memberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06003770 RID: 14192 RVA: 0x0010BA54 File Offset: 0x00109C54
		// (set) Token: 0x06003771 RID: 14193 RVA: 0x00014169 File Offset: 0x00012369
		public unsafe Il2CppStringArray memberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_memberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06003772 RID: 14194 RVA: 0x0010BA84 File Offset: 0x00109C84
		// (set) Token: 0x06003773 RID: 14195 RVA: 0x00014188 File Offset: 0x00012388
		public unsafe ReadObjectInfo objectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06003774 RID: 14196 RVA: 0x0010BAB4 File Offset: 0x00109CB4
		// (set) Token: 0x06003775 RID: 14197 RVA: 0x000141A7 File Offset: 0x000123A7
		public unsafe bool isInitObjectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_isInitObjectInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_isInitObjectInfo)) = value;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06003776 RID: 14198 RVA: 0x0010BADC File Offset: 0x00109CDC
		// (set) Token: 0x06003777 RID: 14199 RVA: 0x000141C2 File Offset: 0x000123C2
		public unsafe ObjectReader objectReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06003778 RID: 14200 RVA: 0x0010BB0C File Offset: 0x00109D0C
		// (set) Token: 0x06003779 RID: 14201 RVA: 0x000141E1 File Offset: 0x000123E1
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600377A RID: 14202 RVA: 0x0010BB34 File Offset: 0x00109D34
		// (set) Token: 0x0600377B RID: 14203 RVA: 0x000141FC File Offset: 0x000123FC
		public unsafe BinaryAssemblyInfo assemblyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_assemblyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectMap.NativeFieldInfoPtr_assemblyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeFieldInfoPtr_objectName;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_binaryTypeEnumA;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_typeInformationA;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_memberTypes;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_memberNames;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_objectInfo;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr_isInitObjectInfo;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr_objectReader;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeFieldInfoPtr_assemblyInfo;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectInfo_Internal_ReadObjectInfo_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Type_Il2CppStringArray_ObjectReader_Int32_BinaryAssemblyInfo_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ObjectMap_String_Il2CppStringArray_Il2CppStructArray_1_BinaryTypeEnum_Il2CppReferenceArray_1_Object_Il2CppStructArray_1_Int32_ObjectReader_Int32_BinaryAssemblyInfo_SizedArray_0;
	}
}
