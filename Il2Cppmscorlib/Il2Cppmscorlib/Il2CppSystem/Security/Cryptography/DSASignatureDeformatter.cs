using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E5 RID: 741
	public class DSASignatureDeformatter : AsymmetricSignatureDeformatter
	{
		// Token: 0x060030D1 RID: 12497 RVA: 0x000F3598 File Offset: 0x000F1798
		// Note: this type is marked as 'beforefieldinit'.
		static DSASignatureDeformatter()
		{
			Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSASignatureDeformatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr);
			DSASignatureDeformatter.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, "_oid");
			DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr, 100670973);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000F35F0 File Offset: 0x000F17F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339461, XrefRangeEnd = 339468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSASignatureDeformatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSASignatureDeformatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSASignatureDeformatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0001149E File Offset: 0x0000F69E
		public DSASignatureDeformatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x000F362C File Offset: 0x000F182C
		// (set) Token: 0x060030D5 RID: 12501 RVA: 0x000114A7 File Offset: 0x0000F6A7
		public unsafe string _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSASignatureDeformatter.NativeFieldInfoPtr__oid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
