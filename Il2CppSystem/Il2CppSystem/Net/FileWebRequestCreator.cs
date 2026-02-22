using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F4 RID: 244
	public class FileWebRequestCreator : Object
	{
		// Token: 0x06000E77 RID: 3703 RVA: 0x000468C4 File Offset: 0x00044AC4
		// Note: this type is marked as 'beforefieldinit'.
		static FileWebRequestCreator()
		{
			Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FileWebRequestCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr);
			FileWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr, 100665316);
			FileWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr, 100665317);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0004691C File Offset: 0x00044B1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileWebRequestCreator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileWebRequestCreator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequestCreator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00046958 File Offset: 0x00044B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49115, XrefRangeEnd = 49133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WebRequest Create(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileWebRequestCreator.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00007B70 File Offset: 0x00005D70
		public FileWebRequestCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_WebRequest_Uri_0;
	}
}
