using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F1 RID: 1009
	[Serializable]
	public class EnvoyTerminatorSink : Object
	{
		// Token: 0x06003FE8 RID: 16360 RVA: 0x00128CA8 File Offset: 0x00126EA8
		// Note: this type is marked as 'beforefieldinit'.
		static EnvoyTerminatorSink()
		{
			Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "EnvoyTerminatorSink");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr);
			EnvoyTerminatorSink.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr, "Instance");
			EnvoyTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr, 100672628);
			EnvoyTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr, 100672629);
			EnvoyTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr, 100672630);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x00128D28 File Offset: 0x00126F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354998, XrefRangeEnd = 355010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IMessage SyncProcessMessage(IMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyTerminatorSink.NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x00128D78 File Offset: 0x00126F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355010, XrefRangeEnd = 355017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyTerminatorSink.NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageCtrl>(intPtr3) : null;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00128DDC File Offset: 0x00126FDC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvoyTerminatorSink()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvoyTerminatorSink>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyTerminatorSink.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00018389 File Offset: 0x00016589
		public EnvoyTerminatorSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06003FED RID: 16365 RVA: 0x00128E18 File Offset: 0x00127018
		// (set) Token: 0x06003FEE RID: 16366 RVA: 0x00018392 File Offset: 0x00016592
		public unsafe static EnvoyTerminatorSink Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnvoyTerminatorSink.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnvoyTerminatorSink>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnvoyTerminatorSink.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003463 RID: 13411
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04003464 RID: 13412
		private static readonly IntPtr NativeMethodInfoPtr_SyncProcessMessage_Public_Virtual_Final_New_IMessage_IMessage_0;

		// Token: 0x04003465 RID: 13413
		private static readonly IntPtr NativeMethodInfoPtr_AsyncProcessMessage_Public_Virtual_Final_New_IMessageCtrl_IMessage_IMessageSink_0;

		// Token: 0x04003466 RID: 13414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
