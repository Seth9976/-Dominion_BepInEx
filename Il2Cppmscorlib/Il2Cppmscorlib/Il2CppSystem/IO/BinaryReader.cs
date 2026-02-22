using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x020001F5 RID: 501
	public class BinaryReader : Object
	{
		// Token: 0x06002001 RID: 8193 RVA: 0x000B2540 File Offset: 0x000B0740
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryReader()
		{
			Il2CppClassPointerStore<BinaryReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "BinaryReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr);
			BinaryReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_stream");
			BinaryReader.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_buffer");
			BinaryReader.NativeFieldInfoPtr_m_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_decoder");
			BinaryReader.NativeFieldInfoPtr_m_charBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBytes");
			BinaryReader.NativeFieldInfoPtr_m_singleChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_singleChar");
			BinaryReader.NativeFieldInfoPtr_m_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBuffer");
			BinaryReader.NativeFieldInfoPtr_m_maxCharsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_maxCharsSize");
			BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_2BytesPerChar");
			BinaryReader.NativeFieldInfoPtr_m_isMemoryStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_isMemoryStream");
			BinaryReader.NativeFieldInfoPtr_m_leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_leaveOpen");
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668625);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668626);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668627);
			BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668628);
			BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668629);
			BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668630);
			BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668631);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668632);
			BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668633);
			BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668634);
			BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668635);
			BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668636);
			BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668637);
			BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668638);
			BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668639);
			BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668640);
			BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668641);
			BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668642);
			BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668643);
			BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668644);
			BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668645);
			BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668646);
			BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668647);
			BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668648);
			BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668649);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668650);
			BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668651);
			BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668652);
			BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100668653);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000B287C File Offset: 0x000B0A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320059, RefRangeEnd = 320061, XrefRangeStart = 320054, XrefRangeEnd = 320059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000B28C8 File Offset: 0x000B0AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320062, RefRangeEnd = 320064, XrefRangeStart = 320061, XrefRangeEnd = 320062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x000B2928 File Offset: 0x000B0B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320079, RefRangeEnd = 320081, XrefRangeStart = 320064, XrefRangeEnd = 320079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x000B2994 File Offset: 0x000B0B94
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000B29E0 File Offset: 0x000B0BE0
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000B2A1C File Offset: 0x000B0C1C
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x000B2A68 File Offset: 0x000B0C68
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x000B2A9C File Offset: 0x000B0C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320081, XrefRangeEnd = 320083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000B2AE4 File Offset: 0x000B0CE4
		[CallerCount(0)]
		public unsafe virtual bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000B2B2C File Offset: 0x000B0D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320083, XrefRangeEnd = 320085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x000B2B74 File Offset: 0x000B0D74
		[CallerCount(0)]
		public unsafe virtual sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x000B2BBC File Offset: 0x000B0DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320085, XrefRangeEnd = 320086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000B2C04 File Offset: 0x000B0E04
		[CallerCount(0)]
		public unsafe virtual short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000B2C4C File Offset: 0x000B0E4C
		[CallerCount(0)]
		public unsafe virtual ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x000B2C94 File Offset: 0x000B0E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320086, XrefRangeEnd = 320087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x000B2CDC File Offset: 0x000B0EDC
		[CallerCount(0)]
		public unsafe virtual uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x000B2D24 File Offset: 0x000B0F24
		[CallerCount(0)]
		public unsafe virtual long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x000B2D6C File Offset: 0x000B0F6C
		[CallerCount(0)]
		public unsafe virtual ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x000B2DB4 File Offset: 0x000B0FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320087, XrefRangeEnd = 320088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x000B2DFC File Offset: 0x000B0FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320088, XrefRangeEnd = 320092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x000B2E44 File Offset: 0x000B1044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320092, XrefRangeEnd = 320096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x000B2E8C File Offset: 0x000B108C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320096, XrefRangeEnd = 320108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x000B2ED0 File Offset: 0x000B10D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320124, RefRangeEnd = 320125, XrefRangeStart = 320108, XrefRangeEnd = 320124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadChars(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x000B2F3C File Offset: 0x000B113C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320131, RefRangeEnd = 320132, XrefRangeStart = 320125, XrefRangeEnd = 320131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadOneChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x000B2F78 File Offset: 0x000B1178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320132, XrefRangeEnd = 320141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> ReadChars(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x000B2FD0 File Offset: 0x000B11D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320141, XrefRangeEnd = 320175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x000B3044 File Offset: 0x000B1244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320175, XrefRangeEnd = 320183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ReadBytes(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x000B309C File Offset: 0x000B129C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320183, XrefRangeEnd = 320185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FillBuffer(int numBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x000B30E8 File Offset: 0x000B12E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 320185, RefRangeEnd = 320191, XrefRangeStart = 320185, XrefRangeEnd = 320185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read7BitEncodedInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0000AD59 File Offset: 0x00008F59
		public BinaryReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x000B3124 File Offset: 0x000B1324
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0000AD62 File Offset: 0x00008F62
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x000B3154 File Offset: 0x000B1354
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000AD81 File Offset: 0x00008F81
		public unsafe Il2CppStructArray<byte> m_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x000B3184 File Offset: 0x000B1384
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public unsafe Decoder m_decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x000B31B4 File Offset: 0x000B13B4
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x0000ADBF File Offset: 0x00008FBF
		public unsafe Il2CppStructArray<byte> m_charBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x000B31E4 File Offset: 0x000B13E4
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x0000ADDE File Offset: 0x00008FDE
		public unsafe Il2CppStructArray<char> m_singleChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x000B3214 File Offset: 0x000B1414
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x0000ADFD File Offset: 0x00008FFD
		public unsafe Il2CppStructArray<char> m_charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x000B3244 File Offset: 0x000B1444
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x0000AE1C File Offset: 0x0000901C
		public unsafe int m_maxCharsSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize)) = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x000B326C File Offset: 0x000B146C
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x0000AE37 File Offset: 0x00009037
		public unsafe bool m_2BytesPerChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar)) = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x000B3294 File Offset: 0x000B1494
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x0000AE52 File Offset: 0x00009052
		public unsafe bool m_isMemoryStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream)) = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x000B32BC File Offset: 0x000B14BC
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x0000AE6D File Offset: 0x0000906D
		public unsafe bool m_leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen)) = value;
			}
		}

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_m_decoder;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeFieldInfoPtr_m_charBytes;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeFieldInfoPtr_m_singleChar;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeFieldInfoPtr_m_charBuffer;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCharsSize;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeFieldInfoPtr_m_2BytesPerChar;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeFieldInfoPtr_m_isMemoryStream;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeFieldInfoPtr_m_leaveOpen;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x04001D04 RID: 7428
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0;

		// Token: 0x04001D16 RID: 7446
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0;
	}
}
