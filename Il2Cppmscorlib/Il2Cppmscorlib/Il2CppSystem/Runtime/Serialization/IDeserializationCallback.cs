using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032B RID: 811
	public class IDeserializationCallback : Il2CppObjectBase
	{
		// Token: 0x06003478 RID: 13432 RVA: 0x00012B04 File Offset: 0x00010D04
		// Note: this type is marked as 'beforefieldinit'.
		static IDeserializationCallback()
		{
			Il2CppClassPointerStore<IDeserializationCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IDeserializationCallback");
			IDeserializationCallback.NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeserializationCallback>.NativeClassPtr, 100671436);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00100D90 File Offset: 0x000FEF90
		[CallerCount(0)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDeserializationCallback.NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00012B33 File Offset: 0x00010D33
		public IDeserializationCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Abstract_Virtual_New_Void_Object_0;
	}
}
