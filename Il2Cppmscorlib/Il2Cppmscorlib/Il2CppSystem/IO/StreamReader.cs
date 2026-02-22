using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020B RID: 523
	[Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x000B9440 File Offset: 0x000B7640
		// Note: this type is marked as 'beforefieldinit'.
		static StreamReader()
		{
			Il2CppClassPointerStore<StreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader>.NativeClassPtr);
			StreamReader.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "Null");
			StreamReader.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "stream");
			StreamReader.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "encoding");
			StreamReader.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "decoder");
			StreamReader.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "byteBuffer");
			StreamReader.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charBuffer");
			StreamReader.NativeFieldInfoPtr__preamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_preamble");
			StreamReader.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charPos");
			StreamReader.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "charLen");
			StreamReader.NativeFieldInfoPtr_byteLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "byteLen");
			StreamReader.NativeFieldInfoPtr_bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "bytePos");
			StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_maxCharsPerBuffer");
			StreamReader.NativeFieldInfoPtr__detectEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_detectEncoding");
			StreamReader.NativeFieldInfoPtr__checkPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_checkPreamble");
			StreamReader.NativeFieldInfoPtr__isBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_isBlocked");
			StreamReader.NativeFieldInfoPtr__closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_closable");
			StreamReader.NativeFieldInfoPtr__asyncReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "_asyncReadTask");
			StreamReader.NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668904);
			StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668905);
			StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668906);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668907);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668908);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668909);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668910);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668911);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668912);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668913);
			StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668914);
			StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668915);
			StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668916);
			StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668917);
			StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668918);
			StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668919);
			StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668920);
			StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668921);
			StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668922);
			StreamReader.NativeMethodInfoPtr_get_EndOfStream_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668923);
			StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668924);
			StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668925);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668926);
			StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668927);
			StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668928);
			StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668929);
			StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668930);
			StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668931);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668932);
			StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668933);
			StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, 100668934);
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x000B9830 File Offset: 0x000B7A30
		public unsafe static int DefaultBufferSize
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000B9860 File Offset: 0x000B7A60
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 321650, RefRangeEnd = 321656, XrefRangeStart = 321648, XrefRangeEnd = 321650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAsyncTaskInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000B9894 File Offset: 0x000B7A94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321660, RefRangeEnd = 321661, XrefRangeStart = 321656, XrefRangeEnd = 321660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000B98D0 File Offset: 0x000B7AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321666, RefRangeEnd = 321667, XrefRangeStart = 321661, XrefRangeEnd = 321666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000B991C File Offset: 0x000B7B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321667, XrefRangeEnd = 321672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000B9978 File Offset: 0x000B7B78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 321676, RefRangeEnd = 321681, XrefRangeStart = 321672, XrefRangeEnd = 321676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000B99D8 File Offset: 0x000B7BD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321707, RefRangeEnd = 321710, XrefRangeStart = 321681, XrefRangeEnd = 321707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000B9A60 File Offset: 0x000B7C60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321715, RefRangeEnd = 321719, XrefRangeStart = 321710, XrefRangeEnd = 321715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000B9AAC File Offset: 0x000B7CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321719, XrefRangeEnd = 321724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, bool detectEncodingFromByteOrderMarks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x000B9B08 File Offset: 0x000B7D08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321728, RefRangeEnd = 321730, XrefRangeStart = 321724, XrefRangeEnd = 321728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000B9B68 File Offset: 0x000B7D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321730, XrefRangeEnd = 321731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x000B9BE4 File Offset: 0x000B7DE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321765, RefRangeEnd = 321769, XrefRangeStart = 321731, XrefRangeEnd = 321765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamReader(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000B9C6C File Offset: 0x000B7E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321775, RefRangeEnd = 321777, XrefRangeStart = 321769, XrefRangeEnd = 321775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref detectEncodingFromByteOrderMarks;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x000B9CEC File Offset: 0x000B7EEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321777, RefRangeEnd = 321778, XrefRangeStart = 321777, XrefRangeEnd = 321777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_Init_Internal_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x000B9D30 File Offset: 0x000B7F30
		[CallerCount(0)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x000B9D6C File Offset: 0x000B7F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321778, XrefRangeEnd = 321780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x000B9DB8 File Offset: 0x000B7FB8
		public unsafe virtual Encoding CurrentEncoding
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000B9E04 File Offset: 0x000B8004
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x000B9E50 File Offset: 0x000B8050
		public unsafe bool LeaveOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000B9E8C File Offset: 0x000B808C
		public unsafe bool EndOfStream
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 321782, RefRangeEnd = 321784, XrefRangeStart = 321780, XrefRangeEnd = 321782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_get_EndOfStream_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x000B9EC8 File Offset: 0x000B80C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321786, RefRangeEnd = 321788, XrefRangeStart = 321784, XrefRangeEnd = 321786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000B9F10 File Offset: 0x000B8110
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321788, RefRangeEnd = 321791, XrefRangeStart = 321788, XrefRangeEnd = 321788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DataAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000B9F4C File Offset: 0x000B814C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321793, RefRangeEnd = 321795, XrefRangeStart = 321791, XrefRangeEnd = 321793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x000B9F94 File Offset: 0x000B8194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321795, XrefRangeEnd = 321800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x000BA01C File Offset: 0x000B821C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321808, RefRangeEnd = 321809, XrefRangeStart = 321800, XrefRangeEnd = 321808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x000BA060 File Offset: 0x000B8260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321810, RefRangeEnd = 321812, XrefRangeStart = 321809, XrefRangeEnd = 321810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompressBuffer(int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000BA0A0 File Offset: 0x000B82A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321836, RefRangeEnd = 321838, XrefRangeStart = 321812, XrefRangeEnd = 321836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_DetectEncoding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000BA0D4 File Offset: 0x000B82D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321839, RefRangeEnd = 321841, XrefRangeStart = 321838, XrefRangeEnd = 321839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPreamble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_IsPreamble_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x000BA110 File Offset: 0x000B8310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321841, XrefRangeEnd = 321844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x000BA158 File Offset: 0x000B8358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321848, RefRangeEnd = 321849, XrefRangeStart = 321844, XrefRangeEnd = 321848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadBuffer(Il2CppStructArray<char> userBuffer, int userOffset, int desiredChars, out bool readToUserBuffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref desiredChars;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &readToUserBuffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x000BA1D0 File Offset: 0x000B83D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321852, RefRangeEnd = 321853, XrefRangeStart = 321849, XrefRangeEnd = 321852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0000B57B File Offset: 0x0000977B
		public StreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x000BA214 File Offset: 0x000B8414
		// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0000B584 File Offset: 0x00009784
		public new unsafe static StreamReader Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamReader.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamReader.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x000BA23C File Offset: 0x000B843C
		// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0000B596 File Offset: 0x00009796
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x000BA26C File Offset: 0x000B846C
		// (set) Token: 0x060021B8 RID: 8632 RVA: 0x0000B5B5 File Offset: 0x000097B5
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x000BA29C File Offset: 0x000B849C
		// (set) Token: 0x060021BA RID: 8634 RVA: 0x0000B5D4 File Offset: 0x000097D4
		public unsafe Decoder decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x000BA2CC File Offset: 0x000B84CC
		// (set) Token: 0x060021BC RID: 8636 RVA: 0x0000B5F3 File Offset: 0x000097F3
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x000BA2FC File Offset: 0x000B84FC
		// (set) Token: 0x060021BE RID: 8638 RVA: 0x0000B612 File Offset: 0x00009812
		public unsafe Il2CppStructArray<char> charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x000BA32C File Offset: 0x000B852C
		// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0000B631 File Offset: 0x00009831
		public unsafe Il2CppStructArray<byte> _preamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__preamble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__preamble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x000BA35C File Offset: 0x000B855C
		// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0000B650 File Offset: 0x00009850
		public unsafe int charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charPos)) = value;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x000BA384 File Offset: 0x000B8584
		// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0000B66B File Offset: 0x0000986B
		public unsafe int charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_charLen)) = value;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000BA3AC File Offset: 0x000B85AC
		// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0000B686 File Offset: 0x00009886
		public unsafe int byteLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_byteLen)) = value;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000BA3D4 File Offset: 0x000B85D4
		// (set) Token: 0x060021C8 RID: 8648 RVA: 0x0000B6A1 File Offset: 0x000098A1
		public unsafe int bytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_bytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr_bytePos)) = value;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000BA3FC File Offset: 0x000B85FC
		// (set) Token: 0x060021CA RID: 8650 RVA: 0x0000B6BC File Offset: 0x000098BC
		public unsafe int _maxCharsPerBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__maxCharsPerBuffer)) = value;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000BA424 File Offset: 0x000B8624
		// (set) Token: 0x060021CC RID: 8652 RVA: 0x0000B6D7 File Offset: 0x000098D7
		public unsafe bool _detectEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__detectEncoding)) = value;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000BA44C File Offset: 0x000B864C
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x0000B6F2 File Offset: 0x000098F2
		public unsafe bool _checkPreamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__checkPreamble)) = value;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x000BA474 File Offset: 0x000B8674
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0000B70D File Offset: 0x0000990D
		public unsafe bool _isBlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__isBlocked)) = value;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x000BA49C File Offset: 0x000B869C
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0000B728 File Offset: 0x00009928
		public unsafe bool _closable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__closable)) = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x000BA4C4 File Offset: 0x000B86C4
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x0000B743 File Offset: 0x00009943
		public unsafe Task _asyncReadTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamReader.NativeFieldInfoPtr__asyncReadTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E1B RID: 7707
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E1C RID: 7708
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04001E1D RID: 7709
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04001E1E RID: 7710
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeFieldInfoPtr__preamble;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeFieldInfoPtr_charPos;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeFieldInfoPtr_charLen;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeFieldInfoPtr_byteLen;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeFieldInfoPtr_bytePos;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeFieldInfoPtr__maxCharsPerBuffer;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeFieldInfoPtr__detectEncoding;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeFieldInfoPtr__checkPreamble;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeFieldInfoPtr__isBlocked;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeFieldInfoPtr__closable;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeFieldInfoPtr__asyncReadTask;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultBufferSize_Internal_Static_get_Int32_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_0;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_Boolean_Int32_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001E38 RID: 7736
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Boolean_Int32_Boolean_0;

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Stream_0;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_New_get_Encoding_0;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeMethodInfoPtr_get_EndOfStream_Public_get_Boolean_0;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeMethodInfoPtr_DataAvailable_Internal_Boolean_0;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_CompressBuffer_Private_Void_Int32_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Void_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_IsPreamble_Private_Boolean_0;

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_New_Int32_0;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_byref_Boolean_0;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x020005D3 RID: 1491
		public class NullStreamReader : StreamReader
		{
			// Token: 0x060051AD RID: 20909 RVA: 0x0016CDA4 File Offset: 0x0016AFA4
			// Note: this type is marked as 'beforefieldinit'.
			static NullStreamReader()
			{
				Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StreamReader>.NativeClassPtr, "NullStreamReader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr);
				StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668936);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668937);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668938);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668939);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668940);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668941);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668942);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668943);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668944);
				StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr, 100668945);
			}

			// Token: 0x060051AE RID: 20910 RVA: 0x0016CE98 File Offset: 0x0016B098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321632, XrefRangeEnd = 321641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStreamReader()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamReader.NullStreamReader>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamReader.NullStreamReader.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014E7 RID: 5351
			// (get) Token: 0x060051AF RID: 20911 RVA: 0x0016CED4 File Offset: 0x0016B0D4
			public unsafe override Stream BaseStream
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321641, XrefRangeEnd = 321645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
				}
			}

			// Token: 0x170014E8 RID: 5352
			// (get) Token: 0x060051B0 RID: 20912 RVA: 0x0016CF20 File Offset: 0x0016B120
			public unsafe override Encoding CurrentEncoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321645, XrefRangeEnd = 321646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x060051B1 RID: 20913 RVA: 0x0016CF6C File Offset: 0x0016B16C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051B2 RID: 20914 RVA: 0x0016CFB8 File Offset: 0x0016B1B8
			[CallerCount(0)]
			public unsafe override int Peek()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B3 RID: 20915 RVA: 0x0016D000 File Offset: 0x0016B200
			[CallerCount(0)]
			public unsafe override int Read()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B4 RID: 20916 RVA: 0x0016D048 File Offset: 0x0016B248
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B5 RID: 20917 RVA: 0x0016D0BC File Offset: 0x0016B2BC
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051B6 RID: 20918 RVA: 0x0016D100 File Offset: 0x0016B300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321646, XrefRangeEnd = 321648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ReadToEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060051B7 RID: 20919 RVA: 0x0016D144 File Offset: 0x0016B344
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int ReadBuffer()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamReader.NullStreamReader.NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060051B8 RID: 20920 RVA: 0x0001F2CA File Offset: 0x0001D4CA
			public NullStreamReader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400421D RID: 16925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400421E RID: 16926
			private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_get_Stream_0;

			// Token: 0x0400421F RID: 16927
			private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEncoding_Public_Virtual_get_Encoding_0;

			// Token: 0x04004220 RID: 16928
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004221 RID: 16929
			private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

			// Token: 0x04004222 RID: 16930
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

			// Token: 0x04004223 RID: 16931
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004224 RID: 16932
			private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

			// Token: 0x04004225 RID: 16933
			private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;

			// Token: 0x04004226 RID: 16934
			private static readonly IntPtr NativeMethodInfoPtr_ReadBuffer_Internal_Virtual_Int32_0;
		}
	}
}
