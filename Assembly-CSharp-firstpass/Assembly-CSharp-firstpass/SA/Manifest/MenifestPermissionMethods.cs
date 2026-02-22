using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Manifest
{
	// Token: 0x02000325 RID: 805
	public static class MenifestPermissionMethods : Object
	{
		// Token: 0x06002F63 RID: 12131 RVA: 0x000CA7F0 File Offset: 0x000C89F0
		// Note: this type is marked as 'beforefieldinit'.
		static MenifestPermissionMethods()
		{
			Il2CppClassPointerStore<MenifestPermissionMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Manifest", "MenifestPermissionMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MenifestPermissionMethods>.NativeClassPtr);
			MenifestPermissionMethods.NativeMethodInfoPtr_GetFullName_Public_Static_String_ManifestPermission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenifestPermissionMethods>.NativeClassPtr, 100669575);
			MenifestPermissionMethods.NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_ManifestPermission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MenifestPermissionMethods>.NativeClassPtr, 100669576);
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x000CA848 File Offset: 0x000C8A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220381, XrefRangeEnd = 220396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFullName(this ManifestPermission permission)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref permission;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenifestPermissionMethods.NativeMethodInfoPtr_GetFullName_Public_Static_String_ManifestPermission_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002F65 RID: 12133 RVA: 0x000CA880 File Offset: 0x000C8A80
		[CallerCount(0)]
		public unsafe static bool IsNormalPermission(this ManifestPermission permission)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref permission;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MenifestPermissionMethods.NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_ManifestPermission_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00012182 File Offset: 0x00010382
		public MenifestPermissionMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002D58 RID: 11608
		private static readonly IntPtr NativeMethodInfoPtr_GetFullName_Public_Static_String_ManifestPermission_0;

		// Token: 0x04002D59 RID: 11609
		private static readonly IntPtr NativeMethodInfoPtr_IsNormalPermission_Public_Static_Boolean_ManifestPermission_0;
	}
}
