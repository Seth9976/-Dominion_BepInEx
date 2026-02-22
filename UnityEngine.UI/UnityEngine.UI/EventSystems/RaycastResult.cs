using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000072 RID: 114
	public sealed class RaycastResult : ValueType
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x000322BC File Offset: 0x000304BC
		// Note: this type is marked as 'beforefieldinit'.
		static RaycastResult()
		{
			Il2CppClassPointerStore<RaycastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycastResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr);
			RaycastResult.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "m_GameObject");
			RaycastResult.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "module");
			RaycastResult.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "distance");
			RaycastResult.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "index");
			RaycastResult.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "depth");
			RaycastResult.NativeFieldInfoPtr_sortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingLayer");
			RaycastResult.NativeFieldInfoPtr_sortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "sortingOrder");
			RaycastResult.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldPosition");
			RaycastResult.NativeFieldInfoPtr_worldNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "worldNormal");
			RaycastResult.NativeFieldInfoPtr_screenPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "screenPosition");
			RaycastResult.NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, "displayIndex");
			RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100664927);
			RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100664928);
			RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100664929);
			RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100664930);
			RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr, 100664931);
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0003242C File Offset: 0x0003062C
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00032470 File Offset: 0x00030670
		public unsafe GameObject gameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000324B8 File Offset: 0x000306B8
		public unsafe bool isValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 123471, RefRangeEnd = 123472, XrefRangeStart = 123467, XrefRangeEnd = 123471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x000324FC File Offset: 0x000306FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123472, XrefRangeEnd = 123475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00032534 File Offset: 0x00030734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123552, RefRangeEnd = 123554, XrefRangeStart = 123475, XrefRangeEnd = 123552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastResult.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00005F3D File Offset: 0x0000413D
		public RaycastResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00005F46 File Offset: 0x00004146
		public RaycastResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastResult>.NativeClassPtr))
		{
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x00032570 File Offset: 0x00030770
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x00005F58 File Offset: 0x00004158
		public unsafe GameObject m_GameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_m_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x000325A0 File Offset: 0x000307A0
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00005F77 File Offset: 0x00004177
		public unsafe BaseRaycaster module
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x000325D0 File Offset: 0x000307D0
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00005F96 File Offset: 0x00004196
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x000325F8 File Offset: 0x000307F8
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00005FB1 File Offset: 0x000041B1
		public unsafe float index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00032620 File Offset: 0x00030820
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00005FCC File Offset: 0x000041CC
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00032648 File Offset: 0x00030848
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00005FE7 File Offset: 0x000041E7
		public unsafe int sortingLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingLayer)) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00032670 File Offset: 0x00030870
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x00006002 File Offset: 0x00004202
		public unsafe int sortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_sortingOrder)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00032698 File Offset: 0x00030898
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0000601D File Offset: 0x0000421D
		public unsafe Vector3 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x000326C0 File Offset: 0x000308C0
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x00006038 File Offset: 0x00004238
		public unsafe Vector3 worldNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_worldNormal)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000326E8 File Offset: 0x000308E8
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00006053 File Offset: 0x00004253
		public unsafe Vector2 screenPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_screenPosition)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00032710 File Offset: 0x00030910
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0000606E File Offset: 0x0000426E
		public unsafe int displayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastResult.NativeFieldInfoPtr_displayIndex)) = value;
			}
		}

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr_module;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr_sortingLayer;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr_sortingOrder;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr_worldNormal;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr_screenPosition;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr_displayIndex;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
