using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000012 RID: 18
	public class GraphicRaycaster : BaseRaycaster
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0000D698 File Offset: 0x0000B898
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRaycaster()
		{
			Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRaycaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr);
			GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "kNoEventMaskSet");
			GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_IgnoreReversedGraphics");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingObjects");
			GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_BlockingMask");
			GraphicRaycaster.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_Canvas");
			GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "m_RaycastResults");
			GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "s_SortedGraphics");
			GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663535);
			GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663536);
			GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663537);
			GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663538);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663539);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663540);
			GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663541);
			GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663542);
			GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663543);
			GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663544);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663545);
			GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663546);
			GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, 100663547);
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000D858 File Offset: 0x0000BA58
		public unsafe override int sortOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111159, XrefRangeEnd = 111161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public unsafe override int renderOrderPriority
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111161, XrefRangeEnd = 111163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000D924 File Offset: 0x0000BB24
		public unsafe bool ignoreReversedGraphics
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000D964 File Offset: 0x0000BB64
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		public unsafe GraphicRaycaster.BlockingObjects blockingObjects
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000DA1C File Offset: 0x0000BC1C
		public unsafe LayerMask blockingMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111163, XrefRangeEnd = 111171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRaycaster()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000DA98 File Offset: 0x0000BC98
		public unsafe Canvas canvas
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 111178, RefRangeEnd = 111190, XrefRangeStart = 111171, XrefRangeEnd = 111178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111190, XrefRangeEnd = 111335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000DB38 File Offset: 0x0000BD38
		public unsafe override Camera eventCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111335, XrefRangeEnd = 111344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GraphicRaycaster.NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000DB84 File Offset: 0x0000BD84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111414, RefRangeEnd = 111415, XrefRangeStart = 111344, XrefRangeEnd = 111414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventCamera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointerPosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foundGraphics);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000029B8 File Offset: 0x00000BB8
		public GraphicRaycaster(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000DC00 File Offset: 0x0000BE00
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x000029C1 File Offset: 0x00000BC1
		public unsafe static int kNoEventMaskSet
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_kNoEventMaskSet, (void*)(&value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000029CF File Offset: 0x00000BCF
		public unsafe bool m_IgnoreReversedGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_IgnoreReversedGraphics)) = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000DC44 File Offset: 0x0000BE44
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x000029EA File Offset: 0x00000BEA
		public unsafe GraphicRaycaster.BlockingObjects m_BlockingObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingObjects)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002A05 File Offset: 0x00000C05
		public unsafe LayerMask m_BlockingMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_BlockingMask)) = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000DC94 File Offset: 0x0000BE94
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002A20 File Offset: 0x00000C20
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00002A3F File Offset: 0x00000C3F
		public unsafe List<Graphic> m_RaycastResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRaycaster.NativeFieldInfoPtr_m_RaycastResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00002A5E File Offset: 0x00000C5E
		public unsafe static List<Graphic> s_SortedGraphics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.NativeFieldInfoPtr_s_SortedGraphics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_kNoEventMaskSet;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreReversedGraphics;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingObjects;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_m_BlockingMask;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastResults;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_s_SortedGraphics;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_get_sortOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_renderOrderPriority_Public_Virtual_get_Int32_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreReversedGraphics_Public_get_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreReversedGraphics_Public_set_Void_Boolean_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingObjects_Public_get_BlockingObjects_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingObjects_Public_set_Void_BlockingObjects_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_get_blockingMask_Public_get_LayerMask_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_set_blockingMask_Public_set_Void_LayerMask_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_Canvas_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_get_eventCamera_Public_Virtual_get_Camera_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_Static_Void_Canvas_Camera_Vector2_IList_1_Graphic_List_1_Graphic_0;

		// Token: 0x02000081 RID: 129
		public enum BlockingObjects
		{
			// Token: 0x040008DD RID: 2269
			None,
			// Token: 0x040008DE RID: 2270
			TwoD,
			// Token: 0x040008DF RID: 2271
			ThreeD,
			// Token: 0x040008E0 RID: 2272
			All
		}

		// Token: 0x02000082 RID: 130
		[ObfuscatedName("UnityEngine.UI.GraphicRaycaster+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000BCF RID: 3023 RVA: 0x00034220 File Offset: 0x00032420
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicRaycaster>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr);
				GraphicRaycaster.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9");
				GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, "<>9__27_0");
				GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100664989);
				GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr, 100664990);
			}

			// Token: 0x06000BD0 RID: 3024 RVA: 0x0003429C File Offset: 0x0003249C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRaycaster.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BD1 RID: 3025 RVA: 0x000342D8 File Offset: 0x000324D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111156, XrefRangeEnd = 111159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Raycast_b__27_0(Graphic g1, Graphic g2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRaycaster.__c.NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000BD2 RID: 3026 RVA: 0x00006502 File Offset: 0x00004702
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00034338 File Offset: 0x00032538
			// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0000650B File Offset: 0x0000470B
			public unsafe static GraphicRaycaster.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x00034360 File Offset: 0x00032560
			// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0000651D File Offset: 0x0000471D
			public unsafe static Comparison<Graphic> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<Graphic>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GraphicRaycaster.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008E1 RID: 2273
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040008E2 RID: 2274
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040008E3 RID: 2275
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040008E4 RID: 2276
			private static readonly IntPtr NativeMethodInfoPtr__Raycast_b__27_0_Internal_Int32_Graphic_Graphic_0;
		}
	}
}
