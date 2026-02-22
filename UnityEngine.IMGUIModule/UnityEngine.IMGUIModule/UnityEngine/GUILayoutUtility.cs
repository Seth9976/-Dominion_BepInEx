using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public class GUILayoutUtility : Object
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000B394 File Offset: 0x00009594
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutUtility()
		{
			Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr);
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredLayouts");
			GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_StoredWindows");
			GUILayoutUtility.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "current");
			GUILayoutUtility.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "kDummyRect");
			GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "s_SpaceStyle");
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663459);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663460);
			GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663461);
			GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663462);
			GUILayoutUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663463);
			GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663464);
			GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663465);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663466);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663467);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663468);
			GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663469);
			GUILayoutUtility.NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663470);
			GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663471);
			GUILayoutUtility.NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663472);
			GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663473);
			GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663474);
			GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663475);
			GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663476);
			GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663477);
			GUILayoutUtility.NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663478);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663480);
			GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, 100663481);
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField = IL2CPP.ResolveICall<GUILayoutUtility.GetWindowsBounds_InjectedDelegate>("UnityEngine.GUILayoutUtility::GetWindowsBounds_Injected");
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000B5F0 File Offset: 0x000097F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86181, XrefRangeEnd = 86186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect Internal_GetWindowRect(int windowID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000B630 File Offset: 0x00009830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86186, XrefRangeEnd = 86191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow(int windowID, Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B670 File Offset: 0x00009870
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 86213, RefRangeEnd = 86218, XrefRangeStart = 86191, XrefRangeEnd = 86213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWindow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr3) : null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000B6C0 File Offset: 0x000098C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86232, RefRangeEnd = 86233, XrefRangeStart = 86218, XrefRangeEnd = 86232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Begin(int instanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000B6F4 File Offset: 0x000098F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86250, RefRangeEnd = 86251, XrefRangeStart = 86233, XrefRangeEnd = 86250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContainer(GUILayoutUtility.LayoutCache cache)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000B72C File Offset: 0x0000992C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86265, RefRangeEnd = 86266, XrefRangeStart = 86251, XrefRangeEnd = 86265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginWindow(int windowID, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000B784 File Offset: 0x00009984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86275, RefRangeEnd = 86277, XrefRangeStart = 86266, XrefRangeEnd = 86275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Layout()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Layout_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000B7AC File Offset: 0x000099AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86287, RefRangeEnd = 86288, XrefRangeStart = 86277, XrefRangeEnd = 86287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFromEditorWindow()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000B7D4 File Offset: 0x000099D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86298, RefRangeEnd = 86299, XrefRangeStart = 86288, XrefRangeEnd = 86298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFromContainer(float w, float h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref w;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000B814 File Offset: 0x00009A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86344, RefRangeEnd = 86345, XrefRangeStart = 86299, XrefRangeEnd = 86344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutFreeGroup(GUILayoutGroup toplevel)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toplevel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000B84C File Offset: 0x00009A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86365, RefRangeEnd = 86366, XrefRangeStart = 86345, XrefRangeEnd = 86365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LayoutSingleGroup(GUILayoutGroup i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B884 File Offset: 0x00009A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86375, RefRangeEnd = 86377, XrefRangeStart = 86366, XrefRangeEnd = 86375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(LayoutType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 86402, RefRangeEnd = 86407, XrefRangeStart = 86377, XrefRangeEnd = 86402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup BeginLayoutGroup(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options, Type layoutType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layoutType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000B930 File Offset: 0x00009B30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 86424, RefRangeEnd = 86428, XrefRangeStart = 86407, XrefRangeEnd = 86424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndLayoutGroup()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B958 File Offset: 0x00009B58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86451, RefRangeEnd = 86452, XrefRangeStart = 86428, XrefRangeEnd = 86451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layoutType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr3) : null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000B9B0 File Offset: 0x00009BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86452, XrefRangeEnd = 86456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000BA24 File Offset: 0x00009C24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 86516, RefRangeEnd = 86521, XrefRangeStart = 86456, XrefRangeEnd = 86516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoGetRect(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000BA8C File Offset: 0x00009C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86521, XrefRangeEnd = 86525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect GetRect(float width, float height, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
		{
			if (options == null)
			{
				options = new Il2CppReferenceArray<GUILayoutOption>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000BB08 File Offset: 0x00009D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86549, RefRangeEnd = 86551, XrefRangeStart = 86525, XrefRangeEnd = 86549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000BB98 File Offset: 0x00009D98
		public unsafe static GUIStyle spaceStyle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86551, XrefRangeEnd = 86568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000BBCC File Offset: 0x00009DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86568, XrefRangeEnd = 86570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_GetWindowRect_Injected(int windowID, out Rect ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000BC0C File Offset: 0x00009E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86570, XrefRangeEnd = 86572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_MoveWindow_Injected(int windowID, ref Rect r)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref windowID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002FCD File Offset: 0x000011CD
		public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002FDC File Offset: 0x000011DC
		public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002FEC File Offset: 0x000011EC
		public GUILayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000BC4C File Offset: 0x00009E4C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002FF5 File Offset: 0x000011F5
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredLayouts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000BC74 File Offset: 0x00009E74
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003007 File Offset: 0x00001207
		public unsafe static Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GUILayoutUtility.LayoutCache>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_StoredWindows, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000BC9C File Offset: 0x00009E9C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00003019 File Offset: 0x00001219
		public unsafe static GUILayoutUtility.LayoutCache current
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_current, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutUtility.LayoutCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000302B File Offset: 0x0000122B
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00003039 File Offset: 0x00001239
		public unsafe static GUIStyle s_SpaceStyle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutUtility.NativeFieldInfoPtr_s_SpaceStyle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000BD08 File Offset: 0x00009F08
		public static Rect GetWindowsBounds()
		{
			Rect rect;
			GUILayoutUtility.GetWindowsBounds_Injected(out rect);
			return rect;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000304B File Offset: 0x0000124B
		public static void CleanupRoots()
		{
			GUILayoutUtility.s_SpaceStyle = null;
			GUILayoutUtility.s_StoredLayouts.Clear();
			GUILayoutUtility.s_StoredWindows.Clear();
			GUILayoutUtility.current = new GUILayoutUtility.LayoutCache(-1);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003075 File Offset: 0x00001275
		public static void BeginGroup(string GroupName)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003078 File Offset: 0x00001278
		public static void EndGroup(string groupName)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000BD20 File Offset: 0x00009F20
		public static float LayoutFromInspector(float width)
		{
			bool flag = GUILayoutUtility.current.topLevel != null && GUILayoutUtility.current.topLevel.windowID == -1;
			float num;
			if (flag)
			{
				GUILayoutUtility.current.topLevel.CalcWidth();
				GUILayoutUtility.current.topLevel.SetHorizontal(0f, width);
				GUILayoutUtility.current.topLevel.CalcHeight();
				GUILayoutUtility.current.topLevel.SetVertical(0f, Mathf.Min((float)Screen.height / GUIUtility.pixelsPerPoint, GUILayoutUtility.current.topLevel.maxHeight));
				float minHeight = GUILayoutUtility.current.topLevel.minHeight;
				GUILayoutUtility.LayoutFreeGroup(GUILayoutUtility.current.windows);
				num = minHeight;
			}
			else
			{
				bool flag2 = GUILayoutUtility.current.topLevel != null;
				if (flag2)
				{
					GUILayoutUtility.LayoutSingleGroup(GUILayoutUtility.current.topLevel);
				}
				num = 0f;
			}
			return num;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000BE10 File Offset: 0x0000A010
		public static GUILayoutGroup DoBeginLayoutArea(GUIStyle style, Type layoutType)
		{
			return GUILayoutUtility.BeginLayoutArea(style, layoutType);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000307B File Offset: 0x0000127B
		public static GUILayoutGroup topLevel
		{
			get
			{
				return GUILayoutUtility.current.topLevel;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000BE2C File Offset: 0x0000A02C
		public static Rect GetRect(GUIContent content, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(content, style, null);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000BE48 File Offset: 0x0000A048
		public static Rect GetRect(float width, float height)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, null);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000BE6C File Offset: 0x0000A06C
		public static Rect GetRect(float width, float height, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, style, null);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000BE8C File Offset: 0x0000A08C
		public static Rect GetRect(float width, float height, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(width, width, height, height, GUIStyle.none, options);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00003087 File Offset: 0x00001287
		public static Rect GetRect(float width, float height, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(width, height, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, null);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, null);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, GUIStyle.none, options);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003096 File Offset: 0x00001296
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000BF18 File Offset: 0x0000A118
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetRect(minWidth, maxWidth, minHeight, maxHeight, style, options);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000030A8 File Offset: 0x000012A8
		public static Rect GetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetRect(minWidth, maxWidth, minHeight, maxHeight, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000BF38 File Offset: 0x0000A138
		public static Rect GetLastRect()
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout && eventType != EventType.Used)
			{
				rect = GUILayoutUtility.current.topLevel.GetLast();
			}
			else
			{
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000BF7C File Offset: 0x0000A17C
		public static Rect GetAspectRect(float aspect)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000BF98 File Offset: 0x0000A198
		public static Rect GetAspectRect(float aspect, GUIStyle style)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, null);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		public static Rect GetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000030BC File Offset: 0x000012BC
		public static Rect GetAspectRect(float aspect, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		public static Rect GetAspectRect(float aspect, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			return GUILayoutUtility.DoGetAspectRect(aspect, options);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000030CA File Offset: 0x000012CA
		public static Rect GetAspectRect(float aspect, GUIStyle style, params GUILayoutOption[] options)
		{
			return GUILayoutUtility.GetAspectRect(aspect, style, new Il2CppReferenceArray<GUILayoutOption>(options));
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public static Rect DoGetAspectRect(float aspect, Il2CppReferenceArray<GUILayoutOption> options)
		{
			EventType type = Event.current.type;
			EventType eventType = type;
			Rect rect;
			if (eventType != EventType.Layout)
			{
				if (eventType != EventType.Used)
				{
					rect = GUILayoutUtility.current.topLevel.GetNext().rect;
				}
				else
				{
					rect = GUILayoutUtility.kDummyRect;
				}
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIAspectSizer(aspect, options));
				rect = GUILayoutUtility.kDummyRect;
			}
			return rect;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000030D9 File Offset: 0x000012D9
		public static void GetWindowsBounds_Injected(out Rect ret)
		{
			GUILayoutUtility.GetWindowsBounds_InjectedDelegateField(out ret);
		}

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredLayouts;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeFieldInfoPtr_s_StoredWindows;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeFieldInfoPtr_current;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeFieldInfoPtr_s_SpaceStyle;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Private_Static_Rect_Int32_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Private_Static_Void_Int32_Rect_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_SelectIDList_Internal_Static_LayoutCache_Int32_Boolean_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Internal_Static_Void_Int32_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_LayoutCache_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_BeginWindow_Internal_Static_Void_Int32_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_Layout_Internal_Static_Void_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFromEditorWindow_Internal_Static_Void_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFromContainer_Internal_Static_Void_Single_Single_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_LayoutFreeGroup_Internal_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_LayoutSingleGroup_Private_Static_Void_GUILayoutGroup_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_CreateGUILayoutGroupInstanceOfType_Private_Static_GUILayoutGroup_Type_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_BeginLayoutGroup_Internal_Static_GUILayoutGroup_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_Type_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_EndLayoutGroup_Internal_Static_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_BeginLayoutArea_Internal_Static_GUILayoutGroup_GUIStyle_Type_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_GetRect_Public_Static_Rect_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_DoGetRect_Private_Static_Rect_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_get_spaceStyle_Internal_Static_get_GUIStyle_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_Internal_GetWindowRect_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Internal_MoveWindow_Injected_Private_Static_Void_Int32_byref_Rect_0;

		// Token: 0x04000143 RID: 323
		private static readonly GUILayoutUtility.GetWindowsBounds_InjectedDelegate GetWindowsBounds_InjectedDelegateField;

		// Token: 0x02000068 RID: 104
		public sealed class LayoutCache : Object
		{
			// Token: 0x0600068E RID: 1678 RVA: 0x00017020 File Offset: 0x00015220
			// Note: this type is marked as 'beforefieldinit'.
			static LayoutCache()
			{
				Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUILayoutUtility>.NativeClassPtr, "LayoutCache");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr);
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "<id>k__BackingField");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "topLevel");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "layoutGroups");
				GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, "windows");
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663482);
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663483);
				GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_ResetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr, 100663484);
			}

			// Token: 0x17000161 RID: 353
			// (set) Token: 0x0600068F RID: 1679 RVA: 0x000170D8 File Offset: 0x000152D8
			public unsafe int id
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 21534, RefRangeEnd = 21538, XrefRangeStart = 21534, XrefRangeEnd = 21538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x00017118 File Offset: 0x00015318
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86154, RefRangeEnd = 86158, XrefRangeStart = 86141, XrefRangeEnd = 86154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LayoutCache(int instanceID = -1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutUtility.LayoutCache>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instanceID;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x00017160 File Offset: 0x00015360
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86180, RefRangeEnd = 86181, XrefRangeStart = 86158, XrefRangeEnd = 86180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ResetCursor()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutUtility.LayoutCache.NativeMethodInfoPtr_ResetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x00004AE6 File Offset: 0x00002CE6
			public LayoutCache(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06000693 RID: 1683 RVA: 0x00017194 File Offset: 0x00015394
			// (set) Token: 0x06000694 RID: 1684 RVA: 0x00004AEF File Offset: 0x00002CEF
			public unsafe int _id_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr__id_k__BackingField)) = value;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x06000695 RID: 1685 RVA: 0x000171BC File Offset: 0x000153BC
			// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004B0A File Offset: 0x00002D0A
			public unsafe GUILayoutGroup topLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_topLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x06000697 RID: 1687 RVA: 0x000171EC File Offset: 0x000153EC
			// (set) Token: 0x06000698 RID: 1688 RVA: 0x00004B29 File Offset: 0x00002D29
			public unsafe GenericStack layoutGroups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_layoutGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001721C File Offset: 0x0001541C
			// (set) Token: 0x0600069A RID: 1690 RVA: 0x00004B48 File Offset: 0x00002D48
			public unsafe GUILayoutGroup windows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutUtility.LayoutCache.NativeFieldInfoPtr_windows), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeFieldInfoPtr_topLevel;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeFieldInfoPtr_layoutGroups;

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeFieldInfoPtr_windows;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_Int32_0;

			// Token: 0x04000364 RID: 868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

			// Token: 0x04000365 RID: 869
			private static readonly IntPtr NativeMethodInfoPtr_ResetCursor_Public_Void_0;
		}

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600069C RID: 1692
		private delegate void GetWindowsBounds_InjectedDelegate([Out] IntPtr ret);
	}
}
