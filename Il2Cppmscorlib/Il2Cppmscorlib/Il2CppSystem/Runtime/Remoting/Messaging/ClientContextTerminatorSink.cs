using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EC RID: 1004
	public class ClientContextTerminatorSink : Object
	{
		// Token: 0x06003FAA RID: 16298 RVA: 0x00127D34 File Offset: 0x00125F34
		// Note: this type is marked as 'beforefieldinit'.
		static ClientContextTerminatorSink()
		{
			Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ClientContextTerminatorSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr);
			ClientContextTerminatorSink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, "_context");
			ClientContextTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100672597);
			ClientContextTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100672598);
			ClientContextTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr, 100672599);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00127DB4 File Offset: 0x00125FB4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientContextTerminatorSink(Context ctx)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientContextTerminatorSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00127E00 File Offset: 0x00126000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354708, XrefRangeEnd = 354734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00127E50 File Offset: 0x00126050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354734, XrefRangeEnd = 354764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00018218 File Offset: 0x00016418
		public ClientContextTerminatorSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x00127EB4 File Offset: 0x001260B4
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x00018221 File Offset: 0x00016421
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextTerminatorSink.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextTerminatorSink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_0;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
