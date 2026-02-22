using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001A3 RID: 419
	public class ICustomAttributeProvider : Il2CppObjectBase
	{
		// Token: 0x06001BAB RID: 7083 RVA: 0x0009E7E0 File Offset: 0x0009C9E0
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomAttributeProvider()
		{
			Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ICustomAttributeProvider");
			ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr, 100667920);
			ICustomAttributeProvider.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomAttributeProvider>.NativeClassPtr, 100667921);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0009E830 File Offset: 0x0009CA30
		[CallerCount(0)]
		public unsafe virtual Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomAttributeProvider.NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0009E89C File Offset: 0x0009CA9C
		[CallerCount(0)]
		public unsafe virtual bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomAttributeProvider.NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000098D4 File Offset: 0x00007AD4
		public ICustomAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Abstract_Virtual_New_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Abstract_Virtual_New_Boolean_Type_Boolean_0;
	}
}
