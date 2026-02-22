using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Principal
{
	// Token: 0x020002CC RID: 716
	public class IIdentity : Il2CppObjectBase
	{
		// Token: 0x06002FAD RID: 12205 RVA: 0x000EF3BC File Offset: 0x000ED5BC
		// Note: this type is marked as 'beforefieldinit'.
		static IIdentity()
		{
			Il2CppClassPointerStore<IIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "IIdentity");
			IIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIdentity>.NativeClassPtr, 100670829);
			IIdentity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IIdentity>.NativeClassPtr, 100670830);
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002FAE RID: 12206 RVA: 0x000EF40C File Offset: 0x000ED60C
		public unsafe virtual string AuthenticationType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIdentity.NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x000EF450 File Offset: 0x000ED650
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IIdentity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00010C0E File Offset: 0x0000EE0E
		public IIdentity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002921 RID: 10529
		private static readonly IntPtr NativeMethodInfoPtr_get_AuthenticationType_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04002922 RID: 10530
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;
	}
}
