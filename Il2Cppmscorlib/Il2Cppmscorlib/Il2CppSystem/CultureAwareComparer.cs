using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public sealed class CultureAwareComparer : StringComparer
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x0006EDA8 File Offset: 0x0006CFA8
		// Note: this type is marked as 'beforefieldinit'.
		static CultureAwareComparer()
		{
			Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CultureAwareComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr);
			CultureAwareComparer.NativeFieldInfoPtr__compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, "_compareInfo");
			CultureAwareComparer.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, "_ignoreCase");
			CultureAwareComparer.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, "_options");
			CultureAwareComparer.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666144);
			CultureAwareComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666145);
			CultureAwareComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666146);
			CultureAwareComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666147);
			CultureAwareComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666148);
			CultureAwareComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr, 100666149);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0006EE8C File Offset: 0x0006D08C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 298104, RefRangeEnd = 298107, XrefRangeStart = 298100, XrefRangeEnd = 298104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CultureAwareComparer(CultureInfo culture, bool ignoreCase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CultureAwareComparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0006EEE8 File Offset: 0x0006D0E8
		[CallerCount(0)]
		public unsafe override int Compare(string x, string y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0006EF48 File Offset: 0x0006D148
		[CallerCount(0)]
		public unsafe override bool Equals(string x, string y)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0006EFA8 File Offset: 0x0006D1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298107, XrefRangeEnd = 298115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0006EFF8 File Offset: 0x0006D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298115, XrefRangeEnd = 298117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0006F048 File Offset: 0x0006D248
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CultureAwareComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00006065 File Offset: 0x00004265
		public CultureAwareComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x0006F084 File Offset: 0x0006D284
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0000606E File Offset: 0x0000426E
		public unsafe CompareInfo _compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x0006F0B4 File Offset: 0x0006D2B4
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0000608D File Offset: 0x0000428D
		public unsafe bool _ignoreCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__ignoreCase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__ignoreCase)) = value;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0006F0DC File Offset: 0x0006D2DC
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x000060A8 File Offset: 0x000042A8
		public unsafe CompareOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CultureAwareComparer.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr__compareInfo;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCase;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureInfo_Boolean_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_String_String_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_String_String_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_String_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
