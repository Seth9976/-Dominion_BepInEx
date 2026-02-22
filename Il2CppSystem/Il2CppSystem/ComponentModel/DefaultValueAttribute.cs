using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000068 RID: 104
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x0600077F RID: 1919 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultValueAttribute()
		{
			Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DefaultValueAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr);
			DefaultValueAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, "value");
			DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100664272);
			DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100664273);
			DefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100664274);
			DefaultValueAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100664275);
			DefaultValueAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100664276);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40936, XrefRangeEnd = 40940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultValueAttribute(bool value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultValueAttribute(Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002C434 File Offset: 0x0002A634
		public unsafe virtual Object Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002C480 File Offset: 0x0002A680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40940, XrefRangeEnd = 40942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultValueAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40942, XrefRangeEnd = 40943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultValueAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00004FF7 File Offset: 0x000031F7
		public DefaultValueAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0002C520 File Offset: 0x0002A720
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00005000 File Offset: 0x00003200
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultValueAttribute.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultValueAttribute.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_Object_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
