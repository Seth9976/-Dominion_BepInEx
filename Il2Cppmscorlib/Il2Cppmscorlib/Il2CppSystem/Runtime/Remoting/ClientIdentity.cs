using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000392 RID: 914
	public class ClientIdentity : Identity
	{
		// Token: 0x06003B60 RID: 15200 RVA: 0x00118620 File Offset: 0x00116820
		// Note: this type is marked as 'beforefieldinit'.
		static ClientIdentity()
		{
			Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ClientIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr);
			ClientIdentity.NativeFieldInfoPtr__proxyReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, "_proxyReference");
			ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672073);
			ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672074);
			ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672075);
			ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672076);
			ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr, 100672077);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x001186C8 File Offset: 0x001168C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 348788, RefRangeEnd = 348789, XrefRangeStart = 348784, XrefRangeEnd = 348788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientIdentity(string objectUri, ObjRef objRef)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06003B62 RID: 15202 RVA: 0x00118728 File Offset: 0x00116928
		// (set) Token: 0x06003B63 RID: 15203 RVA: 0x00118768 File Offset: 0x00116968
		public unsafe MarshalByRefObject ClientProxy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 348791, RefRangeEnd = 348792, XrefRangeStart = 348789, XrefRangeEnd = 348791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348796, RefRangeEnd = 348798, XrefRangeStart = 348792, XrefRangeEnd = 348796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x001187AC File Offset: 0x001169AC
		[CallerCount(0)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x00118808 File Offset: 0x00116A08
		public unsafe string TargetUri
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 348799, RefRangeEnd = 348803, XrefRangeStart = 348798, XrefRangeEnd = 348799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientIdentity.NativeMethodInfoPtr_get_TargetUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x000165DF File Offset: 0x000147DF
		public ClientIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x00118840 File Offset: 0x00116A40
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x000165E8 File Offset: 0x000147E8
		public unsafe WeakReference _proxyReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientIdentity.NativeFieldInfoPtr__proxyReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeFieldInfoPtr__proxyReference;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ObjRef_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientProxy_Public_get_MarshalByRefObject_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_set_ClientProxy_Public_set_Void_MarshalByRefObject_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetUri_Public_get_String_0;
	}
}
