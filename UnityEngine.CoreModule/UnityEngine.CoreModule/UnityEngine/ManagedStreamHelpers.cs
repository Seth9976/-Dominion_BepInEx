using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine
{
	// Token: 0x020000B6 RID: 182
	public static class ManagedStreamHelpers : Object
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x00044148 File Offset: 0x00042348
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedStreamHelpers()
		{
			Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ManagedStreamHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr);
			ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100664409);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100664410);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100664411);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100664412);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x000441C8 File Offset: 0x000423C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72012, RefRangeEnd = 72015, XrefRangeStart = 72012, XrefRangeEnd = 72012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateLoadFromStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00044200 File Offset: 0x00042400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72015, XrefRangeEnd = 72019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamRead(Il2CppStructArray<byte> buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00044274 File Offset: 0x00042474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72019, XrefRangeEnd = 72023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x000442D4 File Offset: 0x000424D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72023, XrefRangeEnd = 72027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0000A430 File Offset: 0x00008630
		public ManagedStreamHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0;
	}
}
