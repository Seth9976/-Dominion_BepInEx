using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class Tile : TileBase
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002CC8 File Offset: 0x00000EC8
		// Note: this type is marked as 'beforefieldinit'.
		static Tile()
		{
			Il2CppClassPointerStore<Tile>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "Tile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tile>.NativeClassPtr);
			Tile.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_Sprite");
			Tile.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_Color");
			Tile.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_Transform");
			Tile.NativeFieldInfoPtr_m_InstancedGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_InstancedGameObject");
			Tile.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_Flags");
			Tile.NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "m_ColliderType");
			Tile.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663300);
			Tile.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663301);
			Tile.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663302);
			Tile.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663303);
			Tile.NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663304);
			Tile.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663305);
			Tile.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663306);
			Tile.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663307);
			Tile.NativeMethodInfoPtr_get_flags_Public_get_TileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663308);
			Tile.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663309);
			Tile.NativeMethodInfoPtr_get_colliderType_Public_get_ColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663310);
			Tile.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663311);
			Tile.NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663312);
			Tile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100663313);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002E88 File Offset: 0x00001088
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002EC8 File Offset: 0x000010C8
		public unsafe Sprite sprite
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002F48 File Offset: 0x00001148
		public unsafe Color color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002FC4 File Offset: 0x000011C4
		public unsafe Matrix4x4 transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003004 File Offset: 0x00001204
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003044 File Offset: 0x00001244
		public unsafe GameObject gameObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003088 File Offset: 0x00001288
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000030C4 File Offset: 0x000012C4
		public unsafe TileFlags flags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_flags_Public_get_TileFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003104 File Offset: 0x00001304
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe Tile.ColliderType colliderType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_colliderType_Public_get_ColliderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003180 File Offset: 0x00001380
		[CallerCount(0)]
		public unsafe override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(tileData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000031F0 File Offset: 0x000013F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90693, XrefRangeEnd = 90696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002094 File Offset: 0x00000294
		public Tile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000322C File Offset: 0x0000142C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000209D File Offset: 0x0000029D
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000020BC File Offset: 0x000002BC
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003284 File Offset: 0x00001484
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000020D7 File Offset: 0x000002D7
		public unsafe Matrix4x4 m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Transform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Transform)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000032AC File Offset: 0x000014AC
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000020F2 File Offset: 0x000002F2
		public unsafe GameObject m_InstancedGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_InstancedGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_InstancedGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000032DC File Offset: 0x000014DC
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00002111 File Offset: 0x00000311
		public unsafe TileFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003304 File Offset: 0x00001504
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000212C File Offset: 0x0000032C
		public unsafe Tile.ColliderType m_ColliderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_ColliderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_m_ColliderType)) = value;
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_InstancedGameObject;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_ColliderType;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_transform_Public_get_Matrix4x4_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_get_TileFlags_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_colliderType_Public_get_ColliderType_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_GetTileData_Public_Virtual_Void_Vector3Int_ITilemap_byref_TileData_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000D RID: 13
		public enum ColliderType
		{
			// Token: 0x04000084 RID: 132
			None,
			// Token: 0x04000085 RID: 133
			Sprite,
			// Token: 0x04000086 RID: 134
			Grid
		}
	}
}
