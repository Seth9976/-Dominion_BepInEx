using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020003AB RID: 939
	public class RealProxy : Object
	{
		// Token: 0x06003CF4 RID: 15604 RVA: 0x0011E77C File Offset: 0x0011C97C
		// Note: this type is marked as 'beforefieldinit'.
		static RealProxy()
		{
			Il2CppClassPointerStore<RealProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "RealProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealProxy>.NativeClassPtr);
			RealProxy.NativeFieldInfoPtr_class_to_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "class_to_proxy");
			RealProxy.NativeFieldInfoPtr__targetContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetContext");
			RealProxy.NativeFieldInfoPtr__server = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_server");
			RealProxy.NativeFieldInfoPtr__targetDomainId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetDomainId");
			RealProxy.NativeFieldInfoPtr__targetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_targetUri");
			RealProxy.NativeFieldInfoPtr__objectIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objectIdentity");
			RealProxy.NativeFieldInfoPtr__objTP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_objTP");
			RealProxy.NativeFieldInfoPtr__stubData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, "_stubData");
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672278);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672279);
			RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672280);
			RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672281);
			RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672282);
			RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672283);
			RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672284);
			RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672285);
			RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672286);
			RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672287);
			RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672288);
			RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672289);
			RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672290);
			RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672291);
			RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672292);
			RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672293);
			RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealProxy>.NativeClassPtr, 100672294);
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x0011E9A0 File Offset: 0x0011CBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351643, XrefRangeEnd = 351644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x0011E9DC File Offset: 0x0011CBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351644, XrefRangeEnd = 351646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0011EA28 File Offset: 0x0011CC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351646, XrefRangeEnd = 351648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, ClientIdentity identity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(identity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0011EA88 File Offset: 0x0011CC88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 351653, RefRangeEnd = 351658, XrefRangeStart = 351648, XrefRangeEnd = 351653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RealProxy(Type classToProxy, IntPtr stub, Object stubData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealProxy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classToProxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stub;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stubData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0011EAF4 File Offset: 0x0011CCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351658, XrefRangeEnd = 351659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type InternalGetProxyType(Object transparentProxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transparentProxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0011EB38 File Offset: 0x0011CD38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 351663, RefRangeEnd = 351667, XrefRangeStart = 351659, XrefRangeEnd = 351663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetProxiedType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetProxiedType_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x0011EB78 File Offset: 0x0011CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351667, XrefRangeEnd = 351672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x0011EBDC File Offset: 0x0011CDDC
		// (set) Token: 0x06003CFD RID: 15613 RVA: 0x0011EC1C File Offset: 0x0011CE1C
		public unsafe Identity ObjectIdentity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x0011EC60 File Offset: 0x0011CE60
		[CallerCount(0)]
		public unsafe virtual IMessage Invoke(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x0011ECBC File Offset: 0x0011CEBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351851, RefRangeEnd = 351853, XrefRangeStart = 351672, XrefRangeEnd = 351851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out Il2CppReferenceArray<Object> out_args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			exc = ((intPtr5 == 0) ? null : new Exception(intPtr5));
			IntPtr intPtr6 = intPtr2;
			out_args = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Object>(intPtr7) : null;
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x0011ED58 File Offset: 0x0011CF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351853, XrefRangeEnd = 351854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object InternalGetTransparentProxy(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x0011EDB4 File Offset: 0x0011CFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351854, XrefRangeEnd = 351866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetTransparentProxy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RealProxy.NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x0011EE00 File Offset: 0x0011D000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServer(MarshalByRefObject s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x0011EE44 File Offset: 0x0011D044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetDomain(int domainId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref domainId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x0011EE84 File Offset: 0x0011D084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351866, XrefRangeEnd = 351872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetAppDomainTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x0011EEC4 File Offset: 0x0011D0C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 351885, RefRangeEnd = 351886, XrefRangeStart = 351872, XrefRangeEnd = 351885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mrm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealProxy.NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00016EE2 File Offset: 0x000150E2
		public RealProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0011EF1C File Offset: 0x0011D11C
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x00016EEB File Offset: 0x000150EB
		public unsafe Type class_to_proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr_class_to_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x0011EF4C File Offset: 0x0011D14C
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x00016F0A File Offset: 0x0001510A
		public unsafe Context _targetContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x0011EF7C File Offset: 0x0011D17C
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x00016F29 File Offset: 0x00015129
		public unsafe MarshalByRefObject _server
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__server), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x0011EFAC File Offset: 0x0011D1AC
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x00016F48 File Offset: 0x00015148
		public unsafe int _targetDomainId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetDomainId)) = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x0011EFD4 File Offset: 0x0011D1D4
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x00016F63 File Offset: 0x00015163
		public unsafe string _targetUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__targetUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x0011EFFC File Offset: 0x0011D1FC
		// (set) Token: 0x06003D12 RID: 15634 RVA: 0x00016F82 File Offset: 0x00015182
		public unsafe Identity _objectIdentity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Identity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objectIdentity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06003D13 RID: 15635 RVA: 0x0011F02C File Offset: 0x0011D22C
		// (set) Token: 0x06003D14 RID: 15636 RVA: 0x00016FA1 File Offset: 0x000151A1
		public unsafe Object _objTP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__objTP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x0011F05C File Offset: 0x0011D25C
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x00016FC0 File Offset: 0x000151C0
		public unsafe Object _stubData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealProxy.NativeFieldInfoPtr__stubData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeFieldInfoPtr_class_to_proxy;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeFieldInfoPtr__targetContext;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeFieldInfoPtr__server;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeFieldInfoPtr__targetDomainId;

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr__targetUri;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr__objectIdentity;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr__objTP;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeFieldInfoPtr__stubData;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ClientIdentity_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_IntPtr_Object_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetProxyType_Private_Static_Type_Object_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_GetProxiedType_Public_Type_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectIdentity_Internal_get_Identity_0;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeMethodInfoPtr_set_ObjectIdentity_Internal_set_Void_Identity_0;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeMethodInfoPtr_PrivateInvoke_Internal_Static_Object_RealProxy_IMessage_byref_Exception_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetTransparentProxy_Internal_Virtual_New_Object_String_0;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeMethodInfoPtr_GetTransparentProxy_Public_Virtual_New_Object_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeMethodInfoPtr_AttachServer_Protected_Void_MarshalByRefObject_0;

		// Token: 0x04003297 RID: 12951
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetDomain_Internal_Void_Int32_0;

		// Token: 0x04003298 RID: 12952
		private static readonly IntPtr NativeMethodInfoPtr_GetAppDomainTarget_Internal_Object_0;

		// Token: 0x04003299 RID: 12953
		private static readonly IntPtr NativeMethodInfoPtr_ProcessResponse_Private_Static_Il2CppReferenceArray_1_Object_IMethodReturnMessage_MonoMethodMessage_0;
	}
}
