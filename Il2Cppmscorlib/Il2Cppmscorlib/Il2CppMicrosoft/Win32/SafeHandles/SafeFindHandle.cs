using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004B RID: 75
	public sealed class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004CA RID: 1226 RVA: 0x00003DA5 File Offset: 0x00001FA5
		// Note: this type is marked as 'beforefieldinit'.
		static SafeFindHandle()
		{
			Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeFindHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr);
			SafeFindHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr, 100663993);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00035424 File Offset: 0x00033624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265979, XrefRangeEnd = 265986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFindHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00003DDE File Offset: 0x00001FDE
		public SafeFindHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
