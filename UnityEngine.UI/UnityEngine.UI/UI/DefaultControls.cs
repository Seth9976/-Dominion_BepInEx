using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000D RID: 13
	public static class DefaultControls : Object
	{
		// Token: 0x06000090 RID: 144 RVA: 0x0000915C File Offset: 0x0000735C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultControls()
		{
			Il2CppClassPointerStore<DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "DefaultControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr);
			DefaultControls.NativeFieldInfoPtr_m_CurrentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "m_CurrentFactory");
			DefaultControls.NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kWidth");
			DefaultControls.NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThickHeight");
			DefaultControls.NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThinHeight");
			DefaultControls.NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThickElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThinElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ImageElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ImageElementSize");
			DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
			DefaultControls.NativeFieldInfoPtr_s_PanelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_PanelColor");
			DefaultControls.NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_TextColor");
			DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663374);
			DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663375);
			DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663376);
			DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663377);
			DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663378);
			DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663379);
			DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663380);
			DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663381);
			DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663382);
			DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663383);
			DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663384);
			DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663385);
			DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663386);
			DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663387);
			DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663388);
			DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663389);
			DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663390);
			DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663391);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000093BC File Offset: 0x000075BC
		public unsafe static DefaultControls.IFactoryControls factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108561, XrefRangeEnd = 108565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr3) : null;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000093F0 File Offset: 0x000075F0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 108580, RefRangeEnd = 108591, XrefRangeStart = 108565, XrefRangeEnd = 108580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009464 File Offset: 0x00007664
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 108603, RefRangeEnd = 108627, XrefRangeStart = 108591, XrefRangeEnd = 108603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIObject(string name, GameObject parent, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000094DC File Offset: 0x000076DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108627, XrefRangeEnd = 108633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTextValues(Text lbl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lbl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009514 File Offset: 0x00007714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108633, XrefRangeEnd = 108636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000954C File Offset: 0x0000774C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 108648, RefRangeEnd = 108652, XrefRangeStart = 108636, XrefRangeEnd = 108648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00009594 File Offset: 0x00007794
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108662, RefRangeEnd = 108664, XrefRangeStart = 108652, XrefRangeEnd = 108662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000095D8 File Offset: 0x000077D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108664, XrefRangeEnd = 108698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreatePanel(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00009624 File Offset: 0x00007824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108698, XrefRangeEnd = 108759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateButton(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009670 File Offset: 0x00007870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108759, XrefRangeEnd = 108786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateText(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000096BC File Offset: 0x000078BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108786, XrefRangeEnd = 108808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009708 File Offset: 0x00007908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108808, XrefRangeEnd = 108830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateRawImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00009754 File Offset: 0x00007954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108830, XrefRangeEnd = 108941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateSlider(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000097A0 File Offset: 0x000079A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109009, RefRangeEnd = 109012, XrefRangeStart = 108941, XrefRangeEnd = 109009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollbar(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000097EC File Offset: 0x000079EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109012, XrefRangeEnd = 109101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateToggle(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009838 File Offset: 0x00007A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109101, XrefRangeEnd = 109190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateInputField(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009884 File Offset: 0x00007A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109190, XrefRangeEnd = 109474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateDropdown(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000098D0 File Offset: 0x00007AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109474, XrefRangeEnd = 109597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollView(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002375 File Offset: 0x00000575
		public static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			return DefaultControls.CreateUIElementRoot(name, size, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002384 File Offset: 0x00000584
		public static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			return DefaultControls.CreateUIObject(name, parent, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002393 File Offset: 0x00000593
		public DefaultControls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000991C File Offset: 0x00007B1C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000239C File Offset: 0x0000059C
		public unsafe static DefaultControls.IFactoryControls m_CurrentFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00009944 File Offset: 0x00007B44
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000023AE File Offset: 0x000005AE
		public unsafe static float kWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00009960 File Offset: 0x00007B60
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023BC File Offset: 0x000005BC
		public unsafe static float kThickHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000997C File Offset: 0x00007B7C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023CA File Offset: 0x000005CA
		public unsafe static float kThinHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009998 File Offset: 0x00007B98
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe static Vector2 s_ThickElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000099B4 File Offset: 0x00007BB4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023E6 File Offset: 0x000005E6
		public unsafe static Vector2 s_ThinElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000099D0 File Offset: 0x00007BD0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023F4 File Offset: 0x000005F4
		public unsafe static Vector2 s_ImageElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000099EC File Offset: 0x00007BEC
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002402 File Offset: 0x00000602
		public unsafe static Color s_DefaultSelectableColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009A08 File Offset: 0x00007C08
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002410 File Offset: 0x00000610
		public unsafe static Color s_PanelColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009A24 File Offset: 0x00007C24
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000241E File Offset: 0x0000061E
		public unsafe static Color s_TextColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&value));
			}
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFactory;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_kWidth;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_kThickHeight;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_kThinHeight;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_s_ThickElementSize;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_s_ThinElementSize;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_s_ImageElementSize;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelColor;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_s_TextColor;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0;

		// Token: 0x02000077 RID: 119
		public class IFactoryControls : Il2CppObjectBase
		{
			// Token: 0x06000B6D RID: 2925 RVA: 0x000061AD File Offset: 0x000043AD
			// Note: this type is marked as 'beforefieldinit'.
			static IFactoryControls()
			{
				Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "IFactoryControls");
				DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr, 100664953);
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x00032F78 File Offset: 0x00031178
			[CallerCount(0)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x000061D7 File Offset: 0x000043D7
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x000061E6 File Offset: 0x000043E6
			public IFactoryControls(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040008A4 RID: 2212
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0;
		}

		// Token: 0x02000078 RID: 120
		public class DefaultRuntimeFactory : Object
		{
			// Token: 0x06000B71 RID: 2929 RVA: 0x00032FF4 File Offset: 0x000311F4
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultRuntimeFactory()
			{
				Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "DefaultRuntimeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr);
				DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, "Default");
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100664954);
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100664955);
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x0003305C File Offset: 0x0003125C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108557, XrefRangeEnd = 108561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x000330CC File Offset: 0x000312CC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultRuntimeFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x000061EF File Offset: 0x000043EF
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000B75 RID: 2933 RVA: 0x000061FE File Offset: 0x000043FE
			public DefaultRuntimeFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00033108 File Offset: 0x00031308
			// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00006207 File Offset: 0x00004407
			public unsafe static DefaultControls.IFactoryControls Default
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008A5 RID: 2213
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x040008A6 RID: 2214
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0;

			// Token: 0x040008A7 RID: 2215
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000079 RID: 121
		public sealed class Resources : ValueType
		{
			// Token: 0x06000B78 RID: 2936 RVA: 0x00033130 File Offset: 0x00031330
			// Note: this type is marked as 'beforefieldinit'.
			static Resources()
			{
				Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "Resources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr);
				DefaultControls.Resources.NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "standard");
				DefaultControls.Resources.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "background");
				DefaultControls.Resources.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "inputField");
				DefaultControls.Resources.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "knob");
				DefaultControls.Resources.NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "checkmark");
				DefaultControls.Resources.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "dropdown");
				DefaultControls.Resources.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "mask");
			}

			// Token: 0x06000B79 RID: 2937 RVA: 0x00006219 File Offset: 0x00004419
			public Resources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x00006222 File Offset: 0x00004422
			public Resources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr))
			{
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000B7B RID: 2939 RVA: 0x000331E8 File Offset: 0x000313E8
			// (set) Token: 0x06000B7C RID: 2940 RVA: 0x00006234 File Offset: 0x00004434
			public unsafe Sprite standard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00033218 File Offset: 0x00031418
			// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00006253 File Offset: 0x00004453
			public unsafe Sprite background
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00033248 File Offset: 0x00031448
			// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00006272 File Offset: 0x00004472
			public unsafe Sprite inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00033278 File Offset: 0x00031478
			// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00006291 File Offset: 0x00004491
			public unsafe Sprite knob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000B83 RID: 2947 RVA: 0x000332A8 File Offset: 0x000314A8
			// (set) Token: 0x06000B84 RID: 2948 RVA: 0x000062B0 File Offset: 0x000044B0
			public unsafe Sprite checkmark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06000B85 RID: 2949 RVA: 0x000332D8 File Offset: 0x000314D8
			// (set) Token: 0x06000B86 RID: 2950 RVA: 0x000062CF File Offset: 0x000044CF
			public unsafe Sprite dropdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x06000B87 RID: 2951 RVA: 0x00033308 File Offset: 0x00031508
			// (set) Token: 0x06000B88 RID: 2952 RVA: 0x000062EE File Offset: 0x000044EE
			public unsafe Sprite mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008A8 RID: 2216
			private static readonly IntPtr NativeFieldInfoPtr_standard;

			// Token: 0x040008A9 RID: 2217
			private static readonly IntPtr NativeFieldInfoPtr_background;

			// Token: 0x040008AA RID: 2218
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x040008AB RID: 2219
			private static readonly IntPtr NativeFieldInfoPtr_knob;

			// Token: 0x040008AC RID: 2220
			private static readonly IntPtr NativeFieldInfoPtr_checkmark;

			// Token: 0x040008AD RID: 2221
			private static readonly IntPtr NativeFieldInfoPtr_dropdown;

			// Token: 0x040008AE RID: 2222
			private static readonly IntPtr NativeFieldInfoPtr_mask;
		}
	}
}
