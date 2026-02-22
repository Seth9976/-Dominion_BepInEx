using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000057 RID: 87
	public class Ucs4Encoding : Encoding
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x00029330 File Offset: 0x00027530
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Encoding()
		{
			Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Encoding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr);
			Ucs4Encoding.NativeFieldInfoPtr_ucs4Decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, "ucs4Decoder");
			Ucs4Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664534);
			Ucs4Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664535);
			Ucs4Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664536);
			Ucs4Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664537);
			Ucs4Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664538);
			Ucs4Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664539);
			Ucs4Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664540);
			Ucs4Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664541);
			Ucs4Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664542);
			Ucs4Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664543);
			Ucs4Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664544);
			Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_Littleendian_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664545);
			Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_Bigendian_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664546);
			Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_2143_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664547);
			Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_3412_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664548);
			Ucs4Encoding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr, 100664549);
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x000294B4 File Offset: 0x000276B4
		public unsafe override string WebName
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 14894, RefRangeEnd = 14910, XrefRangeStart = 14894, XrefRangeEnd = 14910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_get_WebName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x000294F8 File Offset: 0x000276F8
		[CallerCount(0)]
		public unsafe override Decoder GetDecoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr3) : null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00029544 File Offset: 0x00027744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20507, XrefRangeEnd = 20508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000295B8 File Offset: 0x000277B8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetBytes(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00029614 File Offset: 0x00027814
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000296AC File Offset: 0x000278AC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetMaxByteCount(int charCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00029700 File Offset: 0x00027900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20508, XrefRangeEnd = 20509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetCharCount(Il2CppStructArray<byte> bytes, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00029774 File Offset: 0x00027974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20509, XrefRangeEnd = 20510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002980C File Offset: 0x00027A0C
		[CallerCount(0)]
		public unsafe override int GetMaxCharCount(int byteCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref byteCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00029860 File Offset: 0x00027A60
		public unsafe override int CodePage
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_get_CodePage_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000298A8 File Offset: 0x00027AA8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Encoder GetEncoder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding.NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr3) : null;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000298F4 File Offset: 0x00027AF4
		public unsafe static Encoding UCS4_Littleendian
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20521, RefRangeEnd = 20522, XrefRangeStart = 20510, XrefRangeEnd = 20521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_Littleendian_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00029928 File Offset: 0x00027B28
		public unsafe static Encoding UCS4_Bigendian
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20522, XrefRangeEnd = 20533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_Bigendian_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002995C File Offset: 0x00027B5C
		public unsafe static Encoding UCS4_2143
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20533, XrefRangeEnd = 20544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_2143_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00029990 File Offset: 0x00027B90
		public unsafe static Encoding UCS4_3412
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20555, RefRangeEnd = 20556, XrefRangeStart = 20544, XrefRangeEnd = 20555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding.NativeMethodInfoPtr_get_UCS4_3412_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000299C4 File Offset: 0x00027BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20556, XrefRangeEnd = 20557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Encoding()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Encoding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00004673 File Offset: 0x00002873
		public Ucs4Encoding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00029A00 File Offset: 0x00027C00
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0000467C File Offset: 0x0000287C
		public unsafe Ucs4Decoder ucs4Decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Encoding.NativeFieldInfoPtr_ucs4Decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ucs4Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ucs4Encoding.NativeFieldInfoPtr_ucs4Decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_ucs4Decoder;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_get_WebName_Public_Virtual_get_String_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_GetDecoder_Public_Virtual_Decoder_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxByteCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_GetCharCount_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxCharCount_Public_Virtual_Int32_Int32_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_get_CodePage_Public_Virtual_get_Int32_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_GetEncoder_Public_Virtual_Encoder_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_UCS4_Littleendian_Internal_Static_get_Encoding_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_get_UCS4_Bigendian_Internal_Static_get_Encoding_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_UCS4_2143_Internal_Static_get_Encoding_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_UCS4_3412_Internal_Static_get_Encoding_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
