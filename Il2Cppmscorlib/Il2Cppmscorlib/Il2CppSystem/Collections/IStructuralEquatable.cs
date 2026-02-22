using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000480 RID: 1152
	public class IStructuralEquatable : Il2CppObjectBase
	{
		// Token: 0x060044BD RID: 17597 RVA: 0x0013A1B8 File Offset: 0x001383B8
		// Note: this type is marked as 'beforefieldinit'.
		static IStructuralEquatable()
		{
			Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IStructuralEquatable");
			IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100673311);
			IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IStructuralEquatable>.NativeClassPtr, 100673312);
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x0013A208 File Offset: 0x00138408
		[CallerCount(0)]
		public unsafe virtual bool Equals(Object other, IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060044BF RID: 17599 RVA: 0x0013A274 File Offset: 0x00138474
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(IEqualityComparer comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IStructuralEquatable.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044C0 RID: 17600 RVA: 0x0001A55D File Offset: 0x0001875D
		public IStructuralEquatable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_Object_IEqualityComparer_0;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_IEqualityComparer_0;
	}
}
