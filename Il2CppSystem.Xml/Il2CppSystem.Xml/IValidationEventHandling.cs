using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000019 RID: 25
	public class IValidationEventHandling : Il2CppObjectBase
	{
		// Token: 0x060000ED RID: 237 RVA: 0x000024C5 File Offset: 0x000006C5
		// Note: this type is marked as 'beforefieldinit'.
		static IValidationEventHandling()
		{
			Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IValidationEventHandling");
			IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IValidationEventHandling>.NativeClassPtr, 100663423);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000C538 File Offset: 0x0000A738
		[CallerCount(0)]
		public unsafe virtual void SendEvent(Exception exception, XmlSeverityType severity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IValidationEventHandling.NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000024F4 File Offset: 0x000006F4
		public IValidationEventHandling(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_SendEvent_Public_Abstract_Virtual_New_Void_Exception_XmlSeverityType_0;
	}
}
