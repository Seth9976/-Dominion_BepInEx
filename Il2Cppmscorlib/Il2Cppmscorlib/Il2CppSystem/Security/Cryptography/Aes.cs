using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002D4 RID: 724
	public class Aes : SymmetricAlgorithm
	{
		// Token: 0x0600302C RID: 12332 RVA: 0x000F1098 File Offset: 0x000EF298
		// Note: this type is marked as 'beforefieldinit'.
		static Aes()
		{
			Il2CppClassPointerStore<Aes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Aes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Aes>.NativeClassPtr);
			Aes.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalBlockSizes");
			Aes.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Aes>.NativeClassPtr, "s_legalKeySizes");
			Aes.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Aes>.NativeClassPtr, 100670893);
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x000F1104 File Offset: 0x000EF304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 338830, RefRangeEnd = 338832, XrefRangeStart = 338824, XrefRangeEnd = 338830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Aes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Aes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Aes.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00010FFB File Offset: 0x0000F1FB
		public Aes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000F1140 File Offset: 0x000EF340
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x00011004 File Offset: 0x0000F204
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x000F1168 File Offset: 0x000EF368
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00011016 File Offset: 0x0000F216
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Aes.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002980 RID: 10624
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x04002981 RID: 10625
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x04002982 RID: 10626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
