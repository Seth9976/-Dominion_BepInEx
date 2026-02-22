using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Permissions
{
	// Token: 0x020002C4 RID: 708
	[Serializable]
	public class SecurityAttribute : Attribute
	{
		// Token: 0x06002F47 RID: 12103 RVA: 0x00010819 File Offset: 0x0000EA19
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityAttribute()
		{
			Il2CppClassPointerStore<SecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Permissions", "SecurityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityAttribute>.NativeClassPtr);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0001083E File Offset: 0x0000EA3E
		public SecurityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
