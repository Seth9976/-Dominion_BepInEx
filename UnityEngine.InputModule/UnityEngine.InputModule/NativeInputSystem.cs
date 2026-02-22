using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000005 RID: 5
	public class NativeInputSystem : Object
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000022A8 File Offset: 0x000004A8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeInputSystem()
		{
			Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputSystem");
			NativeInputSystem.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onUpdate");
			NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onBeforeUpdate");
			NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onShouldRunUpdate");
			NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "s_OnDeviceDiscoveredCallback");
			NativeInputSystem.NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663300);
			NativeInputSystem.NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663301);
			NativeInputSystem.NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663302);
			NativeInputSystem.NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663303);
			NativeInputSystem.NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663304);
			NativeInputSystem.get_currentTimeDelegateField = IL2CPP.ResolveICall<NativeInputSystem.get_currentTimeDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_currentTime");
			NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegateField = IL2CPP.ResolveICall<NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_currentTimeOffsetToRealtimeSinceStartup");
			NativeInputSystem.AllocateDeviceIdDelegateField = IL2CPP.ResolveICall<NativeInputSystem.AllocateDeviceIdDelegate>("UnityEngineInternal.Input.NativeInputSystem::AllocateDeviceId");
			NativeInputSystem.QueueInputEventDelegateField = IL2CPP.ResolveICall<NativeInputSystem.QueueInputEventDelegate>("UnityEngineInternal.Input.NativeInputSystem::QueueInputEvent");
			NativeInputSystem.IOCTLDelegateField = IL2CPP.ResolveICall<NativeInputSystem.IOCTLDelegate>("UnityEngineInternal.Input.NativeInputSystem::IOCTL");
			NativeInputSystem.SetPollingFrequencyDelegateField = IL2CPP.ResolveICall<NativeInputSystem.SetPollingFrequencyDelegate>("UnityEngineInternal.Input.NativeInputSystem::SetPollingFrequency");
			NativeInputSystem.UpdateDelegateField = IL2CPP.ResolveICall<NativeInputSystem.UpdateDelegate>("UnityEngineInternal.Input.NativeInputSystem::Update");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023EC File Offset: 0x000005EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149993, XrefRangeEnd = 150000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002420 File Offset: 0x00000620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150000, XrefRangeEnd = 150004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002460 File Offset: 0x00000660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150004, XrefRangeEnd = 150011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deviceDescriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024A4 File Offset: 0x000006A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150011, XrefRangeEnd = 150018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &retval;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000024E4 File Offset: 0x000006E4
		public unsafe static bool hasDeviceDiscoveredCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150018, XrefRangeEnd = 150020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeInputSystem.NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000206B File Offset: 0x0000026B
		public NativeInputSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002518 File Offset: 0x00000718
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe static NativeUpdateCallback onUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NativeUpdateCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002540 File Offset: 0x00000740
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe static Action<NativeInputUpdateType> onBeforeUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NativeInputUpdateType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onBeforeUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe static Func<NativeInputUpdateType, bool> onShouldRunUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NativeInputUpdateType, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_onShouldRunUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002590 File Offset: 0x00000790
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000020AA File Offset: 0x000002AA
		public unsafe static Action<int, string> s_OnDeviceDiscoveredCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeInputSystem.NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020BC File Offset: 0x000002BC
		public static double currentTime
		{
			get
			{
				return NativeInputSystem.get_currentTimeDelegateField();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000020C8 File Offset: 0x000002C8
		public static double currentTimeOffsetToRealtimeSinceStartup
		{
			get
			{
				return NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegateField();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020D4 File Offset: 0x000002D4
		public static int AllocateDeviceId()
		{
			return NativeInputSystem.AllocateDeviceIdDelegateField();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020E0 File Offset: 0x000002E0
		public static void QueueInputEvent<TInputEvent>(ref TInputEvent inputEvent) where TInputEvent : struct
		{
			NativeInputSystem.QueueInputEvent((IntPtr)UnsafeUtility.AddressOf<TInputEvent>(ref inputEvent));
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020F4 File Offset: 0x000002F4
		public static void QueueInputEvent(IntPtr inputEvent)
		{
			NativeInputSystem.QueueInputEventDelegateField(inputEvent);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002101 File Offset: 0x00000301
		public static long IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes)
		{
			return NativeInputSystem.IOCTLDelegateField(deviceId, code, data, sizeInBytes);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002111 File Offset: 0x00000311
		public static void SetPollingFrequency(float hertz)
		{
			NativeInputSystem.SetPollingFrequencyDelegateField(hertz);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000211E File Offset: 0x0000031E
		public static void Update(NativeInputUpdateType updateType)
		{
			NativeInputSystem.UpdateDelegateField(updateType);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000212B File Offset: 0x0000032B
		public static void SetUpdateMask(NativeInputUpdateType mask)
		{
		}

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_onBeforeUpdate;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_onShouldRunUpdate;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0;

		// Token: 0x0400001B RID: 27
		private static readonly NativeInputSystem.get_currentTimeDelegate get_currentTimeDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly NativeInputSystem.get_currentTimeOffsetToRealtimeSinceStartupDelegate get_currentTimeOffsetToRealtimeSinceStartupDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly NativeInputSystem.AllocateDeviceIdDelegate AllocateDeviceIdDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly NativeInputSystem.QueueInputEventDelegate QueueInputEventDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly NativeInputSystem.IOCTLDelegate IOCTLDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly NativeInputSystem.SetPollingFrequencyDelegate SetPollingFrequencyDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly NativeInputSystem.UpdateDelegate UpdateDelegateField;

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000020 RID: 32
		private delegate double get_currentTimeDelegate();

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000022 RID: 34
		private delegate double get_currentTimeOffsetToRealtimeSinceStartupDelegate();

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000024 RID: 36
		private delegate int AllocateDeviceIdDelegate();

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000026 RID: 38
		private delegate void QueueInputEventDelegate(IntPtr inputEvent);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000028 RID: 40
		private delegate long IOCTLDelegate(int deviceId, int code, IntPtr data, int sizeInBytes);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002A RID: 42
		private delegate void SetPollingFrequencyDelegate(float hertz);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002C RID: 44
		private delegate void UpdateDelegate(NativeInputUpdateType updateType);
	}
}
