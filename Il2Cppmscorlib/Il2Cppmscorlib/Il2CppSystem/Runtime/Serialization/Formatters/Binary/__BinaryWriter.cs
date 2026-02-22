using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000377 RID: 887
	public sealed class __BinaryWriter : Object
	{
		// Token: 0x06003837 RID: 14391 RVA: 0x0010D8D8 File Offset: 0x0010BAD8
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryWriter()
		{
			Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr);
			__BinaryWriter.NativeFieldInfoPtr_sout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "sout");
			__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "formatterTypeStyle");
			__BinaryWriter.NativeFieldInfoPtr_objectMapTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectMapTable");
			__BinaryWriter.NativeFieldInfoPtr_objectWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectWriter");
			__BinaryWriter.NativeFieldInfoPtr_dataWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "dataWriter");
			__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "m_nestedObjectCount");
			__BinaryWriter.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "nullCount");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodCall");
			__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryMethodReturn");
			__BinaryWriter.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObject");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMap");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectWithMapTyped");
			__BinaryWriter.NativeFieldInfoPtr_binaryObjectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryObjectString");
			__BinaryWriter.NativeFieldInfoPtr_binaryArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryArray");
			__BinaryWriter.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "byteBuffer");
			__BinaryWriter.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "chunkSize");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryWriter.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "objectNull");
			__BinaryWriter.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "memberReference");
			__BinaryWriter.NativeFieldInfoPtr_binaryAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, "binaryAssembly");
			__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671794);
			__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671795);
			__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671796);
			__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671797);
			__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671798);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671799);
			__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671800);
			__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671801);
			__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671802);
			__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671803);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671804);
			__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671805);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671806);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671807);
			__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671808);
			__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671809);
			__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671810);
			__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671811);
			__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671812);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671813);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671814);
			__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671815);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671816);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671817);
			__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671818);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671819);
			__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671820);
			__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671821);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671822);
			__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671823);
			__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671824);
			__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671825);
			__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671826);
			__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671827);
			__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671828);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671829);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671830);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671831);
			__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671832);
			__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671833);
			__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671834);
			__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671835);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671836);
			__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671837);
			__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671838);
			__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671839);
			__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr, 100671840);
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x0010DE58 File Offset: 0x0010C058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345695, RefRangeEnd = 345696, XrefRangeStart = 345689, XrefRangeEnd = 345695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryWriter(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatterTypeStyle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x0010DEC4 File Offset: 0x0010C0C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383A RID: 14394 RVA: 0x0010DEF8 File Offset: 0x0010C0F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341855, RefRangeEnd = 341856, XrefRangeStart = 341855, XrefRangeEnd = 341856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x0010DF2C File Offset: 0x0010C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345696, XrefRangeEnd = 345697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBoolean(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x0010DF6C File Offset: 0x0010C16C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 345698, RefRangeEnd = 345723, XrefRangeStart = 345697, XrefRangeEnd = 345698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x0010DFAC File Offset: 0x0010C1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345723, XrefRangeEnd = 345724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x0010DFF0 File Offset: 0x0010C1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345724, XrefRangeEnd = 345725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteBytes(Il2CppStructArray<byte> byteA, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x0010E050 File Offset: 0x0010C250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345725, XrefRangeEnd = 345726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChar(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x0010E090 File Offset: 0x0010C290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345726, XrefRangeEnd = 345727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteChars(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x0010E0D4 File Offset: 0x0010C2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345727, XrefRangeEnd = 345732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDecimal(Decimal value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x0010E114 File Offset: 0x0010C314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345732, XrefRangeEnd = 345733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingle(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x0010E154 File Offset: 0x0010C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345733, XrefRangeEnd = 345734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDouble(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003844 RID: 14404 RVA: 0x0010E194 File Offset: 0x0010C394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345734, XrefRangeEnd = 345735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt16(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x0010E1D4 File Offset: 0x0010C3D4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 345736, RefRangeEnd = 345760, XrefRangeStart = 345735, XrefRangeEnd = 345736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt32(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003846 RID: 14406 RVA: 0x0010E214 File Offset: 0x0010C414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345760, XrefRangeEnd = 345761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInt64(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x0010E254 File Offset: 0x0010C454
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 345698, RefRangeEnd = 345723, XrefRangeStart = 345698, XrefRangeEnd = 345723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSByte(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0010E294 File Offset: 0x0010C494
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 345762, RefRangeEnd = 345771, XrefRangeStart = 345761, XrefRangeEnd = 345762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteString_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0010E2D8 File Offset: 0x0010C4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTimeSpan(TimeSpan value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0010E318 File Offset: 0x0010C518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDateTime(DateTime value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0010E358 File Offset: 0x0010C558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345771, XrefRangeEnd = 345772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt16(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x0010E398 File Offset: 0x0010C598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345772, XrefRangeEnd = 345773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt32(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0010E3D8 File Offset: 0x0010C5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345773, XrefRangeEnd = 345774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteUInt64(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0010E418 File Offset: 0x0010C618
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0010E46C File Offset: 0x0010C66C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345781, RefRangeEnd = 345782, XrefRangeStart = 345774, XrefRangeEnd = 345781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeaderEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0010E4A0 File Offset: 0x0010C6A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345789, RefRangeEnd = 345791, XrefRangeStart = 345782, XrefRangeEnd = 345789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0010E508 File Offset: 0x0010C708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345791, XrefRangeEnd = 345798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x0010E53C File Offset: 0x0010C73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345798, XrefRangeEnd = 345805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMethodReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0010E570 File Offset: 0x0010C770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345838, RefRangeEnd = 345840, XrefRangeStart = 345805, XrefRangeEnd = 345838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numMembers;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0010E60C File Offset: 0x0010C80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345840, XrefRangeEnd = 345848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectString(int objectId, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x0010E65C File Offset: 0x0010C85C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345873, RefRangeEnd = 345874, XrefRangeStart = 345848, XrefRangeEnd = 345873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x0010E704 File Offset: 0x0010C904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345890, RefRangeEnd = 345891, XrefRangeStart = 345874, XrefRangeEnd = 345890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayAsBytes(Array array, int typeLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0010E754 File Offset: 0x0010C954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345891, XrefRangeEnd = 345906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0010E7EC File Offset: 0x0010C9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345906, XrefRangeEnd = 345915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, Il2CppStructArray<int> lengthA, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthA);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0010E89C File Offset: 0x0010CA9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345917, RefRangeEnd = 345918, XrefRangeStart = 345915, XrefRangeEnd = 345917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Il2CppStructArray<byte> byteA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowerBound;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x0010E944 File Offset: 0x0010CB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345927, RefRangeEnd = 345928, XrefRangeStart = 345918, XrefRangeEnd = 345927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x0010E9AC File Offset: 0x0010CBAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345935, RefRangeEnd = 345937, XrefRangeStart = 345928, XrefRangeEnd = 345935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x0010EA00 File Offset: 0x0010CC00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 345945, RefRangeEnd = 345948, XrefRangeStart = 345937, XrefRangeEnd = 345945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0010EA50 File Offset: 0x0010CC50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345949, RefRangeEnd = 345950, XrefRangeStart = 345948, XrefRangeEnd = 345949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberNested(NameInfo memberNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0010EA94 File Offset: 0x0010CC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345950, XrefRangeEnd = 345959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x0010EAFC File Offset: 0x0010CCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345959, XrefRangeEnd = 345969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x0010EB64 File Offset: 0x0010CD64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 345970, RefRangeEnd = 345972, XrefRangeStart = 345969, XrefRangeEnd = 345970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0010EBB8 File Offset: 0x0010CDB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345972, RefRangeEnd = 345973, XrefRangeStart = 345972, XrefRangeEnd = 345972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDelayedNullItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x0010EBEC File Offset: 0x0010CDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345973, XrefRangeEnd = 345974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0010EC20 File Offset: 0x0010CE20
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 345980, RefRangeEnd = 346000, XrefRangeStart = 345974, XrefRangeEnd = 345980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteItemNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x0010EC54 File Offset: 0x0010CE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346000, XrefRangeEnd = 346009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x0010ECA4 File Offset: 0x0010CEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346019, RefRangeEnd = 346020, XrefRangeStart = 346009, XrefRangeEnd = 346019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x0010ED14 File Offset: 0x0010CF14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346132, RefRangeEnd = 346135, XrefRangeStart = 346020, XrefRangeEnd = 346132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteValue(InternalPrimitiveTypeE code, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryWriter.NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x000148A1 File Offset: 0x00012AA1
		public __BinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x0010ED64 File Offset: 0x0010CF64
		// (set) Token: 0x06003869 RID: 14441 RVA: 0x000148AA File Offset: 0x00012AAA
		public unsafe Stream sout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_sout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x0010ED94 File Offset: 0x0010CF94
		// (set) Token: 0x0600386B RID: 14443 RVA: 0x000148C9 File Offset: 0x00012AC9
		public unsafe FormatterTypeStyle formatterTypeStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_formatterTypeStyle)) = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x0010EDBC File Offset: 0x0010CFBC
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x000148E4 File Offset: 0x00012AE4
		public unsafe Hashtable objectMapTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectMapTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x0010EDEC File Offset: 0x0010CFEC
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x00014903 File Offset: 0x00012B03
		public unsafe ObjectWriter objectWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x0010EE1C File Offset: 0x0010D01C
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x00014922 File Offset: 0x00012B22
		public unsafe BinaryWriter dataWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_dataWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x0010EE4C File Offset: 0x0010D04C
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x00014941 File Offset: 0x00012B41
		public unsafe int m_nestedObjectCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_m_nestedObjectCount)) = value;
			}
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x0010EE74 File Offset: 0x0010D074
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x0001495C File Offset: 0x00012B5C
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x0010EE9C File Offset: 0x0010D09C
		// (set) Token: 0x06003877 RID: 14455 RVA: 0x00014977 File Offset: 0x00012B77
		public unsafe BinaryMethodCall binaryMethodCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodCall>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x0010EECC File Offset: 0x0010D0CC
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x00014996 File Offset: 0x00012B96
		public unsafe BinaryMethodReturn binaryMethodReturn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryMethodReturn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryMethodReturn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x0010EEFC File Offset: 0x0010D0FC
		// (set) Token: 0x0600387B RID: 14459 RVA: 0x000149B5 File Offset: 0x00012BB5
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x0010EF2C File Offset: 0x0010D12C
		// (set) Token: 0x0600387D RID: 14461 RVA: 0x000149D4 File Offset: 0x00012BD4
		public unsafe BinaryObjectWithMap binaryObjectWithMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x0010EF5C File Offset: 0x0010D15C
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x000149F3 File Offset: 0x00012BF3
		public unsafe BinaryObjectWithMapTyped binaryObjectWithMapTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectWithMapTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x0010EF8C File Offset: 0x0010D18C
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x00014A12 File Offset: 0x00012C12
		public unsafe BinaryObjectString binaryObjectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryObjectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x0010EFBC File Offset: 0x0010D1BC
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x00014A31 File Offset: 0x00012C31
		public unsafe BinaryArray binaryArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x0010EFEC File Offset: 0x0010D1EC
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x00014A50 File Offset: 0x00012C50
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x0010F01C File Offset: 0x0010D21C
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x00014A6F File Offset: 0x00012C6F
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x0010F044 File Offset: 0x0010D244
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x00014A8A File Offset: 0x00012C8A
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x0010F074 File Offset: 0x0010D274
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x00014AA9 File Offset: 0x00012CA9
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x00014AC8 File Offset: 0x00012CC8
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x0010F0D4 File Offset: 0x0010D2D4
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x00014AE7 File Offset: 0x00012CE7
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x0010F104 File Offset: 0x0010D304
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x00014B06 File Offset: 0x00012D06
		public unsafe BinaryAssembly binaryAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryWriter.NativeFieldInfoPtr_binaryAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F68 RID: 12136
		private static readonly IntPtr NativeFieldInfoPtr_sout;

		// Token: 0x04002F69 RID: 12137
		private static readonly IntPtr NativeFieldInfoPtr_formatterTypeStyle;

		// Token: 0x04002F6A RID: 12138
		private static readonly IntPtr NativeFieldInfoPtr_objectMapTable;

		// Token: 0x04002F6B RID: 12139
		private static readonly IntPtr NativeFieldInfoPtr_objectWriter;

		// Token: 0x04002F6C RID: 12140
		private static readonly IntPtr NativeFieldInfoPtr_dataWriter;

		// Token: 0x04002F6D RID: 12141
		private static readonly IntPtr NativeFieldInfoPtr_m_nestedObjectCount;

		// Token: 0x04002F6E RID: 12142
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002F6F RID: 12143
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodCall;

		// Token: 0x04002F70 RID: 12144
		private static readonly IntPtr NativeFieldInfoPtr_binaryMethodReturn;

		// Token: 0x04002F71 RID: 12145
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x04002F72 RID: 12146
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMap;

		// Token: 0x04002F73 RID: 12147
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectWithMapTyped;

		// Token: 0x04002F74 RID: 12148
		private static readonly IntPtr NativeFieldInfoPtr_binaryObjectString;

		// Token: 0x04002F75 RID: 12149
		private static readonly IntPtr NativeFieldInfoPtr_binaryArray;

		// Token: 0x04002F76 RID: 12150
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04002F77 RID: 12151
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04002F78 RID: 12152
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x04002F79 RID: 12153
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04002F7A RID: 12154
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x04002F7B RID: 12155
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04002F7C RID: 12156
		private static readonly IntPtr NativeFieldInfoPtr_binaryAssembly;

		// Token: 0x04002F7D RID: 12157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectWriter_FormatterTypeStyle_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly IntPtr NativeMethodInfoPtr_WriteBegin_Internal_Void_0;

		// Token: 0x04002F7F RID: 12159
		private static readonly IntPtr NativeMethodInfoPtr_WriteEnd_Internal_Void_0;

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeMethodInfoPtr_WriteBoolean_Internal_Void_Boolean_0;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Internal_Void_Byte_0;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeMethodInfoPtr_WriteBytes_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeMethodInfoPtr_WriteChar_Internal_Void_Char_0;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeMethodInfoPtr_WriteDecimal_Internal_Void_Decimal_0;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingle_Internal_Void_Single_0;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeMethodInfoPtr_WriteDouble_Internal_Void_Double_0;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt16_Internal_Void_Int16_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32_Internal_Void_Int32_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt64_Internal_Void_Int64_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr_WriteSByte_Internal_Void_SByte_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Internal_Void_String_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_WriteTimeSpan_Internal_Void_TimeSpan_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_WriteDateTime_Internal_Void_DateTime_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt16_Internal_Void_UInt16_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt32_Internal_Void_UInt32_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_WriteUInt64_Internal_Void_UInt64_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectEnd_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeaderEnd_Internal_Void_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializationHeader_Internal_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodCall_Internal_Void_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethodReturn_Internal_Void_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Internal_Void_NameInfo_NameInfo_Int32_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectString_Internal_Void_Int32_String_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_WriteSingleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Array_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayAsBytes_Private_Void_Array_Int32_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_WriteJaggedArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangleArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectByteArray_Internal_Void_NameInfo_NameInfo_WriteObjectInfo_NameInfo_Int32_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_WriteMember_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullMember_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberNested_Internal_Void_NameInfo_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberString_Internal_Void_NameInfo_NameInfo_String_0;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeMethodInfoPtr_WriteItem_Internal_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeMethodInfoPtr_WriteNullItem_Internal_Void_NameInfo_NameInfo_0;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeMethodInfoPtr_WriteDelayedNullItem_Internal_Void_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemEnd_Internal_Void_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteItemNull_Private_Void_0;

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemObjectRef_Internal_Void_NameInfo_Int32_0;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeMethodInfoPtr_WriteAssembly_Internal_Void_Type_String_Int32_Boolean_0;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Internal_Void_InternalPrimitiveTypeE_Object_0;
	}
}
