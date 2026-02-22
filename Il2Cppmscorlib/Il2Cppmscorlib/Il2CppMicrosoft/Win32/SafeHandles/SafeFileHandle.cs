using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004A RID: 74
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004C6 RID: 1222 RVA: 0x00035338 File Offset: 0x00033538
		// Note: this type is marked as 'beforefieldinit'.
		static SafeFileHandle()
		{
			Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeFileHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr);
			SafeFileHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr, 100663990);
			SafeFileHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr, 100663991);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00035390 File Offset: 0x00033590
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265969, RefRangeEnd = 265975, XrefRangeStart = 265968, XrefRangeEnd = 265969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFileHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000353E8 File Offset: 0x000335E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265975, XrefRangeEnd = 265979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFileHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003D9C File Offset: 0x00001F9C
		public SafeFileHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
