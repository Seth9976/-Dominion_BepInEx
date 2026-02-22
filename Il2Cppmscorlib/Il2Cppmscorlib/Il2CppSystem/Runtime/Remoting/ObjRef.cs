using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000394 RID: 916
	[Serializable]
	public class ObjRef : Object
	{
		// Token: 0x06003B6E RID: 15214 RVA: 0x00118934 File Offset: 0x00116B34
		// Note: this type is marked as 'beforefieldinit'.
		static ObjRef()
		{
			Il2CppClassPointerStore<ObjRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ObjRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjRef>.NativeClassPtr);
			ObjRef.NativeFieldInfoPtr_channel_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "channel_info");
			ObjRef.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "uri");
			ObjRef.NativeFieldInfoPtr_typeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "typeInfo");
			ObjRef.NativeFieldInfoPtr_envoyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "envoyInfo");
			ObjRef.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "flags");
			ObjRef.NativeFieldInfoPtr__serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "_serverType");
			ObjRef.NativeFieldInfoPtr_MarshalledObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "MarshalledObjectRef");
			ObjRef.NativeFieldInfoPtr_WellKnowObjectRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, "WellKnowObjectRef");
			ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672080);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672081);
			ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672082);
			ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672083);
			ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672084);
			ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672085);
			ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672086);
			ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672087);
			ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672088);
			ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672089);
			ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672090);
			ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672091);
			ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672092);
			ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672093);
			ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672094);
			ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672095);
			ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672096);
			ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjRef>.NativeClassPtr, 100672097);
		}

		// Token: 0x06003B6F RID: 15215 RVA: 0x00118B6C File Offset: 0x00116D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348870, RefRangeEnd = 348871, XrefRangeStart = 348866, XrefRangeEnd = 348870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B70 RID: 15216 RVA: 0x00118BA8 File Offset: 0x00116DA8
		[CallerCount(0)]
		public unsafe ObjRef(string uri, IChannelInfo cinfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cinfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B71 RID: 15217 RVA: 0x00118C08 File Offset: 0x00116E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348871, XrefRangeEnd = 348887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef DeserializeInTheCurrentDomain(int domainId, Il2CppStructArray<byte> tInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00118C68 File Offset: 0x00116E68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348895, RefRangeEnd = 348897, XrefRangeStart = 348887, XrefRangeEnd = 348895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> SerializeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00118CA8 File Offset: 0x00116EA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 348909, RefRangeEnd = 348912, XrefRangeStart = 348897, XrefRangeEnd = 348909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(Type type, string url, Object remoteChannelData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteChannelData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00118D18 File Offset: 0x00116F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348912, XrefRangeEnd = 348979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjRef(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjRef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x00118D7C File Offset: 0x00116F7C
		public unsafe bool IsReferenceToWellKnow
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348983, RefRangeEnd = 348985, XrefRangeStart = 348979, XrefRangeEnd = 348983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06003B76 RID: 15222 RVA: 0x00118DB8 File Offset: 0x00116FB8
		public unsafe virtual IChannelInfo ChannelInfo
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x00118E04 File Offset: 0x00117004
		// (set) Token: 0x06003B78 RID: 15224 RVA: 0x00118E50 File Offset: 0x00117050
		public unsafe virtual IEnvoyInfo EnvoyInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06003B79 RID: 15225 RVA: 0x00118EA0 File Offset: 0x001170A0
		// (set) Token: 0x06003B7A RID: 15226 RVA: 0x00118EEC File Offset: 0x001170EC
		public unsafe virtual IRemotingTypeInfo TypeInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x00118F3C File Offset: 0x0011713C
		// (set) Token: 0x06003B7C RID: 15228 RVA: 0x00118F80 File Offset: 0x00117180
		public unsafe virtual string URI
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003B7D RID: 15229 RVA: 0x00118FD0 File Offset: 0x001171D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348985, XrefRangeEnd = 349015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B7E RID: 15230 RVA: 0x00119034 File Offset: 0x00117234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349015, XrefRangeEnd = 349020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjRef.NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003B7F RID: 15231 RVA: 0x00119094 File Offset: 0x00117294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348870, RefRangeEnd = 348871, XrefRangeStart = 348870, XrefRangeEnd = 348871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChannelInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06003B80 RID: 15232 RVA: 0x001190C8 File Offset: 0x001172C8
		public unsafe Type ServerType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 349034, RefRangeEnd = 349035, XrefRangeStart = 349020, XrefRangeEnd = 349034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjRef.NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003B81 RID: 15233 RVA: 0x00016622 File Offset: 0x00014822
		public ObjRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00119108 File Offset: 0x00117308
		// (set) Token: 0x06003B83 RID: 15235 RVA: 0x0001662B File Offset: 0x0001482B
		public unsafe IChannelInfo channel_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChannelInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_channel_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06003B84 RID: 15236 RVA: 0x00119138 File Offset: 0x00117338
		// (set) Token: 0x06003B85 RID: 15237 RVA: 0x0001664A File Offset: 0x0001484A
		public unsafe string uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06003B86 RID: 15238 RVA: 0x00119160 File Offset: 0x00117360
		// (set) Token: 0x06003B87 RID: 15239 RVA: 0x00016669 File Offset: 0x00014869
		public unsafe IRemotingTypeInfo typeInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IRemotingTypeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_typeInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06003B88 RID: 15240 RVA: 0x00119190 File Offset: 0x00117390
		// (set) Token: 0x06003B89 RID: 15241 RVA: 0x00016688 File Offset: 0x00014888
		public unsafe IEnvoyInfo envoyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnvoyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_envoyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003B8A RID: 15242 RVA: 0x001191C0 File Offset: 0x001173C0
		// (set) Token: 0x06003B8B RID: 15243 RVA: 0x000166A7 File Offset: 0x000148A7
		public unsafe int flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x001191E8 File Offset: 0x001173E8
		// (set) Token: 0x06003B8D RID: 15245 RVA: 0x000166C2 File Offset: 0x000148C2
		public unsafe Type _serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjRef.NativeFieldInfoPtr__serverType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x00119218 File Offset: 0x00117418
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x000166E1 File Offset: 0x000148E1
		public unsafe static int MarshalledObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_MarshalledObjectRef, (void*)(&value));
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00119234 File Offset: 0x00117434
		// (set) Token: 0x06003B91 RID: 15249 RVA: 0x000166EF File Offset: 0x000148EF
		public unsafe static int WellKnowObjectRef
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjRef.NativeFieldInfoPtr_WellKnowObjectRef, (void*)(&value));
			}
		}

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeFieldInfoPtr_channel_info;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeFieldInfoPtr_typeInfo;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeFieldInfoPtr_envoyInfo;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeFieldInfoPtr__serverType;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeFieldInfoPtr_MarshalledObjectRef;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeFieldInfoPtr_WellKnowObjectRef;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_IChannelInfo_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeInTheCurrentDomain_Internal_ObjRef_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_SerializeType_Internal_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_Object_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReferenceToWellKnow_Internal_get_Boolean_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_get_ChannelInfo_Public_Virtual_New_get_IChannelInfo_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoyInfo_Public_Virtual_New_get_IEnvoyInfo_0;

		// Token: 0x04003183 RID: 12675
		private static readonly IntPtr NativeMethodInfoPtr_set_EnvoyInfo_Public_Virtual_New_set_Void_IEnvoyInfo_0;

		// Token: 0x04003184 RID: 12676
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeInfo_Public_Virtual_New_get_IRemotingTypeInfo_0;

		// Token: 0x04003185 RID: 12677
		private static readonly IntPtr NativeMethodInfoPtr_set_TypeInfo_Public_Virtual_New_set_Void_IRemotingTypeInfo_0;

		// Token: 0x04003186 RID: 12678
		private static readonly IntPtr NativeMethodInfoPtr_get_URI_Public_Virtual_New_get_String_0;

		// Token: 0x04003187 RID: 12679
		private static readonly IntPtr NativeMethodInfoPtr_set_URI_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04003188 RID: 12680
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003189 RID: 12681
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Virtual_New_Object_StreamingContext_0;

		// Token: 0x0400318A RID: 12682
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChannelInfo_Internal_Void_0;

		// Token: 0x0400318B RID: 12683
		private static readonly IntPtr NativeMethodInfoPtr_get_ServerType_Internal_get_Type_0;
	}
}
