using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x0200000E RID: 14
	public class CFNumber : CFObject
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00012FB0 File Offset: 0x000111B0
		// Note: this type is marked as 'beforefieldinit'.
		static CFNumber()
		{
			Il2CppClassPointerStore<CFNumber>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFNumber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFNumber>.NativeClassPtr);
			CFNumber.NativeMethodInfoPtr_CFNumberGetValue_Private_Static_Boolean_IntPtr_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNumber>.NativeClassPtr, 100663450);
			CFNumber.NativeMethodInfoPtr_AsInt32_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFNumber>.NativeClassPtr, 100663451);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00013008 File Offset: 0x00011208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32412, XrefRangeEnd = 32414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CFNumberGetValue(IntPtr handle, IntPtr type, out int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNumber.NativeMethodInfoPtr_CFNumberGetValue_Private_Static_Boolean_IntPtr_IntPtr_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00013064 File Offset: 0x00011264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32414, XrefRangeEnd = 32419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AsInt32(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFNumber.NativeMethodInfoPtr_AsInt32_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000023B8 File Offset: 0x000005B8
		public CFNumber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CFNumberGetValue_Private_Static_Boolean_IntPtr_IntPtr_byref_Int32_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_AsInt32_Public_Static_Int32_IntPtr_0;
	}
}
