using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SA.Common.Util
{
	// Token: 0x02000313 RID: 787
	public static class Loader : global::Il2CppSystem.Object
	{
		// Token: 0x06002D5F RID: 11615 RVA: 0x000C1894 File Offset: 0x000BFA94
		// Note: this type is marked as 'beforefieldinit'.
		static Loader()
		{
			Il2CppClassPointerStore<Loader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Util", "Loader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader>.NativeClassPtr);
			Loader.NativeMethodInfoPtr_LoadWebTexture_Public_Static_Void_String_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100669222);
			Loader.NativeMethodInfoPtr_LoadPrefab_Public_Static_Void_String_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100669223);
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000C18EC File Offset: 0x000BFAEC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 212418, RefRangeEnd = 212433, XrefRangeStart = 212411, XrefRangeEnd = 212418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadWebTexture(string url, Action<Texture2D> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadWebTexture_Public_Static_Void_String_Action_1_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000C1934 File Offset: 0x000BFB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212433, XrefRangeEnd = 212437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadPrefab(string localPath, Action<GameObject> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_LoadPrefab_Public_Static_Void_String_Action_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x0001198A File Offset: 0x0000FB8A
		public Loader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_LoadWebTexture_Public_Static_Void_String_Action_1_Texture2D_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_LoadPrefab_Public_Static_Void_String_Action_1_GameObject_0;
	}
}
