using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO.Compression
{
	// Token: 0x020000A3 RID: 163
	public class DeflateStreamNative : Object
	{
		// Token: 0x060009B5 RID: 2485 RVA: 0x00034654 File Offset: 0x00032854
		// Note: this type is marked as 'beforefieldinit'.
		static DeflateStreamNative()
		{
			Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO.Compression", "DeflateStreamNative");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr);
			DeflateStreamNative.NativeFieldInfoPtr_feeder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "feeder");
			DeflateStreamNative.NativeFieldInfoPtr_base_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "base_stream");
			DeflateStreamNative.NativeFieldInfoPtr_z_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "z_stream");
			DeflateStreamNative.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "data");
			DeflateStreamNative.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "disposed");
			DeflateStreamNative.NativeFieldInfoPtr_io_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "io_buffer");
			DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664570);
			DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664571);
			DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664572);
			DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664573);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664574);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664575);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664576);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664577);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664578);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664579);
			DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664580);
			DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664581);
			DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664582);
			DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664583);
			DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664584);
			DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664585);
			DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, 100664586);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00034850 File Offset: 0x00032A50
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeflateStreamNative()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0003488C File Offset: 0x00032A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43631, XrefRangeEnd = 43651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(compressedStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative>(intPtr3) : null;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000348EC File Offset: 0x00032AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43651, XrefRangeEnd = 43657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeflateStreamNative.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00034928 File Offset: 0x00032B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43664, RefRangeEnd = 43665, XrefRangeStart = 43657, XrefRangeEnd = 43664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00034968 File Offset: 0x00032B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43665, XrefRangeEnd = 43673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0003499C File Offset: 0x00032B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43673, XrefRangeEnd = 43679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x000349F4 File Offset: 0x00032BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43679, XrefRangeEnd = 43687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteZStream(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00034A40 File Offset: 0x00032C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43687, XrefRangeEnd = 43702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00034A9C File Offset: 0x00032C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43702, XrefRangeEnd = 43713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedRead(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00034AF4 File Offset: 0x00032CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43713, XrefRangeEnd = 43729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00034B50 File Offset: 0x00032D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43729, XrefRangeEnd = 43741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int UnmanagedWrite(IntPtr buffer, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00034BA8 File Offset: 0x00032DA8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 43742, RefRangeEnd = 43750, XrefRangeStart = 43741, XrefRangeEnd = 43742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckResult(int result, string where)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(where);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00034BEC File Offset: 0x00032DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43750, XrefRangeEnd = 43756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref compress;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gzip;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(feeder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr3) : null;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00034C5C File Offset: 0x00032E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43757, RefRangeEnd = 43758, XrefRangeStart = 43756, XrefRangeEnd = 43757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CloseZStream(IntPtr stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00034C9C File Offset: 0x00032E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43758, XrefRangeEnd = 43761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00034CE0 File Offset: 0x00032EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43761, XrefRangeEnd = 43764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00034D40 File Offset: 0x00032F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43764, XrefRangeEnd = 43767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00005E70 File Offset: 0x00004070
		public DeflateStreamNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00034DA0 File Offset: 0x00032FA0
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00005E79 File Offset: 0x00004079
		public unsafe DeflateStreamNative.UnmanagedReadOrWrite feeder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.UnmanagedReadOrWrite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_feeder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00034DD0 File Offset: 0x00032FD0
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00005E98 File Offset: 0x00004098
		public unsafe Stream base_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_base_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00034E00 File Offset: 0x00033000
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x00005EB7 File Offset: 0x000040B7
		public unsafe DeflateStreamNative.SafeDeflateStreamHandle z_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeflateStreamNative.SafeDeflateStreamHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_z_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00034E30 File Offset: 0x00033030
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x00005ED6 File Offset: 0x000040D6
		public unsafe GCHandle data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_data)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00034E58 File Offset: 0x00033058
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00005EF1 File Offset: 0x000040F1
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00034E80 File Offset: 0x00033080
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00005F0C File Offset: 0x0000410C
		public unsafe Il2CppStructArray<byte> io_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeflateStreamNative.NativeFieldInfoPtr_io_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeFieldInfoPtr_feeder;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeFieldInfoPtr_base_stream;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeFieldInfoPtr_z_stream;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeFieldInfoPtr_io_buffer;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DeflateStreamNative_Stream_CompressionMode_Boolean_0;

		// Token: 0x04000768 RID: 1896
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000769 RID: 1897
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_Boolean_0;

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Void_0;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Public_Int32_IntPtr_Int32_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Public_Void_IntPtr_Int32_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedRead_Private_Int32_IntPtr_Int32_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Static_Int32_IntPtr_Int32_IntPtr_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_UnmanagedWrite_Private_Int32_IntPtr_Int32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_CheckResult_Private_Static_Void_Int32_String_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_CreateZStream_Private_Static_SafeDeflateStreamHandle_CompressionMode_Boolean_UnmanagedReadOrWrite_IntPtr_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_CloseZStream_Private_Static_Int32_IntPtr_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Static_Int32_SafeDeflateStreamHandle_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_ReadZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_WriteZStream_Private_Static_Int32_SafeDeflateStreamHandle_IntPtr_Int32_0;

		// Token: 0x02000198 RID: 408
		public sealed class UnmanagedReadOrWrite : MulticastDelegate
		{
			// Token: 0x0600176D RID: 5997 RVA: 0x0000C621 File Offset: 0x0000A821
			// Note: this type is marked as 'beforefieldinit'.
			static UnmanagedReadOrWrite()
			{
				Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "UnmanagedReadOrWrite");
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664587);
				DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr, 100664588);
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x00065600 File Offset: 0x00063800
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnmanagedReadOrWrite(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.UnmanagedReadOrWrite>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x0006565C File Offset: 0x0006385C
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr buffer, int length, IntPtr data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref buffer;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.UnmanagedReadOrWrite.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001770 RID: 6000 RVA: 0x0000C65F File Offset: 0x0000A85F
			public UnmanagedReadOrWrite(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001771 RID: 6001 RVA: 0x0000C668 File Offset: 0x0000A868
			public static implicit operator DeflateStreamNative.UnmanagedReadOrWrite(Func<IntPtr, int, IntPtr, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<DeflateStreamNative.UnmanagedReadOrWrite>(A_0);
			}

			// Token: 0x06001772 RID: 6002 RVA: 0x0000C670 File Offset: 0x0000A870
			public static DeflateStreamNative.UnmanagedReadOrWrite operator +(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
			}

			// Token: 0x06001773 RID: 6003 RVA: 0x0000C67E File Offset: 0x0000A87E
			public static DeflateStreamNative.UnmanagedReadOrWrite operator -(DeflateStreamNative.UnmanagedReadOrWrite A_0, DeflateStreamNative.UnmanagedReadOrWrite A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DeflateStreamNative.UnmanagedReadOrWrite>();
				}
				return delegate2;
			}

			// Token: 0x040012B4 RID: 4788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040012B5 RID: 4789
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_Int32_IntPtr_0;
		}

		// Token: 0x02000199 RID: 409
		public sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x06001774 RID: 6004 RVA: 0x000656C4 File Offset: 0x000638C4
			// Note: this type is marked as 'beforefieldinit'.
			static SafeDeflateStreamHandle()
			{
				Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeflateStreamNative>.NativeClassPtr, "SafeDeflateStreamHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664589);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664590);
				DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr, 100664591);
			}

			// Token: 0x17000783 RID: 1923
			// (get) Token: 0x06001775 RID: 6005 RVA: 0x0006572C File Offset: 0x0006392C
			public unsafe override bool IsInvalid
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43623, XrefRangeEnd = 43625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x00065768 File Offset: 0x00063968
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43627, RefRangeEnd = 43630, XrefRangeStart = 43625, XrefRangeEnd = 43627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeDeflateStreamHandle()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeflateStreamNative.SafeDeflateStreamHandle>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001777 RID: 6007 RVA: 0x000657A4 File Offset: 0x000639A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43630, XrefRangeEnd = 43631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeflateStreamNative.SafeDeflateStreamHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001778 RID: 6008 RVA: 0x0000C68F File Offset: 0x0000A88F
			public SafeDeflateStreamHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
