using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D0 RID: 464
	[Serializable]
	public sealed class MonoEvent : RuntimeEventInfo
	{
		// Token: 0x06001DD4 RID: 7636 RVA: 0x000A7660 File Offset: 0x000A5860
		// Note: this type is marked as 'beforefieldinit'.
		static MonoEvent()
		{
			Il2CppClassPointerStore<MonoEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MonoEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr);
			MonoEvent.NativeFieldInfoPtr_klass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, "klass");
			MonoEvent.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, "handle");
			MonoEvent.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668227);
			MonoEvent.NativeMethodInfoPtr_GetRaiseMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668228);
			MonoEvent.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668229);
			MonoEvent.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668230);
			MonoEvent.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668231);
			MonoEvent.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668232);
			MonoEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668233);
			MonoEvent.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668234);
			MonoEvent.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668235);
			MonoEvent.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668236);
			MonoEvent.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668237);
			MonoEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr, 100668238);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x000A77A8 File Offset: 0x000A59A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318445, XrefRangeEnd = 318447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetAddMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x000A77F4 File Offset: 0x000A59F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318447, XrefRangeEnd = 318449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetRaiseMethod_Public_Virtual_MethodInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x000A7840 File Offset: 0x000A5A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318449, XrefRangeEnd = 318451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nonPublic;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x000A788C File Offset: 0x000A5A8C
		public unsafe override Type DeclaringType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318451, XrefRangeEnd = 318452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000A78CC File Offset: 0x000A5ACC
		public unsafe override Type ReflectedType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318452, XrefRangeEnd = 318453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x000A790C File Offset: 0x000A5B0C
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318453, XrefRangeEnd = 318454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000A7944 File Offset: 0x000A5B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318454, XrefRangeEnd = 318457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000A797C File Offset: 0x000A5B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318457, XrefRangeEnd = 318461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000A79D8 File Offset: 0x000A5BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318461, XrefRangeEnd = 318465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000A7A24 File Offset: 0x000A5C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318465, XrefRangeEnd = 318469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000A7A84 File Offset: 0x000A5C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318469, XrefRangeEnd = 318470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IList<CustomAttributeData> GetCustomAttributesData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318470, XrefRangeEnd = 318471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0000A510 File Offset: 0x00008710
		public MonoEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000A7B00 File Offset: 0x000A5D00
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x0000A519 File Offset: 0x00008719
		public unsafe IntPtr klass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEvent.NativeFieldInfoPtr_klass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEvent.NativeFieldInfoPtr_klass)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000A7B28 File Offset: 0x000A5D28
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x0000A534 File Offset: 0x00008734
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEvent.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoEvent.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeFieldInfoPtr_klass;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeMethodInfoPtr_GetAddMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeMethodInfoPtr_GetRaiseMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_GetRemoveMethod_Public_Virtual_MethodInfo_Boolean_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaringType_Public_Virtual_get_Type_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_get_ReflectedType_Public_Virtual_get_Type_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Public_Virtual_IList_1_CustomAttributeData_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
