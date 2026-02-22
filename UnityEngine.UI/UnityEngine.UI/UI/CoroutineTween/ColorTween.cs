using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000047 RID: 71
	public sealed class ColorTween : ValueType
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0002755C File Offset: 0x0002575C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorTween()
		{
			Il2CppClassPointerStore<ColorTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "ColorTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween>.NativeClassPtr);
			ColorTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Target");
			ColorTween.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_StartColor");
			ColorTween.NativeFieldInfoPtr_m_TargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TargetColor");
			ColorTween.NativeFieldInfoPtr_m_TweenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TweenMode");
			ColorTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Duration");
			ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_IgnoreTimeScale");
			ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664516);
			ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664517);
			ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664518);
			ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664519);
			ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664520);
			ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664521);
			ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664522);
			ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664523);
			ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664524);
			ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664525);
			ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664526);
			ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664527);
			ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664528);
			ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664529);
			ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100664530);
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00027730 File Offset: 0x00025930
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00027774 File Offset: 0x00025974
		public unsafe Color startColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000277B8 File Offset: 0x000259B8
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x000277FC File Offset: 0x000259FC
		public unsafe Color targetColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00027840 File Offset: 0x00025A40
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00027884 File Offset: 0x00025A84
		public unsafe ColorTween.ColorTweenMode tweenMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000278C8 File Offset: 0x00025AC8
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x0002790C File Offset: 0x00025B0C
		public unsafe float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 88916, RefRangeEnd = 88918, XrefRangeStart = 88916, XrefRangeEnd = 88918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00027950 File Offset: 0x00025B50
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00027994 File Offset: 0x00025B94
		public unsafe bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000279D8 File Offset: 0x00025BD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120417, RefRangeEnd = 120419, XrefRangeStart = 120412, XrefRangeEnd = 120417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00027A1C File Offset: 0x00025C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120419, XrefRangeEnd = 120427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnChangedCallback(UnityAction<Color> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00027A64 File Offset: 0x00025C64
		[CallerCount(0)]
		public unsafe bool GetIgnoreTimescale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00027AA8 File Offset: 0x00025CA8
		[CallerCount(0)]
		public unsafe float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00027AEC File Offset: 0x00025CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120427, RefRangeEnd = 120429, XrefRangeStart = 120427, XrefRangeEnd = 120427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00004D9D File Offset: 0x00002F9D
		public ColorTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public ColorTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween>.NativeClassPtr))
		{
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00027B30 File Offset: 0x00025D30
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public unsafe ColorTween.ColorTweenCallback m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorTween.ColorTweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00027B60 File Offset: 0x00025D60
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe Color m_StartColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_StartColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_StartColor)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00027B88 File Offset: 0x00025D88
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public unsafe Color m_TargetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TargetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TargetColor)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00027BB0 File Offset: 0x00025DB0
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00004E0D File Offset: 0x0000300D
		public unsafe ColorTween.ColorTweenMode m_TweenMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TweenMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_TweenMode)) = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x00027BD8 File Offset: 0x00025DD8
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x00004E28 File Offset: 0x00003028
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00027C00 File Offset: 0x00025E00
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00004E43 File Offset: 0x00003043
		public unsafe bool m_IgnoreTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale)) = value;
			}
		}

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetColor;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_m_TweenMode;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_get_targetColor_Public_get_Color_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x020000BB RID: 187
		public enum ColorTweenMode
		{
			// Token: 0x040009F2 RID: 2546
			All,
			// Token: 0x040009F3 RID: 2547
			RGB,
			// Token: 0x040009F4 RID: 2548
			Alpha
		}

		// Token: 0x020000BC RID: 188
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000CC1 RID: 3265 RVA: 0x00006C9F File Offset: 0x00004E9F
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTweenCallback()
			{
				Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "ColorTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr);
				ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr, 100665075);
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x0003708C File Offset: 0x0003528C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 120410, RefRangeEnd = 120412, XrefRangeStart = 120407, XrefRangeEnd = 120410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x00006CD3 File Offset: 0x00004ED3
			public ColorTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009F5 RID: 2549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
