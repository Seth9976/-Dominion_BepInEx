using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001DC RID: 476
	[Serializable]
	public class MonoParameterInfo : RuntimeParameterInfo
	{
		// Token: 0x06001EA1 RID: 7841 RVA: 0x000AB3B8 File Offset: 0x000A95B8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoParameterInfo()
		{
			Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoParameterInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr);
			MonoParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr, 100668370);
			MonoParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr, 100668371);
			MonoParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr, 100668372);
			MonoParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr, 100668373);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000AB438 File Offset: 0x000A9638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318877, RefRangeEnd = 318878, XrefRangeStart = 318876, XrefRangeEnd = 318877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoParameterInfo(ParameterInfo pinfo, MemberInfo member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoParameterInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoParameterInfo.NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x000AB498 File Offset: 0x000A9698
		public unsafe override Object DefaultValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318878, XrefRangeEnd = 318907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoParameterInfo.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000AB4E4 File Offset: 0x000A96E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318907, XrefRangeEnd = 318911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoParameterInfo.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000AB550 File Offset: 0x000A9750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318911, XrefRangeEnd = 318915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoParameterInfo.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0000A814 File Offset: 0x00008A14
		public MonoParameterInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001BDB RID: 7131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParameterInfo_MemberInfo_0;

		// Token: 0x04001BDC RID: 7132
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_get_Object_0;

		// Token: 0x04001BDD RID: 7133
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001BDE RID: 7134
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;
	}
}
