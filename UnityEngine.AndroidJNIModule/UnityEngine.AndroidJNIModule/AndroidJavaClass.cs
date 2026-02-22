using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	public class AndroidJavaClass : AndroidJavaObject
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00004770 File Offset: 0x00002970
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaClass()
		{
			Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr);
			AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663337);
			AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr, 100663338);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000047C8 File Offset: 0x000029C8
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 128340, RefRangeEnd = 128371, XrefRangeStart = 128318, XrefRangeEnd = 128340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaClass(string className)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaClass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004814 File Offset: 0x00002A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128371, XrefRangeEnd = 128389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaClass(string className)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaClass.NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000022B4 File Offset: 0x000004B4
		public AndroidJavaClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaClass_Private_Void_String_0;
	}
}
