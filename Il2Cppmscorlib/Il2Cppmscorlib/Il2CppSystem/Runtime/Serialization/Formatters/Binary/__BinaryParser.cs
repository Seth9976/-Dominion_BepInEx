using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000380 RID: 896
	public sealed class __BinaryParser : Object
	{
		// Token: 0x060039D2 RID: 14802 RVA: 0x00113D2C File Offset: 0x00111F2C
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryParser()
		{
			Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr);
			__BinaryParser.NativeFieldInfoPtr_objectReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectReader");
			__BinaryParser.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "input");
			__BinaryParser.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "topId");
			__BinaryParser.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "headerId");
			__BinaryParser.NativeFieldInfoPtr_objectMapIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectMapIdTable");
			__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "assemIdToAssemblyTable");
			__BinaryParser.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "stack");
			__BinaryParser.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedType");
			__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedTypeInformation");
			__BinaryParser.NativeFieldInfoPtr_PRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "PRS");
			__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "systemAssemblyInfo");
			__BinaryParser.NativeFieldInfoPtr_dataReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "dataReader");
			__BinaryParser.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "encoding");
			__BinaryParser.NativeFieldInfoPtr_opPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "opPool");
			__BinaryParser.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "binaryObject");
			__BinaryParser.NativeFieldInfoPtr_bowm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowm");
			__BinaryParser.NativeFieldInfoPtr_bowmt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowmt");
			__BinaryParser.NativeFieldInfoPtr_objectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectString");
			__BinaryParser.NativeFieldInfoPtr_crossAppDomainString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "crossAppDomainString");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryParser.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "byteBuffer");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryParser.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberReference");
			__BinaryParser.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectNull");
			__BinaryParser.NativeFieldInfoPtr_messageEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "messageEnd");
			__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671956);
			__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671957);
			__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671958);
			__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671959);
			__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671960);
			__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671961);
			__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671962);
			__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671963);
			__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671964);
			__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671965);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671966);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671967);
			__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671968);
			__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671969);
			__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671970);
			__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671971);
			__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671972);
			__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671973);
			__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671974);
			__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671975);
			__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671976);
			__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671977);
			__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671978);
			__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671979);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671980);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671981);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671982);
			__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671983);
			__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671984);
			__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671985);
			__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671986);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671987);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671988);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671989);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671990);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671991);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671992);
			__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671993);
			__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671994);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671995);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671996);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671997);
			__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671998);
			__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671999);
			__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672000);
			__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100672001);
		}

		// Token: 0x060039D3 RID: 14803 RVA: 0x001142E8 File Offset: 0x001124E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347255, RefRangeEnd = 347256, XrefRangeStart = 347240, XrefRangeEnd = 347255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryParser(Stream stream, ObjectReader objectReader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x00114348 File Offset: 0x00112548
		public unsafe BinaryAssemblyInfo SystemAssemblyInfo
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 347264, RefRangeEnd = 347269, XrefRangeStart = 347256, XrefRangeEnd = 347264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x00114388 File Offset: 0x00112588
		public unsafe SizedArray ObjectMapIdTable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347269, XrefRangeEnd = 347273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x060039D6 RID: 14806 RVA: 0x001143C8 File Offset: 0x001125C8
		public unsafe SizedArray AssemIdToAssemblyTable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 347277, RefRangeEnd = 347282, XrefRangeStart = 347273, XrefRangeEnd = 347277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x00114408 File Offset: 0x00112608
		public unsafe ParseRecord prs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 347286, RefRangeEnd = 347301, XrefRangeStart = 347282, XrefRangeEnd = 347286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr3) : null;
			}
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00114448 File Offset: 0x00112648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347353, RefRangeEnd = 347354, XrefRangeStart = 347301, XrefRangeEnd = 347353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x0011447C File Offset: 0x0011267C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x001144B0 File Offset: 0x001126B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x001144E4 File Offset: 0x001126E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347354, XrefRangeEnd = 347355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x00114520 File Offset: 0x00112720
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 347356, RefRangeEnd = 347360, XrefRangeStart = 347355, XrefRangeEnd = 347356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0011455C File Offset: 0x0011275C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347361, RefRangeEnd = 347362, XrefRangeStart = 347360, XrefRangeEnd = 347361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBytes(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x001145A8 File Offset: 0x001127A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347362, RefRangeEnd = 347363, XrefRangeStart = 347362, XrefRangeEnd = 347362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBytes(Il2CppStructArray<byte> byteA, int offset, int size)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00114608 File Offset: 0x00112808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347363, XrefRangeEnd = 347364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00114644 File Offset: 0x00112844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347364, XrefRangeEnd = 347365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ReadChars(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00114690 File Offset: 0x00112890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347365, XrefRangeEnd = 347373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x001146CC File Offset: 0x001128CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347373, XrefRangeEnd = 347374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x00114708 File Offset: 0x00112908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347374, XrefRangeEnd = 347375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00114744 File Offset: 0x00112944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347375, XrefRangeEnd = 347376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x00114780 File Offset: 0x00112980
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 347377, RefRangeEnd = 347400, XrefRangeStart = 347376, XrefRangeEnd = 347377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E6 RID: 14822 RVA: 0x001147BC File Offset: 0x001129BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347400, XrefRangeEnd = 347401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x001147F8 File Offset: 0x001129F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 347356, RefRangeEnd = 347360, XrefRangeStart = 347356, XrefRangeEnd = 347360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00114834 File Offset: 0x00112A34
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 347402, RefRangeEnd = 347409, XrefRangeStart = 347401, XrefRangeEnd = 347402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x0011486C File Offset: 0x00112A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ReadTimeSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x001148A8 File Offset: 0x00112AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347409, XrefRangeEnd = 347414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x001148E4 File Offset: 0x00112AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347414, XrefRangeEnd = 347415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x00114920 File Offset: 0x00112B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347415, XrefRangeEnd = 347416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x0011495C File Offset: 0x00112B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347416, XrefRangeEnd = 347417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x00114998 File Offset: 0x00112B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347417, XrefRangeEnd = 347425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSerializationHeaderRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001149CC File Offset: 0x00112BCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347472, RefRangeEnd = 347473, XrefRangeStart = 347425, XrefRangeEnd = 347472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x00114A0C File Offset: 0x00112C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347534, RefRangeEnd = 347535, XrefRangeStart = 347473, XrefRangeEnd = 347534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x00114A40 File Offset: 0x00112C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347720, RefRangeEnd = 347721, XrefRangeStart = 347535, XrefRangeEnd = 347720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCrossAppDomainMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F2 RID: 14834 RVA: 0x00114A74 File Offset: 0x00112C74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347730, RefRangeEnd = 347731, XrefRangeStart = 347721, XrefRangeEnd = 347730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x00114AB4 File Offset: 0x00112CB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347809, RefRangeEnd = 347810, XrefRangeStart = 347731, XrefRangeEnd = 347809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryObjectWithMap record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F4 RID: 14836 RVA: 0x00114AF8 File Offset: 0x00112CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347818, RefRangeEnd = 347819, XrefRangeStart = 347810, XrefRangeEnd = 347818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x00114B38 File Offset: 0x00112D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347900, RefRangeEnd = 347901, XrefRangeStart = 347819, XrefRangeEnd = 347900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00114B7C File Offset: 0x00112D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348041, RefRangeEnd = 348042, XrefRangeStart = 347901, XrefRangeEnd = 348041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00114BBC File Offset: 0x00112DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348129, RefRangeEnd = 348130, XrefRangeStart = 348042, XrefRangeEnd = 348129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00114BF0 File Offset: 0x00112DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348165, RefRangeEnd = 348166, XrefRangeStart = 348130, XrefRangeEnd = 348165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00114C30 File Offset: 0x00112E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348190, RefRangeEnd = 348191, XrefRangeStart = 348166, XrefRangeEnd = 348190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArrayAsBytes(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00114C74 File Offset: 0x00112E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348260, RefRangeEnd = 348261, XrefRangeStart = 348191, XrefRangeEnd = 348260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveUnTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x00114CA8 File Offset: 0x00112EA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348312, RefRangeEnd = 348313, XrefRangeStart = 348261, XrefRangeEnd = 348312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x00114CDC File Offset: 0x00112EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348364, RefRangeEnd = 348365, XrefRangeStart = 348313, XrefRangeEnd = 348364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039FD RID: 14845 RVA: 0x00114D1C File Offset: 0x00112F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348387, RefRangeEnd = 348388, XrefRangeStart = 348365, XrefRangeEnd = 348387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMessageEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x00114D50 File Offset: 0x00112F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348445, RefRangeEnd = 348447, XrefRangeStart = 348388, XrefRangeEnd = 348445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadValue(InternalPrimitiveTypeE code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00114D9C File Offset: 0x00112F9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 348452, RefRangeEnd = 348458, XrefRangeStart = 348447, XrefRangeEnd = 348452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress GetOp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectProgress>(intPtr3) : null;
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x00114DDC File Offset: 0x00112FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348466, RefRangeEnd = 348468, XrefRangeStart = 348458, XrefRangeEnd = 348466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutOp(ObjectProgress op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x000156CC File Offset: 0x000138CC
		public __BinaryParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x00114E20 File Offset: 0x00113020
		// (set) Token: 0x06003A03 RID: 14851 RVA: 0x000156D5 File Offset: 0x000138D5
		public unsafe ObjectReader objectReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06003A04 RID: 14852 RVA: 0x00114E50 File Offset: 0x00113050
		// (set) Token: 0x06003A05 RID: 14853 RVA: 0x000156F4 File Offset: 0x000138F4
		public unsafe Stream input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06003A06 RID: 14854 RVA: 0x00114E80 File Offset: 0x00113080
		// (set) Token: 0x06003A07 RID: 14855 RVA: 0x00015713 File Offset: 0x00013913
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06003A08 RID: 14856 RVA: 0x00114EA8 File Offset: 0x001130A8
		// (set) Token: 0x06003A09 RID: 14857 RVA: 0x0001572E File Offset: 0x0001392E
		public unsafe long headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06003A0A RID: 14858 RVA: 0x00114ED0 File Offset: 0x001130D0
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x00015749 File Offset: 0x00013949
		public unsafe SizedArray objectMapIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06003A0C RID: 14860 RVA: 0x00114F00 File Offset: 0x00113100
		// (set) Token: 0x06003A0D RID: 14861 RVA: 0x00015768 File Offset: 0x00013968
		public unsafe SizedArray assemIdToAssemblyTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x06003A0E RID: 14862 RVA: 0x00114F30 File Offset: 0x00113130
		// (set) Token: 0x06003A0F RID: 14863 RVA: 0x00015787 File Offset: 0x00013987
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06003A10 RID: 14864 RVA: 0x00114F60 File Offset: 0x00113160
		// (set) Token: 0x06003A11 RID: 14865 RVA: 0x000157A6 File Offset: 0x000139A6
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06003A12 RID: 14866 RVA: 0x00114F88 File Offset: 0x00113188
		// (set) Token: 0x06003A13 RID: 14867 RVA: 0x000157C1 File Offset: 0x000139C1
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003A14 RID: 14868 RVA: 0x00114FB8 File Offset: 0x001131B8
		// (set) Token: 0x06003A15 RID: 14869 RVA: 0x000157E0 File Offset: 0x000139E0
		public unsafe ParseRecord PRS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003A16 RID: 14870 RVA: 0x00114FE8 File Offset: 0x001131E8
		// (set) Token: 0x06003A17 RID: 14871 RVA: 0x000157FF File Offset: 0x000139FF
		public unsafe BinaryAssemblyInfo systemAssemblyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00115018 File Offset: 0x00113218
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x0001581E File Offset: 0x00013A1E
		public unsafe BinaryReader dataReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003A1A RID: 14874 RVA: 0x00115048 File Offset: 0x00113248
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x0001583D File Offset: 0x00013A3D
		public unsafe static Encoding encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003A1C RID: 14876 RVA: 0x00115070 File Offset: 0x00113270
		// (set) Token: 0x06003A1D RID: 14877 RVA: 0x0001584F File Offset: 0x00013A4F
		public unsafe SerStack opPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x001150A0 File Offset: 0x001132A0
		// (set) Token: 0x06003A1F RID: 14879 RVA: 0x0001586E File Offset: 0x00013A6E
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06003A20 RID: 14880 RVA: 0x001150D0 File Offset: 0x001132D0
		// (set) Token: 0x06003A21 RID: 14881 RVA: 0x0001588D File Offset: 0x00013A8D
		public unsafe BinaryObjectWithMap bowm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06003A22 RID: 14882 RVA: 0x00115100 File Offset: 0x00113300
		// (set) Token: 0x06003A23 RID: 14883 RVA: 0x000158AC File Offset: 0x00013AAC
		public unsafe BinaryObjectWithMapTyped bowmt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06003A24 RID: 14884 RVA: 0x00115130 File Offset: 0x00113330
		// (set) Token: 0x06003A25 RID: 14885 RVA: 0x000158CB File Offset: 0x00013ACB
		public unsafe BinaryObjectString objectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003A26 RID: 14886 RVA: 0x00115160 File Offset: 0x00113360
		// (set) Token: 0x06003A27 RID: 14887 RVA: 0x000158EA File Offset: 0x00013AEA
		public unsafe BinaryCrossAppDomainString crossAppDomainString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryCrossAppDomainString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003A28 RID: 14888 RVA: 0x00115190 File Offset: 0x00113390
		// (set) Token: 0x06003A29 RID: 14889 RVA: 0x00015909 File Offset: 0x00013B09
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003A2A RID: 14890 RVA: 0x001151C0 File Offset: 0x001133C0
		// (set) Token: 0x06003A2B RID: 14891 RVA: 0x00015928 File Offset: 0x00013B28
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003A2C RID: 14892 RVA: 0x001151F0 File Offset: 0x001133F0
		// (set) Token: 0x06003A2D RID: 14893 RVA: 0x00015947 File Offset: 0x00013B47
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003A2E RID: 14894 RVA: 0x00115220 File Offset: 0x00113420
		// (set) Token: 0x06003A2F RID: 14895 RVA: 0x00015966 File Offset: 0x00013B66
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003A30 RID: 14896 RVA: 0x00115250 File Offset: 0x00113450
		// (set) Token: 0x06003A31 RID: 14897 RVA: 0x00015985 File Offset: 0x00013B85
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003A32 RID: 14898 RVA: 0x00115280 File Offset: 0x00113480
		// (set) Token: 0x06003A33 RID: 14899 RVA: 0x000159A4 File Offset: 0x00013BA4
		public unsafe static MessageEnd messageEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageEnd>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeFieldInfoPtr_objectReader;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr_objectMapIdTable;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeFieldInfoPtr_assemIdToAssemblyTable;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeFieldInfoPtr_PRS;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeFieldInfoPtr_systemAssemblyInfo;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeFieldInfoPtr_dataReader;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeFieldInfoPtr_opPool;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeFieldInfoPtr_bowm;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeFieldInfoPtr_bowmt;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeFieldInfoPtr_objectString;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainString;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeFieldInfoPtr_messageEnd;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_ReadBegin_Internal_Void_0;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnd_Internal_Void_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Internal_Byte_0;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Internal_Char_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Internal_Single_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Internal_Double_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Internal_Int16_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Internal_Int32_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Internal_Int64_0;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Internal_SByte_0;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Internal_String_0;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Private_Void_0;

		// Token: 0x040030B3 RID: 12467
		private static readonly IntPtr NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0;

		// Token: 0x040030B4 RID: 12468
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x040030B5 RID: 12469
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0;

		// Token: 0x040030B6 RID: 12470
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x040030B7 RID: 12471
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0;

		// Token: 0x040030B8 RID: 12472
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberReference_Private_Void_0;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0;
	}
}
