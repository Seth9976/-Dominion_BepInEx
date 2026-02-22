using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037E RID: 894
	public sealed class ObjectReader : Object
	{
		// Token: 0x06003934 RID: 14644 RVA: 0x001114CC File Offset: 0x0010F6CC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectReader()
		{
			Il2CppClassPointerStore<ObjectReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr);
			ObjectReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_stream");
			ObjectReader.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_surrogates");
			ObjectReader.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_context");
			ObjectReader.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_objectManager");
			ObjectReader.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "formatterEnums");
			ObjectReader.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_binder");
			ObjectReader.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "topId");
			ObjectReader.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bSimpleAssembly");
			ObjectReader.NativeFieldInfoPtr_handlerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handlerObject");
			ObjectReader.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_topObject");
			ObjectReader.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "headers");
			ObjectReader.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handler");
			ObjectReader.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "serObjectInfoInit");
			ObjectReader.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_formatterConverter");
			ObjectReader.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "stack");
			ObjectReader.NativeFieldInfoPtr_valueFixupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valueFixupStack");
			ObjectReader.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "crossAppDomainArray");
			ObjectReader.NativeFieldInfoPtr_bFullDeserialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bFullDeserialization");
			ObjectReader.NativeFieldInfoPtr_bOldFormatDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bOldFormatDetected");
			ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valTypeObjectIdTable");
			ObjectReader.NativeFieldInfoPtr_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "typeCache");
			ObjectReader.NativeFieldInfoPtr_previousAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousAssemblyString");
			ObjectReader.NativeFieldInfoPtr_previousName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousName");
			ObjectReader.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousType");
			ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671889);
			ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671890);
			ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671891);
			ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671892);
			ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671893);
			ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671894);
			ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671895);
			ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671896);
			ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671897);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671898);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671899);
			ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671900);
			ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671901);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671902);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671903);
			ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671904);
			ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671905);
			ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671906);
			ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671907);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671908);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671909);
			ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671910);
			ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671911);
			ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671912);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671913);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671914);
			ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671915);
			ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671916);
			ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671917);
			ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671918);
			ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671919);
			ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671920);
			ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671921);
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00111970 File Offset: 0x0010FB70
		public unsafe SerStack ValueFixupStack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 346472, RefRangeEnd = 346473, XrefRangeStart = 346466, XrefRangeEnd = 346472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr3) : null;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x001119B0 File Offset: 0x0010FBB0
		// (set) Token: 0x06003937 RID: 14647 RVA: 0x001119F0 File Offset: 0x0010FBF0
		public unsafe Object TopObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x00111A34 File Offset: 0x0010FC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346477, RefRangeEnd = 346478, XrefRangeStart = 346473, XrefRangeEnd = 346477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00111AD0 File Offset: 0x0010FCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346501, RefRangeEnd = 346502, XrefRangeStart = 346478, XrefRangeEnd = 346501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00111B40 File Offset: 0x0010FD40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346505, RefRangeEnd = 346507, XrefRangeStart = 346502, XrefRangeEnd = 346505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSurrogate(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00111B90 File Offset: 0x0010FD90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346508, RefRangeEnd = 346510, XrefRangeStart = 346507, XrefRangeEnd = 346508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSerializable(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00111BD4 File Offset: 0x0010FDD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346526, RefRangeEnd = 346528, XrefRangeStart = 346510, XrefRangeEnd = 346526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFullDeserialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00111C08 File Offset: 0x0010FE08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346528, RefRangeEnd = 346531, XrefRangeStart = 346528, XrefRangeEnd = 346528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CrossAppDomainArray(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00111C54 File Offset: 0x0010FE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346531, XrefRangeEnd = 346532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00111CA4 File Offset: 0x0010FEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346532, XrefRangeEnd = 346533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00111D18 File Offset: 0x0010FF18
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 346537, RefRangeEnd = 346550, XrefRangeStart = 346533, XrefRangeEnd = 346537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003941 RID: 14657 RVA: 0x00111D5C File Offset: 0x0010FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346550, XrefRangeEnd = 346604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseError(ParseRecord processing, ParseRecord onStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processing);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onStack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x00111DB0 File Offset: 0x0010FFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346604, XrefRangeEnd = 346606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeader(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x00111DF4 File Offset: 0x0010FFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346606, XrefRangeEnd = 346608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00111E38 File Offset: 0x00110038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346628, RefRangeEnd = 346630, XrefRangeStart = 346608, XrefRangeEnd = 346628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObject(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00111E7C File Offset: 0x0011007C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346639, RefRangeEnd = 346642, XrefRangeStart = 346630, XrefRangeEnd = 346639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObjectEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x00111EC0 File Offset: 0x001100C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346642, XrefRangeEnd = 346660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArray(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00111F04 File Offset: 0x00110104
		[CallerCount(0)]
		public unsafe void NextRectangleMap(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00111F48 File Offset: 0x00110148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346739, RefRangeEnd = 346740, XrefRangeStart = 346660, XrefRangeEnd = 346739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x00111F8C File Offset: 0x0011018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346740, XrefRangeEnd = 346741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x00111FD0 File Offset: 0x001101D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346767, RefRangeEnd = 346768, XrefRangeStart = 346741, XrefRangeEnd = 346767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00112014 File Offset: 0x00110214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346768, XrefRangeEnd = 346770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00112058 File Offset: 0x00110258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346770, XrefRangeEnd = 346771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x001120AC File Offset: 0x001102AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346771, XrefRangeEnd = 346774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00112114 File Offset: 0x00110314
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 346777, RefRangeEnd = 346781, XrefRangeStart = 346774, XrefRangeEnd = 346777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00112188 File Offset: 0x00110388
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 346783, RefRangeEnd = 346795, XrefRangeStart = 346781, XrefRangeEnd = 346783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetId(long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x001121D4 File Offset: 0x001103D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346795, XrefRangeEnd = 346796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Bind(string assemblyString, string typeString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00112238 File Offset: 0x00110438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346821, RefRangeEnd = 346823, XrefRangeStart = 346796, XrefRangeEnd = 346821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type FastBindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x0011229C File Offset: 0x0011049C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346826, RefRangeEnd = 346827, XrefRangeStart = 346823, XrefRangeEnd = 346826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x001122E0 File Offset: 0x001104E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346856, RefRangeEnd = 346858, XrefRangeStart = 346827, XrefRangeEnd = 346856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			type = ((intPtr4 == 0) ? null : new Type(intPtr4));
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00112350 File Offset: 0x00110550
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 346874, RefRangeEnd = 346877, XrefRangeStart = 346858, XrefRangeEnd = 346874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x001123B4 File Offset: 0x001105B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346888, RefRangeEnd = 346890, XrefRangeStart = 346877, XrefRangeEnd = 346888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00015149 File Offset: 0x00013349
		public ObjectReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x00112410 File Offset: 0x00110610
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x00015152 File Offset: 0x00013352
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x00112440 File Offset: 0x00110640
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x00015171 File Offset: 0x00013371
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x00112470 File Offset: 0x00110670
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x00015190 File Offset: 0x00013390
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x001124A0 File Offset: 0x001106A0
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x000151BE File Offset: 0x000133BE
		public unsafe ObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x001124D0 File Offset: 0x001106D0
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x000151DD File Offset: 0x000133DD
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x00112500 File Offset: 0x00110700
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x000151FC File Offset: 0x000133FC
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x00112530 File Offset: 0x00110730
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x0001521B File Offset: 0x0001341B
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00112558 File Offset: 0x00110758
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x00015236 File Offset: 0x00013436
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x00112580 File Offset: 0x00110780
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x00015251 File Offset: 0x00013451
		public unsafe Object handlerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x001125B0 File Offset: 0x001107B0
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x00015270 File Offset: 0x00013470
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x001125E0 File Offset: 0x001107E0
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x0001528F File Offset: 0x0001348F
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x00112610 File Offset: 0x00110810
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x000152AE File Offset: 0x000134AE
		public unsafe HeaderHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x00112640 File Offset: 0x00110840
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x000152CD File Offset: 0x000134CD
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x00112670 File Offset: 0x00110870
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x000152EC File Offset: 0x000134EC
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x001126A0 File Offset: 0x001108A0
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x0001530B File Offset: 0x0001350B
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x001126D0 File Offset: 0x001108D0
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x0001532A File Offset: 0x0001352A
		public unsafe SerStack valueFixupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x00112700 File Offset: 0x00110900
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x00015349 File Offset: 0x00013549
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x00112730 File Offset: 0x00110930
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x00015368 File Offset: 0x00013568
		public unsafe bool bFullDeserialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization)) = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x00112758 File Offset: 0x00110958
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x00015383 File Offset: 0x00013583
		public unsafe bool bOldFormatDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected)) = value;
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x00112780 File Offset: 0x00110980
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x0001539E File Offset: 0x0001359E
		public unsafe IntSizedArray valTypeObjectIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntSizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x001127B0 File Offset: 0x001109B0
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x000153BD File Offset: 0x000135BD
		public unsafe NameCache typeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x001127E0 File Offset: 0x001109E0
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x000153DC File Offset: 0x000135DC
		public unsafe string previousAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x00112808 File Offset: 0x00110A08
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x000153FB File Offset: 0x000135FB
		public unsafe string previousName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x00112830 File Offset: 0x00110A30
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x0001541A File Offset: 0x0001361A
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04003010 RID: 12304
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04003011 RID: 12305
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04003012 RID: 12306
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x04003013 RID: 12307
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x04003014 RID: 12308
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04003015 RID: 12309
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04003016 RID: 12310
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x04003017 RID: 12311
		private static readonly IntPtr NativeFieldInfoPtr_handlerObject;

		// Token: 0x04003018 RID: 12312
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x04003019 RID: 12313
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x0400301A RID: 12314
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupStack;

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeFieldInfoPtr_bFullDeserialization;

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeFieldInfoPtr_bOldFormatDetected;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeFieldInfoPtr_valTypeObjectIdTable;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeFieldInfoPtr_typeCache;

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeFieldInfoPtr_previousAssemblyString;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeFieldInfoPtr_previousName;

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0;

		// Token: 0x04003028 RID: 12328
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x04003029 RID: 12329
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x0400302A RID: 12330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x0400302B RID: 12331
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0;

		// Token: 0x0400302C RID: 12332
		private static readonly IntPtr NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0;

		// Token: 0x0400302D RID: 12333
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0;

		// Token: 0x0400302E RID: 12334
		private static readonly IntPtr NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0;

		// Token: 0x0400302F RID: 12335
		private static readonly IntPtr NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0;

		// Token: 0x04003030 RID: 12336
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0;

		// Token: 0x04003031 RID: 12337
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003032 RID: 12338
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0;

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0;

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0;

		// Token: 0x0400303A RID: 12346
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0;

		// Token: 0x0400303B RID: 12347
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x0400303C RID: 12348
		private static readonly IntPtr NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0;

		// Token: 0x0400303D RID: 12349
		private static readonly IntPtr NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x0400303E RID: 12350
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x0400303F RID: 12351
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0;

		// Token: 0x04003040 RID: 12352
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0;

		// Token: 0x04003041 RID: 12353
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0;

		// Token: 0x04003042 RID: 12354
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Type_String_String_0;

		// Token: 0x04003043 RID: 12355
		private static readonly IntPtr NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0;

		// Token: 0x04003044 RID: 12356
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0;

		// Token: 0x04003045 RID: 12357
		private static readonly IntPtr NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0;

		// Token: 0x04003046 RID: 12358
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0;

		// Token: 0x04003047 RID: 12359
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0;

		// Token: 0x02000627 RID: 1575
		public class TypeNAssembly : Object
		{
			// Token: 0x0600541E RID: 21534 RVA: 0x00174ADC File Offset: 0x00172CDC
			// Note: this type is marked as 'beforefieldinit'.
			static TypeNAssembly()
			{
				Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TypeNAssembly");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr);
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "type");
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "assemblyName");
				ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, 100671922);
			}

			// Token: 0x0600541F RID: 21535 RVA: 0x00174B44 File Offset: 0x00172D44
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeNAssembly()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005420 RID: 21536 RVA: 0x000206AA File Offset: 0x0001E8AA
			public TypeNAssembly(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700158C RID: 5516
			// (get) Token: 0x06005421 RID: 21537 RVA: 0x00174B80 File Offset: 0x00172D80
			// (set) Token: 0x06005422 RID: 21538 RVA: 0x000206B3 File Offset: 0x0001E8B3
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700158D RID: 5517
			// (get) Token: 0x06005423 RID: 21539 RVA: 0x00174BB0 File Offset: 0x00172DB0
			// (set) Token: 0x06005424 RID: 21540 RVA: 0x000206D2 File Offset: 0x0001E8D2
			public unsafe string assemblyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040043D0 RID: 17360
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040043D1 RID: 17361
			private static readonly IntPtr NativeFieldInfoPtr_assemblyName;

			// Token: 0x040043D2 RID: 17362
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000628 RID: 1576
		public sealed class TopLevelAssemblyTypeResolver : Object
		{
			// Token: 0x06005425 RID: 21541 RVA: 0x00174BD8 File Offset: 0x00172DD8
			// Note: this type is marked as 'beforefieldinit'.
			static TopLevelAssemblyTypeResolver()
			{
				Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TopLevelAssemblyTypeResolver");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, "m_topLevelAssembly");
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100671923);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100671924);
			}

			// Token: 0x06005426 RID: 21542 RVA: 0x00174C40 File Offset: 0x00172E40
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TopLevelAssemblyTypeResolver(Assembly topLevelAssembly)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(topLevelAssembly);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005427 RID: 21543 RVA: 0x00174C8C File Offset: 0x00172E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346464, XrefRangeEnd = 346466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(simpleTypeName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}

			// Token: 0x06005428 RID: 21544 RVA: 0x000206F1 File Offset: 0x0001E8F1
			public TopLevelAssemblyTypeResolver(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700158E RID: 5518
			// (get) Token: 0x06005429 RID: 21545 RVA: 0x00174CFC File Offset: 0x00172EFC
			// (set) Token: 0x0600542A RID: 21546 RVA: 0x000206FA File Offset: 0x0001E8FA
			public unsafe Assembly m_topLevelAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043D3 RID: 17363
			private static readonly IntPtr NativeFieldInfoPtr_m_topLevelAssembly;

			// Token: 0x040043D4 RID: 17364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;

			// Token: 0x040043D5 RID: 17365
			private static readonly IntPtr NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0;
		}
	}
}
