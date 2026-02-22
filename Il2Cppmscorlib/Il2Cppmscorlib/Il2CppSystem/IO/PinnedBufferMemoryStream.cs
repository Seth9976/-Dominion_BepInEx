using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.IO
{
	// Token: 0x02000209 RID: 521
	public sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream
	{
		// Token: 0x0600215C RID: 8540 RVA: 0x000B8104 File Offset: 0x000B6304
		// Note: this type is marked as 'beforefieldinit'.
		static PinnedBufferMemoryStream()
		{
			Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PinnedBufferMemoryStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr);
			PinnedBufferMemoryStream.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_array");
			PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, "_pinningHandle");
			PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668816);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668817);
			PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr, 100668818);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000B8198 File Offset: 0x000B6398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321150, XrefRangeEnd = 321157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PinnedBufferMemoryStream(Il2CppStructArray<byte> array)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinnedBufferMemoryStream>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x000B81E4 File Offset: 0x000B63E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x000B8218 File Offset: 0x000B6418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321157, XrefRangeEnd = 321159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PinnedBufferMemoryStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0000B4DF File Offset: 0x000096DF
		public PinnedBufferMemoryStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000B8258 File Offset: 0x000B6458
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x0000B4E8 File Offset: 0x000096E8
		public unsafe Il2CppStructArray<byte> _array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000B8288 File Offset: 0x000B6488
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x0000B507 File Offset: 0x00009707
		public unsafe GCHandle _pinningHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PinnedBufferMemoryStream.NativeFieldInfoPtr__pinningHandle)) = value;
			}
		}

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeFieldInfoPtr__array;

		// Token: 0x04001DEF RID: 7663
		private static readonly IntPtr NativeFieldInfoPtr__pinningHandle;

		// Token: 0x04001DF0 RID: 7664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001DF1 RID: 7665
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001DF2 RID: 7666
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
