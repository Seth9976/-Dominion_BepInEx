using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200013B RID: 315
	public class OnDemandRendering : Object
	{
		// Token: 0x060017C1 RID: 6081 RVA: 0x00058E0C File Offset: 0x0005700C
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandRendering()
		{
			Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "OnDemandRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
			OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, "m_RenderFrameInterval");
			OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100665089);
			OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100665090);
			OnDemandRendering.GetEffectiveRenderFrameRateDelegateField = IL2CPP.ResolveICall<OnDemandRendering.GetEffectiveRenderFrameRateDelegate>("UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate");
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00058E88 File Offset: 0x00057088
		// (set) Token: 0x060017C8 RID: 6088 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public unsafe static int renderFrameInterval
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82224, XrefRangeEnd = 82228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				OnDemandRendering.m_RenderFrameInterval = Math.Max(1, value);
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00058EB8 File Offset: 0x000570B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82228, XrefRangeEnd = 82236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderFrameInterval(out int frameInterval)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &frameInterval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
		public OnDemandRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00058EEC File Offset: 0x000570EC
		// (set) Token: 0x060017C6 RID: 6086 RVA: 0x0000D4BA File Offset: 0x0000B6BA
		public unsafe static int m_RenderFrameInterval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00058F08 File Offset: 0x00057108
		public static bool willCurrentFrameRender
		{
			get
			{
				return Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0000D4D7 File Offset: 0x0000B6D7
		public static float GetEffectiveRenderFrameRate()
		{
			return OnDemandRendering.GetEffectiveRenderFrameRateDelegateField();
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00058F28 File Offset: 0x00057128
		public static int effectiveRenderFrameRate
		{
			get
			{
				float effectiveRenderFrameRate = OnDemandRendering.GetEffectiveRenderFrameRate();
				bool flag = (double)effectiveRenderFrameRate <= 0.0;
				int num;
				if (flag)
				{
					num = (int)effectiveRenderFrameRate;
				}
				else
				{
					num = (int)(effectiveRenderFrameRate + 0.5f);
				}
				return num;
			}
		}

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;

		// Token: 0x040011AE RID: 4526
		private static readonly OnDemandRendering.GetEffectiveRenderFrameRateDelegate GetEffectiveRenderFrameRateDelegateField;

		// Token: 0x02000984 RID: 2436
		// (Invoke) Token: 0x06003126 RID: 12582
		private delegate float GetEffectiveRenderFrameRateDelegate();
	}
}
