using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace TMPro
{
	// Token: 0x02000071 RID: 113
	public class TMP_UpdateManager : Object
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x00039BD0 File Offset: 0x00037DD0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_UpdateManager()
		{
			Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr);
			TMP_UpdateManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "s_Instance");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicQueueLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicRebuildQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateLookup");
			TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateQueue");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForCullingUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextObjectForUpdateMarker");
			TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextElementForGraphicRebuildMarker");
			TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664755);
			TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664756);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664757);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664758);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664759);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664760);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664761);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664762);
			TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664763);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664764);
			TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664765);
			TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664766);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664767);
			TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664768);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664769);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664770);
			TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100664771);
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00039E6C File Offset: 0x0003806C
		public unsafe static TMP_UpdateManager instance
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 149426, RefRangeEnd = 149437, XrefRangeStart = 149371, XrefRangeEnd = 149426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr3) : null;
			}
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00039EA0 File Offset: 0x000380A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149437, XrefRangeEnd = 149481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_UpdateManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00039EDC File Offset: 0x000380DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149495, RefRangeEnd = 149498, XrefRangeStart = 149481, XrefRangeEnd = 149495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00039F14 File Offset: 0x00038114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149498, XrefRangeEnd = 149508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00039F58 File Offset: 0x00038158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149508, XrefRangeEnd = 149522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00039F90 File Offset: 0x00038190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149522, XrefRangeEnd = 149532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00039FD4 File Offset: 0x000381D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149532, XrefRangeEnd = 149546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x0003A00C File Offset: 0x0003820C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149546, XrefRangeEnd = 149556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0003A050 File Offset: 0x00038250
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149570, RefRangeEnd = 149571, XrefRangeStart = 149556, XrefRangeEnd = 149570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterTextElementForCullingUpdate(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0003A088 File Offset: 0x00038288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149571, XrefRangeEnd = 149581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0003A0CC File Offset: 0x000382CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149581, XrefRangeEnd = 149582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCameraPreCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0003A100 File Offset: 0x00038300
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149606, RefRangeEnd = 149607, XrefRangeStart = 149582, XrefRangeEnd = 149606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoRebuilds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_DoRebuilds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0003A134 File Offset: 0x00038334
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 149640, RefRangeEnd = 149646, XrefRangeStart = 149607, XrefRangeEnd = 149640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003A16C File Offset: 0x0003836C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149674, RefRangeEnd = 149676, XrefRangeStart = 149646, XrefRangeEnd = 149674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnRegisterTextElementForRebuild(TMP_Text element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0003A1A4 File Offset: 0x000383A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149676, XrefRangeEnd = 149684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003A1E8 File Offset: 0x000383E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149684, XrefRangeEnd = 149692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003A22C File Offset: 0x0003842C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149692, XrefRangeEnd = 149700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_UpdateManager.NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00008ACD File Offset: 0x00006CCD
		public TMP_UpdateManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0003A270 File Offset: 0x00038470
		// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00008AD6 File Offset: 0x00006CD6
		public unsafe static TMP_UpdateManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003A298 File Offset: 0x00038498
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public unsafe HashSet<int> m_LayoutQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0003A2C8 File Offset: 0x000384C8
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00008B07 File Offset: 0x00006D07
		public unsafe List<TMP_Text> m_LayoutRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_LayoutRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003A2F8 File Offset: 0x000384F8
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00008B26 File Offset: 0x00006D26
		public unsafe HashSet<int> m_GraphicQueueLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicQueueLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003A328 File Offset: 0x00038528
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00008B45 File Offset: 0x00006D45
		public unsafe List<TMP_Text> m_GraphicRebuildQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_GraphicRebuildQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003A358 File Offset: 0x00038558
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00008B64 File Offset: 0x00006D64
		public unsafe HashSet<int> m_InternalUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003A388 File Offset: 0x00038588
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00008B83 File Offset: 0x00006D83
		public unsafe List<TMP_Text> m_InternalUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_InternalUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003A3B8 File Offset: 0x000385B8
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00008BA2 File Offset: 0x00006DA2
		public unsafe HashSet<int> m_CullingUpdateLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003A3E8 File Offset: 0x000385E8
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x00008BC1 File Offset: 0x00006DC1
		public unsafe List<TMP_Text> m_CullingUpdateQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_UpdateManager.NativeFieldInfoPtr_m_CullingUpdateQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0003A418 File Offset: 0x00038618
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x00008BE0 File Offset: 0x00006DE0
		public unsafe static ProfilerMarker k_RegisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003A434 File Offset: 0x00038634
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x00008BEE File Offset: 0x00006DEE
		public unsafe static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003A450 File Offset: 0x00038650
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x00008BFC File Offset: 0x00006DFC
		public unsafe static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003A46C File Offset: 0x0003866C
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x00008C0A File Offset: 0x00006E0A
		public unsafe static ProfilerMarker k_UnregisterTextObjectForUpdateMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003A488 File Offset: 0x00038688
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x00008C18 File Offset: 0x00006E18
		public unsafe static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_UpdateManager.NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&value));
			}
		}

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateLookup;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalUpdateQueue;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateLookup;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_m_CullingUpdateQueue;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_DoRebuilds_Private_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;
	}
}
