using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200004D RID: 77
	public class AbstractEventData : Object
	{
		// Token: 0x060008D2 RID: 2258 RVA: 0x000298C8 File Offset: 0x00027AC8
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractEventData()
		{
			Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "AbstractEventData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr);
			AbstractEventData.NativeFieldInfoPtr_m_Used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, "m_Used");
			AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664600);
			AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664601);
			AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664602);
			AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr, 100664603);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0002995C File Offset: 0x00027B5C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00029998 File Offset: 0x00027B98
		[CallerCount(0)]
		public unsafe virtual void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000299D4 File Offset: 0x00027BD4
		public unsafe virtual bool used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractEventData.NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00029A1C File Offset: 0x00027C1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractEventData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractEventData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractEventData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00005041 File Offset: 0x00003241
		public AbstractEventData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00029A58 File Offset: 0x00027C58
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0000504A File Offset: 0x0000324A
		public unsafe bool m_Used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractEventData.NativeFieldInfoPtr_m_Used)) = value;
			}
		}

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_m_Used;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_Use_Public_Virtual_New_Void_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_get_used_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
