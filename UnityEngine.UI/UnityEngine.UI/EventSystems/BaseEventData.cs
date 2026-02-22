using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004E RID: 78
	public class BaseEventData : AbstractEventData
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00029A80 File Offset: 0x00027C80
		// Note: this type is marked as 'beforefieldinit'.
		static BaseEventData()
		{
			Il2CppClassPointerStore<BaseEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "BaseEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr);
			BaseEventData.NativeFieldInfoPtr_m_EventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, "m_EventSystem");
			BaseEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664604);
			BaseEventData.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664605);
			BaseEventData.NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664606);
			BaseEventData.NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr, 100664607);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00029B14 File Offset: 0x00027D14
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseEventData(EventSystem eventSystem)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseEventData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventSystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x00029B60 File Offset: 0x00027D60
		public unsafe BaseInputModule currentInputModule
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BaseInputModule>(intPtr3) : null;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00029BA0 File Offset: 0x00027DA0
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00029BE0 File Offset: 0x00027DE0
		public unsafe GameObject selectedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 120914, RefRangeEnd = 120916, XrefRangeStart = 120912, XrefRangeEnd = 120914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseEventData.NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00005065 File Offset: 0x00003265
		public BaseEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x00029C24 File Offset: 0x00027E24
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0000506E File Offset: 0x0000326E
		public unsafe EventSystem m_EventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseEventData.NativeFieldInfoPtr_m_EventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseEventData.NativeFieldInfoPtr_m_EventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_m_EventSystem;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_currentInputModule_Public_get_BaseInputModule_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedObject_Public_get_GameObject_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedObject_Public_set_Void_GameObject_0;
	}
}
