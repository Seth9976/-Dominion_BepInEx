using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net
{
	// Token: 0x0200000F RID: 15
	[StructLayout(2)]
	public struct CFRange
	{
		// Token: 0x0600009E RID: 158 RVA: 0x000130A4 File Offset: 0x000112A4
		// Note: this type is marked as 'beforefieldinit'.
		static CFRange()
		{
			Il2CppClassPointerStore<CFRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFRange>.NativeClassPtr);
			CFRange.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFRange>.NativeClassPtr, "Location");
			CFRange.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CFRange>.NativeClassPtr, "Length");
			CFRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFRange>.NativeClassPtr, 100663452);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00013110 File Offset: 0x00011310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32419, XrefRangeEnd = 32421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFRange(int loc, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loc;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000023C1 File Offset: 0x000005C1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CFRange>.NativeClassPtr, ref this));
		}

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_Length;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x0400006D RID: 109
		[FieldOffset(0)]
		public IntPtr Location;

		// Token: 0x0400006E RID: 110
		[FieldOffset(8)]
		public IntPtr Length;
	}
}
