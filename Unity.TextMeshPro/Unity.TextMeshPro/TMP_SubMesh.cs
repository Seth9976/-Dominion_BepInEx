using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000058 RID: 88
	public class TMP_SubMesh : MonoBehaviour
	{
		// Token: 0x060009E8 RID: 2536 RVA: 0x0002A240 File Offset: 0x00028440
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_SubMesh()
		{
			Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SubMesh");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr);
			TMP_SubMesh.NativeFieldInfoPtr_m_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_fontAsset");
			TMP_SubMesh.NativeFieldInfoPtr_m_spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_spriteAsset");
			TMP_SubMesh.NativeFieldInfoPtr_m_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_material");
			TMP_SubMesh.NativeFieldInfoPtr_m_sharedMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_sharedMaterial");
			TMP_SubMesh.NativeFieldInfoPtr_m_fallbackMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_fallbackMaterial");
			TMP_SubMesh.NativeFieldInfoPtr_m_fallbackSourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_fallbackSourceMaterial");
			TMP_SubMesh.NativeFieldInfoPtr_m_isDefaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_isDefaultMaterial");
			TMP_SubMesh.NativeFieldInfoPtr_m_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_padding");
			TMP_SubMesh.NativeFieldInfoPtr_m_renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_renderer");
			TMP_SubMesh.NativeFieldInfoPtr_m_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_meshFilter");
			TMP_SubMesh.NativeFieldInfoPtr_m_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_mesh");
			TMP_SubMesh.NativeFieldInfoPtr_m_TextComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_TextComponent");
			TMP_SubMesh.NativeFieldInfoPtr_m_isRegisteredForEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, "m_isRegisteredForEvents");
			TMP_SubMesh.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664282);
			TMP_SubMesh.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664283);
			TMP_SubMesh.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664284);
			TMP_SubMesh.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664285);
			TMP_SubMesh.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664286);
			TMP_SubMesh.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664287);
			TMP_SubMesh.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664288);
			TMP_SubMesh.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664289);
			TMP_SubMesh.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664290);
			TMP_SubMesh.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664291);
			TMP_SubMesh.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664292);
			TMP_SubMesh.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664293);
			TMP_SubMesh.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664294);
			TMP_SubMesh.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664295);
			TMP_SubMesh.NativeMethodInfoPtr_get_padding_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664296);
			TMP_SubMesh.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664297);
			TMP_SubMesh.NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664298);
			TMP_SubMesh.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664299);
			TMP_SubMesh.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664300);
			TMP_SubMesh.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664301);
			TMP_SubMesh.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664302);
			TMP_SubMesh.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMesh_TextMeshPro_MaterialReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664303);
			TMP_SubMesh.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664304);
			TMP_SubMesh.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664305);
			TMP_SubMesh.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664306);
			TMP_SubMesh.NativeMethodInfoPtr_DestroySelf_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664307);
			TMP_SubMesh.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664308);
			TMP_SubMesh.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664309);
			TMP_SubMesh.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664310);
			TMP_SubMesh.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664311);
			TMP_SubMesh.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664312);
			TMP_SubMesh.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664313);
			TMP_SubMesh.NativeMethodInfoPtr_SetVerticesDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664314);
			TMP_SubMesh.NativeMethodInfoPtr_SetMaterialDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664315);
			TMP_SubMesh.NativeMethodInfoPtr_UpdateMaterial_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664316);
			TMP_SubMesh.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr, 100664317);
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x0002A644 File Offset: 0x00028844
		// (set) Token: 0x060009EA RID: 2538 RVA: 0x0002A684 File Offset: 0x00028884
		public unsafe TMP_FontAsset fontAsset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x0002A6C8 File Offset: 0x000288C8
		// (set) Token: 0x060009EC RID: 2540 RVA: 0x0002A708 File Offset: 0x00028908
		public unsafe TMP_SpriteAsset spriteAsset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060009ED RID: 2541 RVA: 0x0002A74C File Offset: 0x0002894C
		// (set) Token: 0x060009EE RID: 2542 RVA: 0x0002A78C File Offset: 0x0002898C
		public unsafe Material material
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145563, RefRangeEnd = 145564, XrefRangeStart = 145562, XrefRangeEnd = 145563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145564, XrefRangeEnd = 145569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_material_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060009EF RID: 2543 RVA: 0x0002A7D0 File Offset: 0x000289D0
		// (set) Token: 0x060009F0 RID: 2544 RVA: 0x0002A810 File Offset: 0x00028A10
		public unsafe Material sharedMaterial
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 145571, RefRangeEnd = 145573, XrefRangeStart = 145569, XrefRangeEnd = 145571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0002A854 File Offset: 0x00028A54
		// (set) Token: 0x060009F2 RID: 2546 RVA: 0x0002A894 File Offset: 0x00028A94
		public unsafe Material fallbackMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 145592, RefRangeEnd = 145593, XrefRangeStart = 145573, XrefRangeEnd = 145592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x0002A8D8 File Offset: 0x00028AD8
		// (set) Token: 0x060009F4 RID: 2548 RVA: 0x0002A918 File Offset: 0x00028B18
		public unsafe Material fallbackSourceMaterial
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060009F5 RID: 2549 RVA: 0x0002A95C File Offset: 0x00028B5C
		// (set) Token: 0x060009F6 RID: 2550 RVA: 0x0002A998 File Offset: 0x00028B98
		public unsafe bool isDefaultMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060009F7 RID: 2551 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		// (set) Token: 0x060009F8 RID: 2552 RVA: 0x0002AA14 File Offset: 0x00028C14
		public unsafe float padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_padding_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88938, RefRangeEnd = 88939, XrefRangeStart = 88938, XrefRangeEnd = 88939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002AA54 File Offset: 0x00028C54
		public unsafe Renderer renderer
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 145600, RefRangeEnd = 145615, XrefRangeStart = 145593, XrefRangeEnd = 145600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr3) : null;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002AA94 File Offset: 0x00028C94
		public unsafe MeshFilter meshFilter
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 145630, RefRangeEnd = 145633, XrefRangeStart = 145615, XrefRangeEnd = 145630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr3) : null;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x0002AAD4 File Offset: 0x00028CD4
		// (set) Token: 0x060009FC RID: 2556 RVA: 0x0002AB14 File Offset: 0x00028D14
		public unsafe Mesh mesh
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 145642, RefRangeEnd = 145653, XrefRangeStart = 145633, XrefRangeEnd = 145642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002AB58 File Offset: 0x00028D58
		public unsafe TMP_Text textComponent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145653, XrefRangeEnd = 145660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002AB98 File Offset: 0x00028D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145709, RefRangeEnd = 145710, XrefRangeStart = 145660, XrefRangeEnd = 145709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textComponent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(materialReference));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMesh_TextMeshPro_MaterialReference_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_SubMesh>(intPtr3) : null;
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002ABF4 File Offset: 0x00028DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145710, XrefRangeEnd = 145747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002AC28 File Offset: 0x00028E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145747, XrefRangeEnd = 145756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002AC5C File Offset: 0x00028E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145756, XrefRangeEnd = 145773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002AC90 File Offset: 0x00028E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145773, XrefRangeEnd = 145778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroySelf()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_DestroySelf_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002ACC4 File Offset: 0x00028EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145804, RefRangeEnd = 145805, XrefRangeStart = 145778, XrefRangeEnd = 145804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002AD14 File Offset: 0x00028F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145805, XrefRangeEnd = 145816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material CreateMaterialInstance(Material source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002AD64 File Offset: 0x00028F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145816, XrefRangeEnd = 145825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetSharedMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002ADA4 File Offset: 0x00028FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145571, RefRangeEnd = 145573, XrefRangeStart = 145571, XrefRangeEnd = 145573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSharedMaterial(Material mat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002ADE8 File Offset: 0x00028FE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 145830, RefRangeEnd = 145836, XrefRangeStart = 145825, XrefRangeEnd = 145830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPaddingForMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002AE24 File Offset: 0x00029024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 145840, RefRangeEnd = 145841, XrefRangeStart = 145836, XrefRangeEnd = 145840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002AE70 File Offset: 0x00029070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 145846, RefRangeEnd = 145848, XrefRangeStart = 145841, XrefRangeEnd = 145846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVerticesDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_SetVerticesDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002AEA4 File Offset: 0x000290A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 145848, XrefRangeEnd = 145849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMaterialDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_SetMaterialDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002AED8 File Offset: 0x000290D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 145876, RefRangeEnd = 145883, XrefRangeStart = 145849, XrefRangeEnd = 145876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr_UpdateMaterial_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002AF0C File Offset: 0x0002910C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_SubMesh()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_SubMesh>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_SubMesh.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0000699A File Offset: 0x00004B9A
		public TMP_SubMesh(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0002AF48 File Offset: 0x00029148
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x000069A3 File Offset: 0x00004BA3
		public unsafe TMP_FontAsset m_fontAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fontAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fontAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0002AF78 File Offset: 0x00029178
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x000069C2 File Offset: 0x00004BC2
		public unsafe TMP_SpriteAsset m_spriteAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_spriteAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_SpriteAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_spriteAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x0002AFA8 File Offset: 0x000291A8
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000069E1 File Offset: 0x00004BE1
		public unsafe Material m_material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0002AFD8 File Offset: 0x000291D8
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x00006A00 File Offset: 0x00004C00
		public unsafe Material m_sharedMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_sharedMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_sharedMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0002B008 File Offset: 0x00029208
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00006A1F File Offset: 0x00004C1F
		public unsafe Material m_fallbackMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fallbackMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fallbackMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0002B038 File Offset: 0x00029238
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00006A3E File Offset: 0x00004C3E
		public unsafe Material m_fallbackSourceMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fallbackSourceMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_fallbackSourceMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x0002B068 File Offset: 0x00029268
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x00006A5D File Offset: 0x00004C5D
		public unsafe bool m_isDefaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_isDefaultMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_isDefaultMaterial)) = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002B090 File Offset: 0x00029290
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x00006A78 File Offset: 0x00004C78
		public unsafe float m_padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_padding)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002B0B8 File Offset: 0x000292B8
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00006A93 File Offset: 0x00004C93
		public unsafe Renderer m_renderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_renderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_renderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0002B0E8 File Offset: 0x000292E8
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00006AB2 File Offset: 0x00004CB2
		public unsafe MeshFilter m_meshFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_meshFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_meshFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002B118 File Offset: 0x00029318
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00006AD1 File Offset: 0x00004CD1
		public unsafe Mesh m_mesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_mesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0002B148 File Offset: 0x00029348
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00006AF0 File Offset: 0x00004CF0
		public unsafe TextMeshPro m_TextComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_TextComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_TextComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0002B178 File Offset: 0x00029378
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00006B0F File Offset: 0x00004D0F
		public unsafe bool m_isRegisteredForEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_isRegisteredForEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_SubMesh.NativeFieldInfoPtr_m_isRegisteredForEvents)) = value;
			}
		}

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_m_fontAsset;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr_m_spriteAsset;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr_m_material;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr_m_sharedMaterial;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackMaterial;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr_m_fallbackSourceMaterial;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr_m_isDefaultMaterial;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr_m_padding;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr_m_renderer;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr_m_meshFilter;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_m_mesh;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_m_TextComponent;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_m_isRegisteredForEvents;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_get_fontAsset_Public_get_TMP_FontAsset_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_set_fontAsset_Public_set_Void_TMP_FontAsset_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_TMP_SpriteAsset_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_set_spriteAsset_Public_set_Void_TMP_SpriteAsset_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_set_material_Public_set_Void_Material_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_sharedMaterial_Public_get_Material_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_set_sharedMaterial_Public_set_Void_Material_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackMaterial_Public_get_Material_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackMaterial_Public_set_Void_Material_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_fallbackSourceMaterial_Public_get_Material_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_set_fallbackSourceMaterial_Public_set_Void_Material_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_isDefaultMaterial_Public_get_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_set_isDefaultMaterial_Public_set_Void_Boolean_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_padding_Public_get_Single_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_set_padding_Public_set_Void_Single_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_renderer_Public_get_Renderer_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_meshFilter_Public_get_MeshFilter_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_mesh_Public_get_Mesh_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_set_mesh_Public_set_Void_Mesh_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TMP_Text_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_AddSubTextObject_Public_Static_TMP_SubMesh_TextMeshPro_MaterialReference_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_DestroySelf_Public_Void_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Private_Material_Material_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_CreateMaterialInstance_Private_Material_Material_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMaterial_Private_Material_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_SetSharedMaterial_Private_Void_Material_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_GetPaddingForMaterial_Public_Single_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMeshPadding_Public_Void_Boolean_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_SetVerticesDirty_Public_Void_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_SetMaterialDirty_Public_Void_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterial_Protected_Void_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
