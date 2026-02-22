using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A0 RID: 928
	public class DisposerReplySink : Object
	{
		// Token: 0x06003C7F RID: 15487 RVA: 0x0011CC90 File Offset: 0x0011AE90
		// Note: this type is marked as 'beforefieldinit'.
		static DisposerReplySink()
		{
			Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "DisposerReplySink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr);
			DisposerReplySink.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_next");
			DisposerReplySink.NativeFieldInfoPtr__disposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, "_disposable");
			DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672222);
			DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672223);
			DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr, 100672224);
		}

		// Token: 0x06003C80 RID: 15488 RVA: 0x0011CD24 File Offset: 0x0011AF24
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposerReplySink(IMessageSink next, IDisposable disposable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposerReplySink>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(disposable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C81 RID: 15489 RVA: 0x0011CD84 File Offset: 0x0011AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351140, XrefRangeEnd = 351148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003C82 RID: 15490 RVA: 0x0011CDD4 File Offset: 0x0011AFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351148, XrefRangeEnd = 351153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposerReplySink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003C83 RID: 15491 RVA: 0x00016C38 File Offset: 0x00014E38
		public DisposerReplySink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x0011CE38 File Offset: 0x0011B038
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x00016C41 File Offset: 0x00014E41
		public unsafe IMessageSink _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x0011CE68 File Offset: 0x0011B068
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x00016C60 File Offset: 0x00014E60
		public unsafe IDisposable _disposable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposerReplySink.NativeFieldInfoPtr__disposable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeFieldInfoPtr__disposable;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_IDisposable_0;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;
	}
}
