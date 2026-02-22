using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public class MessageEventArgs : Object
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x00057A5C File Offset: 0x00055C5C
		// Note: this type is marked as 'beforefieldinit'.
		static MessageEventArgs()
		{
			Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "MessageEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr);
			MessageEventArgs.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "playerId");
			MessageEventArgs.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, "data");
			MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr, 100665038);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00057AC8 File Offset: 0x00055CC8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEventArgs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEventArgs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		public MessageEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00057B04 File Offset: 0x00055D04
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x0000D1B9 File Offset: 0x0000B3B9
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00057B2C File Offset: 0x00055D2C
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageEventArgs.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
