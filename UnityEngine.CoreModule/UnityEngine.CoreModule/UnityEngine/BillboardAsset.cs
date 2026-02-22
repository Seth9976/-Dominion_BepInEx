using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020001D8 RID: 472
	public sealed class BillboardAsset : Object
	{
		// Token: 0x06001C9A RID: 7322 RVA: 0x0000FB8D File Offset: 0x0000DD8D
		public static void Internal_Create(BillboardAsset obj)
		{
			BillboardAsset.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001C9B RID: 7323 RVA: 0x0000FB9F File Offset: 0x0000DD9F
		// (set) Token: 0x06001C9C RID: 7324 RVA: 0x0000FBB1 File Offset: 0x0000DDB1
		public float width
		{
			get
			{
				return BillboardAsset.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001C9D RID: 7325 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		// (set) Token: 0x06001C9E RID: 7326 RVA: 0x0000FBD6 File Offset: 0x0000DDD6
		public float height
		{
			get
			{
				return BillboardAsset.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001C9F RID: 7327 RVA: 0x0000FBE9 File Offset: 0x0000DDE9
		// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0000FBFB File Offset: 0x0000DDFB
		public float bottom
		{
			get
			{
				return BillboardAsset.get_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x0000FC0E File Offset: 0x0000DE0E
		public int imageCount
		{
			get
			{
				return BillboardAsset.get_imageCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public int vertexCount
		{
			get
			{
				return BillboardAsset.get_vertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0000FC32 File Offset: 0x0000DE32
		public int indexCount
		{
			get
			{
				return BillboardAsset.get_indexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x000628B4 File Offset: 0x00060AB4
		// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x0000FC44 File Offset: 0x0000DE44
		public Material material
		{
			get
			{
				IntPtr intPtr = BillboardAsset.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				BillboardAsset.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000628E0 File Offset: 0x00060AE0
		public void GetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.GetImageTexCoordsInternal(imageTexCoords);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0006290C File Offset: 0x00060B0C
		public Il2CppStructArray<Vector4> GetImageTexCoords()
		{
			IntPtr intPtr = BillboardAsset.GetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0000FC5C File Offset: 0x0000DE5C
		public void GetImageTexCoordsInternal(Object list)
		{
			BillboardAsset.GetImageTexCoordsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00062938 File Offset: 0x00060B38
		public void SetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.SetImageTexCoordsInternalList(imageTexCoords);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0000FC74 File Offset: 0x0000DE74
		public void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
		{
			BillboardAsset.SetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(imageTexCoords));
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0000FC8C File Offset: 0x0000DE8C
		public void SetImageTexCoordsInternalList(Object list)
		{
			BillboardAsset.SetImageTexCoordsInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00062964 File Offset: 0x00060B64
		public void GetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00062990 File Offset: 0x00060B90
		public Il2CppStructArray<Vector2> GetVertices()
		{
			IntPtr intPtr = BillboardAsset.GetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public void GetVerticesInternal(Object list)
		{
			BillboardAsset.GetVerticesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000629BC File Offset: 0x00060BBC
		public void SetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.SetVerticesInternalList(vertices);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0000FCBC File Offset: 0x0000DEBC
		public void SetVertices(Il2CppStructArray<Vector2> vertices)
		{
			BillboardAsset.SetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices));
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		public void SetVerticesInternalList(Object list)
		{
			BillboardAsset.SetVerticesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000629E8 File Offset: 0x00060BE8
		public void GetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.GetIndicesInternal(indices);
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00062A14 File Offset: 0x00060C14
		public Il2CppStructArray<ushort> GetIndices()
		{
			IntPtr intPtr = BillboardAsset.GetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0000FCEC File Offset: 0x0000DEEC
		public void GetIndicesInternal(Object list)
		{
			BillboardAsset.GetIndicesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00062A40 File Offset: 0x00060C40
		public void SetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.SetIndicesInternalList(indices);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public void SetIndices(Il2CppStructArray<ushort> indices)
		{
			BillboardAsset.SetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0000FD1C File Offset: 0x0000DF1C
		public void SetIndicesInternalList(Object list)
		{
			BillboardAsset.SetIndicesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0000FD34 File Offset: 0x0000DF34
		public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
		{
			BillboardAsset.MakeMaterialPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x04001686 RID: 5766
		private static readonly BillboardAsset.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<BillboardAsset.Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");

		// Token: 0x04001687 RID: 5767
		private static readonly BillboardAsset.get_widthDelegate get_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_widthDelegate>("UnityEngine.BillboardAsset::get_width");

		// Token: 0x04001688 RID: 5768
		private static readonly BillboardAsset.set_widthDelegate set_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_widthDelegate>("UnityEngine.BillboardAsset::set_width");

		// Token: 0x04001689 RID: 5769
		private static readonly BillboardAsset.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_heightDelegate>("UnityEngine.BillboardAsset::get_height");

		// Token: 0x0400168A RID: 5770
		private static readonly BillboardAsset.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_heightDelegate>("UnityEngine.BillboardAsset::set_height");

		// Token: 0x0400168B RID: 5771
		private static readonly BillboardAsset.get_bottomDelegate get_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_bottomDelegate>("UnityEngine.BillboardAsset::get_bottom");

		// Token: 0x0400168C RID: 5772
		private static readonly BillboardAsset.set_bottomDelegate set_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_bottomDelegate>("UnityEngine.BillboardAsset::set_bottom");

		// Token: 0x0400168D RID: 5773
		private static readonly BillboardAsset.get_imageCountDelegate get_imageCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_imageCountDelegate>("UnityEngine.BillboardAsset::get_imageCount");

		// Token: 0x0400168E RID: 5774
		private static readonly BillboardAsset.get_vertexCountDelegate get_vertexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_vertexCountDelegate>("UnityEngine.BillboardAsset::get_vertexCount");

		// Token: 0x0400168F RID: 5775
		private static readonly BillboardAsset.get_indexCountDelegate get_indexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_indexCountDelegate>("UnityEngine.BillboardAsset::get_indexCount");

		// Token: 0x04001690 RID: 5776
		private static readonly BillboardAsset.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_materialDelegate>("UnityEngine.BillboardAsset::get_material");

		// Token: 0x04001691 RID: 5777
		private static readonly BillboardAsset.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_materialDelegate>("UnityEngine.BillboardAsset::set_material");

		// Token: 0x04001692 RID: 5778
		private static readonly BillboardAsset.GetImageTexCoordsDelegate GetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords");

		// Token: 0x04001693 RID: 5779
		private static readonly BillboardAsset.GetImageTexCoordsInternalDelegate GetImageTexCoordsInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsInternalDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal");

		// Token: 0x04001694 RID: 5780
		private static readonly BillboardAsset.SetImageTexCoordsDelegate SetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords");

		// Token: 0x04001695 RID: 5781
		private static readonly BillboardAsset.SetImageTexCoordsInternalListDelegate SetImageTexCoordsInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsInternalListDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList");

		// Token: 0x04001696 RID: 5782
		private static readonly BillboardAsset.GetVerticesDelegate GetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesDelegate>("UnityEngine.BillboardAsset::GetVertices");

		// Token: 0x04001697 RID: 5783
		private static readonly BillboardAsset.GetVerticesInternalDelegate GetVerticesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesInternalDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal");

		// Token: 0x04001698 RID: 5784
		private static readonly BillboardAsset.SetVerticesDelegate SetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesDelegate>("UnityEngine.BillboardAsset::SetVertices");

		// Token: 0x04001699 RID: 5785
		private static readonly BillboardAsset.SetVerticesInternalListDelegate SetVerticesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesInternalListDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList");

		// Token: 0x0400169A RID: 5786
		private static readonly BillboardAsset.GetIndicesDelegate GetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesDelegate>("UnityEngine.BillboardAsset::GetIndices");

		// Token: 0x0400169B RID: 5787
		private static readonly BillboardAsset.GetIndicesInternalDelegate GetIndicesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesInternalDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal");

		// Token: 0x0400169C RID: 5788
		private static readonly BillboardAsset.SetIndicesDelegate SetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesDelegate>("UnityEngine.BillboardAsset::SetIndices");

		// Token: 0x0400169D RID: 5789
		private static readonly BillboardAsset.SetIndicesInternalListDelegate SetIndicesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesInternalListDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList");

		// Token: 0x0400169E RID: 5790
		private static readonly BillboardAsset.MakeMaterialPropertiesDelegate MakeMaterialPropertiesDelegateField = IL2CPP.ResolveICall<BillboardAsset.MakeMaterialPropertiesDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties");

		// Token: 0x02000AB9 RID: 2745
		// (Invoke) Token: 0x06003372 RID: 13170
		private delegate void Internal_CreateDelegate(IntPtr obj);

		// Token: 0x02000ABA RID: 2746
		// (Invoke) Token: 0x06003374 RID: 13172
		private delegate float get_widthDelegate(IntPtr @this);

		// Token: 0x02000ABB RID: 2747
		// (Invoke) Token: 0x06003376 RID: 13174
		private delegate void set_widthDelegate(IntPtr @this, float value);

		// Token: 0x02000ABC RID: 2748
		// (Invoke) Token: 0x06003378 RID: 13176
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000ABD RID: 2749
		// (Invoke) Token: 0x0600337A RID: 13178
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000ABE RID: 2750
		// (Invoke) Token: 0x0600337C RID: 13180
		private delegate float get_bottomDelegate(IntPtr @this);

		// Token: 0x02000ABF RID: 2751
		// (Invoke) Token: 0x0600337E RID: 13182
		private delegate void set_bottomDelegate(IntPtr @this, float value);

		// Token: 0x02000AC0 RID: 2752
		// (Invoke) Token: 0x06003380 RID: 13184
		private delegate int get_imageCountDelegate(IntPtr @this);

		// Token: 0x02000AC1 RID: 2753
		// (Invoke) Token: 0x06003382 RID: 13186
		private delegate int get_vertexCountDelegate(IntPtr @this);

		// Token: 0x02000AC2 RID: 2754
		// (Invoke) Token: 0x06003384 RID: 13188
		private delegate int get_indexCountDelegate(IntPtr @this);

		// Token: 0x02000AC3 RID: 2755
		// (Invoke) Token: 0x06003386 RID: 13190
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000AC4 RID: 2756
		// (Invoke) Token: 0x06003388 RID: 13192
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000AC5 RID: 2757
		// (Invoke) Token: 0x0600338A RID: 13194
		private delegate IntPtr GetImageTexCoordsDelegate(IntPtr @this);

		// Token: 0x02000AC6 RID: 2758
		// (Invoke) Token: 0x0600338C RID: 13196
		private delegate void GetImageTexCoordsInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AC7 RID: 2759
		// (Invoke) Token: 0x0600338E RID: 13198
		private delegate void SetImageTexCoordsDelegate(IntPtr @this, IntPtr imageTexCoords);

		// Token: 0x02000AC8 RID: 2760
		// (Invoke) Token: 0x06003390 RID: 13200
		private delegate void SetImageTexCoordsInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AC9 RID: 2761
		// (Invoke) Token: 0x06003392 RID: 13202
		private delegate IntPtr GetVerticesDelegate(IntPtr @this);

		// Token: 0x02000ACA RID: 2762
		// (Invoke) Token: 0x06003394 RID: 13204
		private delegate void GetVerticesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000ACB RID: 2763
		// (Invoke) Token: 0x06003396 RID: 13206
		private delegate void SetVerticesDelegate(IntPtr @this, IntPtr vertices);

		// Token: 0x02000ACC RID: 2764
		// (Invoke) Token: 0x06003398 RID: 13208
		private delegate void SetVerticesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000ACD RID: 2765
		// (Invoke) Token: 0x0600339A RID: 13210
		private delegate IntPtr GetIndicesDelegate(IntPtr @this);

		// Token: 0x02000ACE RID: 2766
		// (Invoke) Token: 0x0600339C RID: 13212
		private delegate void GetIndicesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000ACF RID: 2767
		// (Invoke) Token: 0x0600339E RID: 13214
		private delegate void SetIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x02000AD0 RID: 2768
		// (Invoke) Token: 0x060033A0 RID: 13216
		private delegate void SetIndicesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000AD1 RID: 2769
		// (Invoke) Token: 0x060033A2 RID: 13218
		private delegate void MakeMaterialPropertiesDelegate(IntPtr @this, IntPtr properties, IntPtr camera);
	}
}
