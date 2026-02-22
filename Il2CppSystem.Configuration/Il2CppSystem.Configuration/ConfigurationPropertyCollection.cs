using System;
using System.Reflection;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Configuration
{
	// Token: 0x02000006 RID: 6
	[DefaultMember("Item")]
	public class ConfigurationPropertyCollection : Object
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002090 File Offset: 0x00000290
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationPropertyCollection()
		{
			Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Configuration.dll", "System.Configuration", "ConfigurationPropertyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationPropertyCollection>.NativeClassPtr);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020B5 File Offset: 0x000002B5
		public ConfigurationPropertyCollection(IntPtr pointer)
			: base(pointer)
		{
		}
	}
}
