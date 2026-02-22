using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000060 RID: 96
	public class Ucs4Decoder3412 : Ucs4Decoder
	{
		// Token: 0x060007BA RID: 1978 RVA: 0x0002A6D4 File Offset: 0x000288D4
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Decoder3412()
		{
			Il2CppClassPointerStore<Ucs4Decoder3412>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Decoder3412");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Decoder3412>.NativeClassPtr);
			Ucs4Decoder3412.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder3412>.NativeClassPtr, 100664574);
			Ucs4Decoder3412.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Decoder3412>.NativeClassPtr, 100664575);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0002A72C File Offset: 0x0002892C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20630, XrefRangeEnd = 20633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Decoder3412.NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0002A7C4 File Offset: 0x000289C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Decoder3412()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Decoder3412>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Decoder3412.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000471D File Offset: 0x0000291D
		public Ucs4Decoder3412(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_GetFullChars_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
