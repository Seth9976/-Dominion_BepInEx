using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BF RID: 959
	public class IContributeServerContextSink : Il2CppObjectBase
	{
		// Token: 0x06003DEB RID: 15851 RVA: 0x00017536 File Offset: 0x00015736
		// Note: this type is marked as 'beforefieldinit'.
		static IContributeServerContextSink()
		{
			Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContributeServerContextSink");
			IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContributeServerContextSink>.NativeClassPtr, 100672405);
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00121EC0 File Offset: 0x001200C0
		[CallerCount(0)]
		public unsafe virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nextSink);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContributeServerContextSink.NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00017565 File Offset: 0x00015765
		public IContributeServerContextSink(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003328 RID: 13096
		private static readonly IntPtr NativeMethodInfoPtr_GetServerContextSink_Public_Abstract_Virtual_New_IMessageSink_IMessageSink_0;
	}
}
