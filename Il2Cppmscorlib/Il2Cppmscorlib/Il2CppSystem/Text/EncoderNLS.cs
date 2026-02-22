using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000169 RID: 361
	[Serializable]
	public class EncoderNLS : Encoder
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x0008F630 File Offset: 0x0008D830
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderNLS()
		{
			Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderNLS");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr);
			EncoderNLS.NativeFieldInfoPtr_charLeftOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, "charLeftOver");
			EncoderNLS.NativeFieldInfoPtr_m_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, "m_encoding");
			EncoderNLS.NativeFieldInfoPtr_m_mustFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, "m_mustFlush");
			EncoderNLS.NativeFieldInfoPtr_m_throwOnOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, "m_throwOnOverflow");
			EncoderNLS.NativeFieldInfoPtr_m_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, "m_charsUsed");
			EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667336);
			EncoderNLS.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667337);
			EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667338);
			EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667339);
			EncoderNLS.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667340);
			EncoderNLS.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667341);
			EncoderNLS.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667342);
			EncoderNLS.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667343);
			EncoderNLS.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667344);
			EncoderNLS.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667345);
			EncoderNLS.NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667346);
			EncoderNLS.NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr, 100667347);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x0008F7B4 File Offset: 0x0008D9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310541, XrefRangeEnd = 310556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderNLS(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x0008F818 File Offset: 0x0008DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310556, XrefRangeEnd = 310573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0008F874 File Offset: 0x0008DA74
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 310575, RefRangeEnd = 310580, XrefRangeStart = 310573, XrefRangeEnd = 310575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderNLS(Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310581, RefRangeEnd = 310583, XrefRangeStart = 310580, XrefRangeEnd = 310581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderNLS()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderNLS>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x0008F8FC File Offset: 0x0008DAFC
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderNLS.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x0008F938 File Offset: 0x0008DB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310583, XrefRangeEnd = 310611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(Il2CppStructArray<char> chars, int index, int count, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderNLS.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0008F9BC File Offset: 0x0008DBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310611, XrefRangeEnd = 310628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderNLS.NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0008FA2C File Offset: 0x0008DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310628, XrefRangeEnd = 310635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(Il2CppStructArray<char> chars, int charIndex, int charCount, Il2CppStructArray<byte> bytes, int byteIndex, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteIndex;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderNLS.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0008FAD0 File Offset: 0x0008DCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310635, XrefRangeEnd = 310653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = chars;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = bytes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flush;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EncoderNLS.NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0008FB5C File Offset: 0x0008DD5C
		public unsafe Encoding Encoding
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x0008FB9C File Offset: 0x0008DD9C
		public unsafe bool MustFlush
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0008FBD8 File Offset: 0x0008DDD8
		[CallerCount(0)]
		public unsafe void ClearMustFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderNLS.NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00008939 File Offset: 0x00006B39
		public EncoderNLS(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0008FC0C File Offset: 0x0008DE0C
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x00008942 File Offset: 0x00006B42
		public unsafe char charLeftOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_charLeftOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_charLeftOver)) = value;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0008FC34 File Offset: 0x0008DE34
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0000895D File Offset: 0x00006B5D
		public unsafe Encoding m_encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0008FC64 File Offset: 0x0008DE64
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe bool m_mustFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_mustFlush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_mustFlush)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0008FC8C File Offset: 0x0008DE8C
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x00008997 File Offset: 0x00006B97
		public unsafe bool m_throwOnOverflow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_throwOnOverflow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_throwOnOverflow)) = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0008FCB4 File Offset: 0x0008DEB4
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x000089B2 File Offset: 0x00006BB2
		public unsafe int m_charsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_charsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderNLS.NativeFieldInfoPtr_m_charsUsed)) = value;
			}
		}

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeFieldInfoPtr_charLeftOver;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeFieldInfoPtr_m_encoding;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeFieldInfoPtr_m_mustFlush;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeFieldInfoPtr_m_throwOnOverflow;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeFieldInfoPtr_m_charsUsed;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Encoding_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Boolean_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_GetByteCount_Public_Virtual_Int32_ptr_Char_Int32_Boolean_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_Il2CppStructArray_1_Byte_Int32_Boolean_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Int32_ptr_Char_Int32_ptr_Byte_Int32_Boolean_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_get_Encoding_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_get_MustFlush_Public_get_Boolean_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_ClearMustFlush_Internal_Void_0;
	}
}
