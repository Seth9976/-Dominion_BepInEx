using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000225 RID: 549
	public class CStreamWriter : StreamWriter
	{
		// Token: 0x0600239A RID: 9114 RVA: 0x000C22C8 File Offset: 0x000C04C8
		// Note: this type is marked as 'beforefieldinit'.
		static CStreamWriter()
		{
			Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "CStreamWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr);
			CStreamWriter.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, "driver");
			CStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669263);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669264);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669265);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669266);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669267);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669268);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669269);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100669270);
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x000C23AC File Offset: 0x000C05AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 324495, RefRangeEnd = 324497, XrefRangeStart = 324485, XrefRangeEnd = 324495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x000C2418 File Offset: 0x000C0618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324497, XrefRangeEnd = 324511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x000C2484 File Offset: 0x000C0684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324511, XrefRangeEnd = 324519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x000C24D0 File Offset: 0x000C06D0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 324521, RefRangeEnd = 324529, XrefRangeStart = 324519, XrefRangeEnd = 324521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteString(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x000C2514 File Offset: 0x000C0714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 324531, RefRangeEnd = 324532, XrefRangeStart = 324529, XrefRangeEnd = 324531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteChar(char val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x000C2554 File Offset: 0x000C0754
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 324534, RefRangeEnd = 324540, XrefRangeStart = 324532, XrefRangeEnd = 324534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteChars(Il2CppStructArray<char> buffer, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x000C25A4 File Offset: 0x000C07A4
		[CallerCount(0)]
		public unsafe override void Write(Il2CppStructArray<char> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x000C25F4 File Offset: 0x000C07F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324540, XrefRangeEnd = 324542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0000BFC2 File Offset: 0x0000A1C2
		public CStreamWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x000C2644 File Offset: 0x000C0844
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x0000BFCB File Offset: 0x0000A1CB
		public unsafe TermInfoDriver driver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamWriter.NativeFieldInfoPtr_driver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoDriver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamWriter.NativeFieldInfoPtr_driver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FFB RID: 8187
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x04001FFC RID: 8188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0;

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;
	}
}
