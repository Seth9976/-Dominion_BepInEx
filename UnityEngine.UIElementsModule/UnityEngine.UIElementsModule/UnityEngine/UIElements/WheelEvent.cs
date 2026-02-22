using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007D RID: 125
	public class WheelEvent : MouseEventBase<WheelEvent>
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x000230B8 File Offset: 0x000212B8
		// Note: this type is marked as 'beforefieldinit'.
		static WheelEvent()
		{
			Il2CppClassPointerStore<WheelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "WheelEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr);
			WheelEvent.NativeFieldInfoPtr__delta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, "<delta>k__BackingField");
			WheelEvent.NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663952);
			WheelEvent.NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663953);
			WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663954);
			WheelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663955);
			WheelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663956);
			WheelEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr, 100663957);
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00005136 File Offset: 0x00003336
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00023174 File Offset: 0x00021374
		public unsafe Vector3 delta
		{
			get
			{
				return this._delta_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000231B4 File Offset: 0x000213B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95469, XrefRangeEnd = 95474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static WheelEvent GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000231F8 File Offset: 0x000213F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95481, RefRangeEnd = 95482, XrefRangeStart = 95474, XrefRangeEnd = 95481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mousePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WheelEvent>(intPtr3) : null;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00023248 File Offset: 0x00021448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95482, XrefRangeEnd = 95486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WheelEvent.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00023284 File Offset: 0x00021484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95486, XrefRangeEnd = 95487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000232B8 File Offset: 0x000214B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95487, XrefRangeEnd = 95491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00005112 File Offset: 0x00003312
		public WheelEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000232F4 File Offset: 0x000214F4
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0000511B File Offset: 0x0000331B
		public unsafe Vector3 _delta_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelEvent.NativeFieldInfoPtr__delta_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelEvent.NativeFieldInfoPtr__delta_k__BackingField)) = value;
			}
		}

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr__delta_k__BackingField;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_set_delta_Private_set_Void_Vector3_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_WheelEvent_Event_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Internal_Static_WheelEvent_Vector3_Vector3_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
