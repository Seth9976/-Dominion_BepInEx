using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public class GUIContent : Object
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00009804 File Offset: 0x00007A04
		// Note: this type is marked as 'beforefieldinit'.
		static GUIContent()
		{
			Il2CppClassPointerStore<GUIContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIContent>.NativeClassPtr);
			GUIContent.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Text");
			GUIContent.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Image");
			GUIContent.NativeFieldInfoPtr_m_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Tooltip");
			GUIContent.NativeFieldInfoPtr_s_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Text");
			GUIContent.NativeFieldInfoPtr_s_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Image");
			GUIContent.NativeFieldInfoPtr_s_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_TextImage");
			GUIContent.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "none");
			GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663425);
			GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663426);
			GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663427);
			GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663428);
			GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663429);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663430);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663431);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663432);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663433);
			GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663434);
			GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663435);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000999C File Offset: 0x00007B9C
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000099D4 File Offset: 0x00007BD4
		public unsafe string text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00009DA8 File Offset: 0x00007FA8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00009A18 File Offset: 0x00007C18
		public unsafe Texture image
		{
			get
			{
				return this.m_Image;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00009A5C File Offset: 0x00007C5C
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00009A94 File Offset: 0x00007C94
		public unsafe string tooltip
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 80223, RefRangeEnd = 80226, XrefRangeStart = 80223, XrefRangeEnd = 80226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009AD8 File Offset: 0x00007CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85686, XrefRangeEnd = 85690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009B14 File Offset: 0x00007D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85690, XrefRangeEnd = 85696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009B60 File Offset: 0x00007D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85696, XrefRangeEnd = 85700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text, Texture image, string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85700, XrefRangeEnd = 85704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(GUIContent src)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00009C1C File Offset: 0x00007E1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 85712, RefRangeEnd = 85717, XrefRangeStart = 85704, XrefRangeEnd = 85712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIContent Temp(string t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr3) : null;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00009C60 File Offset: 0x00007E60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 85729, RefRangeEnd = 85730, XrefRangeStart = 85717, XrefRangeEnd = 85729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearStaticCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002746 File Offset: 0x00000946
		public GUIContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009C88 File Offset: 0x00007E88
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000274F File Offset: 0x0000094F
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00009CB0 File Offset: 0x00007EB0
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000276E File Offset: 0x0000096E
		public unsafe Texture m_Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00009CE0 File Offset: 0x00007EE0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000278D File Offset: 0x0000098D
		public unsafe string m_Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00009D08 File Offset: 0x00007F08
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000027AC File Offset: 0x000009AC
		public unsafe static GUIContent s_Text
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Text, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Text, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00009D30 File Offset: 0x00007F30
		// (set) Token: 0x06000194 RID: 404 RVA: 0x000027BE File Offset: 0x000009BE
		public unsafe static GUIContent s_Image
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Image, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Image, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00009D58 File Offset: 0x00007F58
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000027D0 File Offset: 0x000009D0
		public unsafe static GUIContent s_TextImage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_TextImage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_TextImage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00009D80 File Offset: 0x00007F80
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000027E2 File Offset: 0x000009E2
		public unsafe static GUIContent none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00009DC0 File Offset: 0x00007FC0
		public int hash
		{
			get
			{
				int num = 0;
				bool flag = !String.IsNullOrEmpty(this.m_Text);
				if (flag)
				{
					num = this.m_Text.GetHashCode() * 37;
				}
				return num;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009DF8 File Offset: 0x00007FF8
		public static GUIContent Temp(string t, string tooltip)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = tooltip;
			return GUIContent.s_Text;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009E28 File Offset: 0x00008028
		public static GUIContent Temp(Texture i)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = String.Empty;
			return GUIContent.s_Image;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00009E5C File Offset: 0x0000805C
		public static GUIContent Temp(Texture i, string tooltip)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = tooltip;
			return GUIContent.s_Image;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009E8C File Offset: 0x0000808C
		public static GUIContent Temp(string t, Texture i)
		{
			GUIContent.s_TextImage.m_Text = t;
			GUIContent.s_TextImage.m_Image = i;
			return GUIContent.s_TextImage;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000027F4 File Offset: 0x000009F4
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppStringArray texts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002801 File Offset: 0x00000A01
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppReferenceArray<Texture> images)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_m_Image;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_m_Tooltip;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_s_Text;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_s_Image;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_s_TextImage;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_get_tooltip_Public_get_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0;
	}
}
