using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public class StringComparer : Object
	{
		// Token: 0x06001072 RID: 4210 RVA: 0x0006E860 File Offset: 0x0006CA60
		// Note: this type is marked as 'beforefieldinit'.
		static StringComparer()
		{
			Il2CppClassPointerStore<StringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "StringComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringComparer>.NativeClassPtr);
			StringComparer.NativeFieldInfoPtr__invariantCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_invariantCulture");
			StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_invariantCultureIgnoreCase");
			StringComparer.NativeFieldInfoPtr__ordinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_ordinal");
			StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, "_ordinalIgnoreCase");
			StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666132);
			StringComparer.NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666133);
			StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666134);
			StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666135);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666136);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666137);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666138);
			StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666139);
			StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666140);
			StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666141);
			StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringComparer>.NativeClassPtr, 100666142);
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0006E9BC File Offset: 0x0006CBBC
		public unsafe static StringComparer InvariantCultureIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298044, XrefRangeEnd = 298048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001074 RID: 4212 RVA: 0x0006E9F0 File Offset: 0x0006CBF0
		public unsafe static StringComparer CurrentCultureIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298048, XrefRangeEnd = 298056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0006EA24 File Offset: 0x0006CC24
		public unsafe static StringComparer Ordinal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298056, XrefRangeEnd = 298060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0006EA58 File Offset: 0x0006CC58
		public unsafe static StringComparer OrdinalIgnoreCase
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298060, XrefRangeEnd = 298064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr3) : null;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0006EA8C File Offset: 0x0006CC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298064, XrefRangeEnd = 298067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Compare(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0006EAEC File Offset: 0x0006CCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298067, XrefRangeEnd = 298069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0006EB4C File Offset: 0x0006CD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298069, XrefRangeEnd = 298100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0006EB9C File Offset: 0x0006CD9C
		[CallerCount(0)]
		public unsafe virtual int Compare(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0006EC08 File Offset: 0x0006CE08
		[CallerCount(0)]
		public unsafe virtual bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0006EC74 File Offset: 0x0006CE74
		[CallerCount(0)]
		public unsafe virtual int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringComparer.NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0006ECCC File Offset: 0x0006CECC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringComparer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00006014 File Offset: 0x00004214
		public StringComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x0006ED08 File Offset: 0x0006CF08
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x0000601D File Offset: 0x0000421D
		public unsafe static StringComparer _invariantCulture
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__invariantCulture, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__invariantCulture, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x0006ED30 File Offset: 0x0006CF30
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x0000602F File Offset: 0x0000422F
		public unsafe static StringComparer _invariantCultureIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__invariantCultureIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x0006ED58 File Offset: 0x0006CF58
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x00006041 File Offset: 0x00004241
		public unsafe static StringComparer _ordinal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__ordinal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__ordinal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x0006ED80 File Offset: 0x0006CF80
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x00006053 File Offset: 0x00004253
		public unsafe static StringComparer _ordinalIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringComparer.NativeFieldInfoPtr__ordinalIgnoreCase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeFieldInfoPtr__invariantCulture;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeFieldInfoPtr__invariantCultureIgnoreCase;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeFieldInfoPtr__ordinal;

		// Token: 0x04000E07 RID: 3591
		private static readonly IntPtr NativeFieldInfoPtr__ordinalIgnoreCase;

		// Token: 0x04000E08 RID: 3592
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantCultureIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E09 RID: 3593
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCultureIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E0A RID: 3594
		private static readonly IntPtr NativeMethodInfoPtr_get_Ordinal_Public_Static_get_StringComparer_0;

		// Token: 0x04000E0B RID: 3595
		private static readonly IntPtr NativeMethodInfoPtr_get_OrdinalIgnoreCase_Public_Static_get_StringComparer_0;

		// Token: 0x04000E0C RID: 3596
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04000E0D RID: 3597
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04000E0E RID: 3598
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Abstract_Virtual_New_Int32_String_String_0;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_String_String_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Abstract_Virtual_New_Int32_String_0;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
