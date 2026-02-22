using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045B RID: 1115
	public class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06004381 RID: 17281 RVA: 0x001356B8 File Offset: 0x001338B8
		// Note: this type is marked as 'beforefieldinit'.
		static SafeBuffer()
		{
			Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "SafeBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr);
			SafeBuffer.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, "inited");
			SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100673075);
			SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeBuffer>.NativeClassPtr, 100673076);
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00135724 File Offset: 0x00133924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358877, RefRangeEnd = 358881, XrefRangeStart = 358875, XrefRangeEnd = 358877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquirePointer(ref byte* pointer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(pointer);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pointer = ((intPtr4 == 0) ? null : new byte*(intPtr4));
			}
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x0013577C File Offset: 0x0013397C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 358887, RefRangeEnd = 358891, XrefRangeStart = 358881, XrefRangeEnd = 358887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleasePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeBuffer.NativeMethodInfoPtr_ReleasePointer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00019DD1 File Offset: 0x00017FD1
		public SafeBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x001357B0 File Offset: 0x001339B0
		// (set) Token: 0x06004386 RID: 17286 RVA: 0x00019DDA File Offset: 0x00017FDA
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SafeBuffer.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeMethodInfoPtr_AcquirePointer_Public_Void_byref_ptr_Byte_0;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeMethodInfoPtr_ReleasePointer_Public_Void_0;
	}
}
