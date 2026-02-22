using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000134 RID: 308
	[StructLayout(2)]
	public struct NotificationData
	{
		// Token: 0x060021DB RID: 8667 RVA: 0x00080204 File Offset: 0x0007E404
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationData()
		{
			Il2CppClassPointerStore<NotificationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "NotificationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationData>.NativeClassPtr);
			NotificationData.NativeFieldInfoPtr_available = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationData>.NativeClassPtr, "available");
			NotificationData.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationData>.NativeClassPtr, "enabled");
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x00015274 File Offset: 0x00013474
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NotificationData>.NativeClassPtr, ref this));
		}

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeFieldInfoPtr_available;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x040016AD RID: 5805
		[FieldOffset(0)]
		public int available;

		// Token: 0x040016AE RID: 5806
		[FieldOffset(4)]
		public int enabled;
	}
}
