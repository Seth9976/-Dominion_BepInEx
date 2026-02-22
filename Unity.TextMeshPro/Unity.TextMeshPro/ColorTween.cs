using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x02000028 RID: 40
	public sealed class ColorTween : ValueType
	{
		// Token: 0x06000399 RID: 921 RVA: 0x000151BC File Offset: 0x000133BC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorTween()
		{
			Il2CppClassPointerStore<ColorTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "ColorTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween>.NativeClassPtr);
			ColorTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Target");
			ColorTween.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_StartColor");
			ColorTween.NativeFieldInfoPtr_m_TargetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TargetColor");
			ColorTween.NativeFieldInfoPtr_m_TweenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_TweenMode");
			ColorTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_Duration");
			ColorTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "m_IgnoreTimeScale");
			ColorTween.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663614);
			ColorTween.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663615);
			ColorTween.NativeMethodInfoPtr_get_targetColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663616);
			ColorTween.NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663617);
			ColorTween.NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663618);
			ColorTween.NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663619);
			ColorTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663620);
			ColorTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663621);
			ColorTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663622);
			ColorTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663623);
			ColorTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663624);
			ColorTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663625);
			ColorTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663626);
			ColorTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663627);
			ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, 100663628);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00015390 File Offset: 0x00013590
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000153D4 File Offset: 0x000135D4
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00015418 File Offset: 0x00013618
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0001545C File Offset: 0x0001365C
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

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000154A0 File Offset: 0x000136A0
		// (set) Token: 0x0600039F RID: 927 RVA: 0x000154E4 File Offset: 0x000136E4
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00015528 File Offset: 0x00013728
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x0001556C File Offset: 0x0001376C
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000155B0 File Offset: 0x000137B0
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x000155F4 File Offset: 0x000137F4
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

		// Token: 0x060003A4 RID: 932 RVA: 0x00015638 File Offset: 0x00013838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137677, XrefRangeEnd = 137682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0001567C File Offset: 0x0001387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137682, XrefRangeEnd = 137690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003A6 RID: 934 RVA: 0x000156C4 File Offset: 0x000138C4
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

		// Token: 0x060003A7 RID: 935 RVA: 0x00015708 File Offset: 0x00013908
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

		// Token: 0x060003A8 RID: 936 RVA: 0x0001574C File Offset: 0x0001394C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120427, RefRangeEnd = 120429, XrefRangeStart = 120427, XrefRangeEnd = 120429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public ColorTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003DB1 File Offset: 0x00001FB1
		public ColorTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween>.NativeClassPtr))
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00015790 File Offset: 0x00013990
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003DC3 File Offset: 0x00001FC3
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

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000157C0 File Offset: 0x000139C0
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00003DE2 File Offset: 0x00001FE2
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000157E8 File Offset: 0x000139E8
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00003DFD File Offset: 0x00001FFD
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x00015810 File Offset: 0x00013A10
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x00003E18 File Offset: 0x00002018
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x00015838 File Offset: 0x00013A38
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x00003E33 File Offset: 0x00002033
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00015860 File Offset: 0x00013A60
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00003E4E File Offset: 0x0000204E
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

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetColor;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_m_TweenMode;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_get_targetColor_Public_get_Color_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_set_targetColor_Public_set_Void_Color_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_get_tweenMode_Public_get_ColorTweenMode_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_set_tweenMode_Public_set_Void_ColorTweenMode_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Color_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0200007A RID: 122
		public enum ColorTweenMode
		{
			// Token: 0x04000B9C RID: 2972
			All,
			// Token: 0x04000B9D RID: 2973
			RGB,
			// Token: 0x04000B9E RID: 2974
			Alpha
		}

		// Token: 0x0200007B RID: 123
		public class ColorTweenCallback : UnityEvent<Color>
		{
			// Token: 0x06000E9C RID: 3740 RVA: 0x00008E09 File Offset: 0x00007009
			// Note: this type is marked as 'beforefieldinit'.
			static ColorTweenCallback()
			{
				Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorTween>.NativeClassPtr, "ColorTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr);
				ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr, 100664797);
			}

			// Token: 0x06000E9D RID: 3741 RVA: 0x0003AFF8 File Offset: 0x000391F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137676, RefRangeEnd = 137677, XrefRangeStart = 137673, XrefRangeEnd = 137676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorTween.ColorTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorTween.ColorTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E9E RID: 3742 RVA: 0x00008E3D File Offset: 0x0000703D
			public ColorTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000B9F RID: 2975
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
