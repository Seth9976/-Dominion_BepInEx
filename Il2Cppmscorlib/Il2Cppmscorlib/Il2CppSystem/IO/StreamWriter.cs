using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020C RID: 524
	[Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x060021D5 RID: 8661 RVA: 0x000BA4F4 File Offset: 0x000B86F4
		// Note: this type is marked as 'beforefieldinit'.
		static StreamWriter()
		{
			Il2CppClassPointerStore<StreamWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr);
			StreamWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "Null");
			StreamWriter.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "stream");
			StreamWriter.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "encoding");
			StreamWriter.NativeFieldInfoPtr_encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "encoder");
			StreamWriter.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "byteBuffer");
			StreamWriter.NativeFieldInfoPtr_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "charBuffer");
			StreamWriter.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "charPos");
			StreamWriter.NativeFieldInfoPtr_charLen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "charLen");
			StreamWriter.NativeFieldInfoPtr_autoFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "autoFlush");
			StreamWriter.NativeFieldInfoPtr_haveWrittenPreamble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "haveWrittenPreamble");
			StreamWriter.NativeFieldInfoPtr_closable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "closable");
			StreamWriter.NativeFieldInfoPtr__asyncWriteTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_asyncWriteTask");
			StreamWriter.NativeFieldInfoPtr__UTF8NoBOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, "_UTF8NoBOM");
			StreamWriter.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668946);
			StreamWriter.NativeMethodInfoPtr_get_UTF8NoBOM_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668947);
			StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668948);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668949);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668950);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668951);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668952);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668953);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668954);
			StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668955);
			StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Encoding_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668956);
			StreamWriter.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668957);
			StreamWriter.NativeMethodInfoPtr_CreateFile_Private_Static_Stream_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668958);
			StreamWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668959);
			StreamWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668960);
			StreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668961);
			StreamWriter.NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668962);
			StreamWriter.NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668963);
			StreamWriter.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668964);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668965);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668966);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668967);
			StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr, 100668968);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x000BA7F4 File Offset: 0x000B89F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 321855, RefRangeEnd = 321862, XrefRangeStart = 321853, XrefRangeEnd = 321855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAsyncTaskInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x000BA828 File Offset: 0x000B8A28
		public unsafe static Encoding UTF8NoBOM
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 321880, RefRangeEnd = 321883, XrefRangeStart = 321862, XrefRangeEnd = 321880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_get_UTF8NoBOM_Internal_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x000BA85C File Offset: 0x000B8A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321883, XrefRangeEnd = 321887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x000BA898 File Offset: 0x000B8A98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321892, RefRangeEnd = 321893, XrefRangeStart = 321887, XrefRangeEnd = 321892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x000BA8E4 File Offset: 0x000B8AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321894, RefRangeEnd = 321895, XrefRangeStart = 321893, XrefRangeEnd = 321894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x000BA944 File Offset: 0x000B8B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321921, RefRangeEnd = 321925, XrefRangeStart = 321895, XrefRangeEnd = 321921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000BA9C0 File Offset: 0x000B8BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321930, RefRangeEnd = 321931, XrefRangeStart = 321925, XrefRangeEnd = 321930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x000BAA0C File Offset: 0x000B8C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321936, RefRangeEnd = 321937, XrefRangeStart = 321931, XrefRangeEnd = 321936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000BAA68 File Offset: 0x000B8C68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321938, RefRangeEnd = 321940, XrefRangeStart = 321937, XrefRangeEnd = 321938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x000BAAD4 File Offset: 0x000B8CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321940, XrefRangeEnd = 321941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append, Encoding encoding, int bufferSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x000BAB50 File Offset: 0x000B8D50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321984, RefRangeEnd = 321988, XrefRangeStart = 321941, XrefRangeEnd = 321984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StreamWriter(string path, bool append, Encoding encoding, int bufferSize, bool checkHost)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Encoding_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x000BABD8 File Offset: 0x000B8DD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321994, RefRangeEnd = 321996, XrefRangeStart = 321988, XrefRangeEnd = 321994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(streamArg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encodingArg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldLeaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x000BAC48 File Offset: 0x000B8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321996, XrefRangeEnd = 322004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream CreateFile(string path, bool append, bool checkHost)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref append;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkHost;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_CreateFile_Private_Static_Stream_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x000BACA8 File Offset: 0x000B8EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322004, XrefRangeEnd = 322008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000BACE4 File Offset: 0x000B8EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322008, XrefRangeEnd = 322014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000BAD30 File Offset: 0x000B8F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322016, RefRangeEnd = 322017, XrefRangeStart = 322014, XrefRangeEnd = 322016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000BAD6C File Offset: 0x000B8F6C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 322020, RefRangeEnd = 322031, XrefRangeStart = 322017, XrefRangeEnd = 322020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush(bool flushStream, bool flushEncoder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flushStream;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flushEncoder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700071F RID: 1823
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x000BADB8 File Offset: 0x000B8FB8
		public unsafe virtual bool AutoFlush
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322031, XrefRangeEnd = 322033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000BAE04 File Offset: 0x000B9004
		public unsafe bool LeaveOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamWriter.NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000BAE40 File Offset: 0x000B9040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322036, RefRangeEnd = 322038, XrefRangeStart = 322033, XrefRangeEnd = 322036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000BAE8C File Offset: 0x000B908C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322042, RefRangeEnd = 322043, XrefRangeStart = 322038, XrefRangeEnd = 322042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000BAEDC File Offset: 0x000B90DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 322047, RefRangeEnd = 322052, XrefRangeStart = 322043, XrefRangeEnd = 322047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000BAF48 File Offset: 0x000B9148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 322056, RefRangeEnd = 322059, XrefRangeStart = 322052, XrefRangeEnd = 322056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0000B762 File Offset: 0x00009962
		public StreamWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x000BAF98 File Offset: 0x000B9198
		// (set) Token: 0x060021EF RID: 8687 RVA: 0x0000B76B File Offset: 0x0000996B
		public new unsafe static StreamWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000BAFC0 File Offset: 0x000B91C0
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x0000B77D File Offset: 0x0000997D
		public unsafe Stream stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x000BAFF0 File Offset: 0x000B91F0
		// (set) Token: 0x060021F3 RID: 8691 RVA: 0x0000B79C File Offset: 0x0000999C
		public unsafe Encoding encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x060021F4 RID: 8692 RVA: 0x000BB020 File Offset: 0x000B9220
		// (set) Token: 0x060021F5 RID: 8693 RVA: 0x0000B7BB File Offset: 0x000099BB
		public unsafe Encoder encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060021F6 RID: 8694 RVA: 0x000BB050 File Offset: 0x000B9250
		// (set) Token: 0x060021F7 RID: 8695 RVA: 0x0000B7DA File Offset: 0x000099DA
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x000BB080 File Offset: 0x000B9280
		// (set) Token: 0x060021F9 RID: 8697 RVA: 0x0000B7F9 File Offset: 0x000099F9
		public unsafe Il2CppStructArray<char> charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000BB0B0 File Offset: 0x000B92B0
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x0000B818 File Offset: 0x00009A18
		public unsafe int charPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charPos)) = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x000BB0D8 File Offset: 0x000B92D8
		// (set) Token: 0x060021FD RID: 8701 RVA: 0x0000B833 File Offset: 0x00009A33
		public unsafe int charLen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charLen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_charLen)) = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x000BB100 File Offset: 0x000B9300
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x0000B84E File Offset: 0x00009A4E
		public unsafe bool autoFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_autoFlush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_autoFlush)) = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x000BB128 File Offset: 0x000B9328
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x0000B869 File Offset: 0x00009A69
		public unsafe bool haveWrittenPreamble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_haveWrittenPreamble);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_haveWrittenPreamble)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x000BB150 File Offset: 0x000B9350
		// (set) Token: 0x06002203 RID: 8707 RVA: 0x0000B884 File Offset: 0x00009A84
		public unsafe bool closable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_closable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr_closable)) = value;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x000BB178 File Offset: 0x000B9378
		// (set) Token: 0x06002205 RID: 8709 RVA: 0x0000B89F File Offset: 0x00009A9F
		public unsafe Task _asyncWriteTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__asyncWriteTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StreamWriter.NativeFieldInfoPtr__asyncWriteTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000BB1A8 File Offset: 0x000B93A8
		// (set) Token: 0x06002207 RID: 8711 RVA: 0x0000B8BE File Offset: 0x00009ABE
		public unsafe static Encoding _UTF8NoBOM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StreamWriter.NativeFieldInfoPtr__UTF8NoBOM, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StreamWriter.NativeFieldInfoPtr__UTF8NoBOM, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeFieldInfoPtr_stream;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeFieldInfoPtr_encoder;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeFieldInfoPtr_charBuffer;

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeFieldInfoPtr_charPos;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeFieldInfoPtr_charLen;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeFieldInfoPtr_autoFlush;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeFieldInfoPtr_haveWrittenPreamble;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeFieldInfoPtr_closable;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeFieldInfoPtr__asyncWriteTask;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeFieldInfoPtr__UTF8NoBOM;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_CheckAsyncTaskInProgress_Private_Void_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeMethodInfoPtr_get_UTF8NoBOM_Internal_Static_get_Encoding_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Int32_Boolean_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Encoding_Int32_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Encoding_Int32_Boolean_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Stream_Encoding_Int32_Boolean_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_CreateFile_Private_Static_Stream_String_Boolean_Boolean_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Void_Boolean_Boolean_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly IntPtr NativeMethodInfoPtr_set_AutoFlush_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaveOpen_Internal_get_Boolean_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;
	}
}
