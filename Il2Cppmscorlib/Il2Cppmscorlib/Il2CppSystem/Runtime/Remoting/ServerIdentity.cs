using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;
using Il2CppSystem.Runtime.Remoting.Lifetime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039C RID: 924
	public class ServerIdentity : Identity
	{
		// Token: 0x06003C52 RID: 15442 RVA: 0x0011BFFC File Offset: 0x0011A1FC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerIdentity()
		{
			Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ServerIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr);
			ServerIdentity.NativeFieldInfoPtr__objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_objectType");
			ServerIdentity.NativeFieldInfoPtr__serverObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverObject");
			ServerIdentity.NativeFieldInfoPtr__serverSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_serverSink");
			ServerIdentity.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_context");
			ServerIdentity.NativeFieldInfoPtr__lease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, "_lease");
			ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672197);
			ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672198);
			ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672199);
			ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672200);
			ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672201);
			ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672202);
			ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672203);
			ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672204);
			ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672205);
			ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672206);
			ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672207);
			ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr, 100672208);
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0011C180 File Offset: 0x0011A380
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 350983, RefRangeEnd = 350986, XrefRangeStart = 350982, XrefRangeEnd = 350983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerIdentity(string objectUri, Context context, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x0011C1F0 File Offset: 0x0011A3F0
		public unsafe Type ObjectType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0011C230 File Offset: 0x0011A430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350995, RefRangeEnd = 350996, XrefRangeStart = 350986, XrefRangeEnd = 350995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrackingLifetime(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0011C274 File Offset: 0x0011A474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350997, RefRangeEnd = 350998, XrefRangeStart = 350996, XrefRangeEnd = 350997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnLifetimeExpired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x0011C2B0 File Offset: 0x0011A4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350998, XrefRangeEnd = 351016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjRef CreateObjRef(Type requestedType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjRef>(intPtr3) : null;
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0011C30C File Offset: 0x0011A50C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351024, RefRangeEnd = 351026, XrefRangeStart = 351016, XrefRangeEnd = 351024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0011C360 File Offset: 0x0011A560
		public unsafe Lease Lease
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Lease_Public_get_Lease_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr3) : null;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x0011C3A0 File Offset: 0x0011A5A0
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x0011C3E0 File Offset: 0x0011A5E0
		public unsafe Context Context
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_get_Context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003C5C RID: 15452 RVA: 0x0011C424 File Offset: 0x0011A624
		[CallerCount(0)]
		public unsafe virtual IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003C5D RID: 15453 RVA: 0x0011C480 File Offset: 0x0011A680
		[CallerCount(0)]
		public unsafe virtual IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServerIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x0011C4F0 File Offset: 0x0011A6F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351031, RefRangeEnd = 351034, XrefRangeStart = 351026, XrefRangeEnd = 351031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisposeServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerIdentity.NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00016B5A File Offset: 0x00014D5A
		public ServerIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06003C60 RID: 15456 RVA: 0x0011C524 File Offset: 0x0011A724
		// (set) Token: 0x06003C61 RID: 15457 RVA: 0x00016B63 File Offset: 0x00014D63
		public unsafe Type _objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0011C554 File Offset: 0x0011A754
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x00016B82 File Offset: 0x00014D82
		public unsafe MarshalByRefObject _serverObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x0011C584 File Offset: 0x0011A784
		// (set) Token: 0x06003C65 RID: 15461 RVA: 0x00016BA1 File Offset: 0x00014DA1
		public unsafe IMessageSink _serverSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__serverSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06003C66 RID: 15462 RVA: 0x0011C5B4 File Offset: 0x0011A7B4
		// (set) Token: 0x06003C67 RID: 15463 RVA: 0x00016BC0 File Offset: 0x00014DC0
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06003C68 RID: 15464 RVA: 0x0011C5E4 File Offset: 0x0011A7E4
		// (set) Token: 0x06003C69 RID: 15465 RVA: 0x00016BDF File Offset: 0x00014DDF
		public unsafe Lease _lease
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lease>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerIdentity.NativeFieldInfoPtr__lease), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeFieldInfoPtr__objectType;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeFieldInfoPtr__serverObject;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeFieldInfoPtr__serverSink;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeFieldInfoPtr__lease;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Context_Type_0;

		// Token: 0x0400321A RID: 12826
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x0400321B RID: 12827
		private static readonly IntPtr NativeMethodInfoPtr_StartTrackingLifetime_Public_Void_ILease_0;

		// Token: 0x0400321C RID: 12828
		private static readonly IntPtr NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_New_Void_0;

		// Token: 0x0400321D RID: 12829
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjRef_Public_Virtual_ObjRef_Type_0;

		// Token: 0x0400321E RID: 12830
		private static readonly IntPtr NativeMethodInfoPtr_AttachServerObject_Public_Void_MarshalByRefObject_Context_0;

		// Token: 0x0400321F RID: 12831
		private static readonly IntPtr NativeMethodInfoPtr_get_Lease_Public_get_Lease_0;

		// Token: 0x04003220 RID: 12832
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Context_0;

		// Token: 0x04003221 RID: 12833
		private static readonly IntPtr NativeMethodInfoPtr_set_Context_Public_set_Void_Context_0;

		// Token: 0x04003222 RID: 12834
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessage_IMessage_0;

		// Token: 0x04003223 RID: 12835
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Abstract_Virtual_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04003224 RID: 12836
		private static readonly IntPtr NativeMethodInfoPtr_DisposeServerObject_Protected_Void_0;
	}
}
