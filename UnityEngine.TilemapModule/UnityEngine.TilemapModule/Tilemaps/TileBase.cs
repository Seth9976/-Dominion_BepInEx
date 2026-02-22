using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000004 RID: 4
	public class TileBase : ScriptableObject
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000332C File Offset: 0x0000152C
		// Note: this type is marked as 'beforefieldinit'.
		static TileBase()
		{
			Il2CppClassPointerStore<TileBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileBase>.NativeClassPtr);
			TileBase.NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663314);
			TileBase.NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663315);
			TileBase.NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663316);
			TileBase.NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663317);
			TileBase.NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663318);
			TileBase.NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663319);
			TileBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileBase>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000033E8 File Offset: 0x000015E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90696, XrefRangeEnd = 90698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTile(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003444 File Offset: 0x00001644
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000034B4 File Offset: 0x000016B4
		[CallerCount(0)]
		public unsafe TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TileData(intPtr);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000350C File Offset: 0x0000170C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(tileAnimationData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003588 File Offset: 0x00001788
		[CallerCount(0)]
		public unsafe TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TileAnimationData(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000035E0 File Offset: 0x000017E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 59613, RefRangeEnd = 59618, XrefRangeStart = 59613, XrefRangeEnd = 59618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tilemap);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileBase.NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003658 File Offset: 0x00001858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 82720, RefRangeEnd = 82724, XrefRangeStart = 82720, XrefRangeEnd = 82724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002147 File Offset: 0x00000347
		public TileBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTile_Public_Virtual_New_Void_Vector3Int_ITilemap_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_GetTileData_Public_Virtual_New_Void_Vector3Int_ITilemap_byref_TileData_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_GetTileDataNoRef_Private_TileData_Vector3Int_ITilemap_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_GetTileAnimationData_Public_Virtual_New_Boolean_Vector3Int_ITilemap_byref_TileAnimationData_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_GetTileAnimationDataNoRef_Private_TileAnimationData_Vector3Int_ITilemap_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_StartUp_Public_Virtual_New_Boolean_Vector3Int_ITilemap_GameObject_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
