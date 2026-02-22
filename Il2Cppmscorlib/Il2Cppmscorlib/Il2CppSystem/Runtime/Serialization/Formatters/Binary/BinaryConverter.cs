using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000352 RID: 850
	public static class BinaryConverter : Object
	{
		// Token: 0x0600365C RID: 13916 RVA: 0x00108098 File Offset: 0x00106298
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryConverter()
		{
			Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr);
			BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671665);
			BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671666);
			BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671667);
			BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671668);
			BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671669);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0010812C File Offset: 0x0010632C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 344861, RefRangeEnd = 344865, XrefRangeStart = 344831, XrefRangeEnd = 344861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out Object typeInformation, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x001081D8 File Offset: 0x001063D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 344883, RefRangeEnd = 344884, XrefRangeStart = 344865, XrefRangeEnd = 344883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out Object typeInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0010823C File Offset: 0x0010643C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344886, RefRangeEnd = 344888, XrefRangeStart = 344884, XrefRangeEnd = 344886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, int assemId, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x001082A0 File Offset: 0x001064A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 344890, RefRangeEnd = 344893, XrefRangeStart = 344888, XrefRangeEnd = 344890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x00108300 File Offset: 0x00106500
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 344901, RefRangeEnd = 344903, XrefRangeStart = 344893, XrefRangeEnd = 344901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &primitiveTypeEnum;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isVariant;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			typeString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			type = ((intPtr5 == 0) ? null : new Type(intPtr5));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x000138D7 File Offset: 0x00011AD7
		public BinaryConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0;
	}
}
