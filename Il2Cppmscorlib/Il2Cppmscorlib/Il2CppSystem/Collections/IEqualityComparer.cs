using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047C RID: 1148
	public class IEqualityComparer : Il2CppObjectBase
	{
		// Token: 0x060044A7 RID: 17575 RVA: 0x00139BB8 File Offset: 0x00137DB8
		// Note: this type is marked as 'beforefieldinit'.
		static IEqualityComparer()
		{
			Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEqualityComparer");
			IEqualityComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr, 100673297);
			IEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEqualityComparer>.NativeClassPtr, 100673298);
		}

		// Token: 0x060044A8 RID: 17576 RVA: 0x00139C08 File Offset: 0x00137E08
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEqualityComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00139C74 File Offset: 0x00137E74
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x0001A4DB File Offset: 0x000186DB
		public IEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_Object_0;
	}
}
