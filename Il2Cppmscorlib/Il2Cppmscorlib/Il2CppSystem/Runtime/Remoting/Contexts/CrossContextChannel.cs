using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B7 RID: 951
	public class CrossContextChannel : Object
	{
		// Token: 0x06003DCA RID: 15818 RVA: 0x001218A0 File Offset: 0x0011FAA0
		// Note: this type is marked as 'beforefieldinit'.
		static CrossContextChannel()
		{
			Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "CrossContextChannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr);
			CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672388);
			CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672389);
			CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, 100672390);
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x0012190C File Offset: 0x0011FB0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352886, RefRangeEnd = 352887, XrefRangeStart = 352852, XrefRangeEnd = 352886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x0012195C File Offset: 0x0011FB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352887, XrefRangeEnd = 352926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x001219C0 File Offset: 0x0011FBC0
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CrossContextChannel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DCE RID: 15822 RVA: 0x0001740B File Offset: 0x0001560B
		public CrossContextChannel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200062D RID: 1581
		public class ContextRestoreSink : Object
		{
			// Token: 0x06005449 RID: 21577 RVA: 0x0017521C File Offset: 0x0017341C
			// Note: this type is marked as 'beforefieldinit'.
			static ContextRestoreSink()
			{
				Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrossContextChannel>.NativeClassPtr, "ContextRestoreSink");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr);
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_next");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_context");
				CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, "_call");
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672391);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672392);
				CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr, 100672393);
			}

			// Token: 0x0600544A RID: 21578 RVA: 0x001752C0 File Offset: 0x001734C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 150611, RefRangeEnd = 150613, XrefRangeStart = 150611, XrefRangeEnd = 150613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContextRestoreSink(IMessageSink next, Context context, IMessage call)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrossContextChannel.ContextRestoreSink>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600544B RID: 21579 RVA: 0x00175330 File Offset: 0x00173530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352826, XrefRangeEnd = 352847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
				}
			}

			// Token: 0x0600544C RID: 21580 RVA: 0x00175380 File Offset: 0x00173580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352847, XrefRangeEnd = 352852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CrossContextChannel.ContextRestoreSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
			}

			// Token: 0x0600544D RID: 21581 RVA: 0x0002081E File Offset: 0x0001EA1E
			public ContextRestoreSink(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001595 RID: 5525
			// (get) Token: 0x0600544E RID: 21582 RVA: 0x001753E4 File Offset: 0x001735E4
			// (set) Token: 0x0600544F RID: 21583 RVA: 0x00020827 File Offset: 0x0001EA27
			public unsafe IMessageSink _next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001596 RID: 5526
			// (get) Token: 0x06005450 RID: 21584 RVA: 0x00175414 File Offset: 0x00173614
			// (set) Token: 0x06005451 RID: 21585 RVA: 0x00020846 File Offset: 0x0001EA46
			public unsafe Context _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001597 RID: 5527
			// (get) Token: 0x06005452 RID: 21586 RVA: 0x00175444 File Offset: 0x00173644
			// (set) Token: 0x06005453 RID: 21587 RVA: 0x00020865 File Offset: 0x0001EA65
			public unsafe IMessage _call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CrossContextChannel.ContextRestoreSink.NativeFieldInfoPtr__call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043E3 RID: 17379
			private static readonly IntPtr NativeFieldInfoPtr__next;

			// Token: 0x040043E4 RID: 17380
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x040043E5 RID: 17381
			private static readonly IntPtr NativeFieldInfoPtr__call;

			// Token: 0x040043E6 RID: 17382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_Context_IMessage_0;

			// Token: 0x040043E7 RID: 17383
			private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

			// Token: 0x040043E8 RID: 17384
			private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
		}
	}
}
