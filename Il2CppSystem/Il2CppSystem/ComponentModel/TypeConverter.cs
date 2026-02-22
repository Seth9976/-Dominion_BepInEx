using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000073 RID: 115
	public class TypeConverter : Object
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x0002C988 File Offset: 0x0002AB88
		// Note: this type is marked as 'beforefieldinit'.
		static TypeConverter()
		{
			Il2CppClassPointerStore<TypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr);
			TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "s_UseCompatibleTypeConverterBehavior");
			TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "useCompatibleTypeConversion");
			TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100664288);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0002C9F4 File Offset: 0x0002ABF4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00005258 File Offset: 0x00003458
		public TypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0002CA30 File Offset: 0x0002AC30
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00005261 File Offset: 0x00003461
		public unsafe static string s_UseCompatibleTypeConverterBehavior
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x0002CA50 File Offset: 0x0002AC50
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x00005273 File Offset: 0x00003473
		public unsafe static bool useCompatibleTypeConversion
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&value));
			}
		}

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_useCompatibleTypeConversion;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000193 RID: 403
		[DefaultMember("Item")]
		public class StandardValuesCollection : Object
		{
			// Token: 0x0600174C RID: 5964 RVA: 0x0000C533 File Offset: 0x0000A733
			// Note: this type is marked as 'beforefieldinit'.
			static StandardValuesCollection()
			{
				Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "StandardValuesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr);
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x0000C553 File Offset: 0x0000A753
			public StandardValuesCollection(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
