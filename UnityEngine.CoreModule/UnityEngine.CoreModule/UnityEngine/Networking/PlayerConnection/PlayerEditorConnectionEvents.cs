using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x0200012B RID: 299
	[Serializable]
	public class PlayerEditorConnectionEvents : Object
	{
		// Token: 0x06001776 RID: 6006 RVA: 0x00058348 File Offset: 0x00056548
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEditorConnectionEvents()
		{
			Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", "PlayerEditorConnectionEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "messageTypeSubscribers");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "connectionEvent");
			PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "disconnectionEvent");
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665064);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665065);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665066);
			PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100665067);
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00058404 File Offset: 0x00056604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82116, RefRangeEnd = 82117, XrefRangeStart = 82067, XrefRangeEnd = 82116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeMessageIdSubscribers(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00058464 File Offset: 0x00056664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82117, XrefRangeEnd = 82144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityEngine.Events.UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityEvent<MessageEventArgs>>(intPtr3) : null;
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000584B0 File Offset: 0x000566B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82144, XrefRangeEnd = 82165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<MessageEventArgs> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00058500 File Offset: 0x00056700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82165, XrefRangeEnd = 82179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEditorConnectionEvents()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0000D279 File Offset: 0x0000B479
		public PlayerEditorConnectionEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0005853C File Offset: 0x0005673C
		// (set) Token: 0x0600177D RID: 6013 RVA: 0x0000D282 File Offset: 0x0000B482
		public unsafe List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_messageTypeSubscribers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x0005856C File Offset: 0x0005676C
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x0000D2A1 File Offset: 0x0000B4A1
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x0005859C File Offset: 0x0005679C
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeFieldInfoPtr_messageTypeSubscribers;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeFieldInfoPtr_connectionEvent;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeFieldInfoPtr_disconnectionEvent;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200095F RID: 2399
		[Serializable]
		public class MessageEvent : UnityEngine.Events.UnityEvent<MessageEventArgs>
		{
			// Token: 0x060030CA RID: 12490 RVA: 0x0001761A File Offset: 0x0001581A
			// Note: this type is marked as 'beforefieldinit'.
			static MessageEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr, 100665068);
			}

			// Token: 0x060030CB RID: 12491 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 82030, RefRangeEnd = 82032, XrefRangeStart = 82027, XrefRangeEnd = 82030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030CC RID: 12492 RVA: 0x0001764E File Offset: 0x0001584E
			public MessageEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001D10 RID: 7440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000960 RID: 2400
		[Serializable]
		public class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
		{
			// Token: 0x060030CD RID: 12493 RVA: 0x00017657 File Offset: 0x00015857
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectionChangeEvent()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "ConnectionChangeEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr);
				PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr, 100665069);
			}

			// Token: 0x060030CE RID: 12494 RVA: 0x0006DFFC File Offset: 0x0006C1FC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 82035, RefRangeEnd = 82039, XrefRangeStart = 82032, XrefRangeEnd = 82035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectionChangeEvent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030CF RID: 12495 RVA: 0x0001768B File Offset: 0x0001588B
			public ConnectionChangeEvent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001D11 RID: 7441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000961 RID: 2401
		[Serializable]
		public class MessageTypeSubscribers : Object
		{
			// Token: 0x060030D0 RID: 12496 RVA: 0x0006E038 File Offset: 0x0006C238
			// Note: this type is marked as 'beforefieldinit'.
			static MessageTypeSubscribers()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "MessageTypeSubscribers");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "m_messageTypeId");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "subscriberCount");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, "messageCallback");
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665070);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665071);
				PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100665072);
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x060030D1 RID: 12497 RVA: 0x0006E0DC File Offset: 0x0006C2DC
			// (set) Token: 0x060030D2 RID: 12498 RVA: 0x0006E118 File Offset: 0x0006C318
			public unsafe Guid MessageTypeId
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82039, XrefRangeEnd = 82040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 82041, RefRangeEnd = 82043, XrefRangeStart = 82040, XrefRangeEnd = 82041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060030D3 RID: 12499 RVA: 0x0006E158 File Offset: 0x0006C358
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 82050, RefRangeEnd = 82052, XrefRangeStart = 82043, XrefRangeEnd = 82050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageTypeSubscribers()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030D4 RID: 12500 RVA: 0x00017694 File Offset: 0x00015894
			public MessageTypeSubscribers(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0006E194 File Offset: 0x0006C394
			// (set) Token: 0x060030D6 RID: 12502 RVA: 0x0001769D File Offset: 0x0001589D
			public unsafe string m_messageTypeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060030D7 RID: 12503 RVA: 0x0006E1BC File Offset: 0x0006C3BC
			// (set) Token: 0x060030D8 RID: 12504 RVA: 0x000176BC File Offset: 0x000158BC
			public unsafe int subscriberCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount)) = value;
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0006E1E4 File Offset: 0x0006C3E4
			// (set) Token: 0x060030DA RID: 12506 RVA: 0x000176D7 File Offset: 0x000158D7
			public unsafe PlayerEditorConnectionEvents.MessageEvent messageCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEditorConnectionEvents.MessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D12 RID: 7442
			private static readonly IntPtr NativeFieldInfoPtr_m_messageTypeId;

			// Token: 0x04001D13 RID: 7443
			private static readonly IntPtr NativeFieldInfoPtr_subscriberCount;

			// Token: 0x04001D14 RID: 7444
			private static readonly IntPtr NativeFieldInfoPtr_messageCallback;

			// Token: 0x04001D15 RID: 7445
			private static readonly IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;

			// Token: 0x04001D16 RID: 7446
			private static readonly IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;

			// Token: 0x04001D17 RID: 7447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000962 RID: 2402
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060030DB RID: 12507 RVA: 0x0006E214 File Offset: 0x0006C414
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100665073);
				PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr, 100665074);
			}

			// Token: 0x060030DC RID: 12508 RVA: 0x0006E27C File Offset: 0x0006C47C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030DD RID: 12509 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82052, XrefRangeEnd = 82057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InvokeMessageIdSubscribers_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060030DE RID: 12510 RVA: 0x000176F6 File Offset: 0x000158F6
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x060030DF RID: 12511 RVA: 0x0006E308 File Offset: 0x0006C508
			// (set) Token: 0x060030E0 RID: 12512 RVA: 0x000176FF File Offset: 0x000158FF
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass6_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001D18 RID: 7448
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001D19 RID: 7449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D1A RID: 7450
			private static readonly IntPtr NativeMethodInfoPtr__InvokeMessageIdSubscribers_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000963 RID: 2403
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060030E1 RID: 12513 RVA: 0x0006E330 File Offset: 0x0006C530
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100665075);
				PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr, 100665076);
			}

			// Token: 0x060030E2 RID: 12514 RVA: 0x0006E398 File Offset: 0x0006C598
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030E3 RID: 12515 RVA: 0x0006E3D4 File Offset: 0x0006C5D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82057, XrefRangeEnd = 82062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddAndCreate_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060030E4 RID: 12516 RVA: 0x0001771A File Offset: 0x0001591A
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x060030E5 RID: 12517 RVA: 0x0006E424 File Offset: 0x0006C624
			// (set) Token: 0x060030E6 RID: 12518 RVA: 0x00017723 File Offset: 0x00015923
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass7_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001D1B RID: 7451
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001D1C RID: 7452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D1D RID: 7453
			private static readonly IntPtr NativeMethodInfoPtr__AddAndCreate_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000964 RID: 2404
		[ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060030E7 RID: 12519 RVA: 0x0006E44C File Offset: 0x0006C64C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, "messageId");
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100665077);
				PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr, 100665078);
			}

			// Token: 0x060030E8 RID: 12520 RVA: 0x0006E4B4 File Offset: 0x0006C6B4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060030E9 RID: 12521 RVA: 0x0006E4F0 File Offset: 0x0006C6F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82062, XrefRangeEnd = 82067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UnregisterManagedCallback_b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060030EA RID: 12522 RVA: 0x0001773E File Offset: 0x0001593E
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000780 RID: 1920
			// (get) Token: 0x060030EB RID: 12523 RVA: 0x0006E540 File Offset: 0x0006C740
			// (set) Token: 0x060030EC RID: 12524 RVA: 0x00017747 File Offset: 0x00015947
			public unsafe Guid messageId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.__c__DisplayClass8_0.NativeFieldInfoPtr_messageId)) = value;
				}
			}

			// Token: 0x04001D1E RID: 7454
			private static readonly IntPtr NativeFieldInfoPtr_messageId;

			// Token: 0x04001D1F RID: 7455
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001D20 RID: 7456
			private static readonly IntPtr NativeMethodInfoPtr__UnregisterManagedCallback_b__0_Internal_Boolean_MessageTypeSubscribers_0;
		}

		// Token: 0x02000965 RID: 2405
		public sealed class <>c__DisplayClass6_0
		{
		}

		// Token: 0x02000966 RID: 2406
		public sealed class <>c__DisplayClass7_0
		{
		}

		// Token: 0x02000967 RID: 2407
		public sealed class <>c__DisplayClass8_0
		{
		}
	}
}
