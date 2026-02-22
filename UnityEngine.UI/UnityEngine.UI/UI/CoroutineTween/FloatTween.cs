using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000048 RID: 72
	public sealed class FloatTween : ValueType
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00027C28 File Offset: 0x00025E28
		// Note: this type is marked as 'beforefieldinit'.
		static FloatTween()
		{
			Il2CppClassPointerStore<FloatTween>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "FloatTween");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween>.NativeClassPtr);
			FloatTween.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Target");
			FloatTween.NativeFieldInfoPtr_m_StartValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_StartValue");
			FloatTween.NativeFieldInfoPtr_m_TargetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_TargetValue");
			FloatTween.NativeFieldInfoPtr_m_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_Duration");
			FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "m_IgnoreTimeScale");
			FloatTween.NativeMethodInfoPtr_get_startValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664531);
			FloatTween.NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664532);
			FloatTween.NativeMethodInfoPtr_get_targetValue_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664533);
			FloatTween.NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664534);
			FloatTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664535);
			FloatTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664536);
			FloatTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664537);
			FloatTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664538);
			FloatTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664539);
			FloatTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664540);
			FloatTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664541);
			FloatTween.NativeMethodInfoPtr_GetDuration_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664542);
			FloatTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, 100664543);
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00027DC0 File Offset: 0x00025FC0
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00027E04 File Offset: 0x00026004
		public unsafe float startValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_startValue_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 61911, RefRangeEnd = 61923, XrefRangeStart = 61911, XrefRangeEnd = 61923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00027E48 File Offset: 0x00026048
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00027E8C File Offset: 0x0002608C
		public unsafe float targetValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_targetValue_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62076, RefRangeEnd = 62088, XrefRangeStart = 62076, XrefRangeEnd = 62088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00027ED0 File Offset: 0x000260D0
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00027F14 File Offset: 0x00026114
		public unsafe float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00027F58 File Offset: 0x00026158
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00027F9C File Offset: 0x0002619C
		public unsafe bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00027FE0 File Offset: 0x000261E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120434, XrefRangeEnd = 120438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00028024 File Offset: 0x00026224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120438, XrefRangeEnd = 120446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOnChangedCallback(UnityAction<float> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002806C File Offset: 0x0002626C
		[CallerCount(0)]
		public unsafe bool GetIgnoreTimescale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000280B0 File Offset: 0x000262B0
		[CallerCount(0)]
		public unsafe float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_GetDuration_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000280F4 File Offset: 0x000262F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120427, RefRangeEnd = 120429, XrefRangeStart = 120427, XrefRangeEnd = 120429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00004E5E File Offset: 0x0000305E
		public FloatTween(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00004E67 File Offset: 0x00003067
		public FloatTween()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween>.NativeClassPtr))
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00028138 File Offset: 0x00026338
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00004E79 File Offset: 0x00003079
		public unsafe FloatTween.FloatTweenCallback m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatTween.FloatTweenCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00028168 File Offset: 0x00026368
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00004E98 File Offset: 0x00003098
		public unsafe float m_StartValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_StartValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_StartValue)) = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00028190 File Offset: 0x00026390
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00004EB3 File Offset: 0x000030B3
		public unsafe float m_TargetValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_TargetValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_TargetValue)) = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000281B8 File Offset: 0x000263B8
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00004ECE File Offset: 0x000030CE
		public unsafe float m_Duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_Duration)) = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x000281E0 File Offset: 0x000263E0
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00004EE9 File Offset: 0x000030E9
		public unsafe bool m_IgnoreTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloatTween.NativeFieldInfoPtr_m_IgnoreTimeScale)) = value;
			}
		}

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_StartValue;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetValue;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr_m_Duration;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTimeScale;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_startValue_Public_get_Single_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_set_startValue_Public_set_Void_Single_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_targetValue_Public_get_Single_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_set_targetValue_Public_set_Void_Single_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_Final_New_get_Single_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_set_duration_Public_set_Void_Single_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreTimeScale_Public_set_Void_Boolean_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Virtual_Final_New_Void_Single_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_AddOnChangedCallback_Public_Void_UnityAction_1_Single_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_GetIgnoreTimescale_Public_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Single_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x020000BD RID: 189
		public class FloatTweenCallback : UnityEvent<float>
		{
			// Token: 0x06000CC4 RID: 3268 RVA: 0x00006CDC File Offset: 0x00004EDC
			// Note: this type is marked as 'beforefieldinit'.
			static FloatTweenCallback()
			{
				Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FloatTween>.NativeClassPtr, "FloatTweenCallback");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr);
				FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr, 100665076);
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x000370C8 File Offset: 0x000352C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 120432, RefRangeEnd = 120434, XrefRangeStart = 120429, XrefRangeEnd = 120432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatTweenCallback()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatTween.FloatTweenCallback>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloatTween.FloatTweenCallback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00006D10 File Offset: 0x00004F10
			public FloatTweenCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009F6 RID: 2550
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
