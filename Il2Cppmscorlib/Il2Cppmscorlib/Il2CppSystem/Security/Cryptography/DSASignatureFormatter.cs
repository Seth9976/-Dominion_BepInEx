using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E6 RID: 742
	public class DSASignatureFormatter : AsymmetricSignatureFormatter
	{
		// Token: 0x060030D6 RID: 12502 RVA: 0x000F3654 File Offset: 0x000F1854
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureFormatter()
		{
			Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr);
			DSASignatureFormatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, "_oid");
			DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr, 100670974);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000F36AC File Offset: 0x000F18AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339468, XrefRangeEnd = 339475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000114C6 File Offset: 0x0000F6C6
		public DSASignatureFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000F36E8 File Offset: 0x000F18E8
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x000114CF File Offset: 0x0000F6CF
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureFormatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
