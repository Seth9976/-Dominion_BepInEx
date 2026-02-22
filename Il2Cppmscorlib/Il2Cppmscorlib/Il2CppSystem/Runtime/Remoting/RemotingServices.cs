using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Runtime.Serialization.Formatters.Binary;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039B RID: 923
	public static class RemotingServices : Object
	{
		// Token: 0x06003C17 RID: 15383 RVA: 0x0011ADC4 File Offset: 0x00118FC4
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingServices()
		{
			Il2CppClassPointerStore<RemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "RemotingServices");
			RemotingServices.NativeFieldInfoPtr_uri_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "uri_hash");
			RemotingServices.NativeFieldInfoPtr__serializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_serializationFormatter");
			RemotingServices.NativeFieldInfoPtr__deserializationFormatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "_deserializationFormatter");
			RemotingServices.NativeFieldInfoPtr_app_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id");
			RemotingServices.NativeFieldInfoPtr_app_id_lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "app_id_lock");
			RemotingServices.NativeFieldInfoPtr_next_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "next_id");
			RemotingServices.NativeFieldInfoPtr_FieldSetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldSetterMethod");
			RemotingServices.NativeFieldInfoPtr_FieldGetterMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "FieldGetterMethod");
			RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672155);
			RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672156);
			RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672157);
			RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672158);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672159);
			RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672160);
			RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672161);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672162);
			RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672163);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672164);
			RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672165);
			RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672166);
			RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672167);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672168);
			RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672169);
			RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672170);
			RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672171);
			RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672172);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672173);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672174);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672175);
			RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672176);
			RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672177);
			RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672178);
			RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672179);
			RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672180);
			RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672181);
			RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672182);
			RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672183);
			RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672184);
			RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672185);
			RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672186);
			RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672187);
			RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672188);
			RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672189);
			RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672190);
			RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672191);
			RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672192);
			RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672193);
			RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672194);
			RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, 100672195);
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x0011B1C0 File Offset: 0x001193C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350241, XrefRangeEnd = 350242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object InternalExecute(MethodBase method, Object obj, Il2CppReferenceArray<Object> parameters, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			out_args = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x0011B24C File Offset: 0x0011944C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350243, RefRangeEnd = 350244, XrefRangeStart = 350242, XrefRangeEnd = 350243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetVirtualMethod(Type type, MethodBase method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0011B2A4 File Offset: 0x001194A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 350249, RefRangeEnd = 350258, XrefRangeStart = 350244, XrefRangeEnd = 350249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsTransparentProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0011B2E8 File Offset: 0x001194E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 350335, RefRangeEnd = 350339, XrefRangeStart = 350258, XrefRangeEnd = 350335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reqMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMethodReturnMessage>(intPtr3) : null;
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x0011B340 File Offset: 0x00119540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350347, RefRangeEnd = 350348, XrefRangeStart = 350339, XrefRangeEnd = 350347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0011B398 File Offset: 0x00119598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350348, XrefRangeEnd = 350356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Connect(Type classToProxy, string url, Object data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0011B400 File Offset: 0x00119600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350362, RefRangeEnd = 350363, XrefRangeStart = 350356, XrefRangeEnd = 350362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetServerTypeForUri(string URI)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(URI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0011B444 File Offset: 0x00119644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350363, XrefRangeEnd = 350367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x0011B488 File Offset: 0x00119688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350410, RefRangeEnd = 350411, XrefRangeStart = 350367, XrefRangeEnd = 350410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unmarshal(ObjRef objectRef, bool fRefine)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fRefine;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x0011B4DC File Offset: 0x001196DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350415, RefRangeEnd = 350418, XrefRangeStart = 350411, XrefRangeEnd = 350415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x0011B520 File Offset: 0x00119720
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350427, RefRangeEnd = 350429, XrefRangeStart = 350418, XrefRangeEnd = 350427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ObjURI);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(RequestedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x0011B588 File Offset: 0x00119788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350429, XrefRangeEnd = 350482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NewUri()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_NewUri_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x0011B5B4 File Offset: 0x001197B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 350487, RefRangeEnd = 350492, XrefRangeStart = 350482, XrefRangeEnd = 350487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RealProxy GetRealProxy(Object proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
			}
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x0011B5F8 File Offset: 0x001197F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350529, RefRangeEnd = 350532, XrefRangeStart = 350492, XrefRangeEnd = 350529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x0011B63C File Offset: 0x0011983C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350550, RefRangeEnd = 350552, XrefRangeStart = 350532, XrefRangeEnd = 350550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase GetMethodBaseFromName(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x0011B6A4 File Offset: 0x001198A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350562, RefRangeEnd = 350563, XrefRangeStart = 350552, XrefRangeEnd = 350562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodBase FindInterfaceMethod(Type type, string methodName, Il2CppReferenceArray<Type> signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x0011B70C File Offset: 0x0011990C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350576, RefRangeEnd = 350577, XrefRangeStart = 350563, XrefRangeEnd = 350576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x0011B76C File Offset: 0x0011996C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350584, RefRangeEnd = 350586, XrefRangeStart = 350577, XrefRangeEnd = 350584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOneWay(MethodBase method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x0011B7B0 File Offset: 0x001199B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350586, XrefRangeEnd = 350602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(ActivatedClientTypeEntry entry, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x0011B808 File Offset: 0x00119A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350621, RefRangeEnd = 350622, XrefRangeStart = 350602, XrefRangeEnd = 350621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(Type objectType, string url, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x0011B870 File Offset: 0x00119A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350622, XrefRangeEnd = 350634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxy(WellKnownClientTypeEntry entry)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x0011B8B4 File Offset: 0x00119AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350634, XrefRangeEnd = 350646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateClientProxyForContextBound(Type type, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x0011B90C File Offset: 0x00119B0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 350684, RefRangeEnd = 350690, XrefRangeStart = 350646, XrefRangeEnd = 350684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetIdentityForUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x0011B950 File Offset: 0x00119B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350690, XrefRangeEnd = 350702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveAppNameFromUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x0011B98C File Offset: 0x00119B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350756, RefRangeEnd = 350758, XrefRangeStart = 350702, XrefRangeEnd = 350756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out Object clientProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientProxy = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ClientIdentity>(intPtr5) : null;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x0011BA08 File Offset: 0x00119C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350758, XrefRangeEnd = 350763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessageSink GetClientChannelSinkChain(string url, Object channelData, out string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(channelData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			objectUri = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr4) : null;
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0011BA7C File Offset: 0x00119C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350775, RefRangeEnd = 350776, XrefRangeStart = 350763, XrefRangeEnd = 350775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
			}
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0011BAC0 File Offset: 0x00119CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350776, XrefRangeEnd = 350793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(realObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientActivatedIdentity>(intPtr3) : null;
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0011BB28 File Offset: 0x00119D28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350812, RefRangeEnd = 350813, XrefRangeStart = 350793, XrefRangeEnd = 350812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr3) : null;
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x0011BB8C File Offset: 0x00119D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 350826, RefRangeEnd = 350828, XrefRangeStart = 350813, XrefRangeEnd = 350826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterServerIdentity(ServerIdentity identity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x0011BBC4 File Offset: 0x00119DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350834, RefRangeEnd = 350835, XrefRangeStart = 350828, XrefRangeEnd = 350834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetProxyForRemoteObject(ObjRef objref, Type classToProxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objref);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C37 RID: 15415 RVA: 0x0011BC1C File Offset: 0x00119E1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 350839, RefRangeEnd = 350843, XrefRangeStart = 350835, XrefRangeEnd = 350839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetRemoteObject(ObjRef objRef, Type proxyType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxyType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x0011BC74 File Offset: 0x00119E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350843, XrefRangeEnd = 350862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeCallData(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x0011BCB8 File Offset: 0x00119EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350862, XrefRangeEnd = 350880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeCallData(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x0011BCFC File Offset: 0x00119EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350880, XrefRangeEnd = 350890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> SerializeExceptionData(Exception ex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003C3B RID: 15419 RVA: 0x0011BD40 File Offset: 0x00119F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350890, XrefRangeEnd = 350894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterInternalChannels()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x0011BD68 File Offset: 0x00119F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350915, RefRangeEnd = 350918, XrefRangeStart = 350894, XrefRangeEnd = 350915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisposeIdentity(Identity ident)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ident);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0011BDA0 File Offset: 0x00119FA0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 350946, RefRangeEnd = 350957, XrefRangeStart = 350918, XrefRangeEnd = 350946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Identity GetMessageTargetIdentity(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
			}
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0011BDE4 File Offset: 0x00119FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350966, RefRangeEnd = 350969, XrefRangeStart = 350957, XrefRangeEnd = 350966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMessageTargetIdentity(IMessage msg, Identity ident)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ident);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0011BE2C File Offset: 0x0011A02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350978, RefRangeEnd = 350979, XrefRangeStart = 350969, XrefRangeEnd = 350978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateOutArgObject(ParameterInfo pi, Object local, Object remote)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(local);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remote);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x0011BE94 File Offset: 0x0011A094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350979, XrefRangeEnd = 350982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetNormalizedUri(string uri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x00016AC5 File Offset: 0x00014CC5
		public RemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003C42 RID: 15426 RVA: 0x0011BED0 File Offset: 0x0011A0D0
		// (set) Token: 0x06003C43 RID: 15427 RVA: 0x00016ACE File Offset: 0x00014CCE
		public unsafe static Hashtable uri_hash
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_uri_hash, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_uri_hash, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003C44 RID: 15428 RVA: 0x0011BEF8 File Offset: 0x0011A0F8
		// (set) Token: 0x06003C45 RID: 15429 RVA: 0x00016AE0 File Offset: 0x00014CE0
		public unsafe static BinaryFormatter _serializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__serializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x0011BF20 File Offset: 0x0011A120
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x00016AF2 File Offset: 0x00014CF2
		public unsafe static BinaryFormatter _deserializationFormatter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryFormatter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr__deserializationFormatter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x0011BF48 File Offset: 0x0011A148
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x00016B04 File Offset: 0x00014D04
		public unsafe static string app_id
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x0011BF68 File Offset: 0x0011A168
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x00016B16 File Offset: 0x00014D16
		public unsafe static Object app_id_lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_app_id_lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x0011BF90 File Offset: 0x0011A190
		// (set) Token: 0x06003C4D RID: 15437 RVA: 0x00016B28 File Offset: 0x00014D28
		public unsafe static int next_id
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_next_id, (void*)(&value));
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x0011BFAC File Offset: 0x0011A1AC
		// (set) Token: 0x06003C4F RID: 15439 RVA: 0x00016B36 File Offset: 0x00014D36
		public unsafe static MethodInfo FieldSetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldSetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x0011BFD4 File Offset: 0x0011A1D4
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x00016B48 File Offset: 0x00014D48
		public unsafe static MethodInfo FieldGetterMethod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingServices.NativeFieldInfoPtr_FieldGetterMethod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E3 RID: 12771
		private static readonly IntPtr NativeFieldInfoPtr_uri_hash;

		// Token: 0x040031E4 RID: 12772
		private static readonly IntPtr NativeFieldInfoPtr__serializationFormatter;

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr__deserializationFormatter;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeFieldInfoPtr_app_id;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeFieldInfoPtr_app_id_lock;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeFieldInfoPtr_next_id;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeFieldInfoPtr_FieldSetterMethod;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeFieldInfoPtr_FieldGetterMethod;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecute_Internal_Static_Object_MethodBase_Object_Il2CppReferenceArray_1_Object_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_Internal_Static_MethodBase_Type_MethodBase_0;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeMethodInfoPtr_IsTransparentProxy_Public_Static_Boolean_Object_0;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeMethodInfoPtr_InternalExecuteMessage_Internal_Static_IMethodReturnMessage_MarshalByRefObject_IMethodCallMessage_0;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_0;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Object_Type_String_Object_0;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeMethodInfoPtr_GetServerTypeForUri_Public_Static_Type_String_0;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_0;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeMethodInfoPtr_Unmarshal_Public_Static_Object_ObjRef_Boolean_0;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_0;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeMethodInfoPtr_Marshal_Public_Static_ObjRef_MarshalByRefObject_String_Type_0;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeMethodInfoPtr_NewUri_Private_Static_String_0;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeMethodInfoPtr_GetRealProxy_Public_Static_RealProxy_Object_0;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromMethodMessage_Public_Static_MethodBase_IMethodMessage_0;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodBaseFromName_Internal_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeMethodInfoPtr_FindInterfaceMethod_Private_Static_MethodBase_Type_String_Il2CppReferenceArray_1_Type_0;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Static_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_IsOneWay_Public_Static_Boolean_MethodBase_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_ActivatedClientTypeEntry_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040031FF RID: 12799
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxy_Internal_Static_Object_WellKnownClientTypeEntry_0;

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientProxyForContextBound_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeMethodInfoPtr_GetIdentityForUri_Internal_Static_Identity_String_0;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAppNameFromUri_Private_Static_String_String_0;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateClientIdentity_Internal_Static_ClientIdentity_ObjRef_Type_byref_Object_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_GetClientChannelSinkChain_Private_Static_IMessageSink_String_Object_byref_String_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr_CreateContextBoundObjectIdentity_Internal_Static_ClientActivatedIdentity_Type_0;

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeMethodInfoPtr_CreateClientActivatedServerIdentity_Internal_Static_ClientActivatedIdentity_MarshalByRefObject_Type_String_0;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeMethodInfoPtr_CreateWellKnownServerIdentity_Internal_Static_ServerIdentity_Type_String_WellKnownObjectMode_0;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeMethodInfoPtr_RegisterServerIdentity_Private_Static_Void_ServerIdentity_0;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyForRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoteObject_Internal_Static_Object_ObjRef_Type_0;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr_SerializeCallData_Internal_Static_Il2CppStructArray_1_Byte_Object_0;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeCallData_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_SerializeExceptionData_Internal_Static_Il2CppStructArray_1_Byte_Exception_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternalChannels_Private_Static_Void_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_DisposeIdentity_Internal_Static_Void_Identity_0;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeMethodInfoPtr_GetMessageTargetIdentity_Internal_Static_Identity_IMessage_0;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageTargetIdentity_Internal_Static_Void_IMessage_Identity_0;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutArgObject_Internal_Static_Boolean_ParameterInfo_Object_Object_0;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedUri_Private_Static_String_String_0;

		// Token: 0x02000629 RID: 1577
		[Serializable]
		public class CACD : Object
		{
			// Token: 0x0600542B RID: 21547 RVA: 0x00174D2C File Offset: 0x00172F2C
			// Note: this type is marked as 'beforefieldinit'.
			static CACD()
			{
				Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemotingServices>.NativeClassPtr, "CACD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr);
				RemotingServices.CACD.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "d");
				RemotingServices.CACD.NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, "c");
				RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr, 100672196);
			}

			// Token: 0x0600542C RID: 21548 RVA: 0x00174D94 File Offset: 0x00172F94
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CACD()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingServices.CACD>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingServices.CACD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600542D RID: 21549 RVA: 0x00020719 File Offset: 0x0001E919
			public CACD(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700158F RID: 5519
			// (get) Token: 0x0600542E RID: 21550 RVA: 0x00174DD0 File Offset: 0x00172FD0
			// (set) Token: 0x0600542F RID: 21551 RVA: 0x00020722 File Offset: 0x0001E922
			public unsafe Object d
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001590 RID: 5520
			// (get) Token: 0x06005430 RID: 21552 RVA: 0x00174E00 File Offset: 0x00173000
			// (set) Token: 0x06005431 RID: 21553 RVA: 0x00020741 File Offset: 0x0001E941
			public unsafe Object c
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingServices.CACD.NativeFieldInfoPtr_c), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043D6 RID: 17366
			private static readonly IntPtr NativeFieldInfoPtr_d;

			// Token: 0x040043D7 RID: 17367
			private static readonly IntPtr NativeFieldInfoPtr_c;

			// Token: 0x040043D8 RID: 17368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
