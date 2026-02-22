using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x02000108 RID: 264
	public class FtpRequestCreator : Object
	{
		// Token: 0x06000F8E RID: 3982 RVA: 0x0004AFF0 File Offset: 0x000491F0
		// Note: this type is marked as 'beforefieldinit'.
		static FtpRequestCreator()
		{
			Il2CppClassPointerStore<FtpRequestCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpRequestCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpRequestCreator>.NativeClassPtr);
			FtpRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpRequestCreator>.NativeClassPtr, 100665476);
			FtpRequestCreator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpRequestCreator>.NativeClassPtr, 100665477);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0004B048 File Offset: 0x00049248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50494, XrefRangeEnd = 50514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0004B098 File Offset: 0x00049298
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FtpRequestCreator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpRequestCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FtpRequestCreator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000081FA File Offset: 0x000063FA
		public FtpRequestCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C29 RID: 3113
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;

		// Token: 0x04000C2A RID: 3114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
