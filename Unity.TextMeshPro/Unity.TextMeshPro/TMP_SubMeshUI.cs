using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000059 RID: 89
	public class TMP_SubMeshUI : MaskableGraphic
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x0002B1A0 File Offset: 0x000293A0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SubMeshUI()
		{
			Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SubMeshUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr);
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fontAsset");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_spriteAsset");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_material");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_sharedMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fallbackMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_fallbackSourceMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_isDefaultMaterial");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_padding");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_mesh");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_TextComponent");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_isRegisteredForEvents");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_materialDirty");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_materialReferenceIndex");
			TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, "m_RootCanvasTransform");
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664318);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664319);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664320);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664321);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664322);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664323);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664324);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664325);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664326);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664327);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664328);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664329);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664330);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664331);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664332);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664333);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_padding_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664334);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664335);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664336);
			TMP_SubMeshUI.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664337);
			TMP_SubMeshUI.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664338);
			TMP_SubMeshUI.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664339);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664340);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664341);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664342);
			TMP_SubMeshUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664343);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664344);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664345);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664346);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664347);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664348);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664349);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664350);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664351);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetPivotDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664352);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664353);
			TMP_SubMeshUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664354);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664355);
			TMP_SubMeshUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664356);
			TMP_SubMeshUI.NativeMethodInfoPtr_RefreshMaterial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664357);
			TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664358);
			TMP_SubMeshUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664359);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664360);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664361);
			TMP_SubMeshUI.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664362);
			TMP_SubMeshUI.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664363);
			TMP_SubMeshUI.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664364);
			TMP_SubMeshUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr, 100664365);
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0002B6A8 File Offset: 0x000298A8
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0002B6E8 File Offset: 0x000298E8
		public unsafe TMP_FontAsset fontAsset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002B72C File Offset: 0x0002992C
		// (set) Token: 0x06000A2C RID: 2604 RVA: 0x0002B76C File Offset: 0x0002996C
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002B7B0 File Offset: 0x000299B0
		public unsafe override Texture mainTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145883, XrefRangeEnd = 145888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0002B7FC File Offset: 0x000299FC
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0002B848 File Offset: 0x00029A48
		public unsafe override Material material
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145888, XrefRangeEnd = 145906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145906, XrefRangeEnd = 145913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0002B898 File Offset: 0x00029A98
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		public unsafe Material sharedMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 145914, RefRangeEnd = 145916, XrefRangeStart = 145913, XrefRangeEnd = 145914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002B91C File Offset: 0x00029B1C
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0002B95C File Offset: 0x00029B5C
		public unsafe Material fallbackMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145934, RefRangeEnd = 145935, XrefRangeStart = 145916, XrefRangeEnd = 145934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		public unsafe Material fallbackSourceMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002BA24 File Offset: 0x00029C24
		public unsafe override Material materialForRendering
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145935, XrefRangeEnd = 145939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x0002BA70 File Offset: 0x00029C70
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x0002BAAC File Offset: 0x00029CAC
		public unsafe bool isDefaultMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0002BAEC File Offset: 0x00029CEC
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x0002BB28 File Offset: 0x00029D28
		public unsafe float padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_padding_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002BB68 File Offset: 0x00029D68
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		public unsafe Mesh mesh
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 145948, RefRangeEnd = 145960, XrefRangeStart = 145939, XrefRangeEnd = 145948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002BBEC File Offset: 0x00029DEC
		public unsafe TMP_Text textComponent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145960, XrefRangeEnd = 145967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002BC2C File Offset: 0x00029E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146021, RefRangeEnd = 146022, XrefRangeStart = 145967, XrefRangeEnd = 146021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(materialReference));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SubMeshUI>(intPtr3) : null;
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002BC88 File Offset: 0x00029E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146022, XrefRangeEnd = 146024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002BCC4 File Offset: 0x00029EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146024, XrefRangeEnd = 146033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002BD00 File Offset: 0x00029F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146033, XrefRangeEnd = 146056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002BD3C File Offset: 0x00029F3C
		[CallerCount(0)]
		public unsafe override void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002BD78 File Offset: 0x00029F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146056, XrefRangeEnd = 146067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Material GetModifiedMaterial(Material baseMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseMaterial);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146072, RefRangeEnd = 146075, XrefRangeStart = 146067, XrefRangeEnd = 146072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002BE10 File Offset: 0x0002A010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146075, XrefRangeEnd = 146080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPaddingForMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002BE60 File Offset: 0x0002A060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146084, RefRangeEnd = 146085, XrefRangeStart = 146080, XrefRangeEnd = 146084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isExtraPadding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUsingBold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002BEAC File Offset: 0x0002A0AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetAllDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146085, XrefRangeEnd = 146089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002BF24 File Offset: 0x0002A124
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetLayoutDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002BF60 File Offset: 0x0002A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146089, XrefRangeEnd = 146090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002BF9C File Offset: 0x0002A19C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146094, RefRangeEnd = 146096, XrefRangeStart = 146090, XrefRangeEnd = 146094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPivotDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_SetPivotDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146096, XrefRangeEnd = 146103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetRootCanvasTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002C010 File Offset: 0x0002A210
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cull(Rect clipRect, bool validRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clipRect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref validRect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002C068 File Offset: 0x0002A268
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateGeometry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		[CallerCount(0)]
		public unsafe override void Rebuild(CanvasUpdate update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref update;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0002C0F0 File Offset: 0x0002A2F0
		[CallerCount(0)]
		public unsafe void RefreshMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_RefreshMaterial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002C124 File Offset: 0x0002A324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146103, XrefRangeEnd = 146129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002C160 File Offset: 0x0002A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecalculateClipping()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_SubMeshUI.NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0002C19C File Offset: 0x0002A39C
		[CallerCount(0)]
		public unsafe Material GetMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0002C1DC File Offset: 0x0002A3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146129, XrefRangeEnd = 146147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002C22C File Offset: 0x0002A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146147, XrefRangeEnd = 146158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002C27C File Offset: 0x0002A47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146158, XrefRangeEnd = 146161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0002C2BC File Offset: 0x0002A4BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146166, RefRangeEnd = 146169, XrefRangeStart = 146161, XrefRangeEnd = 146166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0002C300 File Offset: 0x0002A500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SubMeshUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SubMeshUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMeshUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00006B2A File Offset: 0x00004D2A
		public TMP_SubMeshUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002C33C File Offset: 0x0002A53C
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x00006B33 File Offset: 0x00004D33
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0002C36C File Offset: 0x0002A56C
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00006B52 File Offset: 0x00004D52
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002C39C File Offset: 0x0002A59C
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00006B71 File Offset: 0x00004D71
		public unsafe Material m_material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00006B90 File Offset: 0x00004D90
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00006BAF File Offset: 0x00004DAF
		public unsafe Material m_fallbackMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002C42C File Offset: 0x0002A62C
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00006BCE File Offset: 0x00004DCE
		public unsafe Material m_fallbackSourceMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_fallbackSourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002C45C File Offset: 0x0002A65C
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00006BED File Offset: 0x00004DED
		public unsafe bool m_isDefaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isDefaultMaterial)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0002C484 File Offset: 0x0002A684
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00006C08 File Offset: 0x00004E08
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002C4AC File Offset: 0x0002A6AC
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x00006C23 File Offset: 0x00004E23
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x00006C42 File Offset: 0x00004E42
		public unsafe TextMeshProUGUI m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002C50C File Offset: 0x0002A70C
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x00006C61 File Offset: 0x00004E61
		public unsafe bool m_isRegisteredForEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_isRegisteredForEvents)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002C534 File Offset: 0x0002A734
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00006C7C File Offset: 0x00004E7C
		public unsafe bool m_materialDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialDirty)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002C55C File Offset: 0x0002A75C
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006C97 File Offset: 0x00004E97
		public unsafe int m_materialReferenceIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_materialReferenceIndex)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002C584 File Offset: 0x0002A784
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006CB2 File Offset: 0x00004EB2
		public unsafe Transform m_RootCanvasTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMeshUI.NativeFieldInfoPtr_m_RootCanvasTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_m_material;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterial;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackSourceMaterial;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultMaterial;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_m_isRegisteredForEvents;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_m_materialDirty;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_m_materialReferenceIndex;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_m_RootCanvasTransform;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_get_mainTexture_Public_Virtual_get_Texture_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_Virtual_get_Material_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_Virtual_set_Void_Material_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_materialForRendering_Public_Virtual_get_Material_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Single_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMeshUI_TextMeshProUGUI_MaterialReference_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_GetModifiedMaterial_Public_Virtual_Material_Material_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_Material_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_SetAllDirty_Public_Virtual_Void_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Virtual_Void_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_SetLayoutDirty_Public_Virtual_Void_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Virtual_Void_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_SetPivotDirty_Public_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_GetRootCanvasTransform_Private_Transform_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_Cull_Public_Virtual_Void_Rect_Boolean_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_UpdateGeometry_Protected_Virtual_Void_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_Rebuild_Public_Virtual_Void_CanvasUpdate_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_RefreshMaterial_Public_Void_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Virtual_Void_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_RecalculateClipping_Public_Virtual_Void_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
