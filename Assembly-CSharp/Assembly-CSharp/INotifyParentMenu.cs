using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

// Token: 0x020000A4 RID: 164
public class INotifyParentMenu : Il2CppObjectBase
{
	// Token: 0x06001323 RID: 4899 RVA: 0x0000CA2E File Offset: 0x0000AC2E
	// Note: this type is marked as 'beforefieldinit'.
	static INotifyParentMenu()
	{
		Il2CppClassPointerStore<INotifyParentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "INotifyParentMenu");
		INotifyParentMenu.NativeMethodInfoPtr_Notified_Public_Abstract_Virtual_New_Void_PopupNotificationType_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<INotifyParentMenu>.NativeClassPtr, 100664802);
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00053B50 File Offset: 0x00051D50
	[CallerCount(0)]
	public unsafe virtual void Notified(PopupNotificationType type, string popupName, Object data = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(popupName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), INotifyParentMenu.NativeMethodInfoPtr_Notified_Public_Abstract_Virtual_New_Void_PopupNotificationType_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x0000CA5D File Offset: 0x0000AC5D
	public INotifyParentMenu(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000D5D RID: 3421
	private static readonly IntPtr NativeMethodInfoPtr_Notified_Public_Abstract_Virtual_New_Void_PopupNotificationType_String_Object_0;
}
