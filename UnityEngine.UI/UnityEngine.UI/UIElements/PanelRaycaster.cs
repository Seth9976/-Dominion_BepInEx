using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	// Token: 0x0200004B RID: 75
	public class PanelRaycaster : BaseRaycaster
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x000291FC File Offset: 0x000273FC
		// Note: this type is marked as 'beforefieldinit'.
		static PanelRaycaster()
		{
			Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UIElements", "PanelRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr);
			PanelRaycaster.NativeFieldInfoPtr_m_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, "m_Panel");
			PanelRaycaster.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664583);
			PanelRaycaster.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664584);
			PanelRaycaster.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664585);
			PanelRaycaster.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664586);
			PanelRaycaster.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664587);
			PanelRaycaster.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664588);
			PanelRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664589);
			PanelRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664590);
			PanelRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664591);
			PanelRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664592);
			PanelRaycaster.NativeMethodInfoPtr_ConvertFloatBitsToInt_Private_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664593);
			PanelRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, 100664594);
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00029330 File Offset: 0x00027530
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00029370 File Offset: 0x00027570
		public unsafe virtual IPanel panel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120836, XrefRangeEnd = 120852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000293B4 File Offset: 0x000275B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120852, XrefRangeEnd = 120859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000293E8 File Offset: 0x000275E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120859, XrefRangeEnd = 120866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0002941C File Offset: 0x0002761C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120866, XrefRangeEnd = 120881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00029450 File Offset: 0x00027650
		public unsafe GameObject selectableGameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x00029490 File Offset: 0x00027690
		public unsafe override int sortOrderPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000294D8 File Offset: 0x000276D8
		public unsafe override int renderOrderPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00029520 File Offset: 0x00027720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120881, XrefRangeEnd = 120910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00029580 File Offset: 0x00027780
		public unsafe override Camera eventCamera
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PanelRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000295CC File Offset: 0x000277CC
		[CallerCount(0)]
		public unsafe static int ConvertFloatBitsToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr_ConvertFloatBitsToInt_Private_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0002960C File Offset: 0x0002780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PanelRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PanelRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00004FDA File Offset: 0x000031DA
		public PanelRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00029648 File Offset: 0x00027848
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00004FE3 File Offset: 0x000031E3
		public unsafe BaseRuntimePanel m_Panel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelRaycaster.NativeFieldInfoPtr_m_Panel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRuntimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PanelRaycaster.NativeFieldInfoPtr_m_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeFieldInfoPtr_m_Panel;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_panel_Public_Virtual_Final_New_get_IPanel_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_set_panel_Public_Virtual_Final_New_set_Void_IPanel_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacks_Private_Void_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacks_Private_Void_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Private_Void_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_get_selectableGameObject_Private_get_GameObject_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFloatBitsToInt_Private_Static_Int32_Single_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000C0 RID: 192
		[StructLayout(2)]
		public struct FloatIntBits
		{
			// Token: 0x06000D2A RID: 3370 RVA: 0x00038804 File Offset: 0x00036A04
			// Note: this type is marked as 'beforefieldinit'.
			static FloatIntBits()
			{
				Il2CppClassPointerStore<PanelRaycaster.FloatIntBits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PanelRaycaster>.NativeClassPtr, "FloatIntBits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PanelRaycaster.FloatIntBits>.NativeClassPtr);
				PanelRaycaster.FloatIntBits.NativeFieldInfoPtr_f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelRaycaster.FloatIntBits>.NativeClassPtr, "f");
				PanelRaycaster.FloatIntBits.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PanelRaycaster.FloatIntBits>.NativeClassPtr, "i");
			}

			// Token: 0x06000D2B RID: 3371 RVA: 0x00006F6A File Offset: 0x0000516A
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PanelRaycaster.FloatIntBits>.NativeClassPtr, ref this));
			}

			// Token: 0x04000A40 RID: 2624
			private static readonly IntPtr NativeFieldInfoPtr_f;

			// Token: 0x04000A41 RID: 2625
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04000A42 RID: 2626
			[FieldOffset(0)]
			public float f;

			// Token: 0x04000A43 RID: 2627
			[FieldOffset(0)]
			public int i;
		}
	}
}
