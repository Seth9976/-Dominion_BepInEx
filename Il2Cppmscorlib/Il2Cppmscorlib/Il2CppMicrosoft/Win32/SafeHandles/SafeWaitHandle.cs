using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004D RID: 77
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x0003554C File Offset: 0x0003374C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeWaitHandle()
		{
			Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr);
			SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100663996);
			SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100663997);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000355A4 File Offset: 0x000337A4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 265969, RefRangeEnd = 265975, XrefRangeStart = 265969, XrefRangeEnd = 265975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref existingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000355FC File Offset: 0x000337FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265986, XrefRangeEnd = 265987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public SafeWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
