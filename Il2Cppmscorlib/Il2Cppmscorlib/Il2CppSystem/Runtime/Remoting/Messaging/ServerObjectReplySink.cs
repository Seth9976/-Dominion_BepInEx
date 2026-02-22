using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x0200040A RID: 1034
	public class ServerObjectReplySink : Object
	{
		// Token: 0x0600414A RID: 16714 RVA: 0x0012DEAC File Offset: 0x0012C0AC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerObjectReplySink()
		{
			Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ServerObjectReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr);
			ServerObjectReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_replySink");
			ServerObjectReplySink.NativeFieldInfoPtr__identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, "_identity");
			ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100672807);
			ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100672808);
			ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr, 100672809);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x0012DF40 File Offset: 0x0012C140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353607, RefRangeEnd = 353608, XrefRangeStart = 353607, XrefRangeEnd = 353608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerObjectReplySink(ServerIdentity identity, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerObjectReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x0012DFA0 File Offset: 0x0012C1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355853, XrefRangeEnd = 355858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x0012DFF0 File Offset: 0x0012C1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355858, XrefRangeEnd = 355863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00018CF6 File Offset: 0x00016EF6
		public ServerObjectReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x0012E054 File Offset: 0x0012C254
		// (set) Token: 0x06004150 RID: 16720 RVA: 0x00018CFF File Offset: 0x00016EFF
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x0012E084 File Offset: 0x0012C284
		// (set) Token: 0x06004152 RID: 16722 RVA: 0x00018D1E File Offset: 0x00016F1E
		public unsafe ServerIdentity _identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerIdentity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectReplySink.NativeFieldInfoPtr__identity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003553 RID: 13651
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x04003554 RID: 13652
		private static readonly IntPtr NativeFieldInfoPtr__identity;

		// Token: 0x04003555 RID: 13653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ServerIdentity_IMessageSink_0;

		// Token: 0x04003556 RID: 13654
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003557 RID: 13655
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
