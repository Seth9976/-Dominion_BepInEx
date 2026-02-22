using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000121 RID: 289
	public static class MonoCustomAttrs : Object
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x000800DC File Offset: 0x0007E2DC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoCustomAttrs()
		{
			Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoCustomAttrs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr);
			MonoCustomAttrs.NativeFieldInfoPtr_corlib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "corlib");
			MonoCustomAttrs.NativeFieldInfoPtr_usage_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "usage_cache");
			MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "DefaultAttributeUsage");
			MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666813);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666814);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666815);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666816);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666817);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666818);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666819);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666820);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666821);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666822);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666823);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666824);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666825);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666826);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666827);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100666828);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00080288 File Offset: 0x0007E488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305918, RefRangeEnd = 305920, XrefRangeStart = 305912, XrefRangeEnd = 305918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserCattrProvider(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000802CC File Offset: 0x0007E4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 305920, XrefRangeEnd = 305921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pseudoAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00080330 File Offset: 0x0007E530
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305955, RefRangeEnd = 305957, XrefRangeStart = 305921, XrefRangeEnd = 305955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00080388 File Offset: 0x0007E588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 305972, RefRangeEnd = 305973, XrefRangeStart = 305957, XrefRangeEnd = 305972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000803CC File Offset: 0x0007E5CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 305992, RefRangeEnd = 305994, XrefRangeStart = 305973, XrefRangeEnd = 305992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00080430 File Offset: 0x0007E630
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 306099, RefRangeEnd = 306114, XrefRangeStart = 305994, XrefRangeEnd = 306099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00080494 File Offset: 0x0007E694
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 306125, RefRangeEnd = 306130, XrefRangeStart = 306114, XrefRangeEnd = 306125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000804E8 File Offset: 0x0007E6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306130, XrefRangeEnd = 306131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CustomAttributeData> GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0008052C File Offset: 0x0007E72C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 306144, RefRangeEnd = 306149, XrefRangeStart = 306131, XrefRangeEnd = 306144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00080570 File Offset: 0x0007E770
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 306172, RefRangeEnd = 306183, XrefRangeStart = 306149, XrefRangeEnd = 306172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000805D4 File Offset: 0x0007E7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306183, XrefRangeEnd = 306184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(AttributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00080628 File Offset: 0x0007E828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306194, RefRangeEnd = 306195, XrefRangeStart = 306184, XrefRangeEnd = 306194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetBasePropertyDefinition(MonoProperty property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0008066C File Offset: 0x0007E86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306195, XrefRangeEnd = 306200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo GetBaseEventDefinition(MonoEvent evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x000806B0 File Offset: 0x0007E8B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 306218, RefRangeEnd = 306221, XrefRangeStart = 306200, XrefRangeEnd = 306218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomAttributeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000806F4 File Offset: 0x0007E8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306248, RefRangeEnd = 306249, XrefRangeStart = 306221, XrefRangeEnd = 306248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00080738 File Offset: 0x0007E938
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 306279, RefRangeEnd = 306283, XrefRangeStart = 306249, XrefRangeEnd = 306279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00007360 File Offset: 0x00005560
		public MonoCustomAttrs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0008077C File Offset: 0x0007E97C
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x00007369 File Offset: 0x00005569
		public unsafe static Assembly corlib
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000807A4 File Offset: 0x0007E9A4
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000737B File Offset: 0x0000557B
		public unsafe static Dictionary<Type, AttributeUsageAttribute> usage_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, AttributeUsageAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x000807CC File Offset: 0x0007E9CC
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000738D File Offset: 0x0000558D
		public unsafe static AttributeUsageAttribute DefaultAttributeUsage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeFieldInfoPtr_corlib;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeFieldInfoPtr_usage_cache;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAttributeUsage;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_MonoProperty_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_MonoEvent_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x020005AB RID: 1451
		public class AttributeInfo : Object
		{
			// Token: 0x06004FC3 RID: 20419 RVA: 0x00166338 File Offset: 0x00164538
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeInfo()
			{
				Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "AttributeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr);
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_usage");
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_inheritanceLevel");
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666830);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666831);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100666832);
			}

			// Token: 0x06004FC4 RID: 20420 RVA: 0x001663C8 File Offset: 0x001645C8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 126432, RefRangeEnd = 126433, XrefRangeStart = 126432, XrefRangeEnd = 126433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(usage);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritanceLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700144F RID: 5199
			// (get) Token: 0x06004FC5 RID: 20421 RVA: 0x00166424 File Offset: 0x00164624
			public unsafe AttributeUsageAttribute Usage
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x17001450 RID: 5200
			// (get) Token: 0x06004FC6 RID: 20422 RVA: 0x00166464 File Offset: 0x00164664
			public unsafe int InheritanceLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004FC7 RID: 20423 RVA: 0x0001E4B9 File Offset: 0x0001C6B9
			public AttributeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700144D RID: 5197
			// (get) Token: 0x06004FC8 RID: 20424 RVA: 0x001664A0 File Offset: 0x001646A0
			// (set) Token: 0x06004FC9 RID: 20425 RVA: 0x0001E4C2 File Offset: 0x0001C6C2
			public unsafe AttributeUsageAttribute _usage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700144E RID: 5198
			// (get) Token: 0x06004FCA RID: 20426 RVA: 0x001664D0 File Offset: 0x001646D0
			// (set) Token: 0x06004FCB RID: 20427 RVA: 0x0001E4E1 File Offset: 0x0001C6E1
			public unsafe int _inheritanceLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel)) = value;
				}
			}

			// Token: 0x040040EE RID: 16622
			private static readonly IntPtr NativeFieldInfoPtr__usage;

			// Token: 0x040040EF RID: 16623
			private static readonly IntPtr NativeFieldInfoPtr__inheritanceLevel;

			// Token: 0x040040F0 RID: 16624
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0;

			// Token: 0x040040F1 RID: 16625
			private static readonly IntPtr NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0;

			// Token: 0x040040F2 RID: 16626
			private static readonly IntPtr NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0;
		}
	}
}
