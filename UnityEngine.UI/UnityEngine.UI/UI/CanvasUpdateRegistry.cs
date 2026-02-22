using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000006 RID: 6
	public class CanvasUpdateRegistry : Object
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00007C54 File Offset: 0x00005E54
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasUpdateRegistry()
		{
			Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasUpdateRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr);
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_Instance");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingLayoutUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingGraphicUpdate");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CanvasUpdateProfilerStrings");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CullingUpdateProfilerString");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
			CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_SortLayoutFunction");
			CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663320);
			CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663321);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663322);
			CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663323);
			CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663324);
			CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663325);
			CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663326);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663327);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663328);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663329);
			CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663330);
			CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663331);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663332);
			CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663333);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663334);
			CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663335);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663336);
			CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663337);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007E8C File Offset: 0x0000608C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108106, RefRangeEnd = 108107, XrefRangeStart = 108044, XrefRangeEnd = 108106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasUpdateRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00007EC8 File Offset: 0x000060C8
		public unsafe static CanvasUpdateRegistry instance
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 108119, RefRangeEnd = 108132, XrefRangeStart = 108107, XrefRangeEnd = 108119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr3) : null;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007EFC File Offset: 0x000060FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108138, RefRangeEnd = 108140, XrefRangeStart = 108132, XrefRangeEnd = 108138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ObjectValidForUpdate(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00007F4C File Offset: 0x0000614C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108170, RefRangeEnd = 108171, XrefRangeStart = 108140, XrefRangeEnd = 108170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanInvalidItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00007F80 File Offset: 0x00006180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108171, XrefRangeEnd = 108258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_PerformUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00007FB4 File Offset: 0x000061B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108268, RefRangeEnd = 108270, XrefRangeStart = 108258, XrefRangeEnd = 108268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ParentCount(Transform child)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00007FF8 File Offset: 0x000061F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108270, XrefRangeEnd = 108280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SortLayoutList(ICanvasElement x, ICanvasElement y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000804C File Offset: 0x0000624C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108286, RefRangeEnd = 108289, XrefRangeStart = 108280, XrefRangeEnd = 108286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00008084 File Offset: 0x00006284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108295, RefRangeEnd = 108297, XrefRangeStart = 108289, XrefRangeEnd = 108295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000080C8 File Offset: 0x000062C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108303, RefRangeEnd = 108305, XrefRangeStart = 108297, XrefRangeEnd = 108303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00008118 File Offset: 0x00006318
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 108311, RefRangeEnd = 108332, XrefRangeStart = 108305, XrefRangeEnd = 108311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00008150 File Offset: 0x00006350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108332, XrefRangeEnd = 108338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00008194 File Offset: 0x00006394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108348, RefRangeEnd = 108350, XrefRangeStart = 108338, XrefRangeEnd = 108348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000081E4 File Offset: 0x000063E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 108401, RefRangeEnd = 108406, XrefRangeStart = 108350, XrefRangeEnd = 108401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000821C File Offset: 0x0000641C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108406, XrefRangeEnd = 108424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00008260 File Offset: 0x00006460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108424, XrefRangeEnd = 108442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000082A4 File Offset: 0x000064A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108446, RefRangeEnd = 108450, XrefRangeStart = 108442, XrefRangeEnd = 108446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingLayout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000082D4 File Offset: 0x000064D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108454, RefRangeEnd = 108457, XrefRangeStart = 108450, XrefRangeEnd = 108454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRebuildingGraphics()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasUpdateRegistry.NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000217F File Offset: 0x0000037F
		public CanvasUpdateRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00008304 File Offset: 0x00006504
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe static CanvasUpdateRegistry s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000832C File Offset: 0x0000652C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000219A File Offset: 0x0000039A
		public unsafe bool m_PerformingLayoutUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingLayoutUpdate)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00008354 File Offset: 0x00006554
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000021B5 File Offset: 0x000003B5
		public unsafe bool m_PerformingGraphicUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_PerformingGraphicUpdate)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000837C File Offset: 0x0000657C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000021D0 File Offset: 0x000003D0
		public unsafe Il2CppStringArray m_CanvasUpdateProfilerStrings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000083AC File Offset: 0x000065AC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe static string m_CullingUpdateProfilerString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_m_CullingUpdateProfilerString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000052 RID: 82 RVA: 0x000083CC File Offset: 0x000065CC
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002201 File Offset: 0x00000401
		public unsafe IndexedSet<ICanvasElement> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000083FC File Offset: 0x000065FC
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002220 File Offset: 0x00000420
		public unsafe IndexedSet<ICanvasElement> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasUpdateRegistry.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000842C File Offset: 0x0000662C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000223F File Offset: 0x0000043F
		public unsafe static Comparison<ICanvasElement> s_SortLayoutFunction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ICanvasElement>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasUpdateRegistry.NativeFieldInfoPtr_s_SortLayoutFunction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingLayoutUpdate;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_m_PerformingGraphicUpdate;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateProfilerString;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_s_SortLayoutFunction;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_PerformUpdate_Private_Void_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0;
	}
}
