using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000002 RID: 2
	public class ITilemap : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000029CC File Offset: 0x00000BCC
		// Note: this type is marked as 'beforefieldinit'.
		static ITilemap()
		{
			Il2CppClassPointerStore<ITilemap>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "ITilemap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITilemap>.NativeClassPtr);
			ITilemap.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "s_Instance");
			ITilemap.NativeFieldInfoPtr_m_Tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, "m_Tilemap");
			ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663297);
			ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663298);
			ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITilemap>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002A60 File Offset: 0x00000C60
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITilemap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITilemap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002A9C File Offset: 0x00000C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90685, XrefRangeEnd = 90687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTile(Vector3Int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002ADC File Offset: 0x00000CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90687, XrefRangeEnd = 90693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ITilemap CreateInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITilemap.NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr3) : null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public ITilemap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002B10 File Offset: 0x00000D10
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static ITilemap s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ITilemap.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITilemap>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ITilemap.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002B38 File Offset: 0x00000D38
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe Tilemap m_Tilemap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ITilemap.NativeFieldInfoPtr_m_Tilemap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000208A File Offset: 0x0000028A
		public void SetTilemapInstance(Tilemap tilemap)
		{
			this.m_Tilemap = tilemap;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002B68 File Offset: 0x00000D68
		public Vector3Int origin
		{
			get
			{
				return this.m_Tilemap.origin;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002B88 File Offset: 0x00000D88
		public Vector3Int size
		{
			get
			{
				return this.m_Tilemap.size;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public Bounds localBounds
		{
			get
			{
				return this.m_Tilemap.localBounds;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public BoundsInt cellBounds
		{
			get
			{
				return this.m_Tilemap.cellBounds;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public virtual Sprite GetSprite(Vector3Int position)
		{
			return this.m_Tilemap.GetSprite(position);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C08 File Offset: 0x00000E08
		public virtual Color GetColor(Vector3Int position)
		{
			return this.m_Tilemap.GetColor(position);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002C28 File Offset: 0x00000E28
		public virtual Matrix4x4 GetTransformMatrix(Vector3Int position)
		{
			return this.m_Tilemap.GetTransformMatrix(position);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002C48 File Offset: 0x00000E48
		public virtual TileFlags GetTileFlags(Vector3Int position)
		{
			return this.m_Tilemap.GetTileFlags(position);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002C68 File Offset: 0x00000E68
		public virtual TileBase GetTile(Vector3Int position)
		{
			return this.m_Tilemap.GetTile(position);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C88 File Offset: 0x00000E88
		public virtual T GetTile<T>(Vector3Int position) where T : TileBase
		{
			return this.m_Tilemap.GetTile<T>(position);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public T GetComponent<T>()
		{
			return this.m_Tilemap.GetComponent<T>();
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_Tilemap;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Void_Vector3Int_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_ITilemap_0;
	}
}
