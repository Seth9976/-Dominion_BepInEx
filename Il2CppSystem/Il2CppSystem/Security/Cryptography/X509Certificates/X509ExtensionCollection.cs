using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200009B RID: 155
	[DefaultMember("Item")]
	public sealed class X509ExtensionCollection : Object
	{
		// Token: 0x06000938 RID: 2360 RVA: 0x00005C15 File Offset: 0x00003E15
		// Note: this type is marked as 'beforefieldinit'.
		static X509ExtensionCollection()
		{
			Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ExtensionCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr);
			X509ExtensionCollection.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ExtensionCollection>.NativeClassPtr, "Empty");
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00005C4E File Offset: 0x00003E4E
		public X509ExtensionCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x000322F0 File Offset: 0x000304F0
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00005C57 File Offset: 0x00003E57
		public unsafe static Il2CppStructArray<byte> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509ExtensionCollection.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509ExtensionCollection.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeFieldInfoPtr_Empty;
	}
}
