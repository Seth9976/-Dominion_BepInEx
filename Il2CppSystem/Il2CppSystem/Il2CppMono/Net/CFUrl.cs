using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Net
{
	// Token: 0x02000013 RID: 19
	public class CFUrl : CFObject
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00013754 File Offset: 0x00011954
		// Note: this type is marked as 'beforefieldinit'.
		static CFUrl()
		{
			Il2CppClassPointerStore<CFUrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net", "CFUrl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CFUrl>.NativeClassPtr);
			CFUrl.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663466);
			CFUrl.NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663467);
			CFUrl.NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CFUrl>.NativeClassPtr, 100663468);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000137C0 File Offset: 0x000119C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 32388, RefRangeEnd = 32390, XrefRangeStart = 32388, XrefRangeEnd = 32390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CFUrl(IntPtr handle, bool own)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CFUrl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref own;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00013818 File Offset: 0x00011A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32484, XrefRangeEnd = 32486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CFURLCreateWithString(IntPtr allocator, IntPtr str, IntPtr baseURL)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allocator;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref str;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseURL;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00013874 File Offset: 0x00011A74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 32500, RefRangeEnd = 32503, XrefRangeStart = 32486, XrefRangeEnd = 32500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CFUrl Create(string absolute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(absolute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CFUrl.NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CFUrl>(intPtr3) : null;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002432 File Offset: 0x00000632
		public CFUrl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_CFURLCreateWithString_Private_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CFUrl_String_0;
	}
}
