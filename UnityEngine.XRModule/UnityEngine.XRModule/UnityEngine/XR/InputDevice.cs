using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct InputDevice
	{
		// Token: 0x0600004D RID: 77 RVA: 0x0000375C File Offset: 0x0000195C
		// Note: this type is marked as 'beforefieldinit'.
		static InputDevice()
		{
			Il2CppClassPointerStore<InputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputDevice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice>.NativeClassPtr);
			InputDevice.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_DeviceId");
			InputDevice.NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_Initialized");
			InputDevice.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663309);
			InputDevice.NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663310);
			InputDevice.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663311);
			InputDevice.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663312);
			InputDevice.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663313);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003818 File Offset: 0x00001A18
		[CallerCount(0)]
		public unsafe InputDevice(ulong deviceId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000384C File Offset: 0x00001A4C
		public unsafe ulong deviceId
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000387C File Offset: 0x00001A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158289, XrefRangeEnd = 158293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000038C0 File Offset: 0x00001AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158293, XrefRangeEnd = 158294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InputDevice other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003900 File Offset: 0x00001B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158294, XrefRangeEnd = 158296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputDevice.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000230D File Offset: 0x0000050D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, ref this));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000231F File Offset: 0x0000051F
		public XRInputSubsystem subsystem
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003930 File Offset: 0x00001B30
		public bool isValid
		{
			get
			{
				return this.IsValidId() && InputDevices.IsDeviceValid(this.m_DeviceId);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003958 File Offset: 0x00001B58
		public string name
		{
			get
			{
				return this.IsValidId() ? InputDevices.GetDeviceName(this.m_DeviceId) : null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003980 File Offset: 0x00001B80
		public InputDeviceRole role
		{
			get
			{
				return this.IsValidId() ? InputDevices.GetDeviceRole(this.m_DeviceId) : InputDeviceRole.Unknown;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000039A8 File Offset: 0x00001BA8
		public string manufacturer
		{
			get
			{
				return this.IsValidId() ? InputDevices.GetDeviceManufacturer(this.m_DeviceId) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000039D0 File Offset: 0x00001BD0
		public string serialNumber
		{
			get
			{
				return this.IsValidId() ? InputDevices.GetDeviceSerialNumber(this.m_DeviceId) : null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000039F8 File Offset: 0x00001BF8
		public InputDeviceCharacteristics characteristics
		{
			get
			{
				return this.IsValidId() ? InputDevices.GetDeviceCharacteristics(this.m_DeviceId) : InputDeviceCharacteristics.None;
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003A20 File Offset: 0x00001C20
		public bool IsValidId()
		{
			return this.deviceId != ulong.MaxValue;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003A40 File Offset: 0x00001C40
		public bool SendHapticImpulse(uint channel, float amplitude, [Optional] float duration)
		{
			bool flag = !this.IsValidId();
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = amplitude < 0f;
				if (flag3)
				{
					throw new ArgumentException("Amplitude of SendHapticImpulse cannot be negative.");
				}
				bool flag4 = duration < 0f;
				if (flag4)
				{
					throw new ArgumentException("Duration of SendHapticImpulse cannot be negative.");
				}
				flag2 = InputDevices.SendHapticImpulse(this.m_DeviceId, channel, amplitude, duration);
			}
			return flag2;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public bool SendHapticBuffer(uint channel, Il2CppStructArray<byte> buffer)
		{
			bool flag = !this.IsValidId();
			return !flag && InputDevices.SendHapticBuffer(this.m_DeviceId, channel, buffer);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003AD0 File Offset: 0x00001CD0
		public void StopHaptics()
		{
			bool flag = this.IsValidId();
			if (flag)
			{
				InputDevices.StopHaptics(this.m_DeviceId);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003AF4 File Offset: 0x00001CF4
		public bool TryGetFeatureUsages(List<InputFeatureUsage> featureUsages)
		{
			bool flag = this.IsValidId();
			return flag && InputDevices.TryGetFeatureUsages(this.m_DeviceId, featureUsages);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003B20 File Offset: 0x00001D20
		public bool CheckValidAndSetDefault<T>(out T value)
		{
			value = default(T);
			return this.IsValidId();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003B40 File Offset: 0x00001D40
		public static bool operator ==(InputDevice a, InputDevice b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003B5C File Offset: 0x00001D5C
		public static bool operator !=(InputDevice a, InputDevice b)
		{
			return !(a == b);
		}

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_m_Initialized;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000058 RID: 88
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x04000059 RID: 89
		[FieldOffset(8)]
		[MarshalAs(4)]
		public bool m_Initialized;
	}
}
