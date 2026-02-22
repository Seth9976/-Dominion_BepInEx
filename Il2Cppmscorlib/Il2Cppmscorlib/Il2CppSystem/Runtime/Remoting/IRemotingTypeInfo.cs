using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000390 RID: 912
	public class IRemotingTypeInfo : Il2CppObjectBase
	{
		// Token: 0x06003B3E RID: 15166 RVA: 0x00117E18 File Offset: 0x00116018
		// Note: this type is marked as 'beforefieldinit'.
		static IRemotingTypeInfo()
		{
			Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "IRemotingTypeInfo");
			IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100672057);
			IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRemotingTypeInfo>.NativeClassPtr, 100672058);
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06003B3F RID: 15167 RVA: 0x00117E68 File Offset: 0x00116068
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x00117EAC File Offset: 0x001160AC
		[CallerCount(0)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IRemotingTypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000164F8 File Offset: 0x000146F8
		public IRemotingTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Abstract_Virtual_New_Boolean_Type_Object_0;
	}
}
