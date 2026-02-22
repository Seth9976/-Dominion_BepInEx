using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C5 RID: 453
	[Serializable]
	public sealed class CustomAttributeTypedArgument : ValueType
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x000A4C6C File Offset: 0x000A2E6C
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeTypedArgument()
		{
			Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeTypedArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr);
			CustomAttributeTypedArgument.NativeFieldInfoPtr_argumentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, "argumentType");
			CustomAttributeTypedArgument.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, "value");
			CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100668143);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100668144);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100668145);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100668146);
			CustomAttributeTypedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, 100668147);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000A4D28 File Offset: 0x000A2F28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318157, RefRangeEnd = 318158, XrefRangeStart = 318137, XrefRangeEnd = 318157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeTypedArgument(Type argumentType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000A4D8C File Offset: 0x000A2F8C
		public unsafe Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000A4DD0 File Offset: 0x000A2FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318188, RefRangeEnd = 318191, XrefRangeStart = 318158, XrefRangeEnd = 318188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000A4E0C File Offset: 0x000A300C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318198, RefRangeEnd = 318200, XrefRangeStart = 318191, XrefRangeEnd = 318198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000A4E60 File Offset: 0x000A3060
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeTypedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0000A075 File Offset: 0x00008275
		public CustomAttributeTypedArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0000A07E File Offset: 0x0000827E
		public CustomAttributeTypedArgument()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr))
		{
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000A4EA4 File Offset: 0x000A30A4
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000A090 File Offset: 0x00008290
		public unsafe Type argumentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr_argumentType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr_argumentType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000A4ED4 File Offset: 0x000A30D4
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0000A0AF File Offset: 0x000082AF
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeTypedArgument.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_argumentType;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
