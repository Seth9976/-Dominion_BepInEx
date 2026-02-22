using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem
{
	// Token: 0x020000B8 RID: 184
	public class IComparable : Il2CppObjectBase
	{
		// Token: 0x06000CEA RID: 3306 RVA: 0x000056A4 File Offset: 0x000038A4
		// Note: this type is marked as 'beforefieldinit'.
		static IComparable()
		{
			Il2CppClassPointerStore<IComparable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IComparable");
			IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IComparable>.NativeClassPtr, 100665457);
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0005C980 File Offset: 0x0005AB80
		[CallerCount(0)]
		public unsafe virtual int CompareTo(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IComparable.NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x000056D3 File Offset: 0x000038D3
		public IComparable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
