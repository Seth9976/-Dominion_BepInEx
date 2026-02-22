using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032D RID: 813
	public class IObjectReference : Il2CppObjectBase
	{
		// Token: 0x06003483 RID: 13443 RVA: 0x00012B45 File Offset: 0x00010D45
		// Note: this type is marked as 'beforefieldinit'.
		static IObjectReference()
		{
			Il2CppClassPointerStore<IObjectReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "IObjectReference");
			IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectReference>.NativeClassPtr, 100671443);
		}

		// Token: 0x06003484 RID: 13444 RVA: 0x001010A4 File Offset: 0x000FF2A4
		[CallerCount(0)]
		public unsafe virtual Object GetRealObject(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IObjectReference.NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003485 RID: 13445 RVA: 0x00012B74 File Offset: 0x00010D74
		public IObjectReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeMethodInfoPtr_GetRealObject_Public_Abstract_Virtual_New_Object_StreamingContext_0;
	}
}
