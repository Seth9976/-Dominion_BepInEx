using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200021C RID: 540
	public sealed class SparseTexture : Texture
	{
		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x00011A52 File Offset: 0x0000FC52
		public int tileWidth
		{
			get
			{
				return SparseTexture.get_tileWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00011A64 File Offset: 0x0000FC64
		public int tileHeight
		{
			get
			{
				return SparseTexture.get_tileHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00011A76 File Offset: 0x0000FC76
		public bool isCreated
		{
			get
			{
				return SparseTexture.get_isCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00011A88 File Offset: 0x0000FC88
		public static void Internal_Create(SparseTexture mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount)
		{
			SparseTexture.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), width, height, format, mipCount);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00011A9F File Offset: 0x0000FC9F
		public void UpdateTile(int tileX, int tileY, int miplevel, Il2CppStructArray<Color32> data)
		{
			SparseTexture.UpdateTileDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00011ABB File Offset: 0x0000FCBB
		public void UpdateTileRaw(int tileX, int tileY, int miplevel, Il2CppStructArray<byte> data)
		{
			SparseTexture.UpdateTileRawDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00011AD7 File Offset: 0x0000FCD7
		public void UnloadTile(int tileX, int tileY, int miplevel)
		{
			this.UpdateTileRaw(tileX, tileY, miplevel, null);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00064D4C File Offset: 0x00062F4C
		public bool ValidateSize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			bool flag = (ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockSize(format) * (ulong)((long)width / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockWidth(format))) * (ulong)((long)height / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockHeight(format))) < 65536UL;
			bool flag2;
			if (flag)
			{
				Debug.LogError("SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", this);
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00064D9C File Offset: 0x00062F9C
		public static void ValidateIsNotCrunched(TextureFormat textureFormat)
		{
			bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCrunchFormat(textureFormat);
			if (flag)
			{
				throw new ArgumentException("Crunched SparseTexture is not supported.");
			}
		}

		// Token: 0x0400186F RID: 6255
		private static readonly SparseTexture.get_tileWidthDelegate get_tileWidthDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileWidthDelegate>("UnityEngine.SparseTexture::get_tileWidth");

		// Token: 0x04001870 RID: 6256
		private static readonly SparseTexture.get_tileHeightDelegate get_tileHeightDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileHeightDelegate>("UnityEngine.SparseTexture::get_tileHeight");

		// Token: 0x04001871 RID: 6257
		private static readonly SparseTexture.get_isCreatedDelegate get_isCreatedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_isCreatedDelegate>("UnityEngine.SparseTexture::get_isCreated");

		// Token: 0x04001872 RID: 6258
		private static readonly SparseTexture.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<SparseTexture.Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");

		// Token: 0x04001873 RID: 6259
		private static readonly SparseTexture.UpdateTileDelegate UpdateTileDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileDelegate>("UnityEngine.SparseTexture::UpdateTile");

		// Token: 0x04001874 RID: 6260
		private static readonly SparseTexture.UpdateTileRawDelegate UpdateTileRawDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileRawDelegate>("UnityEngine.SparseTexture::UpdateTileRaw");

		// Token: 0x02000BF4 RID: 3060
		// (Invoke) Token: 0x060035DA RID: 13786
		private delegate int get_tileWidthDelegate(IntPtr @this);

		// Token: 0x02000BF5 RID: 3061
		// (Invoke) Token: 0x060035DC RID: 13788
		private delegate int get_tileHeightDelegate(IntPtr @this);

		// Token: 0x02000BF6 RID: 3062
		// (Invoke) Token: 0x060035DE RID: 13790
		private delegate bool get_isCreatedDelegate(IntPtr @this);

		// Token: 0x02000BF7 RID: 3063
		// (Invoke) Token: 0x060035E0 RID: 13792
		private delegate void Internal_CreateDelegate(IntPtr mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);

		// Token: 0x02000BF8 RID: 3064
		// (Invoke) Token: 0x060035E2 RID: 13794
		private delegate void UpdateTileDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);

		// Token: 0x02000BF9 RID: 3065
		// (Invoke) Token: 0x060035E4 RID: 13796
		private delegate void UpdateTileRawDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);
	}
}
