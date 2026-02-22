using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public sealed class Font : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00004650 File Offset: 0x00002850
		// Note: this type is marked as 'beforefieldinit'.
		static Font()
		{
			Il2CppClassPointerStore<Font>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "Font");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Font>.NativeClassPtr);
			Font.NativeFieldInfoPtr_textureRebuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "textureRebuilt");
			Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Font>.NativeClassPtr, "m_FontTextureRebuildCallback");
			Font.NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663343);
			Font.NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663344);
			Font.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663345);
			Font.NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663346);
			Font.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663347);
			Font.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663348);
			Font.NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663349);
			Font.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663350);
			Font.NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663351);
			Font.NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font>.NativeClassPtr, 100663352);
			Font.set_materialDelegateField = IL2CPP.ResolveICall<Font.set_materialDelegate>("UnityEngine.Font::set_material");
			Font.get_fontNamesDelegateField = IL2CPP.ResolveICall<Font.get_fontNamesDelegate>("UnityEngine.Font::get_fontNames");
			Font.set_fontNamesDelegateField = IL2CPP.ResolveICall<Font.set_fontNamesDelegate>("UnityEngine.Font::set_fontNames");
			Font.get_ascentDelegateField = IL2CPP.ResolveICall<Font.get_ascentDelegate>("UnityEngine.Font::get_ascent");
			Font.get_lineHeightDelegateField = IL2CPP.ResolveICall<Font.get_lineHeightDelegate>("UnityEngine.Font::get_lineHeight");
			Font.GetDefaultDelegateField = IL2CPP.ResolveICall<Font.GetDefaultDelegate>("UnityEngine.Font::GetDefault");
			Font.GetOSInstalledFontNamesDelegateField = IL2CPP.ResolveICall<Font.GetOSInstalledFontNamesDelegate>("UnityEngine.Font::GetOSInstalledFontNames");
			Font.GetPathsToOSFontsDelegateField = IL2CPP.ResolveICall<Font.GetPathsToOSFontsDelegate>("UnityEngine.Font::GetPathsToOSFonts");
			Font.Internal_CreateFontFromPathDelegateField = IL2CPP.ResolveICall<Font.Internal_CreateFontFromPathDelegate>("UnityEngine.Font::Internal_CreateFontFromPath");
			Font.Internal_CreateDynamicFontDelegateField = IL2CPP.ResolveICall<Font.Internal_CreateDynamicFontDelegate>("UnityEngine.Font::Internal_CreateDynamicFont");
			Font.RequestCharactersInTextureDelegateField = IL2CPP.ResolveICall<Font.RequestCharactersInTextureDelegate>("UnityEngine.Font::RequestCharactersInTexture");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004818 File Offset: 0x00002A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84133, RefRangeEnd = 84134, XrefRangeStart = 84126, XrefRangeEnd = 84133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_textureRebuilt(Action<Font> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004850 File Offset: 0x00002A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84141, RefRangeEnd = 84142, XrefRangeStart = 84134, XrefRangeEnd = 84141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_textureRebuilt(Action<Font> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004888 File Offset: 0x00002A88
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe Material material
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 84144, RefRangeEnd = 84151, XrefRangeStart = 84142, XrefRangeEnd = 84144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			set
			{
				Font.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000048C8 File Offset: 0x00002AC8
		public unsafe bool dynamic
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84153, RefRangeEnd = 84155, XrefRangeStart = 84151, XrefRangeEnd = 84153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004904 File Offset: 0x00002B04
		public unsafe int fontSize
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 84157, RefRangeEnd = 84159, XrefRangeStart = 84155, XrefRangeEnd = 84157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00004940 File Offset: 0x00002B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84159, XrefRangeEnd = 84165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Font()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000497C File Offset: 0x00002B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84165, XrefRangeEnd = 84170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeTextureRebuilt_Internal(Font font)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(font);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000049B4 File Offset: 0x00002BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84172, RefRangeEnd = 84173, XrefRangeStart = 84170, XrefRangeEnd = 84172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004A00 File Offset: 0x00002C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84173, XrefRangeEnd = 84175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCharacter(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004A4C File Offset: 0x00002C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84175, XrefRangeEnd = 84177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateFont(Font self, string name)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000254C File Offset: 0x0000074C
		public Font(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004A94 File Offset: 0x00002C94
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002555 File Offset: 0x00000755
		public unsafe static Action<Font> textureRebuilt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Font.NativeFieldInfoPtr_textureRebuilt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Font>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Font.NativeFieldInfoPtr_textureRebuilt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004ABC File Offset: 0x00002CBC
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002567 File Offset: 0x00000767
		public unsafe Font.FontTextureRebuildCallback m_FontTextureRebuildCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font.FontTextureRebuildCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Font.NativeFieldInfoPtr_m_FontTextureRebuildCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002586 File Offset: 0x00000786
		public void add_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002593 File Offset: 0x00000793
		public void remove_m_FontTextureRebuildCallback(Font.FontTextureRebuildCallback value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004AEC File Offset: 0x00002CEC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000025B8 File Offset: 0x000007B8
		public Il2CppStringArray fontNames
		{
			get
			{
				IntPtr intPtr = Font.get_fontNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				Font.set_fontNamesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000025D0 File Offset: 0x000007D0
		public int ascent
		{
			get
			{
				return Font.get_ascentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000025E2 File Offset: 0x000007E2
		public int lineHeight
		{
			get
			{
				return Font.get_lineHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004B18 File Offset: 0x00002D18
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000025F4 File Offset: 0x000007F4
		public Font.FontTextureRebuildCallback textureRebuildCallback
		{
			get
			{
				return this.m_FontTextureRebuildCallback;
			}
			set
			{
				this.m_FontTextureRebuildCallback = value;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000025FE File Offset: 0x000007FE
		public static Font CreateDynamicFontFromOSFont(string fontname, int size)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004B30 File Offset: 0x00002D30
		public static Font CreateDynamicFontFromOSFont(Il2CppStringArray fontnames, int size)
		{
			return new Font(fontnames, size);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004B4C File Offset: 0x00002D4C
		public static int GetMaxVertsForString(string str)
		{
			return str.Length * 4 + 4;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004B68 File Offset: 0x00002D68
		public static Font GetDefault()
		{
			IntPtr intPtr = Font.GetDefaultDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004B90 File Offset: 0x00002D90
		public static Il2CppStringArray GetOSInstalledFontNames()
		{
			IntPtr intPtr = Font.GetOSInstalledFontNamesDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004BB8 File Offset: 0x00002DB8
		public static Il2CppStringArray GetPathsToOSFonts()
		{
			IntPtr intPtr = Font.GetPathsToOSFontsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000260B File Offset: 0x0000080B
		public static void Internal_CreateFontFromPath(Font self, string fontPath)
		{
			Font.Internal_CreateFontFromPathDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(fontPath));
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002623 File Offset: 0x00000823
		public static void Internal_CreateDynamicFont(Font self, Il2CppStringArray _names, int size)
		{
			Font.Internal_CreateDynamicFontDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.Il2CppObjectBaseToPtr(_names), size);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000263C File Offset: 0x0000083C
		public void RequestCharactersInTexture(string characters, int size, FontStyle style)
		{
			Font.RequestCharactersInTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(characters), size, style);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002656 File Offset: 0x00000856
		public void RequestCharactersInTexture(string characters, int size)
		{
			this.RequestCharactersInTexture(characters, size, FontStyle.Normal);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002663 File Offset: 0x00000863
		public void RequestCharactersInTexture(string characters)
		{
			this.RequestCharactersInTexture(characters, 0, FontStyle.Normal);
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_textureRebuilt;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_m_FontTextureRebuildCallback;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_add_textureRebuilt_Public_Static_add_Void_Action_1_Font_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_remove_textureRebuilt_Public_Static_rem_Void_Action_1_Font_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_get_dynamic_Public_get_Boolean_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTextureRebuilt_Internal_Internal_Static_Void_Font_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Public_Boolean_Char_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_HasCharacter_Private_Boolean_Int32_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateFont_Private_Static_Void_Font_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly Font.set_materialDelegate set_materialDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly Font.get_fontNamesDelegate get_fontNamesDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly Font.set_fontNamesDelegate set_fontNamesDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly Font.get_ascentDelegate get_ascentDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly Font.get_lineHeightDelegate get_lineHeightDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly Font.GetDefaultDelegate GetDefaultDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly Font.GetOSInstalledFontNamesDelegate GetOSInstalledFontNamesDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly Font.GetPathsToOSFontsDelegate GetPathsToOSFontsDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly Font.Internal_CreateFontFromPathDelegate Internal_CreateFontFromPathDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly Font.Internal_CreateDynamicFontDelegate Internal_CreateDynamicFontDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly Font.RequestCharactersInTextureDelegate RequestCharactersInTextureDelegateField;

		// Token: 0x02000024 RID: 36
		public sealed class FontTextureRebuildCallback : MulticastDelegate
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x000026E9 File Offset: 0x000008E9
			// Note: this type is marked as 'beforefieldinit'.
			static FontTextureRebuildCallback()
			{
				Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Font>.NativeClassPtr, "FontTextureRebuildCallback");
				Font.FontTextureRebuildCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr, 100663353);
				Font.FontTextureRebuildCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr, 100663354);
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00004D54 File Offset: 0x00002F54
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FontTextureRebuildCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Font.FontTextureRebuildCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.FontTextureRebuildCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00004DB0 File Offset: 0x00002FB0
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Font.FontTextureRebuildCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00002727 File Offset: 0x00000927
			public FontTextureRebuildCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00002730 File Offset: 0x00000930
			public static implicit operator Font.FontTextureRebuildCallback(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Font.FontTextureRebuildCallback>(A_0);
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00002738 File Offset: 0x00000938
			public static Font.FontTextureRebuildCallback operator +(Font.FontTextureRebuildCallback A_0, Font.FontTextureRebuildCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Font.FontTextureRebuildCallback>();
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00002746 File Offset: 0x00000946
			public static Font.FontTextureRebuildCallback operator -(Font.FontTextureRebuildCallback A_0, Font.FontTextureRebuildCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Font.FontTextureRebuildCallback>();
				}
				return delegate2;
			}

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000FC RID: 252
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060000FE RID: 254
		private delegate IntPtr get_fontNamesDelegate(IntPtr @this);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000100 RID: 256
		private delegate void set_fontNamesDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000102 RID: 258
		private delegate int get_ascentDelegate(IntPtr @this);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000104 RID: 260
		private delegate int get_lineHeightDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000106 RID: 262
		private delegate IntPtr GetDefaultDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000108 RID: 264
		private delegate IntPtr GetOSInstalledFontNamesDelegate();

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x0600010A RID: 266
		private delegate IntPtr GetPathsToOSFontsDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600010C RID: 268
		private delegate void Internal_CreateFontFromPathDelegate(IntPtr self, IntPtr fontPath);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600010E RID: 270
		private delegate void Internal_CreateDynamicFontDelegate(IntPtr self, IntPtr _names, int size);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000110 RID: 272
		private delegate void RequestCharactersInTextureDelegate(IntPtr @this, IntPtr characters, int size, FontStyle style);
	}
}
