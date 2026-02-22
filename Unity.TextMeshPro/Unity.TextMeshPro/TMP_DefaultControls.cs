using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200002B RID: 43
	public static class TMP_DefaultControls : global::Il2CppSystem.Object
	{
		// Token: 0x060003DC RID: 988 RVA: 0x00016168 File Offset: 0x00014368
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_DefaultControls()
		{
			Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_DefaultControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr);
			TMP_DefaultControls.NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kWidth");
			TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThickHeight");
			TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThinHeight");
			TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThickElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThinElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
			TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextColor");
			TMP_DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663647);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663648);
			TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663649);
			TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663650);
			TMP_DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663651);
			TMP_DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663652);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663653);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663654);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663655);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663656);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663657);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00016314 File Offset: 0x00014514
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 137752, RefRangeEnd = 137757, XrefRangeStart = 137744, XrefRangeEnd = 137752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00016368 File Offset: 0x00014568
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 137768, RefRangeEnd = 137782, XrefRangeStart = 137757, XrefRangeEnd = 137768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIObject(string name, GameObject parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000163C0 File Offset: 0x000145C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137782, XrefRangeEnd = 137788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTextValues(TMP_Text lbl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lbl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000163F8 File Offset: 0x000145F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00016430 File Offset: 0x00014630
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137800, RefRangeEnd = 137803, XrefRangeStart = 137788, XrefRangeEnd = 137800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetParentAndAlign(GameObject child, GameObject parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00016478 File Offset: 0x00014678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 137813, RefRangeEnd = 137815, XrefRangeStart = 137803, XrefRangeEnd = 137813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x000164BC File Offset: 0x000146BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137858, RefRangeEnd = 137859, XrefRangeStart = 137815, XrefRangeEnd = 137858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00016508 File Offset: 0x00014708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137859, XrefRangeEnd = 137907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateButton(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00016554 File Offset: 0x00014754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137907, XrefRangeEnd = 137917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateText(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000165A0 File Offset: 0x000147A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137917, XrefRangeEnd = 138010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateInputField(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000165EC File Offset: 0x000147EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138010, XrefRangeEnd = 138225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateDropdown(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003F56 File Offset: 0x00002156
		public TMP_DefaultControls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00016638 File Offset: 0x00014838
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00003F5F File Offset: 0x0000215F
		public unsafe static float kWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00016654 File Offset: 0x00014854
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00003F6D File Offset: 0x0000216D
		public unsafe static float kThickHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00016670 File Offset: 0x00014870
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003F7B File Offset: 0x0000217B
		public unsafe static float kThinHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0001668C File Offset: 0x0001488C
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003F89 File Offset: 0x00002189
		public unsafe static Vector2 s_TextElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000166A8 File Offset: 0x000148A8
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003F97 File Offset: 0x00002197
		public unsafe static Vector2 s_ThickElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000166C4 File Offset: 0x000148C4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003FA5 File Offset: 0x000021A5
		public unsafe static Vector2 s_ThinElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000166E0 File Offset: 0x000148E0
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003FB3 File Offset: 0x000021B3
		public unsafe static Color s_DefaultSelectableColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x000166FC File Offset: 0x000148FC
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003FC1 File Offset: 0x000021C1
		public unsafe static Color s_TextColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&value));
			}
		}

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_kWidth;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_kThickHeight;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_kThinHeight;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_s_TextElementSize;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_s_ThickElementSize;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_s_ThinElementSize;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_s_TextColor;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

		// Token: 0x0200007E RID: 126
		public sealed class Resources : ValueType
		{
			// Token: 0x06000EB2 RID: 3762 RVA: 0x0003B45C File Offset: 0x0003965C
			// Note: this type is marked as 'beforefieldinit'.
			static Resources()
			{
				Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "Resources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr);
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "standard");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "background");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "inputField");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "knob");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "checkmark");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "dropdown");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "mask");
			}

			// Token: 0x06000EB3 RID: 3763 RVA: 0x00008EE1 File Offset: 0x000070E1
			public Resources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000EB4 RID: 3764 RVA: 0x00008EEA File Offset: 0x000070EA
			public Resources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr))
			{
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003B514 File Offset: 0x00039714
			// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x00008EFC File Offset: 0x000070FC
			public unsafe Sprite standard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0003B544 File Offset: 0x00039744
			// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x00008F1B File Offset: 0x0000711B
			public unsafe Sprite background
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_background);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0003B574 File Offset: 0x00039774
			// (set) Token: 0x06000EBA RID: 3770 RVA: 0x00008F3A File Offset: 0x0000713A
			public unsafe Sprite inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700056F RID: 1391
			// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0003B5A4 File Offset: 0x000397A4
			// (set) Token: 0x06000EBC RID: 3772 RVA: 0x00008F59 File Offset: 0x00007159
			public unsafe Sprite knob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0003B5D4 File Offset: 0x000397D4
			// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00008F78 File Offset: 0x00007178
			public unsafe Sprite checkmark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003B604 File Offset: 0x00039804
			// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x00008F97 File Offset: 0x00007197
			public unsafe Sprite dropdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0003B634 File Offset: 0x00039834
			// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x00008FB6 File Offset: 0x000071B6
			public unsafe Sprite mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BAB RID: 2987
			private static readonly IntPtr NativeFieldInfoPtr_standard;

			// Token: 0x04000BAC RID: 2988
			private static readonly IntPtr NativeFieldInfoPtr_background;

			// Token: 0x04000BAD RID: 2989
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04000BAE RID: 2990
			private static readonly IntPtr NativeFieldInfoPtr_knob;

			// Token: 0x04000BAF RID: 2991
			private static readonly IntPtr NativeFieldInfoPtr_checkmark;

			// Token: 0x04000BB0 RID: 2992
			private static readonly IntPtr NativeFieldInfoPtr_dropdown;

			// Token: 0x04000BB1 RID: 2993
			private static readonly IntPtr NativeFieldInfoPtr_mask;
		}
	}
}
