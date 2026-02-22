using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000071 RID: 113
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x00031D7C File Offset: 0x0002FF7C
		// Note: this type is marked as 'beforefieldinit'.
		static PhysicsRaycaster()
		{
			Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "PhysicsRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr);
			PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventCamera");
			PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_EventMask");
			PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_MaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_LastMaxRayIntersections");
			PhysicsRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "m_Hits");
			PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664917);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664918);
			PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664919);
			PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664920);
			PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664921);
			PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664922);
			PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664923);
			PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664924);
			PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664925);
			PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, 100664926);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00031EEC File Offset: 0x000300EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhysicsRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00031F28 File Offset: 0x00030128
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123383, XrefRangeEnd = 123391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00031F74 File Offset: 0x00030174
		public unsafe virtual int depth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123391, XrefRangeEnd = 123396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x00031FBC File Offset: 0x000301BC
		public unsafe int finalEventMask
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 123402, RefRangeEnd = 123406, XrefRangeStart = 123396, XrefRangeEnd = 123402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00031FF8 File Offset: 0x000301F8
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00032034 File Offset: 0x00030234
		public unsafe LayerMask eventMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00032074 File Offset: 0x00030274
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000320B0 File Offset: 0x000302B0
		public unsafe int maxRayIntersections
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x000320F0 File Offset: 0x000302F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123427, RefRangeEnd = 123429, XrefRangeStart = 123406, XrefRangeEnd = 123427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDisplayIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distanceToClipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00032168 File Offset: 0x00030368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123429, XrefRangeEnd = 123467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resultAppendList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PhysicsRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00005E97 File Offset: 0x00004097
		public PhysicsRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x000321C8 File Offset: 0x000303C8
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00005EA0 File Offset: 0x000040A0
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x000321E4 File Offset: 0x000303E4
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00005EAE File Offset: 0x000040AE
		public unsafe Camera m_EventCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00032214 File Offset: 0x00030414
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00005ECD File Offset: 0x000040CD
		public unsafe LayerMask m_EventMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_EventMask)) = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003223C File Offset: 0x0003043C
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00005EE8 File Offset: 0x000040E8
		public unsafe int m_MaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_MaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x00032264 File Offset: 0x00030464
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00005F03 File Offset: 0x00004103
		public unsafe int m_LastMaxRayIntersections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_LastMaxRayIntersections)) = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0003228C File Offset: 0x0003048C
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x00005F1E File Offset: 0x0000411E
		public unsafe Il2CppStructArray<RaycastHit> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhysicsRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_m_EventCamera;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr_m_EventMask;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeFieldInfoPtr_m_MaxRayIntersections;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_m_LastMaxRayIntersections;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_depth_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_get_finalEventMask_Public_get_Int32_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_eventMask_Public_get_LayerMask_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_set_eventMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_get_maxRayIntersections_Public_get_Int32_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_set_maxRayIntersections_Public_set_Void_Int32_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_ComputeRayAndDistance_Protected_Boolean_PointerEventData_byref_Ray_byref_Int32_byref_Single_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x020000D3 RID: 211
		public class RaycastHitComparer : Object
		{
			// Token: 0x06000D72 RID: 3442 RVA: 0x00039680 File Offset: 0x00037880
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastHitComparer()
			{
				Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhysicsRaycaster>.NativeClassPtr, "RaycastHitComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr);
				PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, "instance");
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665149);
				PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr, 100665150);
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x000396E8 File Offset: 0x000378E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123380, XrefRangeEnd = 123383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000D74 RID: 3444 RVA: 0x00039740 File Offset: 0x00037940
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHitComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRaycaster.RaycastHitComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhysicsRaycaster.RaycastHitComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000D75 RID: 3445 RVA: 0x00007172 File Offset: 0x00005372
			public RaycastHitComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0003977C File Offset: 0x0003797C
			// (set) Token: 0x06000D77 RID: 3447 RVA: 0x0000717B File Offset: 0x0000537B
			public unsafe static PhysicsRaycaster.RaycastHitComparer instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsRaycaster.RaycastHitComparer>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PhysicsRaycaster.RaycastHitComparer.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A77 RID: 2679
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x04000A78 RID: 2680
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0;

			// Token: 0x04000A79 RID: 2681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
