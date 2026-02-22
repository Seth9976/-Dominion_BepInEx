using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000237 RID: 567
	[StructLayout(2)]
	public struct IPCountry_t
	{
		// Token: 0x0600257D RID: 9597 RVA: 0x0000ED2D File Offset: 0x0000CF2D
		// Note: this type is marked as 'beforefieldinit'.
		static IPCountry_t()
		{
			Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "IPCountry_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr);
			IPCountry_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x0000ED66 File Offset: 0x0000CF66
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IPCountry_t>.NativeClassPtr, ref this));
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600257F RID: 9599 RVA: 0x000A9148 File Offset: 0x000A7348
		// (set) Token: 0x06002580 RID: 9600 RVA: 0x0000ED78 File Offset: 0x0000CF78
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(IPCountry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IPCountry_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001EFE RID: 7934
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
