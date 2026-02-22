using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Pool;

namespace UnityEngine.UI
{
	// Token: 0x02000026 RID: 38
	public class LayoutRebuilder : Object
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x00018E28 File Offset: 0x00017028
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutRebuilder()
		{
			Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutRebuilder");
			LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_ToRebuild");
			LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "m_CachedHashFromTransform");
			LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "s_Rebuilders");
			LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663977);
			LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663978);
			LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663980);
			LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663981);
			LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663982);
			LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663983);
			LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663984);
			LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663985);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663986);
			LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663987);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663988);
			LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663989);
			LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663990);
			LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663991);
			LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663992);
			LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663993);
			LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663994);
			LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663995);
			LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, 100663996);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00019008 File Offset: 0x00017208
		[CallerCount(0)]
		public unsafe void Initialize(RectTransform controller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001904C File Offset: 0x0001724C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115170, RefRangeEnd = 115171, XrefRangeStart = 115170, XrefRangeEnd = 115170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00019080 File Offset: 0x00017280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115171, XrefRangeEnd = 115175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReapplyDrivenProperties(RectTransform driven)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driven);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000190B8 File Offset: 0x000172B8
		public unsafe virtual Transform transform
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000190F8 File Offset: 0x000172F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115175, XrefRangeEnd = 115179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00019134 File Offset: 0x00017334
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115198, RefRangeEnd = 115200, XrefRangeStart = 115179, XrefRangeEnd = 115198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StripDisabledBehavioursFromList(List<Component> components)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001916C File Offset: 0x0001736C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 115213, RefRangeEnd = 115215, XrefRangeStart = 115200, XrefRangeEnd = 115213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForceRebuildLayoutImmediate(RectTransform layoutRoot)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000191A4 File Offset: 0x000173A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115270, RefRangeEnd = 115271, XrefRangeStart = 115215, XrefRangeEnd = 115270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Rebuild(CanvasUpdate executing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000191E4 File Offset: 0x000173E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115333, RefRangeEnd = 115336, XrefRangeStart = 115271, XrefRangeEnd = 115333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutControl(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00019238 File Offset: 0x00017438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 115384, RefRangeEnd = 115387, XrefRangeStart = 115336, XrefRangeEnd = 115384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0001928C File Offset: 0x0001748C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 115466, RefRangeEnd = 115482, XrefRangeStart = 115387, XrefRangeEnd = 115466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutForRebuild(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000192C4 File Offset: 0x000174C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115507, RefRangeEnd = 115508, XrefRangeStart = 115482, XrefRangeEnd = 115507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ValidController(RectTransform layoutRoot, List<Component> comps)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layoutRoot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00019318 File Offset: 0x00017518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115508, XrefRangeEnd = 115529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkLayoutRootForRebuild(RectTransform controller)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00019350 File Offset: 0x00017550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115529, XrefRangeEnd = 115537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LayoutComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00019384 File Offset: 0x00017584
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GraphicUpdateComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000193B8 File Offset: 0x000175B8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00019400 File Offset: 0x00017600
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00019458 File Offset: 0x00017658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115537, XrefRangeEnd = 115541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LayoutRebuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001949C File Offset: 0x0001769C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LayoutRebuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000039AD File Offset: 0x00001BAD
		public LayoutRebuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000194D8 File Offset: 0x000176D8
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x000039B6 File Offset: 0x00001BB6
		public unsafe RectTransform m_ToRebuild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_ToRebuild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00019508 File Offset: 0x00017708
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x000039D5 File Offset: 0x00001BD5
		public unsafe int m_CachedHashFromTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LayoutRebuilder.NativeFieldInfoPtr_m_CachedHashFromTransform)) = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00019530 File Offset: 0x00017730
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x000039F0 File Offset: 0x00001BF0
		public unsafe static ObjectPool<LayoutRebuilder> s_Rebuilders
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LayoutRebuilder>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.NativeFieldInfoPtr_s_Rebuilders, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeFieldInfoPtr_m_ToRebuild;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedHashFromTransform;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_s_Rebuilders;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_RectTransform_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_ReapplyDrivenProperties_Private_Static_Void_RectTransform_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_IsDestroyed_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_StripDisabledBehavioursFromList_Private_Static_Void_List_1_Component_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_ForceRebuildLayoutImmediate_Public_Static_Void_RectTransform_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Final_New_Void_CanvasUpdate_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutControl_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_PerformLayoutCalculation_Private_Void_RectTransform_UnityAction_1_Component_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutForRebuild_Public_Static_Void_RectTransform_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_ValidController_Private_Static_Boolean_RectTransform_List_1_Component_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr_MarkLayoutRootForRebuild_Private_Static_Void_RectTransform_0;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeMethodInfoPtr_LayoutComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr_GraphicUpdateComplete_Public_Virtual_Final_New_Void_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200009F RID: 159
		[ObfuscatedName("UnityEngine.UI.LayoutRebuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C16 RID: 3094 RVA: 0x00034F70 File Offset: 0x00033170
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutRebuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr);
				LayoutRebuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__10_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_0");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_1");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_2");
				LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, "<>9__12_3");
				LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665017);
				LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665018);
				LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665019);
				LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665020);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665021);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665022);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665023);
				LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr, 100665024);
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x000350B4 File Offset: 0x000332B4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutRebuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x000350F0 File Offset: 0x000332F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115129, XrefRangeEnd = 115133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LayoutRebuilder __cctor_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LayoutRebuilder>(intPtr3) : null;
			}

			// Token: 0x06000C19 RID: 3097 RVA: 0x00035130 File Offset: 0x00033330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115133, XrefRangeEnd = 115135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__5_1(LayoutRebuilder x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x00035174 File Offset: 0x00033374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115135, XrefRangeEnd = 115138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StripDisabledBehavioursFromList_b__10_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x000351C4 File Offset: 0x000333C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115138, XrefRangeEnd = 115146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_0(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x00035208 File Offset: 0x00033408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115146, XrefRangeEnd = 115154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_1(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x0003524C File Offset: 0x0003344C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115154, XrefRangeEnd = 115162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_2(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C1E RID: 3102 RVA: 0x00035290 File Offset: 0x00033490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115162, XrefRangeEnd = 115170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Rebuild_b__12_3(Component e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutRebuilder.__c.NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x0000675B File Offset: 0x0000495B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x06000C20 RID: 3104 RVA: 0x000352D4 File Offset: 0x000334D4
			// (set) Token: 0x06000C21 RID: 3105 RVA: 0x00006764 File Offset: 0x00004964
			public unsafe static LayoutRebuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutRebuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x06000C22 RID: 3106 RVA: 0x000352FC File Offset: 0x000334FC
			// (set) Token: 0x06000C23 RID: 3107 RVA: 0x00006776 File Offset: 0x00004976
			public unsafe static Predicate<Component> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06000C24 RID: 3108 RVA: 0x00035324 File Offset: 0x00033524
			// (set) Token: 0x06000C25 RID: 3109 RVA: 0x00006788 File Offset: 0x00004988
			public unsafe static UnityAction<Component> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0003534C File Offset: 0x0003354C
			// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0000679A File Offset: 0x0000499A
			public unsafe static UnityAction<Component> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00035374 File Offset: 0x00033574
			// (set) Token: 0x06000C29 RID: 3113 RVA: 0x000067AC File Offset: 0x000049AC
			public unsafe static UnityAction<Component> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0003539C File Offset: 0x0003359C
			// (set) Token: 0x06000C2B RID: 3115 RVA: 0x000067BE File Offset: 0x000049BE
			public unsafe static UnityAction<Component> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Component>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutRebuilder.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400096A RID: 2410
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400096B RID: 2411
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400096C RID: 2412
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x0400096D RID: 2413
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x0400096E RID: 2414
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x0400096F RID: 2415
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04000970 RID: 2416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000971 RID: 2417
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_0_Internal_LayoutRebuilder_0;

			// Token: 0x04000972 RID: 2418
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__5_1_Internal_Void_LayoutRebuilder_0;

			// Token: 0x04000973 RID: 2419
			private static readonly IntPtr NativeMethodInfoPtr__StripDisabledBehavioursFromList_b__10_0_Internal_Boolean_Component_0;

			// Token: 0x04000974 RID: 2420
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_0_Internal_Void_Component_0;

			// Token: 0x04000975 RID: 2421
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_1_Internal_Void_Component_0;

			// Token: 0x04000976 RID: 2422
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_2_Internal_Void_Component_0;

			// Token: 0x04000977 RID: 2423
			private static readonly IntPtr NativeMethodInfoPtr__Rebuild_b__12_3_Internal_Void_Component_0;
		}
	}
}
