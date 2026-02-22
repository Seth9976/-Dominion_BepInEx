using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	public class GraphicRegistry : Object
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0000DD1C File Offset: 0x0000BF1C
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicRegistry()
		{
			Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "GraphicRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr);
			GraphicRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_Instance");
			GraphicRegistry.NativeFieldInfoPtr_m_Graphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_Graphics");
			GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "m_RaycastableGraphics");
			GraphicRegistry.NativeFieldInfoPtr_s_EmptyList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, "s_EmptyList");
			GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663549);
			GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663550);
			GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663551);
			GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663552);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663553);
			GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663554);
			GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663555);
			GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr, 100663556);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000DE3C File Offset: 0x0000C03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111415, XrefRangeEnd = 111450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000DE78 File Offset: 0x0000C078
		public unsafe static GraphicRegistry instance
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 111496, RefRangeEnd = 111507, XrefRangeStart = 111450, XrefRangeEnd = 111496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111538, RefRangeEnd = 111542, XrefRangeStart = 111507, XrefRangeEnd = 111538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111572, RefRangeEnd = 111574, XrefRangeStart = 111542, XrefRangeEnd = 111572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000DF3C File Offset: 0x0000C13C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 111600, RefRangeEnd = 111605, XrefRangeStart = 111574, XrefRangeEnd = 111600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000DF84 File Offset: 0x0000C184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111628, RefRangeEnd = 111630, XrefRangeStart = 111605, XrefRangeEnd = 111628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graphic);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000DFCC File Offset: 0x0000C1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111630, XrefRangeEnd = 111640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000E010 File Offset: 0x0000C210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111640, XrefRangeEnd = 111650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicRegistry.NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Graphic>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002A70 File Offset: 0x00000C70
		public GraphicRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000E054 File Offset: 0x0000C254
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002A79 File Offset: 0x00000C79
		public unsafe static GraphicRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000E07C File Offset: 0x0000C27C
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00002A8B File Offset: 0x00000C8B
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_Graphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00002AAA File Offset: 0x00000CAA
		public unsafe Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Canvas, IndexedSet<Graphic>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicRegistry.NativeFieldInfoPtr_m_RaycastableGraphics), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000E0DC File Offset: 0x0000C2DC
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00002AC9 File Offset: 0x00000CC9
		public unsafe static List<Graphic> s_EmptyList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Graphic>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GraphicRegistry.NativeFieldInfoPtr_s_EmptyList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_m_Graphics;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_m_RaycastableGraphics;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyList;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_GraphicRegistry_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_RegisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterRaycastGraphicForCanvas_Public_Static_Void_Canvas_Graphic_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_GetGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_GetRaycastableGraphicsForCanvas_Public_Static_IList_1_Graphic_Canvas_0;
	}
}
