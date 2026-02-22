using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.U2D
{
	// Token: 0x02000155 RID: 341
	[StructLayout(2)]
	public struct SpriteIntermediateRendererInfo
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x0005E348 File Offset: 0x0005C548
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteIntermediateRendererInfo()
		{
			Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", "SpriteIntermediateRendererInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr);
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SpriteID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SpriteID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_TextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "TextureID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_MaterialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "MaterialID");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Color");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Transform");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Bounds");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "Layer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingLayer");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SortingOrder");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_SceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "SceneCullingMask");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexData");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_IndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "IndexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "VertexCount");
			SpriteIntermediateRendererInfo.NativeFieldInfoPtr_ShaderChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, "ShaderChannelMask");
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0000EB01 File Offset: 0x0000CD01
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteIntermediateRendererInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr_SpriteID;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_TextureID;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_MaterialID;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeFieldInfoPtr_Transform;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeFieldInfoPtr_Bounds;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeFieldInfoPtr_Layer;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeFieldInfoPtr_SortingLayer;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeFieldInfoPtr_SortingOrder;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_SceneCullingMask;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_IndexData;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_VertexData;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_IndexCount;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_VertexCount;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_ShaderChannelMask;

		// Token: 0x0400133F RID: 4927
		[FieldOffset(0)]
		public int SpriteID;

		// Token: 0x04001340 RID: 4928
		[FieldOffset(4)]
		public int TextureID;

		// Token: 0x04001341 RID: 4929
		[FieldOffset(8)]
		public int MaterialID;

		// Token: 0x04001342 RID: 4930
		[FieldOffset(12)]
		public Color Color;

		// Token: 0x04001343 RID: 4931
		[FieldOffset(28)]
		public Matrix4x4 Transform;

		// Token: 0x04001344 RID: 4932
		[FieldOffset(92)]
		public Bounds Bounds;

		// Token: 0x04001345 RID: 4933
		[FieldOffset(116)]
		public int Layer;

		// Token: 0x04001346 RID: 4934
		[FieldOffset(120)]
		public int SortingLayer;

		// Token: 0x04001347 RID: 4935
		[FieldOffset(124)]
		public int SortingOrder;

		// Token: 0x04001348 RID: 4936
		[FieldOffset(128)]
		public ulong SceneCullingMask;

		// Token: 0x04001349 RID: 4937
		[FieldOffset(136)]
		public IntPtr IndexData;

		// Token: 0x0400134A RID: 4938
		[FieldOffset(144)]
		public IntPtr VertexData;

		// Token: 0x0400134B RID: 4939
		[FieldOffset(152)]
		public int IndexCount;

		// Token: 0x0400134C RID: 4940
		[FieldOffset(156)]
		public int VertexCount;

		// Token: 0x0400134D RID: 4941
		[FieldOffset(160)]
		public int ShaderChannelMask;
	}
}
