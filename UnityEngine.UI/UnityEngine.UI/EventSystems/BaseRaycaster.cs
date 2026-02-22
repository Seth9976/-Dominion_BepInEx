using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006F RID: 111
	public class BaseRaycaster : UIBehaviour
	{
		// Token: 0x06000AF8 RID: 2808 RVA: 0x000317AC File Offset: 0x0002F9AC
		// Note: this type is marked as 'beforefieldinit'.
		static BaseRaycaster()
		{
			Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr);
			BaseRaycaster.NativeFieldInfoPtr_m_RootRaycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, "m_RootRaycaster");
			BaseRaycaster.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664903);
			BaseRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Abstract_Virtual_New_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664904);
			BaseRaycaster.NativeMethodInfoPtr_get_priority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664905);
			BaseRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664906);
			BaseRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664907);
			BaseRaycaster.NativeMethodInfoPtr_get_rootRaycaster_Public_get_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664908);
			BaseRaycaster.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664909);
			BaseRaycaster.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664910);
			BaseRaycaster.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664911);
			BaseRaycaster.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664912);
			BaseRaycaster.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664913);
			BaseRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr, 100664914);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000318E0 File Offset: 0x0002FAE0
		[CallerCount(0)]
		public unsafe virtual void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x00031940 File Offset: 0x0002FB40
		public unsafe virtual Camera eventCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Abstract_Virtual_New_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x0003198C File Offset: 0x0002FB8C
		public unsafe virtual int priority
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_get_priority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000319D4 File Offset: 0x0002FBD4
		public unsafe virtual int sortOrderPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00031A1C File Offset: 0x0002FC1C
		public unsafe virtual int renderOrderPriority
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x00031A64 File Offset: 0x0002FC64
		public unsafe BaseRaycaster rootRaycaster
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 123281, RefRangeEnd = 123283, XrefRangeStart = 123274, XrefRangeEnd = 123281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRaycaster.NativeMethodInfoPtr_get_rootRaycaster_Public_get_BaseRaycaster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseRaycaster>(intPtr3) : null;
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x00031AA4 File Offset: 0x0002FCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123283, XrefRangeEnd = 123311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x00031AE8 File Offset: 0x0002FCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123311, XrefRangeEnd = 123316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00031B24 File Offset: 0x0002FD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123316, XrefRangeEnd = 123321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00031B60 File Offset: 0x0002FD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123321, XrefRangeEnd = 123322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCanvasHierarchyChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00031B9C File Offset: 0x0002FD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseRaycaster.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x00005E47 File Offset: 0x00004047
		public BaseRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00031C14 File Offset: 0x0002FE14
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x00005E50 File Offset: 0x00004050
		public unsafe BaseRaycaster m_RootRaycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRaycaster.NativeFieldInfoPtr_m_RootRaycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseRaycaster.NativeFieldInfoPtr_m_RootRaycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeFieldInfoPtr_m_RootRaycaster;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Abstract_Virtual_New_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Abstract_Virtual_New_get_Camera_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_get_priority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_get_rootRaycaster_Public_get_BaseRaycaster_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_OnCanvasHierarchyChanged_Protected_Virtual_Void_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
