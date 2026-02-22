using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000068 RID: 104
	public static class Res : Object
	{
		// Token: 0x06000837 RID: 2103 RVA: 0x0002C990 File Offset: 0x0002AB90
		// Note: this type is marked as 'beforefieldinit'.
		static Res()
		{
			Il2CppClassPointerStore<Res>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Res");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Res>.NativeClassPtr);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100664645);
			Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Res>.NativeClassPtr, 100664646);
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0002CA24 File Offset: 0x0002AC24
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 21207, RefRangeEnd = 21220, XrefRangeStart = 21202, XrefRangeEnd = 21207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Res.NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000049E6 File Offset: 0x00002BE6
		public static string GetString(string name, params Object[] args)
		{
			return Res.GetString(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000049F4 File Offset: 0x00002BF4
		public Res(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
	}
}
