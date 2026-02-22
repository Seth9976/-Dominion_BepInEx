using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000AC RID: 172
	public static class ClassLibraryInitializer : Object
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x0000A050 File Offset: 0x00008250
		// Note: this type is marked as 'beforefieldinit'.
		static ClassLibraryInitializer()
		{
			Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ClassLibraryInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
			ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100664336);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00042008 File Offset: 0x00040208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68431, XrefRangeEnd = 68432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0000A089 File Offset: 0x00008289
		public ClassLibraryInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C2C RID: 3116
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;
	}
}
