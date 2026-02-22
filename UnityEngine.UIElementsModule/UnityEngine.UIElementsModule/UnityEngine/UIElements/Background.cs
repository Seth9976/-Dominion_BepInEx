using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000AC RID: 172
	public sealed class Background : ValueType
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x000295AC File Offset: 0x000277AC
		// Note: this type is marked as 'beforefieldinit'.
		static Background()
		{
			Il2CppClassPointerStore<Background>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Background");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Background>.NativeClassPtr);
			Background.NativeFieldInfoPtr_m_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_Texture");
			Background.NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_Sprite");
			Background.NativeFieldInfoPtr_m_RenderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_RenderTexture");
			Background.NativeFieldInfoPtr_m_VectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Background>.NativeClassPtr, "m_VectorImage");
			Background.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664154);
			Background.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664155);
			Background.NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664156);
			Background.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664157);
			Background.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664158);
			Background.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664159);
			Background.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664160);
			Background.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664161);
			Background.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Background>.NativeClassPtr, 100664162);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x000296E0 File Offset: 0x000278E0
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00029A3C File Offset: 0x00027C3C
		public unsafe Texture2D texture
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_Texture == value;
				if (!flag)
				{
					this.m_Texture = value;
					this.m_Sprite = null;
					this.m_RenderTexture = null;
					this.m_VectorImage = null;
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00029724 File Offset: 0x00027924
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00029A78 File Offset: 0x00027C78
		public unsafe Sprite sprite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_Sprite == value;
				if (!flag)
				{
					this.m_Texture = null;
					this.m_Sprite = value;
					this.m_RenderTexture = null;
					this.m_VectorImage = null;
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00029768 File Offset: 0x00027968
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00029AB4 File Offset: 0x00027CB4
		public unsafe RenderTexture renderTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr3) : null;
			}
			set
			{
				bool flag = this.m_RenderTexture == value;
				if (!flag)
				{
					this.m_Texture = null;
					this.m_Sprite = null;
					this.m_RenderTexture = value;
					this.m_VectorImage = null;
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x000297AC File Offset: 0x000279AC
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00029AF0 File Offset: 0x00027CF0
		public unsafe VectorImage vectorImage
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 79925, RefRangeEnd = 79936, XrefRangeStart = 79925, XrefRangeEnd = 79936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr3) : null;
			}
			set
			{
				bool flag = this.vectorImage == value;
				if (!flag)
				{
					this.m_Texture = null;
					this.m_Sprite = null;
					this.m_RenderTexture = null;
					this.m_VectorImage = value;
				}
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x000297F0 File Offset: 0x000279F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96638, RefRangeEnd = 96641, XrefRangeStart = 96625, XrefRangeEnd = 96638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Background lhs, Background rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00029850 File Offset: 0x00027A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96641, XrefRangeEnd = 96642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Background other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x000298A8 File Offset: 0x00027AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96642, XrefRangeEnd = 96646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000298FC File Offset: 0x00027AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96646, RefRangeEnd = 96647, XrefRangeStart = 96646, XrefRangeEnd = 96646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00029940 File Offset: 0x00027B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96647, XrefRangeEnd = 96662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Background.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005C09 File Offset: 0x00003E09
		public Background(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00005C12 File Offset: 0x00003E12
		public Background()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Background>.NativeClassPtr))
		{
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0002997C File Offset: 0x00027B7C
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00005C24 File Offset: 0x00003E24
		public unsafe Texture2D m_Texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x000299AC File Offset: 0x00027BAC
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00005C43 File Offset: 0x00003E43
		public unsafe Sprite m_Sprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Sprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x000299DC File Offset: 0x00027BDC
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00005C62 File Offset: 0x00003E62
		public unsafe RenderTexture m_RenderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_RenderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_RenderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00029A0C File Offset: 0x00027C0C
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00005C81 File Offset: 0x00003E81
		public unsafe VectorImage m_VectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_VectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Background.NativeFieldInfoPtr_m_VectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00029B2C File Offset: 0x00027D2C
		public static Background FromTexture2D(Texture2D t)
		{
			Background background = null;
			background.texture = t;
			return background;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00029B50 File Offset: 0x00027D50
		public static Background FromRenderTexture(RenderTexture rt)
		{
			Background background = null;
			background.renderTexture = rt;
			return background;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00029B74 File Offset: 0x00027D74
		public static Background FromSprite(Sprite s)
		{
			Background background = null;
			background.sprite = s;
			return background;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00029B98 File Offset: 0x00027D98
		public static Background FromVectorImage(VectorImage vi)
		{
			Background background = null;
			background.vectorImage = vi;
			return background;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00029BBC File Offset: 0x00027DBC
		public static Background FromObject(Object obj)
		{
			Texture2D texture2D = obj.TryCast<Texture2D>();
			bool flag = texture2D != null;
			Background background;
			if (flag)
			{
				background = Background.FromTexture2D(texture2D);
			}
			else
			{
				RenderTexture renderTexture = obj.TryCast<RenderTexture>();
				bool flag2 = renderTexture != null;
				if (flag2)
				{
					background = Background.FromRenderTexture(renderTexture);
				}
				else
				{
					Sprite sprite = obj.TryCast<Sprite>();
					bool flag3 = sprite != null;
					if (flag3)
					{
						background = Background.FromSprite(sprite);
					}
					else
					{
						VectorImage vectorImage = obj.TryCast<VectorImage>();
						bool flag4 = vectorImage != null;
						if (flag4)
						{
							background = Background.FromVectorImage(vectorImage);
						}
						else
						{
							background = null;
						}
					}
				}
			}
			return background;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00029C54 File Offset: 0x00027E54
		public static bool operator !=(Background lhs, Background rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_m_Texture;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_m_Sprite;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderTexture;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_m_VectorImage;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_get_renderTexture_Public_get_RenderTexture_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_get_vectorImage_Public_get_VectorImage_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Background_Background_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Background_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
