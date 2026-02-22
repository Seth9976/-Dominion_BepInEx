using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005A RID: 90
	public class Ucs4Encoding2143 : Ucs4Encoding
	{
		// Token: 0x06000798 RID: 1944 RVA: 0x00029CA0 File Offset: 0x00027EA0
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Encoding2143()
		{
			Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Encoding2143");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr);
			Ucs4Encoding2143.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr, 100664556);
			Ucs4Encoding2143.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr, 100664557);
			Ucs4Encoding2143.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr, 100664558);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00029D0C File Offset: 0x00027F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20583, XrefRangeEnd = 20591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Encoding2143()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Encoding2143>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding2143.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00029D48 File Offset: 0x00027F48
		public unsafe override string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20591, XrefRangeEnd = 20593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding2143.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00029D8C File Offset: 0x00027F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20593, XrefRangeEnd = 20596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding2143.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000046AD File Offset: 0x000028AD
		public Ucs4Encoding2143(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
