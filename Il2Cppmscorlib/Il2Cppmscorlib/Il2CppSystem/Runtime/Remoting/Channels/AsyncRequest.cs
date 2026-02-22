using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C7 RID: 967
	public class AsyncRequest : Object
	{
		// Token: 0x06003E3A RID: 15930 RVA: 0x00123120 File Offset: 0x00121320
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncRequest()
		{
			Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "AsyncRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr);
			AsyncRequest.NativeFieldInfoPtr_ReplySink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "ReplySink");
			AsyncRequest.NativeFieldInfoPtr_MsgRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, "MsgRequest");
			AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr, 100672447);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x0012318C File Offset: 0x0012138C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353607, RefRangeEnd = 353608, XrefRangeStart = 353606, XrefRangeEnd = 353607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncRequest(IMessage msgRequest, IMessageSink replySink)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncRequest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msgRequest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(replySink);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncRequest.NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x000176E0 File Offset: 0x000158E0
		public AsyncRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003E3D RID: 15933 RVA: 0x001231EC File Offset: 0x001213EC
		// (set) Token: 0x06003E3E RID: 15934 RVA: 0x000176E9 File Offset: 0x000158E9
		public unsafe IMessageSink ReplySink
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_ReplySink), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003E3F RID: 15935 RVA: 0x0012321C File Offset: 0x0012141C
		// (set) Token: 0x06003E40 RID: 15936 RVA: 0x00017708 File Offset: 0x00015908
		public unsafe IMessage MsgRequest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncRequest.NativeFieldInfoPtr_MsgRequest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeFieldInfoPtr_ReplySink;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeFieldInfoPtr_MsgRequest;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessage_IMessageSink_0;
	}
}
