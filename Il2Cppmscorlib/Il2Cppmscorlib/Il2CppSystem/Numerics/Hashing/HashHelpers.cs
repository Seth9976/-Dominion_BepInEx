using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Numerics.Hashing
{
	// Token: 0x02000254 RID: 596
	public static class HashHelpers : Object
	{
		// Token: 0x0600296E RID: 10606 RVA: 0x000D7580 File Offset: 0x000D5780
		// Note: this type is marked as 'beforefieldinit'.
		static HashHelpers()
		{
			Il2CppClassPointerStore<HashHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Numerics.Hashing", "HashHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr);
			HashHelpers.NativeFieldInfoPtr_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, "RandomSeed");
			HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashHelpers>.NativeClassPtr, 100669913);
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x000D75D8 File Offset: 0x000D57D8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 330033, RefRangeEnd = 330047, XrefRangeStart = 330033, XrefRangeEnd = 330033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashHelpers.NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0000E6CE File Offset: 0x0000C8CE
		public HashHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002971 RID: 10609 RVA: 0x000D7624 File Offset: 0x000D5824
		// (set) Token: 0x06002972 RID: 10610 RVA: 0x0000E6D7 File Offset: 0x0000C8D7
		public unsafe static int RandomSeed
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashHelpers.NativeFieldInfoPtr_RandomSeed, (void*)(&value));
			}
		}

		// Token: 0x04002484 RID: 9348
		private static readonly IntPtr NativeFieldInfoPtr_RandomSeed;

		// Token: 0x04002485 RID: 9349
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_Int32_Int32_0;
	}
}
