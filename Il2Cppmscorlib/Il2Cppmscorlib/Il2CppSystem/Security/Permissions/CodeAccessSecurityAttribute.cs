using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Permissions
{
	// Token: 0x020002C3 RID: 707
	[Serializable]
	public class CodeAccessSecurityAttribute : SecurityAttribute
	{
		// Token: 0x06002F45 RID: 12101 RVA: 0x000107EB File Offset: 0x0000E9EB
		// Note: this type is marked as 'beforefieldinit'.
		static CodeAccessSecurityAttribute()
		{
			Il2CppClassPointerStore<CodeAccessSecurityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Permissions", "CodeAccessSecurityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodeAccessSecurityAttribute>.NativeClassPtr);
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00010810 File Offset: 0x0000EA10
		public CodeAccessSecurityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
