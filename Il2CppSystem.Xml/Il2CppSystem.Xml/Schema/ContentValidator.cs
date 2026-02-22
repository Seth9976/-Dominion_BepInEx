using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000083 RID: 131
	public class ContentValidator : Object
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00030784 File Offset: 0x0002E984
		// Note: this type is marked as 'beforefieldinit'.
		static ContentValidator()
		{
			Il2CppClassPointerStore<ContentValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ContentValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr);
			ContentValidator.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "contentType");
			ContentValidator.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isOpen");
			ContentValidator.NativeFieldInfoPtr_isEmptiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "isEmptiable");
			ContentValidator.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Empty");
			ContentValidator.NativeFieldInfoPtr_TextOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "TextOnly");
			ContentValidator.NativeFieldInfoPtr_Mixed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Mixed");
			ContentValidator.NativeFieldInfoPtr_Any = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, "Any");
			ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100664776);
			ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100664777);
			ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100664778);
			ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr, 100664779);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00030890 File Offset: 0x0002EA90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 21720, RefRangeEnd = 21722, XrefRangeStart = 21719, XrefRangeEnd = 21720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator(XmlSchemaContentType contentType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000308D8 File Offset: 0x0002EAD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 21723, RefRangeEnd = 21726, XrefRangeStart = 21722, XrefRangeEnd = 21723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContentValidator(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentValidator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref contentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEmptiable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x0003093C File Offset: 0x0002EB3C
		public unsafe XmlSchemaContentType ContentType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00030978 File Offset: 0x0002EB78
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21726, RefRangeEnd = 21727, XrefRangeStart = 21726, XrefRangeEnd = 21726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContentValidator.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00004F0B File Offset: 0x0000310B
		public ContentValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x000309B4 File Offset: 0x0002EBB4
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00004F14 File Offset: 0x00003114
		public unsafe XmlSchemaContentType contentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_contentType)) = value;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x000309DC File Offset: 0x0002EBDC
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x00004F2F File Offset: 0x0000312F
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00030A04 File Offset: 0x0002EC04
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00004F4A File Offset: 0x0000314A
		public unsafe bool isEmptiable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContentValidator.NativeFieldInfoPtr_isEmptiable)) = value;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00030A2C File Offset: 0x0002EC2C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x00004F65 File Offset: 0x00003165
		public unsafe static ContentValidator Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00030A54 File Offset: 0x0002EC54
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x00004F77 File Offset: 0x00003177
		public unsafe static ContentValidator TextOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_TextOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_TextOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00030A7C File Offset: 0x0002EC7C
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00004F89 File Offset: 0x00003189
		public unsafe static ContentValidator Mixed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Mixed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Mixed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00004F9B File Offset: 0x0000319B
		public unsafe static ContentValidator Any
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContentValidator.NativeFieldInfoPtr_Any, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContentValidator.NativeFieldInfoPtr_Any, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_contentType;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_isEmptiable;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr_TextOnly;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeFieldInfoPtr_Mixed;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeFieldInfoPtr_Any;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlSchemaContentType_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_XmlSchemaContentType_Boolean_Boolean_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_XmlSchemaContentType_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;
	}
}
