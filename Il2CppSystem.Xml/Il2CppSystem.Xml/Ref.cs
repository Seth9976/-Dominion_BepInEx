using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000049 RID: 73
	public static class Ref : Object
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x0000406B File Offset: 0x0000226B
		// Note: this type is marked as 'beforefieldinit'.
		static Ref()
		{
			Il2CppClassPointerStore<Ref>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Ref");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ref>.NativeClassPtr);
			Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ref>.NativeClassPtr, 100664296);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00022E2C File Offset: 0x0002102C
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 16551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ref.NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000040A4 File Offset: 0x000022A4
		public Ref(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_Equal_Public_Static_Boolean_String_String_0;
	}
}
