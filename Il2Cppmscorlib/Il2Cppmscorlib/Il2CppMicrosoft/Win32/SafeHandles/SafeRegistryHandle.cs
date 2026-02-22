using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004C RID: 76
	public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00035460 File Offset: 0x00033660
		// Note: this type is marked as 'beforefieldinit'.
		static SafeRegistryHandle()
		{
			Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeRegistryHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr);
			SafeRegistryHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr, 100663994);
			SafeRegistryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr, 100663995);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000354B8 File Offset: 0x000336B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265969, RefRangeEnd = 265975, XrefRangeStart = 265969, XrefRangeEnd = 265975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeRegistryHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00035510 File Offset: 0x00033710
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeRegistryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00003DE7 File Offset: 0x00001FE7
		public SafeRegistryHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
