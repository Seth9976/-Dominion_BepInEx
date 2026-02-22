using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200005B RID: 91
	public class Ucs4Encoding3412 : Ucs4Encoding
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x00029DD8 File Offset: 0x00027FD8
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Encoding3412()
		{
			Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Encoding3412");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr);
			Ucs4Encoding3412.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr, 100664559);
			Ucs4Encoding3412.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr, 100664560);
			Ucs4Encoding3412.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr, 100664561);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00029E44 File Offset: 0x00028044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20596, XrefRangeEnd = 20604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Encoding3412()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Encoding3412>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding3412.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00029E80 File Offset: 0x00028080
		public unsafe override string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20604, XrefRangeEnd = 20606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding3412.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00029EC4 File Offset: 0x000280C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20606, XrefRangeEnd = 20609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding3412.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000046B6 File Offset: 0x000028B6
		public Ucs4Encoding3412(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
