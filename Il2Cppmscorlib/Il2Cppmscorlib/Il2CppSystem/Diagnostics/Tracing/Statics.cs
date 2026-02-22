using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Tracing
{
	// Token: 0x02000503 RID: 1283
	public static class Statics : Object
	{
		// Token: 0x06004961 RID: 18785 RVA: 0x00150650 File Offset: 0x0014E850
		// Note: this type is marked as 'beforefieldinit'.
		static Statics()
		{
			Il2CppClassPointerStore<Statics>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Tracing", "Statics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Statics>.NativeClassPtr);
			Statics.NativeFieldInfoPtr_IntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "IntPtrType");
			Statics.NativeFieldInfoPtr_UIntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "UIntPtrType");
			Statics.NativeFieldInfoPtr_HexIntPtrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Statics>.NativeClassPtr, "HexIntPtrType");
			Statics.NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674144);
			Statics.NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674145);
			Statics.NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674146);
			Statics.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674147);
			Statics.NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674148);
			Statics.NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674149);
			Statics.NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674150);
			Statics.NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674151);
			Statics.NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674152);
			Statics.NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674153);
			Statics.NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674154);
			Statics.NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674155);
			Statics.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674156);
			Statics.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674157);
			Statics.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674158);
			Statics.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674159);
			Statics.NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674160);
			Statics.NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674161);
			Statics.NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674162);
			Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674163);
			Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674164);
			Statics.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674165);
			Statics.NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674166);
			Statics.NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674167);
			Statics.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674168);
			Statics.NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674169);
			Statics.NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Statics>.NativeClassPtr, 100674170);
		}

		// Token: 0x06004962 RID: 18786 RVA: 0x001508D8 File Offset: 0x0014EAD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368740, RefRangeEnd = 368743, XrefRangeStart = 368730, XrefRangeEnd = 368740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixSize;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suffixSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additionalSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06004963 RID: 18787 RVA: 0x00150948 File Offset: 0x0014EB48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 368743, RefRangeEnd = 368746, XrefRangeStart = 368743, XrefRangeEnd = 368743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EncodeTags(int tags, ref int pos, Il2CppStructArray<byte> metadata)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004964 RID: 18788 RVA: 0x0015099C File Offset: 0x0014EB9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368746, RefRangeEnd = 368750, XrefRangeStart = 368746, XrefRangeEnd = 368746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte Combine(int settingValue, byte defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settingValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004965 RID: 18789 RVA: 0x001509E8 File Offset: 0x0014EBE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368750, RefRangeEnd = 368754, XrefRangeStart = 368750, XrefRangeEnd = 368750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine(int settingValue1, int settingValue2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref settingValue1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settingValue2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004966 RID: 18790 RVA: 0x00150A34 File Offset: 0x0014EC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368755, RefRangeEnd = 368757, XrefRangeStart = 368754, XrefRangeEnd = 368755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004967 RID: 18791 RVA: 0x00150A6C File Offset: 0x0014EC6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 368757, RefRangeEnd = 368759, XrefRangeStart = 368757, XrefRangeEnd = 368757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldOverrideFieldName(string fieldName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004968 RID: 18792 RVA: 0x00150AB0 File Offset: 0x0014ECB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 368759, RefRangeEnd = 368767, XrefRangeStart = 368759, XrefRangeEnd = 368759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baseType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004969 RID: 18793 RVA: 0x00150AFC File Offset: 0x0014ECFC
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 368768, RefRangeEnd = 368817, XrefRangeStart = 368767, XrefRangeEnd = 368768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600496A RID: 18794 RVA: 0x00150B48 File Offset: 0x0014ED48
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 368818, RefRangeEnd = 368868, XrefRangeStart = 368817, XrefRangeEnd = 368818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600496B RID: 18795 RVA: 0x00150B94 File Offset: 0x0014ED94
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 368869, RefRangeEnd = 368919, XrefRangeStart = 368868, XrefRangeEnd = 368869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00150BE0 File Offset: 0x0014EDE0
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 368920, RefRangeEnd = 368970, XrefRangeStart = 368919, XrefRangeEnd = 368920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x00150C2C File Offset: 0x0014EE2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 368974, RefRangeEnd = 368978, XrefRangeStart = 368970, XrefRangeEnd = 368974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref native;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00150C78 File Offset: 0x0014EE78
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 368979, RefRangeEnd = 368987, XrefRangeStart = 368978, XrefRangeEnd = 368979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateInstance(Type type, [Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00150CDC File Offset: 0x0014EEDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368989, RefRangeEnd = 368990, XrefRangeStart = 368987, XrefRangeEnd = 368989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValueType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004970 RID: 18800 RVA: 0x00150D20 File Offset: 0x0014EF20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264622, RefRangeEnd = 264627, XrefRangeStart = 264622, XrefRangeEnd = 264627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEnum(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004971 RID: 18801 RVA: 0x00150D64 File Offset: 0x0014EF64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368992, RefRangeEnd = 368993, XrefRangeStart = 368990, XrefRangeEnd = 368992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PropertyInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x00150DA8 File Offset: 0x0014EFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368995, RefRangeEnd = 368996, XrefRangeStart = 368993, XrefRangeEnd = 368995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetGetMethod(PropertyInfo propInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x00150DEC File Offset: 0x0014EFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368998, RefRangeEnd = 368999, XrefRangeStart = 368996, XrefRangeEnd = 368998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(declaringType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x00150E44 File Offset: 0x0014F044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 368999, RefRangeEnd = 369000, XrefRangeStart = 368999, XrefRangeEnd = 368999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x00150E98 File Offset: 0x0014F098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 369006, RefRangeEnd = 369007, XrefRangeStart = 369000, XrefRangeEnd = 369006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) where AttributeType : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0<AttributeType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<AttributeType>(intPtr, false, true);
			}
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x00150ED8 File Offset: 0x0014F0D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369013, RefRangeEnd = 369017, XrefRangeStart = 369007, XrefRangeEnd = 369013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeType GetCustomAttribute<AttributeType>(Type type) where AttributeType : Attribute
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_Type_0<AttributeType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<AttributeType>(intPtr, false, true);
			}
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x00150F18 File Offset: 0x0014F118
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369018, RefRangeEnd = 369022, XrefRangeStart = 369017, XrefRangeEnd = 369018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetGenericArguments(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x00150F5C File Offset: 0x0014F15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369041, RefRangeEnd = 369043, XrefRangeStart = 369022, XrefRangeEnd = 369041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type FindEnumerableElementType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06004979 RID: 18809 RVA: 0x00150FA0 File Offset: 0x0014F1A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 369044, RefRangeEnd = 369048, XrefRangeStart = 369043, XrefRangeEnd = 369044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenericMatch(Type type, Object openType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(openType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x00150FF4 File Offset: 0x0014F1F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 369049, RefRangeEnd = 369051, XrefRangeStart = 369048, XrefRangeEnd = 369049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0015104C File Offset: 0x0014F24C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 369104, RefRangeEnd = 369111, XrefRangeStart = 369051, XrefRangeEnd = 369104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo>(intPtr3) : null;
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x001510A4 File Offset: 0x0014F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369111, XrefRangeEnd = 369696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recursionCheck);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Statics.MethodInfoStoreGeneric_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0<DataType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraceLoggingTypeInfo<DataType>>(intPtr3) : null;
			}
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x0001B952 File Offset: 0x00019B52
		public static Object CreateInstance(Type type, params Object[] parameters)
		{
			return Statics.CreateInstance(type, new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0001B960 File Offset: 0x00019B60
		public Statics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x001510E8 File Offset: 0x0014F2E8
		// (set) Token: 0x06004980 RID: 18816 RVA: 0x0001B969 File Offset: 0x00019B69
		public unsafe static TraceLoggingDataType IntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_IntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_IntPtrType, (void*)(&value));
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06004981 RID: 18817 RVA: 0x00151104 File Offset: 0x0014F304
		// (set) Token: 0x06004982 RID: 18818 RVA: 0x0001B977 File Offset: 0x00019B77
		public unsafe static TraceLoggingDataType UIntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_UIntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_UIntPtrType, (void*)(&value));
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06004983 RID: 18819 RVA: 0x00151120 File Offset: 0x0014F320
		// (set) Token: 0x06004984 RID: 18820 RVA: 0x0001B985 File Offset: 0x00019B85
		public unsafe static TraceLoggingDataType HexIntPtrType
		{
			get
			{
				TraceLoggingDataType traceLoggingDataType;
				IL2CPP.il2cpp_field_static_get_value(Statics.NativeFieldInfoPtr_HexIntPtrType, (void*)(&traceLoggingDataType));
				return traceLoggingDataType;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Statics.NativeFieldInfoPtr_HexIntPtrType, (void*)(&value));
			}
		}

		// Token: 0x04003B27 RID: 15143
		private static readonly IntPtr NativeFieldInfoPtr_IntPtrType;

		// Token: 0x04003B28 RID: 15144
		private static readonly IntPtr NativeFieldInfoPtr_UIntPtrType;

		// Token: 0x04003B29 RID: 15145
		private static readonly IntPtr NativeFieldInfoPtr_HexIntPtrType;

		// Token: 0x04003B2A RID: 15146
		private static readonly IntPtr NativeMethodInfoPtr_MetadataForString_Public_Static_Il2CppStructArray_1_Byte_String_Int32_Int32_Int32_0;

		// Token: 0x04003B2B RID: 15147
		private static readonly IntPtr NativeMethodInfoPtr_EncodeTags_Public_Static_Void_Int32_byref_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003B2C RID: 15148
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Byte_Int32_Byte_0;

		// Token: 0x04003B2D RID: 15149
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04003B2E RID: 15150
		private static readonly IntPtr NativeMethodInfoPtr_CheckName_Public_Static_Void_String_0;

		// Token: 0x04003B2F RID: 15151
		private static readonly IntPtr NativeMethodInfoPtr_ShouldOverrideFieldName_Public_Static_Boolean_String_0;

		// Token: 0x04003B30 RID: 15152
		private static readonly IntPtr NativeMethodInfoPtr_MakeDataType_Public_Static_TraceLoggingDataType_TraceLoggingDataType_EventFieldFormat_0;

		// Token: 0x04003B31 RID: 15153
		private static readonly IntPtr NativeMethodInfoPtr_Format8_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003B32 RID: 15154
		private static readonly IntPtr NativeMethodInfoPtr_Format16_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003B33 RID: 15155
		private static readonly IntPtr NativeMethodInfoPtr_Format32_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003B34 RID: 15156
		private static readonly IntPtr NativeMethodInfoPtr_Format64_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003B35 RID: 15157
		private static readonly IntPtr NativeMethodInfoPtr_FormatPtr_Public_Static_TraceLoggingDataType_EventFieldFormat_TraceLoggingDataType_0;

		// Token: 0x04003B36 RID: 15158
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003B37 RID: 15159
		private static readonly IntPtr NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0;

		// Token: 0x04003B38 RID: 15160
		private static readonly IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

		// Token: 0x04003B39 RID: 15161
		private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Static_IEnumerable_1_PropertyInfo_Type_0;

		// Token: 0x04003B3A RID: 15162
		private static readonly IntPtr NativeMethodInfoPtr_GetGetMethod_Public_Static_MethodInfo_PropertyInfo_0;

		// Token: 0x04003B3B RID: 15163
		private static readonly IntPtr NativeMethodInfoPtr_GetDeclaredStaticMethod_Public_Static_MethodInfo_Type_String_0;

		// Token: 0x04003B3C RID: 15164
		private static readonly IntPtr NativeMethodInfoPtr_HasCustomAttribute_Public_Static_Boolean_PropertyInfo_Type_0;

		// Token: 0x04003B3D RID: 15165
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0;

		// Token: 0x04003B3E RID: 15166
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0;

		// Token: 0x04003B3F RID: 15167
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0;

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeMethodInfoPtr_FindEnumerableElementType_Public_Static_Type_Type_0;

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeMethodInfoPtr_IsGenericMatch_Public_Static_Boolean_Type_Object_0;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0;

		// Token: 0x04003B43 RID: 15171
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInfoInstance_Public_Static_TraceLoggingTypeInfo_Type_List_1_Type_0;

		// Token: 0x04003B44 RID: 15172
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0;

		// Token: 0x02000672 RID: 1650
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0<AttributeType>
		{
			// Token: 0x04004566 RID: 17766
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_PropertyInfo_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AttributeType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000673 RID: 1651
		private sealed class MethodInfoStoreGeneric_GetCustomAttribute_Public_Static_AttributeType_Type_0<AttributeType>
		{
			// Token: 0x04004567 RID: 17767
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_AttributeType_Type_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<AttributeType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000674 RID: 1652
		private sealed class MethodInfoStoreGeneric_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0<DataType>
		{
			// Token: 0x04004568 RID: 17768
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Statics.NativeMethodInfoPtr_CreateDefaultTypeInfo_Public_Static_TraceLoggingTypeInfo_1_DataType_List_1_Type_0, Il2CppClassPointerStore<Statics>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<DataType>.NativeClassPtr)) }))));
		}
	}
}
