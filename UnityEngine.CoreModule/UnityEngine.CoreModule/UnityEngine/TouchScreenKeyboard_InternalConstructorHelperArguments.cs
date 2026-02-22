using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000D8 RID: 216
	[StructLayout(2)]
	public struct TouchScreenKeyboard_InternalConstructorHelperArguments
	{
		// Token: 0x060012D4 RID: 4820 RVA: 0x00049258 File Offset: 0x00047458
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard_InternalConstructorHelperArguments()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard_InternalConstructorHelperArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "keyboardType");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "autocorrection");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "multiline");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "secure");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "alert");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "characterLimit");
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x0000B33D File Offset: 0x0000953D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, ref this));
		}

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeFieldInfoPtr_keyboardType;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeFieldInfoPtr_autocorrection;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeFieldInfoPtr_characterLimit;

		// Token: 0x04000DEF RID: 3567
		[FieldOffset(0)]
		public uint keyboardType;

		// Token: 0x04000DF0 RID: 3568
		[FieldOffset(4)]
		public uint autocorrection;

		// Token: 0x04000DF1 RID: 3569
		[FieldOffset(8)]
		public uint multiline;

		// Token: 0x04000DF2 RID: 3570
		[FieldOffset(12)]
		public uint secure;

		// Token: 0x04000DF3 RID: 3571
		[FieldOffset(16)]
		public uint alert;

		// Token: 0x04000DF4 RID: 3572
		[FieldOffset(20)]
		public int characterLimit;
	}
}
