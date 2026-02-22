using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000058 RID: 88
	public class Ucs4Encoding1234 : Ucs4Encoding
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x00029A30 File Offset: 0x00027C30
		// Note: this type is marked as 'beforefieldinit'.
		static Ucs4Encoding1234()
		{
			Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ucs4Encoding1234");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr);
			Ucs4Encoding1234.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr, 100664550);
			Ucs4Encoding1234.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr, 100664551);
			Ucs4Encoding1234.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr, 100664552);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00029A9C File Offset: 0x00027C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20557, XrefRangeEnd = 20565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ucs4Encoding1234()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ucs4Encoding1234>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ucs4Encoding1234.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00029AD8 File Offset: 0x00027CD8
		public unsafe override string EncodingName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20565, XrefRangeEnd = 20567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding1234.NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00029B1C File Offset: 0x00027D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20567, XrefRangeEnd = 20570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ucs4Encoding1234.NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000469B File Offset: 0x0000289B
		public Ucs4Encoding1234(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodingName_Public_Virtual_get_String_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_GetPreamble_Public_Virtual_Il2CppStructArray_1_Byte_0;
	}
}
