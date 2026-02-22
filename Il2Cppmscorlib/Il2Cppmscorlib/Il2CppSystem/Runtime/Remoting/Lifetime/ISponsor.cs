using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003AE RID: 942
	public class ISponsor : Il2CppObjectBase
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x0001706E File Offset: 0x0001526E
		// Note: this type is marked as 'beforefieldinit'.
		static ISponsor()
		{
			Il2CppClassPointerStore<ISponsor>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "ISponsor");
			ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISponsor>.NativeClassPtr, 100672308);
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x0011F6D0 File Offset: 0x0011D8D0
		[CallerCount(0)]
		public unsafe virtual TimeSpan Renewal(ILease lease)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lease);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISponsor.NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x0001709D File Offset: 0x0001529D
		public ISponsor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeMethodInfoPtr_Renewal_Public_Abstract_Virtual_New_TimeSpan_ILease_0;
	}
}
