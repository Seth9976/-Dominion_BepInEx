using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000224 RID: 548
	public class CStreamReader : StreamReader
	{
		// Token: 0x06002390 RID: 9104 RVA: 0x000C1FDC File Offset: 0x000C01DC
		// Note: this type is marked as 'beforefieldinit'.
		static CStreamReader()
		{
			Il2CppClassPointerStore<CStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "CStreamReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr);
			CStreamReader.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, "driver");
			CStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669257);
			CStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669258);
			CStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669259);
			CStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669260);
			CStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669261);
			CStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr, 100669262);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x000C2098 File Offset: 0x000C0298
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324477, RefRangeEnd = 324478, XrefRangeStart = 324467, XrefRangeEnd = 324477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CStreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CStreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000C20F8 File Offset: 0x000C02F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x000C2140 File Offset: 0x000C0340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324478, XrefRangeEnd = 324482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x000C2188 File Offset: 0x000C0388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324482, XrefRangeEnd = 324483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> dest, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x000C2210 File Offset: 0x000C0410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324483, XrefRangeEnd = 324484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x000C2254 File Offset: 0x000C0454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324484, XrefRangeEnd = 324485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0000BF9A File Offset: 0x0000A19A
		public CStreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002398 RID: 9112 RVA: 0x000C2298 File Offset: 0x000C0498
		// (set) Token: 0x06002399 RID: 9113 RVA: 0x0000BFA3 File Offset: 0x0000A1A3
		public unsafe TermInfoDriver driver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamReader.NativeFieldInfoPtr_driver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoDriver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamReader.NativeFieldInfoPtr_driver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x04001FF5 RID: 8181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;
	}
}
