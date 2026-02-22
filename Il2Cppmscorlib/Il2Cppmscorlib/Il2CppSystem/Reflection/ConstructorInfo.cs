using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class ConstructorInfo : MethodBase
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x000A3C84 File Offset: 0x000A1E84
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructorInfo()
		{
			Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ConstructorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr);
			ConstructorInfo.NativeFieldInfoPtr_ConstructorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, "ConstructorName");
			ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, "TypeConstructorName");
			ConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668107);
			ConstructorInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668108);
			ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668109);
			ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668110);
			ConstructorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668111);
			ConstructorInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668112);
			ConstructorInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668113);
			ConstructorInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr, 100668114);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x000A3D7C File Offset: 0x000A1F7C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructorInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x000A3DB8 File Offset: 0x000A1FB8
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000A3E00 File Offset: 0x000A2000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317913, RefRangeEnd = 317914, XrefRangeStart = 317909, XrefRangeEnd = 317913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Invoke(Il2CppReferenceArray<Object> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000A3E50 File Offset: 0x000A2050
		[CallerCount(0)]
		public unsafe virtual Object Invoke(BindingFlags invokeAttr, Binder binder, Il2CppReferenceArray<Object> parameters, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref invokeAttr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000A3EE0 File Offset: 0x000A20E0
		[CallerCount(0)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000A3F38 File Offset: 0x000A2138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317914, XrefRangeEnd = 317915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructorInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000A3F80 File Offset: 0x000A2180
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 317559, RefRangeEnd = 317601, XrefRangeStart = 317559, XrefRangeEnd = 317601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000A3FD4 File Offset: 0x000A21D4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 317601, RefRangeEnd = 317626, XrefRangeStart = 317601, XrefRangeEnd = 317626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00009F52 File Offset: 0x00008152
		public ConstructorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x000A4028 File Offset: 0x000A2228
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00009F5B File Offset: 0x0000815B
		public unsafe static string ConstructorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructorInfo.NativeFieldInfoPtr_ConstructorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructorInfo.NativeFieldInfoPtr_ConstructorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x000A4048 File Offset: 0x000A2248
		// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00009F6D File Offset: 0x0000816D
		public unsafe static string TypeConstructorName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructorInfo.NativeFieldInfoPtr_TypeConstructorName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_ConstructorName;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_TypeConstructorName;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Object_BindingFlags_Binder_Il2CppReferenceArray_1_Object_CultureInfo_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConstructorInfo_ConstructorInfo_0;
	}
}
