using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200000F RID: 15
	public static class TMPro_EventManager : global::Il2CppSystem.Object
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00010978 File Offset: 0x0000EB78
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_EventManager()
		{
			Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_EventManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr);
			TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COMPUTE_DT_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "MATERIAL_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "FONT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "SPRITE_ASSET_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "DRAG_AND_DROP_MATERIAL_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_STYLE_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COLOR_GRADIENT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TMP_SETTINGS_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "RESOURCE_LOAD_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_UGUI_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_CHANGED_EVENT");
			TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663524);
			TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663525);
			TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663526);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663527);
			TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663528);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663529);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663530);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663531);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663532);
			TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663533);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663534);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663535);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00010B88 File Offset: 0x0000ED88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137167, XrefRangeEnd = 137175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00010BCC File Offset: 0x0000EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137175, XrefRangeEnd = 137183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_FONT_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00010C10 File Offset: 0x0000EE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137183, XrefRangeEnd = 137191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00010C54 File Offset: 0x0000EE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137191, XrefRangeEnd = 137199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00010C98 File Offset: 0x0000EE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137199, XrefRangeEnd = 137206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00010CF4 File Offset: 0x0000EEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137206, XrefRangeEnd = 137214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00010D28 File Offset: 0x0000EF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137214, XrefRangeEnd = 137222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00010D60 File Offset: 0x0000EF60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 137230, RefRangeEnd = 137234, XrefRangeStart = 137222, XrefRangeEnd = 137230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00010D98 File Offset: 0x0000EF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137234, XrefRangeEnd = 137312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TMP_SETTINGS_CHANGED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137312, XrefRangeEnd = 137318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_RESOURCES_LOADED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137318, XrefRangeEnd = 137326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00010E2C File Offset: 0x0000F02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137326, XrefRangeEnd = 137334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COMPUTE_DT_EVENT(global::Il2CppSystem.Object Sender, Compute_DT_EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002B76 File Offset: 0x00000D76
		public TMPro_EventManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00010E74 File Offset: 0x0000F074
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00002B7F File Offset: 0x00000D7F
		public unsafe static FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00010E9C File Offset: 0x0000F09C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00002B91 File Offset: 0x00000D91
		public unsafe static FastAction<bool, Material> MATERIAL_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00010EC4 File Offset: 0x0000F0C4
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002BA3 File Offset: 0x00000DA3
		public unsafe static FastAction<bool, global::UnityEngine.Object> FONT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00010EEC File Offset: 0x0000F0EC
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002BB5 File Offset: 0x00000DB5
		public unsafe static FastAction<bool, global::UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00010F14 File Offset: 0x0000F114
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002BC7 File Offset: 0x00000DC7
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00010F3C File Offset: 0x0000F13C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002BD9 File Offset: 0x00000DD9
		public unsafe static FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<GameObject, Material, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00010F64 File Offset: 0x0000F164
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002BEB File Offset: 0x00000DEB
		public unsafe static FastAction<bool> TEXT_STYLE_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00010F8C File Offset: 0x0000F18C
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002BFD File Offset: 0x00000DFD
		public unsafe static FastAction<global::UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00010FB4 File Offset: 0x0000F1B4
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002C0F File Offset: 0x00000E0F
		public unsafe static FastAction TMP_SETTINGS_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00010FDC File Offset: 0x0000F1DC
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002C21 File Offset: 0x00000E21
		public unsafe static FastAction RESOURCE_LOAD_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00011004 File Offset: 0x0000F204
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002C33 File Offset: 0x00000E33
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001102C File Offset: 0x0000F22C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002C45 File Offset: 0x00000E45
		public unsafe static FastAction<global::UnityEngine.Object> TEXT_CHANGED_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_COMPUTE_DT_EVENT;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_FONT_PROPERTY_EVENT;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_RESOURCE_LOAD_EVENT;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_CHANGED_EVENT;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0;
	}
}
