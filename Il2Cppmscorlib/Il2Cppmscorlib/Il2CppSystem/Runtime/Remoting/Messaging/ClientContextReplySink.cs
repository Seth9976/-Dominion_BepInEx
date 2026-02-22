using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003ED RID: 1005
	public class ClientContextReplySink : Object
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x00127EE4 File Offset: 0x001260E4
		// Note: this type is marked as 'beforefieldinit'.
		static ClientContextReplySink()
		{
			Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ClientContextReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr);
			ClientContextReplySink.NativeFieldInfoPtr__replySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_replySink");
			ClientContextReplySink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, "_context");
			ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672600);
			ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672601);
			ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr, 100672602);
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x00127F78 File Offset: 0x00126178
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353607, RefRangeEnd = 353608, XrefRangeStart = 353607, XrefRangeEnd = 353608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientContextReplySink(Context ctx, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientContextReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00127FD8 File Offset: 0x001261D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354764, XrefRangeEnd = 354774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00128028 File Offset: 0x00126228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354774, XrefRangeEnd = 354779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientContextReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x00018240 File Offset: 0x00016440
		public ClientContextReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06003FB6 RID: 16310 RVA: 0x0012808C File Offset: 0x0012628C
		// (set) Token: 0x06003FB7 RID: 16311 RVA: 0x00018249 File Offset: 0x00016449
		public unsafe IMessageSink _replySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__replySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700101B RID: 4123
		// (get) Token: 0x06003FB8 RID: 16312 RVA: 0x001280BC File Offset: 0x001262BC
		// (set) Token: 0x06003FB9 RID: 16313 RVA: 0x00018268 File Offset: 0x00016468
		public unsafe Context _context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClientContextReplySink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeFieldInfoPtr__replySink;

		// Token: 0x0400343F RID: 13375
		private static readonly IntPtr NativeFieldInfoPtr__context;

		// Token: 0x04003440 RID: 13376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Context_IMessageSink_0;

		// Token: 0x04003441 RID: 13377
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
