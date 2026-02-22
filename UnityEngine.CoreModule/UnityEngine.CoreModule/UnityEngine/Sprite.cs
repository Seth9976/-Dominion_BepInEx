using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	public sealed class Sprite : Object
	{
		// Token: 0x060013D3 RID: 5075 RVA: 0x0004CA80 File Offset: 0x0004AC80
		// Note: this type is marked as 'beforefieldinit'.
		static Sprite()
		{
			Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Sprite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
			Sprite.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664709);
			Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664710);
			Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664711);
			Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664712);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664713);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664714);
			Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664715);
			Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664716);
			Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664717);
			Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664718);
			Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664719);
			Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664720);
			Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664721);
			Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664722);
			Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664723);
			Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664724);
			Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664725);
			Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664726);
			Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664727);
			Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664728);
			Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664729);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664730);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664731);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664732);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664733);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664734);
			Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664735);
			Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664736);
			Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664737);
			Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664738);
			Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664739);
			Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664740);
			Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664741);
			Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664742);
			Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664743);
			Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100664744);
			Sprite.GetPackingRotationDelegateField = IL2CPP.ResolveICall<Sprite.GetPackingRotationDelegate>("UnityEngine.Sprite::GetPackingRotation");
			Sprite.GetSecondaryTextureDelegateField = IL2CPP.ResolveICall<Sprite.GetSecondaryTextureDelegate>("UnityEngine.Sprite::GetSecondaryTexture");
			Sprite.get_spriteAtlasTextureScaleDelegateField = IL2CPP.ResolveICall<Sprite.get_spriteAtlasTextureScaleDelegate>("UnityEngine.Sprite::get_spriteAtlasTextureScale");
			Sprite.GetPhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeCountDelegate>("UnityEngine.Sprite::GetPhysicsShapeCount");
			Sprite.Internal_GetPhysicsShapePointCountDelegateField = IL2CPP.ResolveICall<Sprite.Internal_GetPhysicsShapePointCountDelegate>("UnityEngine.Sprite::Internal_GetPhysicsShapePointCount");
			Sprite.GetPhysicsShapeImplDelegateField = IL2CPP.ResolveICall<Sprite.GetPhysicsShapeImplDelegate>("UnityEngine.Sprite::GetPhysicsShapeImpl");
			Sprite.OverridePhysicsShapeCountDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeCountDelegate>("UnityEngine.Sprite::OverridePhysicsShapeCount");
			Sprite.OverridePhysicsShapeDelegateField = IL2CPP.ResolveICall<Sprite.OverridePhysicsShapeDelegate>("UnityEngine.Sprite::OverridePhysicsShape");
			Sprite.OverrideGeometryDelegateField = IL2CPP.ResolveICall<Sprite.OverrideGeometryDelegate>("UnityEngine.Sprite::OverrideGeometry");
			Sprite.GetTextureRectOffset_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.GetTextureRectOffset_InjectedDelegate>("UnityEngine.Sprite::GetTextureRectOffset_Injected");
			Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField = IL2CPP.ResolveICall<Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate>("UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected");
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0004CE28 File Offset: 0x0004B028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79318, XrefRangeEnd = 79322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0004CE64 File Offset: 0x0004B064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79322, XrefRangeEnd = 79324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPackingMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0004CEA0 File Offset: 0x0004B0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79324, XrefRangeEnd = 79326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0004CEDC File Offset: 0x0004B0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79326, XrefRangeEnd = 79328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect GetTextureRect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0004CF18 File Offset: 0x0004B118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79330, RefRangeEnd = 79331, XrefRangeStart = 79328, XrefRangeEnd = 79330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetInnerUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0004CF54 File Offset: 0x0004B154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79333, RefRangeEnd = 79334, XrefRangeStart = 79331, XrefRangeEnd = 79333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetOuterUVs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0004CF90 File Offset: 0x0004B190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79336, RefRangeEnd = 79337, XrefRangeStart = 79334, XrefRangeEnd = 79336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4 GetPadding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0004CFCC File Offset: 0x0004B1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79337, XrefRangeEnd = 79339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0004D074 File Offset: 0x0004B274
		public unsafe Bounds bounds
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79341, RefRangeEnd = 79342, XrefRangeStart = 79339, XrefRangeEnd = 79341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x0004D0B0 File Offset: 0x0004B2B0
		public unsafe Rect rect
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79344, RefRangeEnd = 79355, XrefRangeStart = 79342, XrefRangeEnd = 79344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0004D0EC File Offset: 0x0004B2EC
		public unsafe Vector4 border
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 79357, RefRangeEnd = 79365, XrefRangeStart = 79355, XrefRangeEnd = 79357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x0004D128 File Offset: 0x0004B328
		public unsafe Texture2D texture
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 79367, RefRangeEnd = 79376, XrefRangeStart = 79365, XrefRangeEnd = 79367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0004D168 File Offset: 0x0004B368
		public unsafe float pixelsPerUnit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79378, RefRangeEnd = 79379, XrefRangeStart = 79376, XrefRangeEnd = 79378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x0004D1A4 File Offset: 0x0004B3A4
		public unsafe Texture2D associatedAlphaSplitTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79381, RefRangeEnd = 79383, XrefRangeStart = 79379, XrefRangeEnd = 79381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x0004D1E4 File Offset: 0x0004B3E4
		public unsafe Vector2 pivot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79385, RefRangeEnd = 79386, XrefRangeStart = 79383, XrefRangeEnd = 79385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x0004D220 File Offset: 0x0004B420
		public unsafe bool packed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79388, RefRangeEnd = 79389, XrefRangeStart = 79386, XrefRangeEnd = 79388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0004D25C File Offset: 0x0004B45C
		public unsafe SpritePackingMode packingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0004D298 File Offset: 0x0004B498
		public unsafe Rect textureRect
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79393, RefRangeEnd = 79395, XrefRangeStart = 79389, XrefRangeEnd = 79393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
		public unsafe Il2CppStructArray<Vector2> vertices
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79397, RefRangeEnd = 79398, XrefRangeStart = 79395, XrefRangeEnd = 79397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0004D314 File Offset: 0x0004B514
		public unsafe Il2CppStructArray<ushort> triangles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79400, RefRangeEnd = 79401, XrefRangeStart = 79398, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr3) : null;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0004D354 File Offset: 0x0004B554
		public unsafe Il2CppStructArray<Vector2> uv
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79403, RefRangeEnd = 79404, XrefRangeStart = 79401, XrefRangeEnd = 79403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0004D394 File Offset: 0x0004B594
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 79411, RefRangeEnd = 79416, XrefRangeStart = 79404, XrefRangeEnd = 79411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x0004D43C File Offset: 0x0004B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79416, XrefRangeEnd = 79417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref border;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79417, XrefRangeEnd = 79420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0004D560 File Offset: 0x0004B760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79420, XrefRangeEnd = 79423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0004D5DC File Offset: 0x0004B7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79423, XrefRangeEnd = 79426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0004D64C File Offset: 0x0004B84C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79429, RefRangeEnd = 79440, XrefRangeStart = 79426, XrefRangeEnd = 79429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pivot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79440, XrefRangeEnd = 79442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTextureRect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79442, XrefRangeEnd = 79444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInnerUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0004D72C File Offset: 0x0004B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79444, XrefRangeEnd = 79446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOuterUVs_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0004D76C File Offset: 0x0004B96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79446, XrefRangeEnd = 79448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPadding_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0004D7AC File Offset: 0x0004B9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79448, XrefRangeEnd = 79450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pivot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pixelsPerUnit;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extrude;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref meshType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &border;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref generateFallbackPhysicsShape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0004D854 File Offset: 0x0004BA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79450, XrefRangeEnd = 79452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_bounds_Injected(out Bounds ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x0004D894 File Offset: 0x0004BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79452, XrefRangeEnd = 79454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_rect_Injected(out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0004D8D4 File Offset: 0x0004BAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79454, XrefRangeEnd = 79456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_border_Injected(out Vector4 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0004D914 File Offset: 0x0004BB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79456, XrefRangeEnd = 79458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_pivot_Injected(out Vector2 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0000B864 File Offset: 0x00009A64
		public Sprite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0000B86D File Offset: 0x00009A6D
		public int GetPackingRotation()
		{
			return Sprite.GetPackingRotationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0004D954 File Offset: 0x0004BB54
		public Vector2 GetTextureRectOffset()
		{
			Vector2 vector;
			this.GetTextureRectOffset_Injected(out vector);
			return vector;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0000B87F File Offset: 0x00009A7F
		public static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting_Injected(ref rect, ref pivot, pixelsToUnits, texture);
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0004D96C File Offset: 0x0004BB6C
		public Texture2D GetSecondaryTexture(int index)
		{
			IntPtr intPtr = Sprite.GetSecondaryTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), index);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x0000B88C File Offset: 0x00009A8C
		public float spriteAtlasTextureScale
		{
			get
			{
				return Sprite.get_spriteAtlasTextureScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x0004D99C File Offset: 0x0004BB9C
		public SpritePackingRotation packingRotation
		{
			get
			{
				return (SpritePackingRotation)this.GetPackingRotation();
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0004D9B4 File Offset: 0x0004BBB4
		public Vector2 textureRectOffset
		{
			get
			{
				bool flag = this.packed && this.packingMode != SpritePackingMode.Rectangle;
				Vector2 vector;
				if (flag)
				{
					vector = Vector2.zero;
				}
				else
				{
					vector = this.GetTextureRectOffset();
				}
				return vector;
			}
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0000B89E File Offset: 0x00009A9E
		public int GetPhysicsShapeCount()
		{
			return Sprite.GetPhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x0004D9F0 File Offset: 0x0004BBF0
		public int GetPhysicsShapePointCount(int shapeIdx)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			return this.Internal_GetPhysicsShapePointCount(shapeIdx);
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		public int Internal_GetPhysicsShapePointCount(int shapeIdx)
		{
			return Sprite.Internal_GetPhysicsShapePointCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIdx);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x0004DA40 File Offset: 0x0004BC40
		public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape)
		{
			int physicsShapeCount = this.GetPhysicsShapeCount();
			bool flag = shapeIdx < 0 || shapeIdx >= physicsShapeCount;
			if (flag)
			{
				throw new IndexOutOfRangeException(String.Format("Index({0}) is out of bounds(0 - {1})", shapeIdx, physicsShapeCount - 1));
			}
			Sprite.GetPhysicsShapeImpl(this, shapeIdx, physicsShape);
			return physicsShape.Count;
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x0000B8C3 File Offset: 0x00009AC3
		public static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape)
		{
			Sprite.GetPhysicsShapeImplDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), shapeIdx, IL2CPP.Il2CppObjectBaseToPtr(physicsShape));
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0004DA98 File Offset: 0x0004BC98
		public void OverridePhysicsShape(IList<Il2CppStructArray<Vector2>> physicsShapes)
		{
			for (int i = 0; i < physicsShapes.Count; i++)
			{
				Il2CppStructArray<Vector2> il2CppStructArray = physicsShapes[i];
				bool flag = il2CppStructArray == null;
				if (flag)
				{
					throw new ArgumentNullException(String.Format("Physics Shape at {0} is null.", i));
				}
				bool flag2 = il2CppStructArray.Length < 3;
				if (flag2)
				{
					throw new ArgumentException(String.Format("Physics Shape at {0} has less than 3 vertices ({1}).", i, il2CppStructArray.Length));
				}
			}
			Sprite.OverridePhysicsShapeCount(this, physicsShapes.Count);
			for (int j = 0; j < physicsShapes.Count; j++)
			{
				Sprite.OverridePhysicsShape(this, physicsShapes[j], j);
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0000B8DC File Offset: 0x00009ADC
		public static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount)
		{
			Sprite.OverridePhysicsShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), physicsShapeCount);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0000B8EF File Offset: 0x00009AEF
		public static void OverridePhysicsShape(Sprite sprite, Il2CppStructArray<Vector2> physicsShape, int idx)
		{
			Sprite.OverridePhysicsShapeDelegateField(IL2CPP.Il2CppObjectBaseToPtr(sprite), IL2CPP.Il2CppObjectBaseToPtr(physicsShape), idx);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0000B908 File Offset: 0x00009B08
		public void OverrideGeometry(Il2CppStructArray<Vector2> vertices, Il2CppStructArray<ushort> triangles)
		{
			Sprite.OverrideGeometryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices), IL2CPP.Il2CppObjectBaseToPtr(triangles));
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0004DB50 File Offset: 0x0004BD50
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, texture);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0004DB6C File Offset: 0x0004BD6C
		public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits)
		{
			return Sprite.CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, null);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0000B926 File Offset: 0x00009B26
		public void GetTextureRectOffset_Injected(out Vector2 ret)
		{
			Sprite.GetTextureRectOffset_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0004DB88 File Offset: 0x0004BD88
		public static Sprite CreateSpriteWithoutTextureScripting_Injected(ref Rect rect, ref Vector2 pivot, float pixelsToUnits, Texture2D texture)
		{
			IntPtr intPtr = Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegateField(ref rect, ref pivot, pixelsToUnits, IL2CPP.Il2CppObjectBaseToPtr(texture));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_GetPacked_Internal_Int32_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Internal_Vector4_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Public_get_Vector4_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_get_packed_Public_get_Boolean_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_Sprite_Texture2D_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_0;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Void_byref_Bounds_0;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Void_byref_Rect_0;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_get_border_Injected_Private_Void_byref_Vector4_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Void_byref_Vector2_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly Sprite.GetPackingRotationDelegate GetPackingRotationDelegateField;

		// Token: 0x04000F02 RID: 3842
		private static readonly Sprite.GetSecondaryTextureDelegate GetSecondaryTextureDelegateField;

		// Token: 0x04000F03 RID: 3843
		private static readonly Sprite.get_spriteAtlasTextureScaleDelegate get_spriteAtlasTextureScaleDelegateField;

		// Token: 0x04000F04 RID: 3844
		private static readonly Sprite.GetPhysicsShapeCountDelegate GetPhysicsShapeCountDelegateField;

		// Token: 0x04000F05 RID: 3845
		private static readonly Sprite.Internal_GetPhysicsShapePointCountDelegate Internal_GetPhysicsShapePointCountDelegateField;

		// Token: 0x04000F06 RID: 3846
		private static readonly Sprite.GetPhysicsShapeImplDelegate GetPhysicsShapeImplDelegateField;

		// Token: 0x04000F07 RID: 3847
		private static readonly Sprite.OverridePhysicsShapeCountDelegate OverridePhysicsShapeCountDelegateField;

		// Token: 0x04000F08 RID: 3848
		private static readonly Sprite.OverridePhysicsShapeDelegate OverridePhysicsShapeDelegateField;

		// Token: 0x04000F09 RID: 3849
		private static readonly Sprite.OverrideGeometryDelegate OverrideGeometryDelegateField;

		// Token: 0x04000F0A RID: 3850
		private static readonly Sprite.GetTextureRectOffset_InjectedDelegate GetTextureRectOffset_InjectedDelegateField;

		// Token: 0x04000F0B RID: 3851
		private static readonly Sprite.CreateSpriteWithoutTextureScripting_InjectedDelegate CreateSpriteWithoutTextureScripting_InjectedDelegateField;

		// Token: 0x02000875 RID: 2165
		// (Invoke) Token: 0x06002E9D RID: 11933
		private delegate int GetPackingRotationDelegate(IntPtr @this);

		// Token: 0x02000876 RID: 2166
		// (Invoke) Token: 0x06002E9F RID: 11935
		private delegate IntPtr GetSecondaryTextureDelegate(IntPtr @this, int index);

		// Token: 0x02000877 RID: 2167
		// (Invoke) Token: 0x06002EA1 RID: 11937
		private delegate float get_spriteAtlasTextureScaleDelegate(IntPtr @this);

		// Token: 0x02000878 RID: 2168
		// (Invoke) Token: 0x06002EA3 RID: 11939
		private delegate int GetPhysicsShapeCountDelegate(IntPtr @this);

		// Token: 0x02000879 RID: 2169
		// (Invoke) Token: 0x06002EA5 RID: 11941
		private delegate int Internal_GetPhysicsShapePointCountDelegate(IntPtr @this, int shapeIdx);

		// Token: 0x0200087A RID: 2170
		// (Invoke) Token: 0x06002EA7 RID: 11943
		private delegate void GetPhysicsShapeImplDelegate(IntPtr sprite, int shapeIdx, IntPtr physicsShape);

		// Token: 0x0200087B RID: 2171
		// (Invoke) Token: 0x06002EA9 RID: 11945
		private delegate void OverridePhysicsShapeCountDelegate(IntPtr sprite, int physicsShapeCount);

		// Token: 0x0200087C RID: 2172
		// (Invoke) Token: 0x06002EAB RID: 11947
		private delegate void OverridePhysicsShapeDelegate(IntPtr sprite, IntPtr physicsShape, int idx);

		// Token: 0x0200087D RID: 2173
		// (Invoke) Token: 0x06002EAD RID: 11949
		private delegate void OverrideGeometryDelegate(IntPtr @this, IntPtr vertices, IntPtr triangles);

		// Token: 0x0200087E RID: 2174
		// (Invoke) Token: 0x06002EAF RID: 11951
		private delegate void GetTextureRectOffset_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200087F RID: 2175
		// (Invoke) Token: 0x06002EB1 RID: 11953
		private delegate IntPtr CreateSpriteWithoutTextureScripting_InjectedDelegate(IntPtr rect, IntPtr pivot, float pixelsToUnits, IntPtr texture);
	}
}
