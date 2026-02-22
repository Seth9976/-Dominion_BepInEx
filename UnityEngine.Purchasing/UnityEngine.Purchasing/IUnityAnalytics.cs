using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000B RID: 11
	public class IUnityAnalytics : Il2CppObjectBase
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000037C4 File Offset: 0x000019C4
		// Note: this type is marked as 'beforefieldinit'.
		static IUnityAnalytics()
		{
			Il2CppClassPointerStore<IUnityAnalytics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "IUnityAnalytics");
			IUnityAnalytics.NativeMethodInfoPtr_Transaction_Public_Abstract_Virtual_New_Void_String_Decimal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnityAnalytics>.NativeClassPtr, 100663323);
			IUnityAnalytics.NativeMethodInfoPtr_CustomEvent_Public_Abstract_Virtual_New_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnityAnalytics>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003814 File Offset: 0x00001A14
		[CallerCount(0)]
		public unsafe virtual void Transaction(string productId, Decimal price, string currency, string receipt, string signature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnityAnalytics.NativeMethodInfoPtr_Transaction_Public_Abstract_Virtual_New_Void_String_Decimal_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000038A8 File Offset: 0x00001AA8
		[CallerCount(0)]
		public unsafe virtual void CustomEvent(string name, Dictionary<string, Object> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUnityAnalytics.NativeMethodInfoPtr_CustomEvent_Public_Abstract_Virtual_New_Void_String_Dictionary_2_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002196 File Offset: 0x00000396
		public IUnityAnalytics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Transaction_Public_Abstract_Virtual_New_Void_String_Decimal_String_String_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_CustomEvent_Public_Abstract_Virtual_New_Void_String_Dictionary_2_String_Object_0;
	}
}
