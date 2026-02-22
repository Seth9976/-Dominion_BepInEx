using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037F RID: 895
	public sealed class ObjectWriter : Object
	{
		// Token: 0x06003987 RID: 14727 RVA: 0x00112860 File Offset: 0x00110A60
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectWriter()
		{
			Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr);
			ObjectWriter.NativeFieldInfoPtr_m_objectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectQueue");
			ObjectWriter.NativeFieldInfoPtr_m_idGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_idGenerator");
			ObjectWriter.NativeFieldInfoPtr_m_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_currentId");
			ObjectWriter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_surrogates");
			ObjectWriter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_context");
			ObjectWriter.NativeFieldInfoPtr_serWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serWriter");
			ObjectWriter.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectManager");
			ObjectWriter.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topId");
			ObjectWriter.NativeFieldInfoPtr_topName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topName");
			ObjectWriter.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "headers");
			ObjectWriter.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "formatterEnums");
			ObjectWriter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_binder");
			ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serObjectInfoInit");
			ObjectWriter.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_formatterConverter");
			ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "crossAppDomainArray");
			ObjectWriter.NativeFieldInfoPtr_previousObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousObj");
			ObjectWriter.NativeFieldInfoPtr_previousId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousId");
			ObjectWriter.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousType");
			ObjectWriter.NativeFieldInfoPtr_previousCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousCode");
			ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "assemblyToIdTable");
			ObjectWriter.NativeFieldInfoPtr_niPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "niPool");
			ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671925);
			ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671926);
			ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671927);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671928);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671929);
			ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671930);
			ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671931);
			ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671932);
			ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671933);
			ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671934);
			ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671935);
			ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671936);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671937);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671938);
			ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671939);
			ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671940);
			ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671941);
			ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671942);
			ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671943);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671944);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671945);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671946);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671947);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671948);
			ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671949);
			ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671950);
			ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671951);
			ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671952);
			ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671953);
			ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671954);
			ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671955);
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00112CA0 File Offset: 0x00110EA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346900, RefRangeEnd = 346901, XrefRangeStart = 346890, XrefRangeEnd = 346900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00112D28 File Offset: 0x00110F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346945, RefRangeEnd = 346946, XrefRangeStart = 346901, XrefRangeEnd = 346945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Object graph, Il2CppReferenceArray<Header> inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inHeaders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serWriter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x00112D9C File Offset: 0x00110F9C
		public unsafe SerializationObjectManager ObjectManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00112DDC File Offset: 0x00110FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346998, RefRangeEnd = 346999, XrefRangeStart = 346946, XrefRangeEnd = 346998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00112E44 File Offset: 0x00111044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346999, XrefRangeEnd = 347026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<Object> memberData, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00112EF8 File Offset: 0x001110F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347026, XrefRangeEnd = 347038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, Object memberData, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00112FAC File Offset: 0x001111AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 347070, RefRangeEnd = 347073, XrefRangeStart = 347038, XrefRangeEnd = 347070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, Object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0011304C File Offset: 0x0011124C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347113, RefRangeEnd = 347114, XrefRangeStart = 347073, XrefRangeEnd = 347113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x001130B4 File Offset: 0x001112B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347116, RefRangeEnd = 347117, XrefRangeStart = 347114, XrefRangeEnd = 347116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0011311C File Offset: 0x0011131C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347117, XrefRangeEnd = 347125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangle(WriteObjectInfo objectInfo, int rank, Il2CppStructArray<int> maxA, Array array, NameInfo arrayElemNameTypeInfo, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maxA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemNameTypeInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x001131B8 File Offset: 0x001113B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347128, RefRangeEnd = 347130, XrefRangeStart = 347125, XrefRangeEnd = 347128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetNext(out long objID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00113204 File Offset: 0x00111404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347130, XrefRangeEnd = 347131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long InternalGetId(Object obj, bool assignUniqueIdToValueType, Type type, out bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00113280 File Offset: 0x00111480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347131, XrefRangeEnd = 347132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x001132F0 File Offset: 0x001114F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 347133, RefRangeEnd = 347135, XrefRangeStart = 347132, XrefRangeEnd = 347133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00113370 File Offset: 0x00111570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347140, RefRangeEnd = 347141, XrefRangeStart = 347135, XrefRangeEnd = 347140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x001133E4 File Offset: 0x001115E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347141, XrefRangeEnd = 347143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00113434 File Offset: 0x00111634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347143, XrefRangeEnd = 347146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, Object stringObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0011349C File Offset: 0x0011169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347146, XrefRangeEnd = 347147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00113520 File Offset: 0x00111720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347147, XrefRangeEnd = 347148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializedStreamHeader(long topId, long headerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x0011356C File Offset: 0x0011176C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347148, XrefRangeEnd = 347153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x001135F0 File Offset: 0x001117F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347153, XrefRangeEnd = 347155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00113640 File Offset: 0x00111840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 347159, RefRangeEnd = 347160, XrefRangeStart = 347155, XrefRangeEnd = 347159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00113690 File Offset: 0x00111890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347160, XrefRangeEnd = 347166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x001136F4 File Offset: 0x001118F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347166, XrefRangeEnd = 347170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TypeToNameInfo(Type type, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00113748 File Offset: 0x00111948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347170, XrefRangeEnd = 347171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo MemberToNameInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00113798 File Offset: 0x00111998
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 347175, RefRangeEnd = 347188, XrefRangeStart = 347171, XrefRangeEnd = 347175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalPrimitiveTypeE ToCode(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x001137E8 File Offset: 0x001119E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 347210, RefRangeEnd = 347213, XrefRangeStart = 347188, XrefRangeEnd = 347210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00113838 File Offset: 0x00111A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347213, XrefRangeEnd = 347215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00113888 File Offset: 0x00111A88
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 347220, RefRangeEnd = 347238, XrefRangeStart = 347215, XrefRangeEnd = 347220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo GetNameInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x001138C8 File Offset: 0x00111AC8
		[CallerCount(0)]
		public unsafe bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref test;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref want;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00113920 File Offset: 0x00111B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347238, XrefRangeEnd = 347240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutNameInfo(NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00015439 File Offset: 0x00013639
		public ObjectWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x00113964 File Offset: 0x00111B64
		// (set) Token: 0x060039A9 RID: 14761 RVA: 0x00015442 File Offset: 0x00013642
		public unsafe Queue m_objectQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x060039AA RID: 14762 RVA: 0x00113994 File Offset: 0x00111B94
		// (set) Token: 0x060039AB RID: 14763 RVA: 0x00015461 File Offset: 0x00013661
		public unsafe ObjectIDGenerator m_idGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectIDGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x001139C4 File Offset: 0x00111BC4
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x00015480 File Offset: 0x00013680
		public unsafe int m_currentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId)) = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x001139EC File Offset: 0x00111BEC
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x0001549B File Offset: 0x0001369B
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x00113A1C File Offset: 0x00111C1C
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x000154BA File Offset: 0x000136BA
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x00113A4C File Offset: 0x00111C4C
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x000154E8 File Offset: 0x000136E8
		public unsafe __BinaryWriter serWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<__BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x00113A7C File Offset: 0x00111C7C
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x00015507 File Offset: 0x00013707
		public unsafe SerializationObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060039B6 RID: 14774 RVA: 0x00113AAC File Offset: 0x00111CAC
		// (set) Token: 0x060039B7 RID: 14775 RVA: 0x00015526 File Offset: 0x00013726
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060039B8 RID: 14776 RVA: 0x00113AD4 File Offset: 0x00111CD4
		// (set) Token: 0x060039B9 RID: 14777 RVA: 0x00015541 File Offset: 0x00013741
		public unsafe string topName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x060039BA RID: 14778 RVA: 0x00113AFC File Offset: 0x00111CFC
		// (set) Token: 0x060039BB RID: 14779 RVA: 0x00015560 File Offset: 0x00013760
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x00113B2C File Offset: 0x00111D2C
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x0001557F File Offset: 0x0001377F
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x00113B5C File Offset: 0x00111D5C
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x0001559E File Offset: 0x0001379E
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x00113B8C File Offset: 0x00111D8C
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x000155BD File Offset: 0x000137BD
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00113BBC File Offset: 0x00111DBC
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x000155DC File Offset: 0x000137DC
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x00113BEC File Offset: 0x00111DEC
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x000155FB File Offset: 0x000137FB
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x00113C1C File Offset: 0x00111E1C
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x0001561A File Offset: 0x0001381A
		public unsafe Object previousObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x00113C4C File Offset: 0x00111E4C
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x00015639 File Offset: 0x00013839
		public unsafe long previousId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId)) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x00113C74 File Offset: 0x00111E74
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x00015654 File Offset: 0x00013854
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x00113CA4 File Offset: 0x00111EA4
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x00015673 File Offset: 0x00013873
		public unsafe InternalPrimitiveTypeE previousCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode)) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x00113CCC File Offset: 0x00111ECC
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x0001568E File Offset: 0x0001388E
		public unsafe Hashtable assemblyToIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00113CFC File Offset: 0x00111EFC
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x000156AD File Offset: 0x000138AD
		public unsafe SerStack niPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003048 RID: 12360
		private static readonly IntPtr NativeFieldInfoPtr_m_objectQueue;

		// Token: 0x04003049 RID: 12361
		private static readonly IntPtr NativeFieldInfoPtr_m_idGenerator;

		// Token: 0x0400304A RID: 12362
		private static readonly IntPtr NativeFieldInfoPtr_m_currentId;

		// Token: 0x0400304B RID: 12363
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x0400304C RID: 12364
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x0400304D RID: 12365
		private static readonly IntPtr NativeFieldInfoPtr_serWriter;

		// Token: 0x0400304E RID: 12366
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x0400304F RID: 12367
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04003050 RID: 12368
		private static readonly IntPtr NativeFieldInfoPtr_topName;

		// Token: 0x04003051 RID: 12369
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04003052 RID: 12370
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x04003053 RID: 12371
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04003054 RID: 12372
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04003055 RID: 12373
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeFieldInfoPtr_previousObj;

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeFieldInfoPtr_previousId;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeFieldInfoPtr_previousCode;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeFieldInfoPtr_assemblyToIdTable;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeFieldInfoPtr_niPool;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0;

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Private_Type_Object_0;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0;
	}
}
