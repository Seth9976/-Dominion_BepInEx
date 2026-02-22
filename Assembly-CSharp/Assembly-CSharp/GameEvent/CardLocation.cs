using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x02000143 RID: 323
	[StructLayout(2)]
	public struct CardLocation
	{
		// Token: 0x060021F7 RID: 8695 RVA: 0x00080968 File Offset: 0x0007EB68
		// Note: this type is marked as 'beforefieldinit'.
		static CardLocation()
		{
			Il2CppClassPointerStore<CardLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "CardLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardLocation>.NativeClassPtr);
			CardLocation.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardLocation>.NativeClassPtr, "id");
			CardLocation.NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardLocation>.NativeClassPtr, "location");
			CardLocation.NativeFieldInfoPtr_bDoNotAnimate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardLocation>.NativeClassPtr, "bDoNotAnimate");
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00015370 File Offset: 0x00013570
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CardLocation>.NativeClassPtr, ref this));
		}

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeFieldInfoPtr_location;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeFieldInfoPtr_bDoNotAnimate;

		// Token: 0x0400176D RID: 5997
		[FieldOffset(0)]
		public int id;

		// Token: 0x0400176E RID: 5998
		[FieldOffset(4)]
		public int location;

		// Token: 0x0400176F RID: 5999
		[FieldOffset(8)]
		public int bDoNotAnimate;
	}
}
