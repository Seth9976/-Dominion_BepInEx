using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[StructLayout(2)]
	public struct Touch
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000253C File Offset: 0x0000073C
		// Note: this type is marked as 'beforefieldinit'.
		static Touch()
		{
			Il2CppClassPointerStore<Touch>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "Touch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Touch>.NativeClassPtr);
			Touch.NativeFieldInfoPtr_m_FingerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_FingerId");
			Touch.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Position");
			Touch.NativeFieldInfoPtr_m_RawPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RawPosition");
			Touch.NativeFieldInfoPtr_m_PositionDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_PositionDelta");
			Touch.NativeFieldInfoPtr_m_TimeDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TimeDelta");
			Touch.NativeFieldInfoPtr_m_TapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_TapCount");
			Touch.NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Phase");
			Touch.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Type");
			Touch.NativeFieldInfoPtr_m_Pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Pressure");
			Touch.NativeFieldInfoPtr_m_maximumPossiblePressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_maximumPossiblePressure");
			Touch.NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_Radius");
			Touch.NativeFieldInfoPtr_m_RadiusVariance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_RadiusVariance");
			Touch.NativeFieldInfoPtr_m_AltitudeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AltitudeAngle");
			Touch.NativeFieldInfoPtr_m_AzimuthAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Touch>.NativeClassPtr, "m_AzimuthAngle");
			Touch.NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663297);
			Touch.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663298);
			Touch.NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663299);
			Touch.NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663300);
			Touch.NativeMethodInfoPtr_get_pressure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663301);
			Touch.NativeMethodInfoPtr_get_type_Public_get_TouchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663302);
			Touch.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663303);
			Touch.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663304);
			Touch.NativeMethodInfoPtr_get_radius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663305);
			Touch.NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Touch>.NativeClassPtr, 100663306);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000274C File Offset: 0x0000094C
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe int fingerId
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FingerId = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000277C File Offset: 0x0000097C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000206C File Offset: 0x0000026C
		public unsafe Vector2 position
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 83365, RefRangeEnd = 83372, XrefRangeStart = 83365, XrefRangeEnd = 83365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000027AC File Offset: 0x000009AC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		public unsafe Vector2 deltaPosition
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83372, RefRangeEnd = 83375, XrefRangeStart = 83372, XrefRangeEnd = 83372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_PositionDelta = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000027DC File Offset: 0x000009DC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000209E File Offset: 0x0000029E
		public unsafe TouchPhase phase
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 83375, RefRangeEnd = 83380, XrefRangeStart = 83375, XrefRangeEnd = 83375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Phase = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000280C File Offset: 0x00000A0C
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000020A8 File Offset: 0x000002A8
		public unsafe float pressure
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83380, RefRangeEnd = 83382, XrefRangeStart = 83380, XrefRangeEnd = 83380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_pressure_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Pressure = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000283C File Offset: 0x00000A3C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020BC File Offset: 0x000002BC
		public unsafe TouchType type
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80226, RefRangeEnd = 80229, XrefRangeStart = 80226, XrefRangeEnd = 80229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_type_Public_get_TouchType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000286C File Offset: 0x00000A6C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020C6 File Offset: 0x000002C6
		public unsafe float altitudeAngle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83382, RefRangeEnd = 83383, XrefRangeStart = 83382, XrefRangeEnd = 83382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_AltitudeAngle = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000289C File Offset: 0x00000A9C
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020D0 File Offset: 0x000002D0
		public unsafe float azimuthAngle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 83383, RefRangeEnd = 83384, XrefRangeStart = 83383, XrefRangeEnd = 83383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_AzimuthAngle = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000028CC File Offset: 0x00000ACC
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020DA File Offset: 0x000002DA
		public unsafe float radius
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 83384, RefRangeEnd = 83397, XrefRangeStart = 83384, XrefRangeEnd = 83384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_radius_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Radius = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000028FC File Offset: 0x00000AFC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe float radiusVariance
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 83397, RefRangeEnd = 83412, XrefRangeStart = 83397, XrefRangeEnd = 83397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Touch.NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_RadiusVariance = value;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Touch>.NativeClassPtr, ref this));
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000292C File Offset: 0x00000B2C
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002076 File Offset: 0x00000276
		public Vector2 rawPosition
		{
			get
			{
				return this.m_RawPosition;
			}
			set
			{
				this.m_RawPosition = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002944 File Offset: 0x00000B44
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000208A File Offset: 0x0000028A
		public float deltaTime
		{
			get
			{
				return this.m_TimeDelta;
			}
			set
			{
				this.m_TimeDelta = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000295C File Offset: 0x00000B5C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002094 File Offset: 0x00000294
		public int tapCount
		{
			get
			{
				return this.m_TapCount;
			}
			set
			{
				this.m_TapCount = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002974 File Offset: 0x00000B74
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020B2 File Offset: 0x000002B2
		public float maximumPossiblePressure
		{
			get
			{
				return this.m_maximumPossiblePressure;
			}
			set
			{
				this.m_maximumPossiblePressure = value;
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_m_FingerId;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_RawPosition;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_PositionDelta;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeDelta;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_m_TapCount;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_Phase;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_m_Pressure;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_m_maximumPossiblePressure;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_m_Radius;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_m_RadiusVariance;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_m_AltitudeAngle;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_m_AzimuthAngle;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_fingerId_Public_get_Int32_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaPosition_Public_get_Vector2_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_phase_Public_get_TouchPhase_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_pressure_Public_get_Single_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_TouchType_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_altitudeAngle_Public_get_Single_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_azimuthAngle_Public_get_Single_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_radius_Public_get_Single_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_radiusVariance_Public_get_Single_0;

		// Token: 0x04000027 RID: 39
		[FieldOffset(0)]
		public int m_FingerId;

		// Token: 0x04000028 RID: 40
		[FieldOffset(4)]
		public Vector2 m_Position;

		// Token: 0x04000029 RID: 41
		[FieldOffset(12)]
		public Vector2 m_RawPosition;

		// Token: 0x0400002A RID: 42
		[FieldOffset(20)]
		public Vector2 m_PositionDelta;

		// Token: 0x0400002B RID: 43
		[FieldOffset(28)]
		public float m_TimeDelta;

		// Token: 0x0400002C RID: 44
		[FieldOffset(32)]
		public int m_TapCount;

		// Token: 0x0400002D RID: 45
		[FieldOffset(36)]
		public TouchPhase m_Phase;

		// Token: 0x0400002E RID: 46
		[FieldOffset(40)]
		public TouchType m_Type;

		// Token: 0x0400002F RID: 47
		[FieldOffset(44)]
		public float m_Pressure;

		// Token: 0x04000030 RID: 48
		[FieldOffset(48)]
		public float m_maximumPossiblePressure;

		// Token: 0x04000031 RID: 49
		[FieldOffset(52)]
		public float m_Radius;

		// Token: 0x04000032 RID: 50
		[FieldOffset(56)]
		public float m_RadiusVariance;

		// Token: 0x04000033 RID: 51
		[FieldOffset(60)]
		public float m_AltitudeAngle;

		// Token: 0x04000034 RID: 52
		[FieldOffset(64)]
		public float m_AzimuthAngle;
	}
}
