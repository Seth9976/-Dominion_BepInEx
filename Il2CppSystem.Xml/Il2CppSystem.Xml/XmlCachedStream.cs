using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000054 RID: 84
	public class XmlCachedStream : MemoryStream
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x00028BEC File Offset: 0x00026DEC
		// Note: this type is marked as 'beforefieldinit'.
		static XmlCachedStream()
		{
			Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlCachedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr);
			XmlCachedStream.NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, "uri");
			XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr, 100664524);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00028C44 File Offset: 0x00026E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20492, RefRangeEnd = 20494, XrefRangeStart = 20485, XrefRangeEnd = 20492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlCachedStream(Uri uri, Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlCachedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlCachedStream.NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00004603 File Offset: 0x00002803
		public XmlCachedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00028CA4 File Offset: 0x00026EA4
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x0000460C File Offset: 0x0000280C
		public unsafe Uri uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlCachedStream.NativeFieldInfoPtr_uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_uri;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Uri_Stream_0;
	}
}
