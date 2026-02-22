using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x02000016 RID: 22
	public static class HashCodeHelper : Object
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00002B46 File Offset: 0x00000D46
		// Note: this type is marked as 'beforefieldinit'.
		static HashCodeHelper()
		{
			Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "HashCodeHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr);
			HashCodeHelper.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCodeHelper>.NativeClassPtr, 100663342);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000523C File Offset: 0x0000343C
		[CallerCount(0)]
		public unsafe static int Combine(int hash1, int hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCodeHelper.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002B7F File Offset: 0x00000D7F
		public HashCodeHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x040000E6 RID: 230
		public const int k_HashCodeMultiplier = 486187739;
	}
}
