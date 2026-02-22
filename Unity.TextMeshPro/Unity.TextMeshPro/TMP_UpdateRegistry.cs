using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000072 RID: 114
	public class TMP_UpdateRegistry : Object
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x0003A4A4 File Offset: 0x000386A4
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UpdateRegistry()
		{
			Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr);
			TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "s_Instance");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_LayoutQueueLookup");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
			TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, "m_GraphicQueueLookup");
			TMP_UpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664773);
			TMP_UpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664774);
			TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664775);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664776);
			TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664777);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664778);
			TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664779);
			TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664780);
			TMP_UpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664781);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664782);
			TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr, 100664783);
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003A614 File Offset: 0x00038814
		public unsafe static TMP_UpdateRegistry instance
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 149733, RefRangeEnd = 149743, XrefRangeStart = 149700, XrefRangeEnd = 149733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_UpdateRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003A648 File Offset: 0x00038848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149743, XrefRangeEnd = 149771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UpdateRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0003A684 File Offset: 0x00038884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149771, XrefRangeEnd = 149784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0003A6BC File Offset: 0x000388BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149784, XrefRangeEnd = 149796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0003A70C File Offset: 0x0003890C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149796, XrefRangeEnd = 149809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0003A744 File Offset: 0x00038944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149809, XrefRangeEnd = 149821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0003A794 File Offset: 0x00038994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149821, XrefRangeEnd = 149846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdateForCanvasRendererObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003A7C8 File Offset: 0x000389C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149846, XrefRangeEnd = 149852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdateForMeshRendererObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0003A7FC File Offset: 0x000389FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149852, XrefRangeEnd = 149875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003A834 File Offset: 0x00038A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149875, XrefRangeEnd = 149886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003A878 File Offset: 0x00038A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149886, XrefRangeEnd = 149897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00008C26 File Offset: 0x00006E26
		public TMP_UpdateRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0003A8BC File Offset: 0x00038ABC
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00008C2F File Offset: 0x00006E2F
		public unsafe static TMP_UpdateRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_UpdateRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003A8E4 File Offset: 0x00038AE4
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00008C41 File Offset: 0x00006E41
		public unsafe List<ICanvasElement> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003A914 File Offset: 0x00038B14
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00008C60 File Offset: 0x00006E60
		public unsafe HashSet<int> m_LayoutQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_LayoutQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003A944 File Offset: 0x00038B44
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00008C7F File Offset: 0x00006E7F
		public unsafe List<ICanvasElement> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003A974 File Offset: 0x00038B74
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00008C9E File Offset: 0x00006E9E
		public unsafe HashSet<int> m_GraphicQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateRegistry.NativeFieldInfoPtr_m_GraphicQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_TMP_UpdateRegistry_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdateForCanvasRendererObjects_Private_Void_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdateForMeshRendererObjects_Private_Void_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;
	}
}
