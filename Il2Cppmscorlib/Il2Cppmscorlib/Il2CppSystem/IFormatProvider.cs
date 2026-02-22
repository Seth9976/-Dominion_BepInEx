using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000BE RID: 190
	public class IFormatProvider : Il2CppObjectBase
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x00005767 File Offset: 0x00003967
		// Note: this type is marked as 'beforefieldinit'.
		static IFormatProvider()
		{
			Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IFormatProvider");
			IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFormatProvider>.NativeClassPtr, 100665479);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0005D3F4 File Offset: 0x0005B5F4
		[CallerCount(0)]
		public unsafe virtual Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IFormatProvider.NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00005796 File Offset: 0x00003996
		public IFormatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Abstract_Virtual_New_Object_Type_0;
	}
}
