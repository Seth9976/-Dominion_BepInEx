using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005E RID: 94
	public class Ucs4Decoder1234 : Ucs4Decoder
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0002A47C File Offset: 0x0002867C
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Decoder1234()
		{
			Il2CppClassPointerStore<Ucs4Decoder1234>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Decoder1234");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Decoder1234>.NativeClassPtr);
			Ucs4Decoder1234.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder1234>.NativeClassPtr, 100664570);
			Ucs4Decoder1234.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder1234>.NativeClassPtr, 100664571);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002A4D4 File Offset: 0x000286D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20624, XrefRangeEnd = 20627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder1234.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002A56C File Offset: 0x0002876C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Decoder1234()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Decoder1234>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Decoder1234.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000470B File Offset: 0x0000290B
		public Ucs4Decoder1234(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
