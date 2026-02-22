using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005F RID: 95
	public class Ucs4Decoder2143 : Ucs4Decoder
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0002A5A8 File Offset: 0x000287A8
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Decoder2143()
		{
			Il2CppClassPointerStore<Ucs4Decoder2143>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Decoder2143");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Decoder2143>.NativeClassPtr);
			Ucs4Decoder2143.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder2143>.NativeClassPtr, 100664572);
			Ucs4Decoder2143.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder2143>.NativeClassPtr, 100664573);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002A600 File Offset: 0x00028800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20627, XrefRangeEnd = 20630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetFullChars(Il2CppStructArray<byte> bytes, int byteIndex, int byteCount, Il2CppStructArray<char> chars, int charIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder2143.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002A698 File Offset: 0x00028898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Decoder2143()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Decoder2143>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Decoder2143.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00004714 File Offset: 0x00002914
		public Ucs4Decoder2143(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
