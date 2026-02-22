using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000074 RID: 116
	public sealed class TypeConverterAttribute : Attribute
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x0002CA6C File Offset: 0x0002AC6C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeConverterAttribute()
		{
			Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeConverterAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr);
			TypeConverterAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, "typeName");
			TypeConverterAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, "Default");
			TypeConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, 100664289);
			TypeConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, 100664290);
			TypeConverterAttribute.NativeMethodInfoPtr_get_ConverterTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, 100664291);
			TypeConverterAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, 100664292);
			TypeConverterAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr, 100664293);
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0002CB28 File Offset: 0x0002AD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40956, XrefRangeEnd = 40959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverterAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0002CB64 File Offset: 0x0002AD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40959, XrefRangeEnd = 40960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverterAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverterAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		public unsafe string ConverterTypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverterAttribute.NativeMethodInfoPtr_get_ConverterTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40960, XrefRangeEnd = 40963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverterAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002CC38 File Offset: 0x0002AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverterAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00005281 File Offset: 0x00003481
		public TypeConverterAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002CC74 File Offset: 0x0002AE74
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x0000528A File Offset: 0x0000348A
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverterAttribute.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeConverterAttribute.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0002CC9C File Offset: 0x0002AE9C
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x000052A9 File Offset: 0x000034A9
		public unsafe static TypeConverterAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeConverterAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverterAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverterAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr_get_ConverterTypeName_Public_get_String_0;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
