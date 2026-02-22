using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000A7 RID: 167
	[StructLayout(2)]
	public struct Vertex
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x00028B2C File Offset: 0x00026D2C
		// Note: this type is marked as 'beforefieldinit'.
		static Vertex()
		{
			Il2CppClassPointerStore<Vertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Vertex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vertex>.NativeClassPtr);
			Vertex.NativeFieldInfoPtr_nearZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "nearZ");
			Vertex.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "position");
			Vertex.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "tint");
			Vertex.NativeFieldInfoPtr_uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "uv");
			Vertex.NativeFieldInfoPtr_xformClipPages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "xformClipPages");
			Vertex.NativeFieldInfoPtr_ids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "ids");
			Vertex.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "flags");
			Vertex.NativeFieldInfoPtr_opacityPageSettingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "opacityPageSettingIndex");
			Vertex.NativeFieldInfoPtr_textureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "textureId");
			Vertex.NativeFieldInfoPtr_idsFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vertex>.NativeClassPtr, "idsFlags");
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00005A7D File Offset: 0x00003C7D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vertex>.NativeClassPtr, ref this));
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00028C24 File Offset: 0x00026E24
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00005A8F File Offset: 0x00003C8F
		public unsafe static float nearZ
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vertex.NativeFieldInfoPtr_nearZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vertex.NativeFieldInfoPtr_nearZ, (void*)(&value));
			}
		}

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_nearZ;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_uv;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_xformClipPages;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_ids;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeFieldInfoPtr_opacityPageSettingIndex;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeFieldInfoPtr_textureId;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeFieldInfoPtr_idsFlags;

		// Token: 0x040004E8 RID: 1256
		[FieldOffset(0)]
		public Vector3 position;

		// Token: 0x040004E9 RID: 1257
		[FieldOffset(12)]
		public Color32 tint;

		// Token: 0x040004EA RID: 1258
		[FieldOffset(16)]
		public Vector2 uv;

		// Token: 0x040004EB RID: 1259
		[FieldOffset(24)]
		public Color32 xformClipPages;

		// Token: 0x040004EC RID: 1260
		[FieldOffset(28)]
		public Color32 ids;

		// Token: 0x040004ED RID: 1261
		[FieldOffset(32)]
		public Color32 flags;

		// Token: 0x040004EE RID: 1262
		[FieldOffset(36)]
		public Color32 opacityPageSettingIndex;

		// Token: 0x040004EF RID: 1263
		[FieldOffset(40)]
		public float textureId;

		// Token: 0x040004F0 RID: 1264
		[FieldOffset(44)]
		public Color32 idsFlags;
	}
}
