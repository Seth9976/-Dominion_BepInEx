using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008D RID: 141
	public class PlayerPrefsException : Exception
	{
		// Token: 0x06000F0A RID: 3850 RVA: 0x00009962 File Offset: 0x00007B62
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefsException()
		{
			Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr);
			PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr, 100664241);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0003EF78 File Offset: 0x0003D178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67572, XrefRangeEnd = 67576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPrefsException(string error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0000999B File Offset: 0x00007B9B
		public PlayerPrefsException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
