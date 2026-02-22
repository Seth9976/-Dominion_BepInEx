using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FB RID: 251
	public static class Logging : Object
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x00007DAC File Offset: 0x00005FAC
		// Note: this type is marked as 'beforefieldinit'.
		static Logging()
		{
			Il2CppClassPointerStore<Logging>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Logging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logging>.NativeClassPtr);
			Logging.NativeFieldInfoPtr_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logging>.NativeClassPtr, "On");
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00007DE5 File Offset: 0x00005FE5
		public Logging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0004830C File Offset: 0x0004650C
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00007DEE File Offset: 0x00005FEE
		public unsafe static bool On
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Logging.NativeFieldInfoPtr_On, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Logging.NativeFieldInfoPtr_On, (void*)(&value));
			}
		}

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeFieldInfoPtr_On;
	}
}
