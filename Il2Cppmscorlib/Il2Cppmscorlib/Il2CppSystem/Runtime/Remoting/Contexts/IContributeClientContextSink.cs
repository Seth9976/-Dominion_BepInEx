using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BB RID: 955
	public class IContributeClientContextSink : Il2CppObjectBase
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x00017456 File Offset: 0x00015656
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeClientContextSink()
		{
			Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeClientContextSink");
			IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeClientContextSink>.NativeClassPtr, 100672401);
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00121D38 File Offset: 0x0011FF38
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeClientContextSink.NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00017485 File Offset: 0x00015685
		public IContributeClientContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeMethodInfoPtr_GetClientContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
