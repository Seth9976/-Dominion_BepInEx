using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x02000211 RID: 529
	public static class PathInternal : Object
	{
		// Token: 0x0600227B RID: 8827 RVA: 0x000BCEFC File Offset: 0x000BB0FC
		// Note: this type is marked as 'beforefieldinit'.
		static PathInternal()
		{
			Il2CppClassPointerStore<PathInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "PathInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathInternal>.NativeClassPtr);
			PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100669073);
			PathInternal.NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathInternal>.NativeClassPtr, 100669074);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000BCF54 File Offset: 0x000BB154
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPartiallyQualified(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000BCF98 File Offset: 0x000BB198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322421, XrefRangeEnd = 322426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasIllegalCharacters(string path, bool checkAdditional)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkAdditional;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathInternal.NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x0000BB48 File Offset: 0x00009D48
		public PathInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001EC1 RID: 7873
		private static readonly IntPtr NativeMethodInfoPtr_IsPartiallyQualified_Public_Static_Boolean_String_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly IntPtr NativeMethodInfoPtr_HasIllegalCharacters_Public_Static_Boolean_String_Boolean_0;
	}
}
