using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001B RID: 27
	public class ContentSizeFitter : UIBehaviour
	{
		// Token: 0x060003CA RID: 970 RVA: 0x000157EC File Offset: 0x000139EC
		// Note: this type is marked as 'beforefieldinit'.
		static ContentSizeFitter()
		{
			Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ContentSizeFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr);
			ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_HorizontalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_VerticalFit");
			ContentSizeFitter.NativeFieldInfoPtr_m_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Rect");
			ContentSizeFitter.NativeFieldInfoPtr_m_Tracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, "m_Tracker");
			ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663847);
			ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663848);
			ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663849);
			ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663850);
			ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663851);
			ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663852);
			ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663853);
			ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663854);
			ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663855);
			ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663856);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663857);
			ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663858);
			ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr, 100663859);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00015970 File Offset: 0x00013B70
		// (set) Token: 0x060003CC RID: 972 RVA: 0x000159AC File Offset: 0x00013BAC
		public unsafe ContentSizeFitter.FitMode horizontalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114470, XrefRangeEnd = 114474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000159EC File Offset: 0x00013BEC
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00015A28 File Offset: 0x00013C28
		public unsafe ContentSizeFitter.FitMode verticalFit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114474, XrefRangeEnd = 114478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00015A68 File Offset: 0x00013C68
		public unsafe RectTransform rectTransform
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 114485, RefRangeEnd = 114493, XrefRangeStart = 114478, XrefRangeEnd = 114485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00015AA8 File Offset: 0x00013CA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114493, XrefRangeEnd = 114494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentSizeFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentSizeFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00015AE4 File Offset: 0x00013CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114502, XrefRangeEnd = 114504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00015B20 File Offset: 0x00013D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114504, XrefRangeEnd = 114511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00015B5C File Offset: 0x00013D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114511, XrefRangeEnd = 114512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnRectTransformDimensionsChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00015B98 File Offset: 0x00013D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114512, XrefRangeEnd = 114523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleSelfFittingAlongAxis(int axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axis;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00015BD8 File Offset: 0x00013DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114523, XrefRangeEnd = 114532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutHorizontal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00015C14 File Offset: 0x00013E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114532, XrefRangeEnd = 114540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLayoutVertical()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContentSizeFitter.NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00015C50 File Offset: 0x00013E50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114545, RefRangeEnd = 114549, XrefRangeStart = 114540, XrefRangeEnd = 114545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentSizeFitter.NativeMethodInfoPtr_SetDirty_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000353F File Offset: 0x0000173F
		public ContentSizeFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00015C84 File Offset: 0x00013E84
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00003548 File Offset: 0x00001748
		public unsafe ContentSizeFitter.FitMode m_HorizontalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_HorizontalFit)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00015CAC File Offset: 0x00013EAC
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00003563 File Offset: 0x00001763
		public unsafe ContentSizeFitter.FitMode m_VerticalFit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_VerticalFit)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00015CD4 File Offset: 0x00013ED4
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000357E File Offset: 0x0000177E
		public unsafe RectTransform m_Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00015D04 File Offset: 0x00013F04
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000359D File Offset: 0x0000179D
		public unsafe DrivenRectTransformTracker m_Tracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentSizeFitter.NativeFieldInfoPtr_m_Tracker)) = value;
			}
		}

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalFit;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_m_VerticalFit;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_m_Rect;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracker;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalFit_Public_get_FitMode_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_set_horizontalFit_Public_set_Void_FitMode_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_get_verticalFit_Public_get_FitMode_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_set_verticalFit_Public_set_Void_FitMode_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_OnRectTransformDimensionsChange_Protected_Virtual_Void_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_HandleSelfFittingAlongAxis_Private_Void_Int32_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutHorizontal_Public_Virtual_New_Void_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutVertical_Public_Virtual_New_Void_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_SetDirty_Protected_Void_0;

		// Token: 0x02000099 RID: 153
		public enum FitMode
		{
			// Token: 0x04000951 RID: 2385
			Unconstrained,
			// Token: 0x04000952 RID: 2386
			MinSize,
			// Token: 0x04000953 RID: 2387
			PreferredSize
		}
	}
}
