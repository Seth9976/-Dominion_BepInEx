using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000056 RID: 86
	public class ITupleInternal : Il2CppObjectBase
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x00003EF6 File Offset: 0x000020F6
		// Note: this type is marked as 'beforefieldinit'.
		static ITupleInternal()
		{
			Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ITupleInternal");
			ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITupleInternal>.NativeClassPtr, 100664260);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0003C878 File Offset: 0x0003AA78
		[CallerCount(0)]
		public unsafe virtual string ToString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITupleInternal.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00003F25 File Offset: 0x00002125
		public ITupleInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_StringBuilder_0;
	}
}
