using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AA RID: 170
	public class TextureRegistry : Object
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x00028EE8 File Offset: 0x000270E8
		// Note: this type is marked as 'beforefieldinit'.
		static TextureRegistry()
		{
			Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextureRegistry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr);
			TextureRegistry.NativeFieldInfoPtr_m_Textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_Textures");
			TextureRegistry.NativeFieldInfoPtr_m_TextureToId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_TextureToId");
			TextureRegistry.NativeFieldInfoPtr_m_FreeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "m_FreeIds");
			TextureRegistry.NativeFieldInfoPtr_maxTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "maxTextures");
			TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "<instance>k__BackingField");
			TextureRegistry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, 100664150);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00028F90 File Offset: 0x00027190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96606, XrefRangeEnd = 96625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureRegistry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureRegistry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00005B28 File Offset: 0x00003D28
		public TextureRegistry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00028FCC File Offset: 0x000271CC
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00005B31 File Offset: 0x00003D31
		public unsafe List<TextureRegistry.TextureInfo> m_Textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_Textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextureRegistry.TextureInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_Textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00028FFC File Offset: 0x000271FC
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00005B50 File Offset: 0x00003D50
		public unsafe Dictionary<Texture, TextureId> m_TextureToId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_TextureToId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Texture, TextureId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_TextureToId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0002902C File Offset: 0x0002722C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00005B6F File Offset: 0x00003D6F
		public unsafe Stack<TextureId> m_FreeIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_FreeIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<TextureId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.NativeFieldInfoPtr_m_FreeIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0002905C File Offset: 0x0002725C
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00005B8E File Offset: 0x00003D8E
		public unsafe static int maxTextures
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TextureRegistry.NativeFieldInfoPtr_maxTextures, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureRegistry.NativeFieldInfoPtr_maxTextures, (void*)(&value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00029078 File Offset: 0x00027278
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00005B9C File Offset: 0x00003D9C
		public unsafe static TextureRegistry _instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureRegistry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextureRegistry.NativeFieldInfoPtr__instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00005BAE File Offset: 0x00003DAE
		public static TextureRegistry instance
		{
			get
			{
				return TextureRegistry._instance_k__BackingField;
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000290A0 File Offset: 0x000272A0
		public Texture GetTexture(TextureId id)
		{
			bool flag = id.index < 0 || id.index >= this.m_Textures.Count;
			Texture texture;
			if (flag)
			{
				Debug.LogError(String.Format("Attempted to get an invalid texture (index={0}).", id.index));
				texture = null;
			}
			else
			{
				TextureRegistry.TextureInfo textureInfo = this.m_Textures[id.index];
				bool flag2 = textureInfo.refCount < 1;
				if (flag2)
				{
					Debug.LogError(String.Format("Attempted to get a texture (index={0}) that is not allocated.", id.index));
					texture = null;
				}
				else
				{
					texture = textureInfo.texture;
				}
			}
			return texture;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00029144 File Offset: 0x00027344
		public TextureId AllocAndAcquireDynamic()
		{
			return this.AllocAndAcquire(null, true);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00029160 File Offset: 0x00027360
		public void UpdateDynamic(TextureId id, Texture texture)
		{
			bool flag = id.index < 0 || id.index >= this.m_Textures.Count;
			if (flag)
			{
				Debug.LogError(String.Format("Attempted to update an invalid dynamic texture (index={0}).", id.index));
			}
			else
			{
				TextureRegistry.TextureInfo textureInfo = this.m_Textures[id.index];
				bool flag2 = !textureInfo.dynamic;
				if (flag2)
				{
					Debug.LogError(String.Format("Attempted to update a texture (index={0}) that is not dynamic.", id.index));
				}
				else
				{
					bool flag3 = textureInfo.refCount < 1;
					if (flag3)
					{
						Debug.LogError(String.Format("Attempted to update a dynamic texture (index={0}) that is not allocated.", id.index));
					}
					else
					{
						textureInfo.texture = texture;
						this.m_Textures[id.index] = textureInfo;
					}
				}
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00029240 File Offset: 0x00027440
		public TextureId AllocAndAcquire(Texture texture, bool dynamic)
		{
			TextureRegistry.TextureInfo textureInfo = null;
			textureInfo.texture = texture;
			textureInfo.dynamic = dynamic;
			textureInfo.refCount = 1;
			TextureRegistry.TextureInfo textureInfo2 = textureInfo;
			bool flag = this.m_FreeIds.Count > 0;
			TextureId textureId;
			if (flag)
			{
				textureId = this.m_FreeIds.Pop();
				this.m_Textures[textureId.index] = textureInfo2;
			}
			else
			{
				bool flag2 = this.m_Textures.Count == 2048;
				if (flag2)
				{
					Debug.LogError(String.Format("Failed to allocate a {0} because the limit of {1} textures is reached.", "TextureId", 2048));
					return TextureId.invalid;
				}
				textureId = new TextureId(this.m_Textures.Count);
				this.m_Textures.Add(textureInfo2);
			}
			bool flag3 = !dynamic;
			if (flag3)
			{
				this.m_TextureToId[texture] = textureId;
			}
			return textureId;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public TextureId Acquire(Texture tex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00005BC2 File Offset: 0x00003DC2
		public void Acquire(TextureId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00005BCF File Offset: 0x00003DCF
		public void Release(TextureId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00029328 File Offset: 0x00027528
		public TextureId TextureToId(Texture texture)
		{
			TextureId textureId;
			bool flag = this.m_TextureToId.TryGetValue(texture, out textureId);
			TextureId textureId2;
			if (flag)
			{
				textureId2 = textureId;
			}
			else
			{
				textureId2 = TextureId.invalid;
			}
			return textureId2;
		}

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeFieldInfoPtr_m_Textures;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureToId;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeFieldInfoPtr_m_FreeIds;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeFieldInfoPtr_maxTextures;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeFieldInfoPtr__instance_k__BackingField;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200021D RID: 541
		public sealed class TextureInfo : ValueType
		{
			// Token: 0x060013A9 RID: 5033 RVA: 0x0003C4FC File Offset: 0x0003A6FC
			// Note: this type is marked as 'beforefieldinit'.
			static TextureInfo()
			{
				Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureRegistry>.NativeClassPtr, "TextureInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr);
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "texture");
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "dynamic");
				TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr, "refCount");
			}

			// Token: 0x060013AA RID: 5034 RVA: 0x0000C93B File Offset: 0x0000AB3B
			public TextureInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060013AB RID: 5035 RVA: 0x0000C944 File Offset: 0x0000AB44
			public TextureInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureRegistry.TextureInfo>.NativeClassPtr))
			{
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x060013AC RID: 5036 RVA: 0x0003C564 File Offset: 0x0003A764
			// (set) Token: 0x060013AD RID: 5037 RVA: 0x0000C956 File Offset: 0x0000AB56
			public unsafe Texture texture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x060013AE RID: 5038 RVA: 0x0003C594 File Offset: 0x0003A794
			// (set) Token: 0x060013AF RID: 5039 RVA: 0x0000C975 File Offset: 0x0000AB75
			public unsafe bool dynamic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_dynamic)) = value;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0003C5BC File Offset: 0x0003A7BC
			// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0000C990 File Offset: 0x0000AB90
			public unsafe int refCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextureRegistry.TextureInfo.NativeFieldInfoPtr_refCount)) = value;
				}
			}

			// Token: 0x040008D0 RID: 2256
			private static readonly IntPtr NativeFieldInfoPtr_texture;

			// Token: 0x040008D1 RID: 2257
			private static readonly IntPtr NativeFieldInfoPtr_dynamic;

			// Token: 0x040008D2 RID: 2258
			private static readonly IntPtr NativeFieldInfoPtr_refCount;
		}
	}
}
