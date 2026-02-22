using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x0200013E RID: 318
	public class TypeIdentifier : Il2CppObjectBase
	{
		// Token: 0x060016A4 RID: 5796 RVA: 0x00007F73 File Offset: 0x00006173
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifier()
		{
			Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifier");
			TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifier>.NativeClassPtr, 100667095);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00087EFC File Offset: 0x000860FC
		public unsafe virtual string InternalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifier.NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00007FA2 File Offset: 0x000061A2
		public TypeIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Abstract_Virtual_New_get_String_0;
	}
}
