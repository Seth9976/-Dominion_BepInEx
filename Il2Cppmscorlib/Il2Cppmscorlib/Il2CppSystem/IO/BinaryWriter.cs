using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F6 RID: 502
	[Serializable]
	public class BinaryWriter : Object
	{
		// Token: 0x06002034 RID: 8244 RVA: 0x000B32E4 File Offset: 0x000B14E4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryWriter()
		{
			Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "BinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr);
			BinaryWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "Null");
			BinaryWriter.NativeFieldInfoPtr_OutStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "OutStream");
			BinaryWriter.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_buffer");
			BinaryWriter.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_encoding");
			BinaryWriter.NativeFieldInfoPtr__encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_encoder");
			BinaryWriter.NativeFieldInfoPtr__leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_leaveOpen");
			BinaryWriter.NativeFieldInfoPtr__largeByteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_largeByteBuffer");
			BinaryWriter.NativeFieldInfoPtr__maxChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_maxChars");
			BinaryWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668654);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668655);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668656);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668657);
			BinaryWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668658);
			BinaryWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668659);
			BinaryWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668660);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668661);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668662);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668663);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668664);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668665);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668666);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668667);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668668);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668669);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668670);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668671);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668672);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668673);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668674);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668675);
			BinaryWriter.NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100668676);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x000B3580 File Offset: 0x000B1780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320191, XrefRangeEnd = 320203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x000B35BC File Offset: 0x000B17BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320208, RefRangeEnd = 320209, XrefRangeStart = 320203, XrefRangeEnd = 320208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000B3608 File Offset: 0x000B1808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320210, RefRangeEnd = 320211, XrefRangeStart = 320209, XrefRangeEnd = 320210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x000B3668 File Offset: 0x000B1868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320215, RefRangeEnd = 320217, XrefRangeStart = 320211, XrefRangeEnd = 320215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x000B36D4 File Offset: 0x000B18D4
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x000B3720 File Offset: 0x000B1920
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x000B3754 File Offset: 0x000B1954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12035, RefRangeEnd = 12037, XrefRangeStart = 12035, XrefRangeEnd = 12037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000B3790 File Offset: 0x000B1990
		[CallerCount(0)]
		public unsafe virtual void Write(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000B37DC File Offset: 0x000B19DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48880, RefRangeEnd = 48882, XrefRangeStart = 48880, XrefRangeEnd = 48882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000B3828 File Offset: 0x000B1A28
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000B3878 File Offset: 0x000B1A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320217, XrefRangeEnd = 320218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000B38E4 File Offset: 0x000B1AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320218, XrefRangeEnd = 320223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000B3930 File Offset: 0x000B1B30
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000B3980 File Offset: 0x000B1B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320223, XrefRangeEnd = 320224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000B39CC File Offset: 0x000B1BCC
		[CallerCount(0)]
		public unsafe virtual void Write(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000B3A18 File Offset: 0x000B1C18
		[CallerCount(0)]
		public unsafe virtual void Write(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000B3A64 File Offset: 0x000B1C64
		[CallerCount(0)]
		public unsafe virtual void Write(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000B3AB0 File Offset: 0x000B1CB0
		[CallerCount(0)]
		public unsafe virtual void Write(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000B3AFC File Offset: 0x000B1CFC
		[CallerCount(0)]
		public unsafe virtual void Write(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000B3B48 File Offset: 0x000B1D48
		[CallerCount(0)]
		public unsafe virtual void Write(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x000B3B94 File Offset: 0x000B1D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320224, XrefRangeEnd = 320225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320225, XrefRangeEnd = 320233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x000B3C30 File Offset: 0x000B1E30
		[CallerCount(0)]
		public unsafe void Write7BitEncodedInt(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0000AE88 File Offset: 0x00009088
		public BinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000B3C70 File Offset: 0x000B1E70
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x0000AE91 File Offset: 0x00009091
		public unsafe static BinaryWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x000B3C98 File Offset: 0x000B1E98
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x0000AEA3 File Offset: 0x000090A3
		public unsafe Stream OutStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr_OutStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr_OutStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x000B3CC8 File Offset: 0x000B1EC8
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x0000AEC2 File Offset: 0x000090C2
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x000B3CF8 File Offset: 0x000B1EF8
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x0000AEE1 File Offset: 0x000090E1
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x000B3D28 File Offset: 0x000B1F28
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x0000AF00 File Offset: 0x00009100
		public unsafe Encoder _encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x000B3D58 File Offset: 0x000B1F58
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x0000AF1F File Offset: 0x0000911F
		public unsafe bool _leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__leaveOpen)) = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x000B3D80 File Offset: 0x000B1F80
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x0000AF3A File Offset: 0x0000913A
		public unsafe Il2CppStructArray<byte> _largeByteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__largeByteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__largeByteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000B3DB0 File Offset: 0x000B1FB0
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x0000AF59 File Offset: 0x00009159
		public unsafe int _maxChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__maxChars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__maxChars)) = value;
			}
		}

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeFieldInfoPtr_OutStream;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeFieldInfoPtr__encoder;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr__leaveOpen;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeFieldInfoPtr__largeByteBuffer;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeFieldInfoPtr__maxChars;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x04001D2C RID: 7468
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0;
	}
}
