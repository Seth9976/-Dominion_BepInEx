using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000043 RID: 67
	public static class IOSelector : Object
	{
		// Token: 0x060003DB RID: 987 RVA: 0x0000355D File Offset: 0x0000175D
		// Note: this type is marked as 'beforefieldinit'.
		static IOSelector()
		{
			Il2CppClassPointerStore<IOSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "IOSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IOSelector>.NativeClassPtr);
			IOSelector.NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOSelector>.NativeClassPtr, 100663902);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000200AC File Offset: 0x0001E2AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37138, RefRangeEnd = 37139, XrefRangeStart = 37137, XrefRangeEnd = 37138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Add(IntPtr handle, IOSelectorJob job)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(job);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IOSelector.NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00003596 File Offset: 0x00001796
		public IOSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_Void_IntPtr_IOSelectorJob_0;
	}
}
