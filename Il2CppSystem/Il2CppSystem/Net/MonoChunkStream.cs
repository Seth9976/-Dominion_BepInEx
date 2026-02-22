using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net
{
	// Token: 0x02000111 RID: 273
	public class MonoChunkStream : Object
	{
		// Token: 0x0600112E RID: 4398 RVA: 0x00050AD8 File Offset: 0x0004ECD8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoChunkStream()
		{
			Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "MonoChunkStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr);
			MonoChunkStream.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "headers");
			MonoChunkStream.NativeFieldInfoPtr_chunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunkSize");
			MonoChunkStream.NativeFieldInfoPtr_chunkRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunkRead");
			MonoChunkStream.NativeFieldInfoPtr_totalWritten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "totalWritten");
			MonoChunkStream.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "state");
			MonoChunkStream.NativeFieldInfoPtr_saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "saved");
			MonoChunkStream.NativeFieldInfoPtr_sawCR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "sawCR");
			MonoChunkStream.NativeFieldInfoPtr_gotit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "gotit");
			MonoChunkStream.NativeFieldInfoPtr_trailerState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "trailerState");
			MonoChunkStream.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "chunks");
			MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665671);
			MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665672);
			MonoChunkStream.NativeMethodInfoPtr_ResetBuffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665673);
			MonoChunkStream.NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665674);
			MonoChunkStream.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665675);
			MonoChunkStream.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665676);
			MonoChunkStream.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665677);
			MonoChunkStream.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665678);
			MonoChunkStream.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665679);
			MonoChunkStream.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665680);
			MonoChunkStream.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665681);
			MonoChunkStream.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665682);
			MonoChunkStream.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665683);
			MonoChunkStream.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665684);
			MonoChunkStream.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665685);
			MonoChunkStream.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665686);
			MonoChunkStream.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, 100665687);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00050D24 File Offset: 0x0004EF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52706, RefRangeEnd = 52707, XrefRangeStart = 52696, XrefRangeEnd = 52706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream(Il2CppStructArray<byte> buffer, int offset, int size, WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00050DA0 File Offset: 0x0004EFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52707, XrefRangeEnd = 52716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream(WebHeaderCollection headers)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(headers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x00050DEC File Offset: 0x0004EFEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52717, RefRangeEnd = 52718, XrefRangeStart = 52716, XrefRangeEnd = 52717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ResetBuffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00050E20 File Offset: 0x0004F020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52720, RefRangeEnd = 52721, XrefRangeStart = 52718, XrefRangeEnd = 52720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAndReadBack(Il2CppStructArray<byte> buffer, int offset, int size, ref int read)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &read;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00050E90 File Offset: 0x0004F090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52722, RefRangeEnd = 52723, XrefRangeStart = 52721, XrefRangeEnd = 52722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00050EFC File Offset: 0x0004F0FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52750, RefRangeEnd = 52752, XrefRangeStart = 52723, XrefRangeEnd = 52750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadFromChunks(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00050F68 File Offset: 0x0004F168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52753, RefRangeEnd = 52755, XrefRangeStart = 52752, XrefRangeEnd = 52753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(Il2CppStructArray<byte> buffer, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00050FC8 File Offset: 0x0004F1C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 52772, RefRangeEnd = 52775, XrefRangeStart = 52755, XrefRangeEnd = 52772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWrite(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x00051028 File Offset: 0x0004F228
		public unsafe bool WantMore
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 52775, RefRangeEnd = 52778, XrefRangeStart = 52775, XrefRangeEnd = 52775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x00051064 File Offset: 0x0004F264
		public unsafe bool DataAvailable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 52780, RefRangeEnd = 52781, XrefRangeStart = 52778, XrefRangeEnd = 52780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x000510A0 File Offset: 0x0004F2A0
		public unsafe int ChunkLeft
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 52781, RefRangeEnd = 52783, XrefRangeStart = 52781, XrefRangeEnd = 52781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000510DC File Offset: 0x0004F2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52783, XrefRangeEnd = 52791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadBody(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00051148 File Offset: 0x0004F348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52801, RefRangeEnd = 52802, XrefRangeStart = 52791, XrefRangeEnd = 52801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State GetChunkSize(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000511B4 File Offset: 0x0004F3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52802, XrefRangeEnd = 52804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveChunkExtension(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000511F0 File Offset: 0x0004F3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52804, XrefRangeEnd = 52807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadCRLF(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0005125C File Offset: 0x0004F45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52813, RefRangeEnd = 52814, XrefRangeStart = 52807, XrefRangeEnd = 52813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoChunkStream.State ReadTrailer(Il2CppStructArray<byte> buffer, ref int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x000512C8 File Offset: 0x0004F4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52814, XrefRangeEnd = 52819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowProtocolViolation(string message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00008F41 File Offset: 0x00007141
		public MonoChunkStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x00051300 File Offset: 0x0004F500
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x00008F4A File Offset: 0x0000714A
		public unsafe WebHeaderCollection headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WebHeaderCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00051330 File Offset: 0x0004F530
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x00008F69 File Offset: 0x00007169
		public unsafe int chunkSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkSize)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00051358 File Offset: 0x0004F558
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x00008F84 File Offset: 0x00007184
		public unsafe int chunkRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunkRead)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00051380 File Offset: 0x0004F580
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x00008F9F File Offset: 0x0000719F
		public unsafe int totalWritten
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_totalWritten);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_totalWritten)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000513A8 File Offset: 0x0004F5A8
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00008FBA File Offset: 0x000071BA
		public unsafe MonoChunkStream.State state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x000513D0 File Offset: 0x0004F5D0
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x00008FD5 File Offset: 0x000071D5
		public unsafe StringBuilder saved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_saved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_saved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00051400 File Offset: 0x0004F600
		// (set) Token: 0x0600114E RID: 4430 RVA: 0x00008FF4 File Offset: 0x000071F4
		public unsafe bool sawCR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_sawCR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_sawCR)) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00051428 File Offset: 0x0004F628
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0000900F File Offset: 0x0000720F
		public unsafe bool gotit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_gotit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_gotit)) = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x00051450 File Offset: 0x0004F650
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0000902A File Offset: 0x0000722A
		public unsafe int trailerState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_trailerState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_trailerState)) = value;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x00051478 File Offset: 0x0004F678
		// (set) Token: 0x06001154 RID: 4436 RVA: 0x00009045 File Offset: 0x00007245
		public unsafe ArrayList chunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_chunkSize;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_chunkRead;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_totalWritten;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_saved;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_sawCR;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_gotit;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_trailerState;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeFieldInfoPtr_chunks;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_WebHeaderCollection_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WebHeaderCollection_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_ResetBuffer_Public_Void_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_WriteAndReadBack_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_byref_Int32_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_ReadFromChunks_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_InternalWrite_Private_Void_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_get_WantMore_Public_get_Boolean_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_get_DataAvailable_Public_get_Boolean_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_get_ChunkLeft_Public_get_Int32_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_ReadBody_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_GetChunkSize_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChunkExtension_Private_Static_String_String_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_ReadCRLF_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_ReadTrailer_Private_State_Il2CppStructArray_1_Byte_byref_Int32_Int32_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_ThrowProtocolViolation_Private_Static_Void_String_0;

		// Token: 0x020001CA RID: 458
		public enum State
		{
			// Token: 0x040013FD RID: 5117
			None,
			// Token: 0x040013FE RID: 5118
			PartialSize,
			// Token: 0x040013FF RID: 5119
			Body,
			// Token: 0x04001400 RID: 5120
			BodyFinished,
			// Token: 0x04001401 RID: 5121
			Trailer
		}

		// Token: 0x020001CB RID: 459
		public class Chunk : Object
		{
			// Token: 0x06001985 RID: 6533 RVA: 0x0006C0AC File Offset: 0x0006A2AC
			// Note: this type is marked as 'beforefieldinit'.
			static Chunk()
			{
				Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoChunkStream>.NativeClassPtr, "Chunk");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr);
				MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, "Bytes");
				MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, "Offset");
				MonoChunkStream.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, 100665688);
				MonoChunkStream.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr, 100665689);
			}

			// Token: 0x06001986 RID: 6534 RVA: 0x0006C128 File Offset: 0x0006A328
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Chunk(Il2CppStructArray<byte> chunk)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoChunkStream.Chunk>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chunk);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.Chunk.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001987 RID: 6535 RVA: 0x0006C174 File Offset: 0x0006A374
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 52695, RefRangeEnd = 52696, XrefRangeStart = 52694, XrefRangeEnd = 52695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Read(Il2CppStructArray<byte> buffer, int offset, int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoChunkStream.Chunk.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001988 RID: 6536 RVA: 0x0000D8CA File Offset: 0x0000BACA
			public Chunk(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06001989 RID: 6537 RVA: 0x0006C1E0 File Offset: 0x0006A3E0
			// (set) Token: 0x0600198A RID: 6538 RVA: 0x0000D8D3 File Offset: 0x0000BAD3
			public unsafe Il2CppStructArray<byte> Bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x0600198B RID: 6539 RVA: 0x0006C210 File Offset: 0x0006A410
			// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoChunkStream.Chunk.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x04001402 RID: 5122
			private static readonly IntPtr NativeFieldInfoPtr_Bytes;

			// Token: 0x04001403 RID: 5123
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x04001404 RID: 5124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04001405 RID: 5125
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;
		}
	}
}
