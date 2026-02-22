using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200039D RID: 925
	public class ClientActivatedIdentity : ServerIdentity
	{
		// Token: 0x06003C6A RID: 15466 RVA: 0x0011C614 File Offset: 0x0011A814
		// Note: this type is marked as 'beforefieldinit'.
		static ClientActivatedIdentity()
		{
			Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ClientActivatedIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr);
			ClientActivatedIdentity.NativeFieldInfoPtr__targetThis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, "_targetThis");
			ClientActivatedIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672209);
			ClientActivatedIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672210);
			ClientActivatedIdentity.NativeMethodInfoPtr_SetClientProxy_Public_Void_MarshalByRefObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672211);
			ClientActivatedIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672212);
			ClientActivatedIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672213);
			ClientActivatedIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr, 100672214);
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x0011C6D0 File Offset: 0x0011A8D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351035, RefRangeEnd = 351037, XrefRangeStart = 351034, XrefRangeEnd = 351035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientActivatedIdentity(string objectUri, Type objectType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientActivatedIdentity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(objectUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientActivatedIdentity.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x0011C730 File Offset: 0x0011A930
		[CallerCount(0)]
		public unsafe MarshalByRefObject GetServerObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientActivatedIdentity.NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x0011C770 File Offset: 0x0011A970
		[CallerCount(0)]
		public unsafe void SetClientProxy(MarshalByRefObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientActivatedIdentity.NativeMethodInfoPtr_SetClientProxy_Public_Void_MarshalByRefObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x0011C7B4 File Offset: 0x0011A9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351037, XrefRangeEnd = 351042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnLifetimeExpired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientActivatedIdentity.NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x0011C7F0 File Offset: 0x0011A9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351042, XrefRangeEnd = 351047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessage SyncObjectProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientActivatedIdentity.NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003C70 RID: 15472 RVA: 0x0011C84C File Offset: 0x0011AA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351047, XrefRangeEnd = 351051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientActivatedIdentity.NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x00016BFE File Offset: 0x00014DFE
		public ClientActivatedIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06003C72 RID: 15474 RVA: 0x0011C8BC File Offset: 0x0011AABC
		// (set) Token: 0x06003C73 RID: 15475 RVA: 0x00016C07 File Offset: 0x00014E07
		public unsafe MarshalByRefObject _targetThis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientActivatedIdentity.NativeFieldInfoPtr__targetThis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientActivatedIdentity.NativeFieldInfoPtr__targetThis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003225 RID: 12837
		private static readonly IntPtr NativeFieldInfoPtr__targetThis;

		// Token: 0x04003226 RID: 12838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

		// Token: 0x04003227 RID: 12839
		private static readonly IntPtr NativeMethodInfoPtr_GetServerObject_Public_MarshalByRefObject_0;

		// Token: 0x04003228 RID: 12840
		private static readonly IntPtr NativeMethodInfoPtr_SetClientProxy_Public_Void_MarshalByRefObject_0;

		// Token: 0x04003229 RID: 12841
		private static readonly IntPtr NativeMethodInfoPtr_OnLifetimeExpired_Public_Virtual_Void_0;

		// Token: 0x0400322A RID: 12842
		private static readonly IntPtr NativeMethodInfoPtr_SyncObjectProcessMessage_Public_Virtual_IMessage_IMessage_0;

		// Token: 0x0400322B RID: 12843
		private static readonly IntPtr NativeMethodInfoPtr_AsyncObjectProcessMessage_Public_Virtual_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
