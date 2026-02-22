using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000174 RID: 372
	[StructLayout(2)]
	public struct NewUrlLaunchParameters_t
	{
		// Token: 0x060020C1 RID: 8385 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		// Note: this type is marked as 'beforefieldinit'.
		static NewUrlLaunchParameters_t()
		{
			Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "NewUrlLaunchParameters_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr);
			NewUrlLaunchParameters_t.NativeFieldInfoPtr_k_iCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, "k_iCallback");
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0000BC2D File Offset: 0x00009E2D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewUrlLaunchParameters_t>.NativeClassPtr, ref this));
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0009F76C File Offset: 0x0009D96C
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public unsafe static int k_iCallback
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NewUrlLaunchParameters_t.NativeFieldInfoPtr_k_iCallback, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewUrlLaunchParameters_t.NativeFieldInfoPtr_k_iCallback, (void*)(&value));
			}
		}

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeFieldInfoPtr_k_iCallback;
	}
}
