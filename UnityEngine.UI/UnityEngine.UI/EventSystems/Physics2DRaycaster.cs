using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000070 RID: 112
	public class Physics2DRaycaster : PhysicsRaycaster
	{
		// Token: 0x06000B08 RID: 2824 RVA: 0x00031C44 File Offset: 0x0002FE44
		// Note: this type is marked as 'beforefieldinit'.
		static Physics2DRaycaster()
		{
			Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "Physics2DRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr);
			Physics2DRaycaster.NativeFieldInfoPtr_m_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, "m_Hits");
			Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100664915);
			Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr, 100664916);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123322, XrefRangeEnd = 123324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Physics2DRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Physics2DRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Physics2DRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00031CEC File Offset: 0x0002FEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123324, XrefRangeEnd = 123380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Physics2DRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00005E6F File Offset: 0x0000406F
		public Physics2DRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x00031D4C File Offset: 0x0002FF4C
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x00005E78 File Offset: 0x00004078
		public new unsafe Il2CppStructArray<RaycastHit2D> m_Hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Physics2DRaycaster.NativeFieldInfoPtr_m_Hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeFieldInfoPtr_m_Hits;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;
	}
}
