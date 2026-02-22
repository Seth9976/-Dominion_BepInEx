using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200000D RID: 13
	[StructLayout(2)]
	public struct Eyes
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00003DF4 File Offset: 0x00001FF4
		// Note: this type is marked as 'beforefieldinit'.
		static Eyes()
		{
			Il2CppClassPointerStore<Eyes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "Eyes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyes>.NativeClassPtr);
			Eyes.NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_DeviceId");
			Eyes.NativeFieldInfoPtr_m_FeatureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyes>.NativeClassPtr, "m_FeatureIndex");
			Eyes.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663319);
			Eyes.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663320);
			Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663321);
			Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663322);
			Eyes.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyes>.NativeClassPtr, 100663323);
			Eyes.Eyes_TryGetEyePosition_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyePosition_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyePosition_Injected");
			Eyes.Eyes_TryGetEyeRotation_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyeRotation_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeRotation_Injected");
			Eyes.Eyes_TryGetFixationPoint_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetFixationPoint_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetFixationPoint_Injected");
			Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegateField = IL2CPP.ResolveICall<Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegate>("UnityEngine.XR.Eyes::Eyes_TryGetEyeOpenAmount_Injected");
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003EEC File Offset: 0x000020EC
		public unsafe ulong deviceId
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003F1C File Offset: 0x0000211C
		public unsafe uint featureIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003F4C File Offset: 0x0000214C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158301, XrefRangeEnd = 158304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003F90 File Offset: 0x00002190
		[CallerCount(0)]
		public unsafe bool Equals(Eyes other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003FD0 File Offset: 0x000021D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyes.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002375 File Offset: 0x00000575
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Eyes>.NativeClassPtr, ref this));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004000 File Offset: 0x00002200
		public bool TryGetLeftEyePosition(out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition(this, EyeSide.Left, out position);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004020 File Offset: 0x00002220
		public bool TryGetRightEyePosition(out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition(this, EyeSide.Right, out position);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004040 File Offset: 0x00002240
		public bool TryGetLeftEyeRotation(out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation(this, EyeSide.Left, out rotation);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004060 File Offset: 0x00002260
		public bool TryGetRightEyeRotation(out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation(this, EyeSide.Right, out rotation);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002387 File Offset: 0x00000587
		public static bool Eyes_TryGetEyePosition(Eyes eyes, EyeSide chirality, out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition_Injected(ref eyes, chirality, out position);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002392 File Offset: 0x00000592
		public static bool Eyes_TryGetEyeRotation(Eyes eyes, EyeSide chirality, out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation_Injected(ref eyes, chirality, out rotation);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004080 File Offset: 0x00002280
		public bool TryGetFixationPoint(out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint(this, out fixationPoint);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000239D File Offset: 0x0000059D
		public static bool Eyes_TryGetFixationPoint(Eyes eyes, out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint_Injected(ref eyes, out fixationPoint);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000040A0 File Offset: 0x000022A0
		public bool TryGetLeftEyeOpenAmount(out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount(this, EyeSide.Left, out openAmount);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000040C0 File Offset: 0x000022C0
		public bool TryGetRightEyeOpenAmount(out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount(this, EyeSide.Right, out openAmount);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000023A7 File Offset: 0x000005A7
		public static bool Eyes_TryGetEyeOpenAmount(Eyes eyes, EyeSide chirality, out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount_Injected(ref eyes, chirality, out openAmount);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000040E0 File Offset: 0x000022E0
		public static bool operator ==(Eyes a, Eyes b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000040FC File Offset: 0x000022FC
		public static bool operator !=(Eyes a, Eyes b)
		{
			return !(a == b);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000023B2 File Offset: 0x000005B2
		public static bool Eyes_TryGetEyePosition_Injected(ref Eyes eyes, EyeSide chirality, out Vector3 position)
		{
			return Eyes.Eyes_TryGetEyePosition_InjectedDelegateField(ref eyes, chirality, out position);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000023C1 File Offset: 0x000005C1
		public static bool Eyes_TryGetEyeRotation_Injected(ref Eyes eyes, EyeSide chirality, out Quaternion rotation)
		{
			return Eyes.Eyes_TryGetEyeRotation_InjectedDelegateField(ref eyes, chirality, out rotation);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000023D0 File Offset: 0x000005D0
		public static bool Eyes_TryGetFixationPoint_Injected(ref Eyes eyes, out Vector3 fixationPoint)
		{
			return Eyes.Eyes_TryGetFixationPoint_InjectedDelegateField(ref eyes, out fixationPoint);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000023DE File Offset: 0x000005DE
		public static bool Eyes_TryGetEyeOpenAmount_Injected(ref Eyes eyes, EyeSide chirality, out float openAmount)
		{
			return Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegateField(ref eyes, chirality, out openAmount);
		}

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_DeviceId;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_FeatureIndex;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceId_Internal_get_UInt64_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_featureIndex_Internal_get_UInt32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Eyes_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400006C RID: 108
		[FieldOffset(0)]
		public ulong m_DeviceId;

		// Token: 0x0400006D RID: 109
		[FieldOffset(8)]
		public uint m_FeatureIndex;

		// Token: 0x0400006E RID: 110
		private static readonly Eyes.Eyes_TryGetEyePosition_InjectedDelegate Eyes_TryGetEyePosition_InjectedDelegateField;

		// Token: 0x0400006F RID: 111
		private static readonly Eyes.Eyes_TryGetEyeRotation_InjectedDelegate Eyes_TryGetEyeRotation_InjectedDelegateField;

		// Token: 0x04000070 RID: 112
		private static readonly Eyes.Eyes_TryGetFixationPoint_InjectedDelegate Eyes_TryGetFixationPoint_InjectedDelegateField;

		// Token: 0x04000071 RID: 113
		private static readonly Eyes.Eyes_TryGetEyeOpenAmount_InjectedDelegate Eyes_TryGetEyeOpenAmount_InjectedDelegateField;

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x0600016F RID: 367
		private delegate bool Eyes_TryGetEyePosition_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr position);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000171 RID: 369
		private delegate bool Eyes_TryGetEyeRotation_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr rotation);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000173 RID: 371
		private delegate bool Eyes_TryGetFixationPoint_InjectedDelegate(IntPtr eyes, [Out] IntPtr fixationPoint);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000175 RID: 373
		private delegate bool Eyes_TryGetEyeOpenAmount_InjectedDelegate(IntPtr eyes, EyeSide chirality, [Out] IntPtr openAmount);
	}
}
