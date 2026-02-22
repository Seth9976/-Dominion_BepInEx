using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200013D RID: 317
	public class TypeName : Il2CppObjectBase
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x00007F3B File Offset: 0x0000613B
		// Note: this type is marked as 'beforefieldinit'.
		static TypeName()
		{
			Il2CppClassPointerStore<TypeName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeName");
			TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeName>.NativeClassPtr, 100667094);
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00087EB8 File Offset: 0x000860B8
		public unsafe virtual string DisplayName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeName.NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00007F6A File Offset: 0x0000616A
		public TypeName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Abstract_Virtual_New_get_String_0;
	}
}
