using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000339 RID: 825
	public sealed class LoginScope : Object
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x000D0474 File Offset: 0x000CE674
		// Note: this type is marked as 'beforefieldinit'.
		static LoginScope()
		{
			Il2CppClassPointerStore<LoginScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "LoginScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginScope>.NativeClassPtr);
			LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_ACTIVITY_READ");
			LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ_WRITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_ACTIVITY_READ_WRITE");
			LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_LOCATION_READ");
			LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ_WRITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_LOCATION_READ_WRITE");
			LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_BODY_READ");
			LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ_WRITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_BODY_READ_WRITE");
			LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_NUTRITION_READ");
			LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ_WRITE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "SCOPE_NUTRITION_READ_WRITE");
			LoginScope.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, "value");
			LoginScope.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, 100669695);
			LoginScope.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, 100669696);
			LoginScope.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, 100669697);
			LoginScope.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, 100669698);
			LoginScope.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginScope>.NativeClassPtr, 100669699);
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000D05BC File Offset: 0x000CE7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221668, XrefRangeEnd = 221671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginScope()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginScope>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginScope.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000D05F8 File Offset: 0x000CE7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221671, XrefRangeEnd = 221674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginScope(string scope)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginScope>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scope);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginScope.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000D0644 File Offset: 0x000CE844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221674, XrefRangeEnd = 221683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginScope.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000D0694 File Offset: 0x000CE894
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginScope.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000D06D0 File Offset: 0x000CE8D0
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginScope.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x00013333 File Offset: 0x00011533
		public LoginScope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x000D0708 File Offset: 0x000CE908
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x0001333C File Offset: 0x0001153C
		public unsafe static LoginScope SCOPE_ACTIVITY_READ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x000D0730 File Offset: 0x000CE930
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x0001334E File Offset: 0x0001154E
		public unsafe static LoginScope SCOPE_ACTIVITY_READ_WRITE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ_WRITE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_ACTIVITY_READ_WRITE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x000D0758 File Offset: 0x000CE958
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x00013360 File Offset: 0x00011560
		public unsafe static LoginScope SCOPE_LOCATION_READ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000D0780 File Offset: 0x000CE980
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x00013372 File Offset: 0x00011572
		public unsafe static LoginScope SCOPE_LOCATION_READ_WRITE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ_WRITE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_LOCATION_READ_WRITE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000D07A8 File Offset: 0x000CE9A8
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x00013384 File Offset: 0x00011584
		public unsafe static LoginScope SCOPE_BODY_READ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000D07D0 File Offset: 0x000CE9D0
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x00013396 File Offset: 0x00011596
		public unsafe static LoginScope SCOPE_BODY_READ_WRITE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ_WRITE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_BODY_READ_WRITE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x000D07F8 File Offset: 0x000CE9F8
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x000133A8 File Offset: 0x000115A8
		public unsafe static LoginScope SCOPE_NUTRITION_READ
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x000D0820 File Offset: 0x000CEA20
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x000133BA File Offset: 0x000115BA
		public unsafe static LoginScope SCOPE_NUTRITION_READ_WRITE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ_WRITE, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginScope>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginScope.NativeFieldInfoPtr_SCOPE_NUTRITION_READ_WRITE, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x000D0848 File Offset: 0x000CEA48
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x000133CC File Offset: 0x000115CC
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginScope.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginScope.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_ACTIVITY_READ;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_ACTIVITY_READ_WRITE;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_LOCATION_READ;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_LOCATION_READ_WRITE;

		// Token: 0x04002EB4 RID: 11956
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_BODY_READ;

		// Token: 0x04002EB5 RID: 11957
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_BODY_READ_WRITE;

		// Token: 0x04002EB6 RID: 11958
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_NUTRITION_READ;

		// Token: 0x04002EB7 RID: 11959
		private static readonly IntPtr NativeFieldInfoPtr_SCOPE_NUTRITION_READ_WRITE;

		// Token: 0x04002EB8 RID: 11960
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002EB9 RID: 11961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002EBA RID: 11962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04002EBB RID: 11963
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
