using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B1 RID: 945
	public class LeaseSink : Object
	{
		// Token: 0x06003D5C RID: 15708 RVA: 0x0011FF20 File Offset: 0x0011E120
		// Note: this type is marked as 'beforefieldinit'.
		static LeaseSink()
		{
			Il2CppClassPointerStore<LeaseSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr);
			LeaseSink.NativeFieldInfoPtr__nextSink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, "_nextSink");
			LeaseSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100672329);
			LeaseSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100672330);
			LeaseSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100672331);
			LeaseSink.NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr, 100672332);
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x0011FFB4 File Offset: 0x0011E1B4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaseSink(IMessageSink nextSink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaseSink>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00120000 File Offset: 0x0011E200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352159, XrefRangeEnd = 352165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00120050 File Offset: 0x0011E250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352165, XrefRangeEnd = 352171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x001200B4 File Offset: 0x0011E2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 352190, RefRangeEnd = 352192, XrefRangeStart = 352171, XrefRangeEnd = 352190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenewLease(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseSink.NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x000171DA File Offset: 0x000153DA
		public LeaseSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x001200F8 File Offset: 0x0011E2F8
		// (set) Token: 0x06003D63 RID: 15715 RVA: 0x000171E3 File Offset: 0x000153E3
		public unsafe IMessageSink _nextSink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseSink.NativeFieldInfoPtr__nextSink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseSink.NativeFieldInfoPtr__nextSink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeFieldInfoPtr__nextSink;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr_RenewLease_Private_Void_IMessage_0;
	}
}
