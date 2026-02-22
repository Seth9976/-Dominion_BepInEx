using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008C RID: 140
	[DefaultMember("Item")]
	public class X509Certificate2Collection : X509CertificateCollection
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x00005608 File Offset: 0x00003808
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Collection()
		{
			Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Collection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr);
			X509Certificate2Collection.NativeFieldInfoPtr_newline_split = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2Collection>.NativeClassPtr, "newline_split");
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00005641 File Offset: 0x00003841
		public X509Certificate2Collection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0002F220 File Offset: 0x0002D420
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x0000564A File Offset: 0x0000384A
		public unsafe static Il2CppStringArray newline_split
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2Collection.NativeFieldInfoPtr_newline_split, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeFieldInfoPtr_newline_split;
	}
}
