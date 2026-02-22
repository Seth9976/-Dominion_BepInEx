using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000476 RID: 1142
	public class ICollection : Il2CppObjectBase
	{
		// Token: 0x0600448C RID: 17548 RVA: 0x00139560 File Offset: 0x00137760
		// Note: this type is marked as 'beforefieldinit'.
		static ICollection()
		{
			Il2CppClassPointerStore<ICollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "ICollection");
			ICollection.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100673282);
			ICollection.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection>.NativeClassPtr, 100673283);
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x001395B0 File Offset: 0x001377B0
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x0600448E RID: 17550 RVA: 0x0013960C File Offset: 0x0013780C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x0001A447 File Offset: 0x00018647
		public ICollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Array_Int32_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;
	}
}
