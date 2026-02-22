using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000005 RID: 5
	public class YogaConfig : Object
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000300C File Offset: 0x0000120C
		// Note: this type is marked as 'beforefieldinit'.
		static YogaConfig()
		{
			Il2CppClassPointerStore<YogaConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsNativeModule.dll", "UnityEngine.Yoga", "YogaConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr);
			YogaConfig.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "Default");
			YogaConfig.NativeFieldInfoPtr__ygConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "_ygConfig");
			YogaConfig.NativeFieldInfoPtr__logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, "_logger");
			YogaConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663304);
			YogaConfig.NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663305);
			YogaConfig.NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConfig>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030B4 File Offset: 0x000012B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89385, XrefRangeEnd = 89397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YogaConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000030F0 File Offset: 0x000012F0
		public unsafe IntPtr Handle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003244 File Offset: 0x00001444
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000312C File Offset: 0x0000132C
		public unsafe float PointScaleFactor
		{
			get
			{
				return Native.YGConfigGetPointScaleFactor(this._ygConfig);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 89399, RefRangeEnd = 89401, XrefRangeStart = 89397, XrefRangeEnd = 89399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConfig.NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020E0 File Offset: 0x000002E0
		public YogaConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000316C File Offset: 0x0000136C
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020E9 File Offset: 0x000002E9
		public unsafe static YogaConfig Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YogaConfig.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YogaConfig>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YogaConfig.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003194 File Offset: 0x00001394
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020FB File Offset: 0x000002FB
		public unsafe IntPtr _ygConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__ygConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__ygConfig)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000031BC File Offset: 0x000013BC
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002116 File Offset: 0x00000316
		public unsafe Logger _logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Logger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YogaConfig.NativeFieldInfoPtr__logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000031EC File Offset: 0x000013EC
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002135 File Offset: 0x00000335
		public Logger Logger
		{
			get
			{
				return this._logger;
			}
			set
			{
				this._logger = value;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000213F File Offset: 0x0000033F
		public void SetExperimentalFeatureEnabled(YogaExperimentalFeature feature, bool enabled)
		{
			Native.YGConfigSetExperimentalFeatureEnabled(this._ygConfig, feature, enabled);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003204 File Offset: 0x00001404
		public bool IsExperimentalFeatureEnabled(YogaExperimentalFeature feature)
		{
			return Native.YGConfigIsExperimentalFeatureEnabled(this._ygConfig, feature);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003224 File Offset: 0x00001424
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002150 File Offset: 0x00000350
		public bool UseWebDefaults
		{
			get
			{
				return Native.YGConfigGetUseWebDefaults(this._ygConfig);
			}
			set
			{
				Native.YGConfigSetUseWebDefaults(this._ygConfig, value);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003264 File Offset: 0x00001464
		public static int GetInstanceCount()
		{
			return Native.YGConfigGetInstanceCount();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002160 File Offset: 0x00000360
		public static void SetDefaultLogger(Logger logger)
		{
			YogaConfig.Default.Logger = logger;
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr__ygConfig;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__logger;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_IntPtr_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_set_PointScaleFactor_Public_set_Void_Single_0;
	}
}
