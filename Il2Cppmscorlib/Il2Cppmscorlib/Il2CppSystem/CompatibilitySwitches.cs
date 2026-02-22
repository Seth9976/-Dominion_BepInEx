using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000105 RID: 261
	public static class CompatibilitySwitches : Object
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x0007B994 File Offset: 0x00079B94
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibilitySwitches()
		{
			Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CompatibilitySwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr);
			CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanSilverlight4");
			CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanWindowsPhone8");
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00006B42 File Offset: 0x00004D42
		public CompatibilitySwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0007B9EC File Offset: 0x00079BEC
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00006B4B File Offset: 0x00004D4B
		public unsafe static bool IsAppEarlierThanSilverlight4
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanSilverlight4, (void*)(&value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0007BA08 File Offset: 0x00079C08
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00006B59 File Offset: 0x00004D59
		public unsafe static bool IsAppEarlierThanWindowsPhone8
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&value));
			}
		}

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeFieldInfoPtr_IsAppEarlierThanSilverlight4;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8;
	}
}
