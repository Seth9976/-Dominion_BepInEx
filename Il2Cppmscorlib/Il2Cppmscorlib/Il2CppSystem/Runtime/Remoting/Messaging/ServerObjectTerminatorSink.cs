using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000409 RID: 1033
	public class ServerObjectTerminatorSink : Object
	{
		// Token: 0x06004143 RID: 16707 RVA: 0x0012DCFC File Offset: 0x0012BEFC
		// Note: this type is marked as 'beforefieldinit'.
		static ServerObjectTerminatorSink()
		{
			Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ServerObjectTerminatorSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr);
			ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, "_nextSink");
			ServerObjectTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100672804);
			ServerObjectTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100672805);
			ServerObjectTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr, 100672806);
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x0012DD7C File Offset: 0x0012BF7C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerObjectTerminatorSink(IMessageSink nextSink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerObjectTerminatorSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x0012DDC8 File Offset: 0x0012BFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355826, XrefRangeEnd = 355837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x0012DE18 File Offset: 0x0012C018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355837, XrefRangeEnd = 355853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerObjectTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00018CCE File Offset: 0x00016ECE
		public ServerObjectTerminatorSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x0012DE7C File Offset: 0x0012C07C
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00018CD7 File Offset: 0x00016ED7
		public unsafe IMessageSink _nextSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerObjectTerminatorSink.NativeFieldInfoPtr__nextSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400354F RID: 13647
		private static readonly IntPtr NativeFieldInfoPtr__nextSink;

		// Token: 0x04003550 RID: 13648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x04003551 RID: 13649
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003552 RID: 13650
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
