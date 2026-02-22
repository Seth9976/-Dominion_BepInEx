using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000008 RID: 8
	public sealed class TileData : ValueType
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00003FF4 File Offset: 0x000021F4
		// Note: this type is marked as 'beforefieldinit'.
		static TileData()
		{
			Il2CppClassPointerStore<TileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileData>.NativeClassPtr);
			TileData.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Sprite");
			TileData.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Color");
			TileData.NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Transform");
			TileData.NativeFieldInfoPtr_m_GameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_GameObject");
			TileData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_Flags");
			TileData.NativeFieldInfoPtr_m_ColliderType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileData>.NativeClassPtr, "m_ColliderType");
			TileData.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663326);
			TileData.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663327);
			TileData.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663328);
			TileData.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663329);
			TileData.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663330);
			TileData.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileData>.NativeClassPtr, 100663331);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000043B4 File Offset: 0x000025B4
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00004114 File Offset: 0x00002314
		public unsafe Sprite sprite
		{
			get
			{
				return this.m_Sprite;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000043CC File Offset: 0x000025CC
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000415C File Offset: 0x0000235C
		public unsafe Color color
		{
			get
			{
				return this.m_Color;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000043E4 File Offset: 0x000025E4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000041A0 File Offset: 0x000023A0
		public unsafe Matrix4x4 transform
		{
			get
			{
				return this.m_Transform;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000043FC File Offset: 0x000025FC
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x000041E4 File Offset: 0x000023E4
		public unsafe GameObject gameObject
		{
			get
			{
				return this.m_GameObject;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00004414 File Offset: 0x00002614
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000422C File Offset: 0x0000242C
		public unsafe TileFlags flags
		{
			get
			{
				return this.m_Flags;
			}
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 90728, RefRangeEnd = 90897, XrefRangeStart = 90728, XrefRangeEnd = 90728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000442C File Offset: 0x0000262C
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00004270 File Offset: 0x00002470
		public unsafe Tile.ColliderType colliderType
		{
			get
			{
				return this.m_ColliderType;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileData.NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000027B1 File Offset: 0x000009B1
		public TileData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000027BA File Offset: 0x000009BA
		public TileData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileData>.NativeClassPtr))
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x000042B4 File Offset: 0x000024B4
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x000027CC File Offset: 0x000009CC
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000042E4 File Offset: 0x000024E4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000027EB File Offset: 0x000009EB
		public unsafe Color m_Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Color)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000430C File Offset: 0x0000250C
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00002806 File Offset: 0x00000A06
		public unsafe Matrix4x4 m_Transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Transform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Transform)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004334 File Offset: 0x00002534
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002821 File Offset: 0x00000A21
		public unsafe GameObject m_GameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_GameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_GameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004364 File Offset: 0x00002564
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002840 File Offset: 0x00000A40
		public unsafe TileFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000438C File Offset: 0x0000258C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000285B File Offset: 0x00000A5B
		public unsafe Tile.ColliderType m_ColliderType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_ColliderType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileData.NativeFieldInfoPtr_m_ColliderType)) = value;
			}
		}

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_Color;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_Transform;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_m_GameObject;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_m_ColliderType;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_transform_Public_set_Void_Matrix4x4_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_gameObject_Public_set_Void_GameObject_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_TileFlags_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_set_colliderType_Public_set_Void_ColliderType_0;
	}
}
