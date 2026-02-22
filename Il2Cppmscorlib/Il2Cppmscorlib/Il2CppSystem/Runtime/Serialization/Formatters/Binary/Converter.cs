using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000368 RID: 872
	public sealed class Converter : Object
	{
		// Token: 0x060037AA RID: 14250 RVA: 0x0010C1E4 File Offset: 0x0010A3E4
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Converter>.NativeClassPtr);
			Converter.NativeFieldInfoPtr_primitiveTypeEnumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "primitiveTypeEnumLength");
			Converter.NativeFieldInfoPtr_typeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeA");
			Converter.NativeFieldInfoPtr_arrayTypeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "arrayTypeA");
			Converter.NativeFieldInfoPtr_valueA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "valueA");
			Converter.NativeFieldInfoPtr_typeCodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeCodeA");
			Converter.NativeFieldInfoPtr_codeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "codeA");
			Converter.NativeFieldInfoPtr_typeofISerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofISerializable");
			Converter.NativeFieldInfoPtr_typeofString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofString");
			Converter.NativeFieldInfoPtr_typeofConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofConverter");
			Converter.NativeFieldInfoPtr_typeofBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBoolean");
			Converter.NativeFieldInfoPtr_typeofByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByte");
			Converter.NativeFieldInfoPtr_typeofChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofChar");
			Converter.NativeFieldInfoPtr_typeofDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimal");
			Converter.NativeFieldInfoPtr_typeofDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDouble");
			Converter.NativeFieldInfoPtr_typeofInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16");
			Converter.NativeFieldInfoPtr_typeofInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32");
			Converter.NativeFieldInfoPtr_typeofInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64");
			Converter.NativeFieldInfoPtr_typeofSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByte");
			Converter.NativeFieldInfoPtr_typeofSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingle");
			Converter.NativeFieldInfoPtr_typeofTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpan");
			Converter.NativeFieldInfoPtr_typeofDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTime");
			Converter.NativeFieldInfoPtr_typeofUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16");
			Converter.NativeFieldInfoPtr_typeofUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32");
			Converter.NativeFieldInfoPtr_typeofUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64");
			Converter.NativeFieldInfoPtr_typeofObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObject");
			Converter.NativeFieldInfoPtr_typeofSystemVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSystemVoid");
			Converter.NativeFieldInfoPtr_urtAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssembly");
			Converter.NativeFieldInfoPtr_urtAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssemblyString");
			Converter.NativeFieldInfoPtr_typeofTypeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTypeArray");
			Converter.NativeFieldInfoPtr_typeofObjectArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObjectArray");
			Converter.NativeFieldInfoPtr_typeofStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofStringArray");
			Converter.NativeFieldInfoPtr_typeofBooleanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBooleanArray");
			Converter.NativeFieldInfoPtr_typeofByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByteArray");
			Converter.NativeFieldInfoPtr_typeofCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofCharArray");
			Converter.NativeFieldInfoPtr_typeofDecimalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimalArray");
			Converter.NativeFieldInfoPtr_typeofDoubleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDoubleArray");
			Converter.NativeFieldInfoPtr_typeofInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16Array");
			Converter.NativeFieldInfoPtr_typeofInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32Array");
			Converter.NativeFieldInfoPtr_typeofInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64Array");
			Converter.NativeFieldInfoPtr_typeofSByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByteArray");
			Converter.NativeFieldInfoPtr_typeofSingleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingleArray");
			Converter.NativeFieldInfoPtr_typeofTimeSpanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpanArray");
			Converter.NativeFieldInfoPtr_typeofDateTimeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTimeArray");
			Converter.NativeFieldInfoPtr_typeofUInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16Array");
			Converter.NativeFieldInfoPtr_typeofUInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32Array");
			Converter.NativeFieldInfoPtr_typeofUInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64Array");
			Converter.NativeFieldInfoPtr_typeofMarshalByRefObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofMarshalByRefObject");
			Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671765);
			Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671766);
			Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671767);
			Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671768);
			Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671769);
			Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671770);
			Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671771);
			Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671772);
			Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671773);
			Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671774);
			Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671775);
			Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671776);
			Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671777);
			Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671778);
			Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671779);
			Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671780);
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x0010C700 File Offset: 0x0010A900
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 345206, RefRangeEnd = 345214, XrefRangeStart = 345196, XrefRangeEnd = 345206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToCode(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x0010C744 File Offset: 0x0010A944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345214, RefRangeEnd = 345217, XrefRangeStart = 345214, XrefRangeEnd = 345214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x0010C784 File Offset: 0x0010A984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345217, RefRangeEnd = 345219, XrefRangeStart = 345217, XrefRangeEnd = 345217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TypeLength(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x0010C7C4 File Offset: 0x0010A9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345219, XrefRangeEnd = 345231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToArrayType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0010C804 File Offset: 0x0010AA04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345270, RefRangeEnd = 345271, XrefRangeStart = 345231, XrefRangeEnd = 345270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x0010C82C File Offset: 0x0010AA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345310, RefRangeEnd = 345311, XrefRangeStart = 345271, XrefRangeEnd = 345310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitArrayTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0010C854 File Offset: 0x0010AA54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345323, RefRangeEnd = 345326, XrefRangeStart = 345311, XrefRangeEnd = 345323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x0010C894 File Offset: 0x0010AA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345371, RefRangeEnd = 345372, XrefRangeStart = 345326, XrefRangeEnd = 345371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0010C8E4 File Offset: 0x0010AAE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345413, RefRangeEnd = 345415, XrefRangeStart = 345372, XrefRangeEnd = 345413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitiveArray(Type type, out Object typeInformation)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0010C948 File Offset: 0x0010AB48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345484, RefRangeEnd = 345485, XrefRangeStart = 345415, XrefRangeEnd = 345484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitValueA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0010C970 File Offset: 0x0010AB70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345497, RefRangeEnd = 345499, XrefRangeStart = 345485, XrefRangeEnd = 345497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToComType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x0010C9A8 File Offset: 0x0010ABA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345508, RefRangeEnd = 345510, XrefRangeStart = 345499, XrefRangeEnd = 345508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x0010C9D0 File Offset: 0x0010ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345510, XrefRangeEnd = 345522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x0010CA10 File Offset: 0x0010AC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345530, RefRangeEnd = 345531, XrefRangeStart = 345522, XrefRangeEnd = 345530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x0010CA38 File Offset: 0x0010AC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345531, XrefRangeEnd = 345543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x0010CA78 File Offset: 0x0010AC78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345567, RefRangeEnd = 345570, XrefRangeStart = 345543, XrefRangeEnd = 345567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromString(string value, InternalPrimitiveTypeE code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x00014457 File Offset: 0x00012657
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x0010CACC File Offset: 0x0010ACCC
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x00014460 File Offset: 0x00012660
		public unsafe static int primitiveTypeEnumLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&value));
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0010CAE8 File Offset: 0x0010ACE8
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x0001446E File Offset: 0x0001266E
		public unsafe static Il2CppReferenceArray<Type> typeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060037C0 RID: 14272 RVA: 0x0010CB10 File Offset: 0x0010AD10
		// (set) Token: 0x060037C1 RID: 14273 RVA: 0x00014480 File Offset: 0x00012680
		public unsafe static Il2CppReferenceArray<Type> arrayTypeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_arrayTypeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_arrayTypeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060037C2 RID: 14274 RVA: 0x0010CB38 File Offset: 0x0010AD38
		// (set) Token: 0x060037C3 RID: 14275 RVA: 0x00014492 File Offset: 0x00012692
		public unsafe static Il2CppStringArray valueA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_valueA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_valueA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060037C4 RID: 14276 RVA: 0x0010CB60 File Offset: 0x0010AD60
		// (set) Token: 0x060037C5 RID: 14277 RVA: 0x000144A4 File Offset: 0x000126A4
		public unsafe static Il2CppStructArray<TypeCode> typeCodeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeCodeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeCodeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060037C6 RID: 14278 RVA: 0x0010CB88 File Offset: 0x0010AD88
		// (set) Token: 0x060037C7 RID: 14279 RVA: 0x000144B6 File Offset: 0x000126B6
		public unsafe static Il2CppStructArray<InternalPrimitiveTypeE> codeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_codeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InternalPrimitiveTypeE>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_codeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060037C8 RID: 14280 RVA: 0x0010CBB0 File Offset: 0x0010ADB0
		// (set) Token: 0x060037C9 RID: 14281 RVA: 0x000144C8 File Offset: 0x000126C8
		public unsafe static Type typeofISerializable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofISerializable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofISerializable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x060037CA RID: 14282 RVA: 0x0010CBD8 File Offset: 0x0010ADD8
		// (set) Token: 0x060037CB RID: 14283 RVA: 0x000144DA File Offset: 0x000126DA
		public unsafe static Type typeofString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x060037CC RID: 14284 RVA: 0x0010CC00 File Offset: 0x0010AE00
		// (set) Token: 0x060037CD RID: 14285 RVA: 0x000144EC File Offset: 0x000126EC
		public unsafe static Type typeofConverter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofConverter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofConverter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060037CE RID: 14286 RVA: 0x0010CC28 File Offset: 0x0010AE28
		// (set) Token: 0x060037CF RID: 14287 RVA: 0x000144FE File Offset: 0x000126FE
		public unsafe static Type typeofBoolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBoolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBoolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060037D0 RID: 14288 RVA: 0x0010CC50 File Offset: 0x0010AE50
		// (set) Token: 0x060037D1 RID: 14289 RVA: 0x00014510 File Offset: 0x00012710
		public unsafe static Type typeofByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060037D2 RID: 14290 RVA: 0x0010CC78 File Offset: 0x0010AE78
		// (set) Token: 0x060037D3 RID: 14291 RVA: 0x00014522 File Offset: 0x00012722
		public unsafe static Type typeofChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x060037D4 RID: 14292 RVA: 0x0010CCA0 File Offset: 0x0010AEA0
		// (set) Token: 0x060037D5 RID: 14293 RVA: 0x00014534 File Offset: 0x00012734
		public unsafe static Type typeofDecimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060037D6 RID: 14294 RVA: 0x0010CCC8 File Offset: 0x0010AEC8
		// (set) Token: 0x060037D7 RID: 14295 RVA: 0x00014546 File Offset: 0x00012746
		public unsafe static Type typeofDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060037D8 RID: 14296 RVA: 0x0010CCF0 File Offset: 0x0010AEF0
		// (set) Token: 0x060037D9 RID: 14297 RVA: 0x00014558 File Offset: 0x00012758
		public unsafe static Type typeofInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x0010CD18 File Offset: 0x0010AF18
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x0001456A File Offset: 0x0001276A
		public unsafe static Type typeofInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x0010CD40 File Offset: 0x0010AF40
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x0001457C File Offset: 0x0001277C
		public unsafe static Type typeofInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x0010CD68 File Offset: 0x0010AF68
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x0001458E File Offset: 0x0001278E
		public unsafe static Type typeofSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x0010CD90 File Offset: 0x0010AF90
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x000145A0 File Offset: 0x000127A0
		public unsafe static Type typeofSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x0010CDB8 File Offset: 0x0010AFB8
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x000145B2 File Offset: 0x000127B2
		public unsafe static Type typeofTimeSpan
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x0010CDE0 File Offset: 0x0010AFE0
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x000145C4 File Offset: 0x000127C4
		public unsafe static Type typeofDateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x060037E6 RID: 14310 RVA: 0x0010CE08 File Offset: 0x0010B008
		// (set) Token: 0x060037E7 RID: 14311 RVA: 0x000145D6 File Offset: 0x000127D6
		public unsafe static Type typeofUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x060037E8 RID: 14312 RVA: 0x0010CE30 File Offset: 0x0010B030
		// (set) Token: 0x060037E9 RID: 14313 RVA: 0x000145E8 File Offset: 0x000127E8
		public unsafe static Type typeofUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x060037EA RID: 14314 RVA: 0x0010CE58 File Offset: 0x0010B058
		// (set) Token: 0x060037EB RID: 14315 RVA: 0x000145FA File Offset: 0x000127FA
		public unsafe static Type typeofUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0010CE80 File Offset: 0x0010B080
		// (set) Token: 0x060037ED RID: 14317 RVA: 0x0001460C File Offset: 0x0001280C
		public unsafe static Type typeofObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060037EE RID: 14318 RVA: 0x0010CEA8 File Offset: 0x0010B0A8
		// (set) Token: 0x060037EF RID: 14319 RVA: 0x0001461E File Offset: 0x0001281E
		public unsafe static Type typeofSystemVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x0010CED0 File Offset: 0x0010B0D0
		// (set) Token: 0x060037F1 RID: 14321 RVA: 0x00014630 File Offset: 0x00012830
		public unsafe static Assembly urtAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x0010CEF8 File Offset: 0x0010B0F8
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x00014642 File Offset: 0x00012842
		public unsafe static string urtAssemblyString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssemblyString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssemblyString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x0010CF18 File Offset: 0x0010B118
		// (set) Token: 0x060037F5 RID: 14325 RVA: 0x00014654 File Offset: 0x00012854
		public unsafe static Type typeofTypeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTypeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTypeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060037F6 RID: 14326 RVA: 0x0010CF40 File Offset: 0x0010B140
		// (set) Token: 0x060037F7 RID: 14327 RVA: 0x00014666 File Offset: 0x00012866
		public unsafe static Type typeofObjectArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObjectArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObjectArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x0010CF68 File Offset: 0x0010B168
		// (set) Token: 0x060037F9 RID: 14329 RVA: 0x00014678 File Offset: 0x00012878
		public unsafe static Type typeofStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060037FA RID: 14330 RVA: 0x0010CF90 File Offset: 0x0010B190
		// (set) Token: 0x060037FB RID: 14331 RVA: 0x0001468A File Offset: 0x0001288A
		public unsafe static Type typeofBooleanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x060037FC RID: 14332 RVA: 0x0010CFB8 File Offset: 0x0010B1B8
		// (set) Token: 0x060037FD RID: 14333 RVA: 0x0001469C File Offset: 0x0001289C
		public unsafe static Type typeofByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x060037FE RID: 14334 RVA: 0x0010CFE0 File Offset: 0x0010B1E0
		// (set) Token: 0x060037FF RID: 14335 RVA: 0x000146AE File Offset: 0x000128AE
		public unsafe static Type typeofCharArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofCharArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofCharArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003800 RID: 14336 RVA: 0x0010D008 File Offset: 0x0010B208
		// (set) Token: 0x06003801 RID: 14337 RVA: 0x000146C0 File Offset: 0x000128C0
		public unsafe static Type typeofDecimalArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003802 RID: 14338 RVA: 0x0010D030 File Offset: 0x0010B230
		// (set) Token: 0x06003803 RID: 14339 RVA: 0x000146D2 File Offset: 0x000128D2
		public unsafe static Type typeofDoubleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06003804 RID: 14340 RVA: 0x0010D058 File Offset: 0x0010B258
		// (set) Token: 0x06003805 RID: 14341 RVA: 0x000146E4 File Offset: 0x000128E4
		public unsafe static Type typeofInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06003806 RID: 14342 RVA: 0x0010D080 File Offset: 0x0010B280
		// (set) Token: 0x06003807 RID: 14343 RVA: 0x000146F6 File Offset: 0x000128F6
		public unsafe static Type typeofInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0010D0A8 File Offset: 0x0010B2A8
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x00014708 File Offset: 0x00012908
		public unsafe static Type typeofInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600380A RID: 14346 RVA: 0x0010D0D0 File Offset: 0x0010B2D0
		// (set) Token: 0x0600380B RID: 14347 RVA: 0x0001471A File Offset: 0x0001291A
		public unsafe static Type typeofSByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600380C RID: 14348 RVA: 0x0010D0F8 File Offset: 0x0010B2F8
		// (set) Token: 0x0600380D RID: 14349 RVA: 0x0001472C File Offset: 0x0001292C
		public unsafe static Type typeofSingleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600380E RID: 14350 RVA: 0x0010D120 File Offset: 0x0010B320
		// (set) Token: 0x0600380F RID: 14351 RVA: 0x0001473E File Offset: 0x0001293E
		public unsafe static Type typeofTimeSpanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06003810 RID: 14352 RVA: 0x0010D148 File Offset: 0x0010B348
		// (set) Token: 0x06003811 RID: 14353 RVA: 0x00014750 File Offset: 0x00012950
		public unsafe static Type typeofDateTimeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06003812 RID: 14354 RVA: 0x0010D170 File Offset: 0x0010B370
		// (set) Token: 0x06003813 RID: 14355 RVA: 0x00014762 File Offset: 0x00012962
		public unsafe static Type typeofUInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x0010D198 File Offset: 0x0010B398
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x00014774 File Offset: 0x00012974
		public unsafe static Type typeofUInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x0010D1C0 File Offset: 0x0010B3C0
		// (set) Token: 0x06003817 RID: 14359 RVA: 0x00014786 File Offset: 0x00012986
		public unsafe static Type typeofUInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x0010D1E8 File Offset: 0x0010B3E8
		// (set) Token: 0x06003819 RID: 14361 RVA: 0x00014798 File Offset: 0x00012998
		public unsafe static Type typeofMarshalByRefObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnumLength;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeFieldInfoPtr_typeA;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeFieldInfoPtr_arrayTypeA;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeFieldInfoPtr_valueA;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeFieldInfoPtr_typeCodeA;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeFieldInfoPtr_codeA;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeFieldInfoPtr_typeofISerializable;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeFieldInfoPtr_typeofString;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeFieldInfoPtr_typeofConverter;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeFieldInfoPtr_typeofBoolean;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeFieldInfoPtr_typeofByte;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeFieldInfoPtr_typeofChar;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimal;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeFieldInfoPtr_typeofDouble;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByte;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingle;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpan;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTime;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeFieldInfoPtr_typeofObject;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeFieldInfoPtr_typeofSystemVoid;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeFieldInfoPtr_urtAssembly;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeFieldInfoPtr_urtAssemblyString;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_typeofTypeArray;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeFieldInfoPtr_typeofObjectArray;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeFieldInfoPtr_typeofStringArray;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeFieldInfoPtr_typeofBooleanArray;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeFieldInfoPtr_typeofByteArray;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeFieldInfoPtr_typeofCharArray;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimalArray;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeFieldInfoPtr_typeofDoubleArray;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16Array;

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32Array;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64Array;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByteArray;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingleArray;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpanArray;

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTimeArray;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16Array;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32Array;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64Array;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeFieldInfoPtr_typeofMarshalByRefObject;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002ECD RID: 11981
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0;

		// Token: 0x04002ECE RID: 11982
		private static readonly IntPtr NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0;

		// Token: 0x04002ECF RID: 11983
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002ED0 RID: 11984
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0;

		// Token: 0x04002ED1 RID: 11985
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0;

		// Token: 0x04002ED2 RID: 11986
		private static readonly IntPtr NativeMethodInfoPtr_InitValueA_Private_Static_Void_0;

		// Token: 0x04002ED3 RID: 11987
		private static readonly IntPtr NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0;

		// Token: 0x04002ED4 RID: 11988
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0;

		// Token: 0x04002ED5 RID: 11989
		private static readonly IntPtr NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0;

		// Token: 0x04002ED6 RID: 11990
		private static readonly IntPtr NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0;

		// Token: 0x04002ED7 RID: 11991
		private static readonly IntPtr NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0;

		// Token: 0x04002ED8 RID: 11992
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0;
	}
}
