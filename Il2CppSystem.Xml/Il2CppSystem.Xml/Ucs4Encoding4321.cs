using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000059 RID: 89
	public class Ucs4Encoding4321 : Ucs4Encoding
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x00029B68 File Offset: 0x00027D68
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Encoding4321()
		{
			Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Encoding4321");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr);
			Ucs4Encoding4321.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr, 100664553);
			Ucs4Encoding4321.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr, 100664554);
			Ucs4Encoding4321.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr, 100664555);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00029BD4 File Offset: 0x00027DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20570, XrefRangeEnd = 20578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Encoding4321()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Encoding4321>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding4321.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00029C10 File Offset: 0x00027E10
		public unsafe override string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20578, XrefRangeEnd = 20580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding4321.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00029C54 File Offset: 0x00027E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20580, XrefRangeEnd = 20583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding4321.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000046A4 File Offset: 0x000028A4
		public Ucs4Encoding4321(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
