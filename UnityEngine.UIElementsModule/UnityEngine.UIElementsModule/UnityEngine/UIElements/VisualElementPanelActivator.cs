using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000047 RID: 71
	public class VisualElementPanelActivator : Object
	{
		// Token: 0x060004E5 RID: 1253 RVA: 0x0001B230 File Offset: 0x00019430
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementPanelActivator()
		{
			Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementPanelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr);
			VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "m_Activatable");
			VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "<isActive>k__BackingField");
			VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, "<isDetaching>k__BackingField");
			VisualElementPanelActivator.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663668);
			VisualElementPanelActivator.NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663669);
			VisualElementPanelActivator.NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663670);
			VisualElementPanelActivator.NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663671);
			VisualElementPanelActivator.NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663672);
			VisualElementPanelActivator.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663673);
			VisualElementPanelActivator.NativeMethodInfoPtr_SendActivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663674);
			VisualElementPanelActivator.NativeMethodInfoPtr_SendDeactivation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663675);
			VisualElementPanelActivator.NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663676);
			VisualElementPanelActivator.NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr, 100663677);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001B364 File Offset: 0x00019564
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x0001B3A0 File Offset: 0x000195A0
		public unsafe bool isActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001B3E0 File Offset: 0x000195E0
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x0001B41C File Offset: 0x0001961C
		public unsafe bool isDetaching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001B45C File Offset: 0x0001965C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementPanelActivator(IVisualElementPanelActivatable activatable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementPanelActivator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activatable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001B4A8 File Offset: 0x000196A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 93480, RefRangeEnd = 93483, XrefRangeStart = 93450, XrefRangeEnd = 93480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActive(bool action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001B4E8 File Offset: 0x000196E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93488, RefRangeEnd = 93489, XrefRangeStart = 93483, XrefRangeEnd = 93488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendActivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SendActivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001B51C File Offset: 0x0001971C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93494, RefRangeEnd = 93496, XrefRangeStart = 93489, XrefRangeEnd = 93494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDeactivation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_SendDeactivation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001B550 File Offset: 0x00019750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93496, XrefRangeEnd = 93497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnter(AttachToPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001B594 File Offset: 0x00019794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93497, XrefRangeEnd = 93499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLeave(DetachFromPanelEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementPanelActivator.NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000044C9 File Offset: 0x000026C9
		public VisualElementPanelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x0001B5D8 File Offset: 0x000197D8
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000044D2 File Offset: 0x000026D2
		public unsafe IVisualElementPanelActivatable m_Activatable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IVisualElementPanelActivatable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr_m_Activatable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001B608 File Offset: 0x00019808
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000044F1 File Offset: 0x000026F1
		public unsafe bool _isActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001B630 File Offset: 0x00019830
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0000450C File Offset: 0x0000270C
		public unsafe bool _isDetaching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementPanelActivator.NativeFieldInfoPtr__isDetaching_k__BackingField)) = value;
			}
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_m_Activatable;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr__isActive_k__BackingField;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr__isDetaching_k__BackingField;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_set_isActive_Private_set_Void_Boolean_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_get_isDetaching_Public_get_Boolean_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_set_isDetaching_Private_set_Void_Boolean_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IVisualElementPanelActivatable_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_SendActivation_Public_Void_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_SendDeactivation_Public_Void_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_OnEnter_Private_Void_AttachToPanelEvent_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_OnLeave_Private_Void_DetachFromPanelEvent_0;
	}
}
