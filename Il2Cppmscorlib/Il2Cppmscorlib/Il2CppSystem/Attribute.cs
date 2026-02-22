using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class Attribute : Object
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00043108 File Offset: 0x00041308
		// Note: this type is marked as 'beforefieldinit'.
		static Attribute()
		{
			Il2CppClassPointerStore<Attribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Attribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attribute>.NativeClassPtr);
			Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664445);
			Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664446);
			Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664447);
			Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664448);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664449);
			Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664450);
			Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664451);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664452);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664453);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664454);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664455);
			Attribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664456);
			Attribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664457);
			Attribute.NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664458);
			Attribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100664459);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00043264 File Offset: 0x00041464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276320, XrefRangeEnd = 276326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000432C8 File Offset: 0x000414C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276326, XrefRangeEnd = 276332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0004332C File Offset: 0x0004152C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276332, XrefRangeEnd = 276336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00043390 File Offset: 0x00041590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276336, XrefRangeEnd = 276340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x000433F4 File Offset: 0x000415F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276365, RefRangeEnd = 276366, XrefRangeStart = 276340, XrefRangeEnd = 276365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00043458 File Offset: 0x00041658
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276367, RefRangeEnd = 276368, XrefRangeStart = 276366, XrefRangeEnd = 276367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000434AC File Offset: 0x000416AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276388, RefRangeEnd = 276389, XrefRangeStart = 276368, XrefRangeEnd = 276388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00043510 File Offset: 0x00041710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276390, RefRangeEnd = 276392, XrefRangeStart = 276389, XrefRangeEnd = 276390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00043574 File Offset: 0x00041774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276409, RefRangeEnd = 276411, XrefRangeStart = 276392, XrefRangeEnd = 276409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000435D8 File Offset: 0x000417D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276412, RefRangeEnd = 276413, XrefRangeStart = 276411, XrefRangeEnd = 276412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00043630 File Offset: 0x00041830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276413, XrefRangeEnd = 276414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00043694 File Offset: 0x00041894
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Attribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Attribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000436D0 File Offset: 0x000418D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276414, XrefRangeEnd = 276432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00043728 File Offset: 0x00041928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 276433, RefRangeEnd = 276434, XrefRangeStart = 276432, XrefRangeEnd = 276433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreFieldValuesEqual(Object thisValue, Object thatValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thatValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0004377C File Offset: 0x0004197C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 276446, RefRangeEnd = 276449, XrefRangeStart = 276434, XrefRangeEnd = 276446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x000045B1 File Offset: 0x000027B1
		public Attribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
