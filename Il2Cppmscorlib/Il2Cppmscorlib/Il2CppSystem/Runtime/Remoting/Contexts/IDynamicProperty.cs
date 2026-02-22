using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003C1 RID: 961
	public class IDynamicProperty : Il2CppObjectBase
	{
		// Token: 0x06003DF2 RID: 15858 RVA: 0x00017577 File Offset: 0x00015777
		// Note: this type is marked as 'beforefieldinit'.
		static IDynamicProperty()
		{
			Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IDynamicProperty");
			IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDynamicProperty>.NativeClassPtr, 100672408);
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06003DF3 RID: 15859 RVA: 0x00122044 File Offset: 0x00120244
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDynamicProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000175A6 File Offset: 0x000157A6
		public IDynamicProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400332B RID: 13099
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
