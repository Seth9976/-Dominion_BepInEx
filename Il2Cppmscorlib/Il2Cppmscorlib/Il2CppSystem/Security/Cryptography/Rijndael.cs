using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F7 RID: 759
	public class Rijndael : SymmetricAlgorithm
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x000F6118 File Offset: 0x000F4318
		// Note: this type is marked as 'beforefieldinit'.
		static Rijndael()
		{
			Il2CppClassPointerStore<Rijndael>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Rijndael");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rijndael>.NativeClassPtr);
			Rijndael.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalBlockSizes");
			Rijndael.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, "s_legalKeySizes");
			Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rijndael>.NativeClassPtr, 100671066);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000F6184 File Offset: 0x000F4384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340003, XrefRangeEnd = 340009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rijndael()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rijndael>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rijndael.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x00011887 File Offset: 0x0000FA87
		public Rijndael(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000F61C0 File Offset: 0x000F43C0
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x00011890 File Offset: 0x0000FA90
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000F61E8 File Offset: 0x000F43E8
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x000118A2 File Offset: 0x0000FAA2
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Rijndael.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
