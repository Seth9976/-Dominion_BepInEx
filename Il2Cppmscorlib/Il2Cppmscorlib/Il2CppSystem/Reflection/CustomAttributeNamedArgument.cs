using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C4 RID: 452
	[Serializable]
	public sealed class CustomAttributeNamedArgument : ValueType
	{
		// Token: 0x06001D14 RID: 7444 RVA: 0x000A4984 File Offset: 0x000A2B84
		// Note: this type is marked as 'beforefieldinit'.
		static CustomAttributeNamedArgument()
		{
			Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "CustomAttributeNamedArgument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr);
			CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "typedArgument");
			CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, "memberInfo");
			CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668137);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668138);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668139);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668140);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668141);
			CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr, 100668142);
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x000A4A54 File Offset: 0x000A2C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318119, XrefRangeEnd = 318122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomAttributeNamedArgument(MemberInfo memberInfo, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x000A4AB8 File Offset: 0x000A2CB8
		public unsafe MemberInfo MemberInfo
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x000A4AFC File Offset: 0x000A2CFC
		public unsafe CustomAttributeTypedArgument TypedValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 108457, RefRangeEnd = 108458, XrefRangeStart = 108457, XrefRangeEnd = 108458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CustomAttributeTypedArgument(intPtr);
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x000A4B38 File Offset: 0x000A2D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318122, XrefRangeEnd = 318127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x000A4B74 File Offset: 0x000A2D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318135, RefRangeEnd = 318136, XrefRangeStart = 318127, XrefRangeEnd = 318135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318136, XrefRangeEnd = 318137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomAttributeNamedArgument.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0000A00D File Offset: 0x0000820D
		public CustomAttributeNamedArgument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0000A016 File Offset: 0x00008216
		public CustomAttributeNamedArgument()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomAttributeNamedArgument>.NativeClassPtr))
		{
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x000A4C0C File Offset: 0x000A2E0C
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0000A028 File Offset: 0x00008228
		public CustomAttributeTypedArgument typedArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument);
				return new CustomAttributeTypedArgument(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_typedArgument), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CustomAttributeTypedArgument>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000A4C3C File Offset: 0x000A2E3C
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000A056 File Offset: 0x00008256
		public unsafe MemberInfo memberInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomAttributeNamedArgument.NativeFieldInfoPtr_memberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeFieldInfoPtr_typedArgument;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeFieldInfoPtr_memberInfo;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemberInfo_Object_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberInfo_Public_get_MemberInfo_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_get_CustomAttributeTypedArgument_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
