using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace SA.Fitness
{
	// Token: 0x02000338 RID: 824
	public sealed class LoginApi : Object
	{
		// Token: 0x0600318D RID: 12685 RVA: 0x000D00B4 File Offset: 0x000CE2B4
		// Note: this type is marked as 'beforefieldinit'.
		static LoginApi()
		{
			Il2CppClassPointerStore<LoginApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Fitness", "LoginApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginApi>.NativeClassPtr);
			LoginApi.NativeFieldInfoPtr_SENSORS_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "SENSORS_API");
			LoginApi.NativeFieldInfoPtr_RECORDING_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "RECORDING_API");
			LoginApi.NativeFieldInfoPtr_SESSIONS_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "SESSIONS_API");
			LoginApi.NativeFieldInfoPtr_HISTORY_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "HISTORY_API");
			LoginApi.NativeFieldInfoPtr_GOALS_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "GOALS_API");
			LoginApi.NativeFieldInfoPtr_CONFIG_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "CONFIG_API");
			LoginApi.NativeFieldInfoPtr_BLE_API = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "BLE_API");
			LoginApi.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, "value");
			LoginApi.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, 100669689);
			LoginApi.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, 100669690);
			LoginApi.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, 100669691);
			LoginApi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, 100669692);
			LoginApi.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginApi>.NativeClassPtr, 100669693);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000D01E8 File Offset: 0x000CE3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221653, XrefRangeEnd = 221656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginApi()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginApi>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginApi.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x000D0224 File Offset: 0x000CE424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221656, XrefRangeEnd = 221659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginApi(string api)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginApi>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(api);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginApi.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x000D0270 File Offset: 0x000CE470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221659, XrefRangeEnd = 221668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginApi.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x000D02C0 File Offset: 0x000CE4C0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 221564, RefRangeEnd = 221576, XrefRangeStart = 221564, XrefRangeEnd = 221576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginApi.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x000D02FC File Offset: 0x000CE4FC
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginApi.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003193 RID: 12691 RVA: 0x0001328D File Offset: 0x0001148D
		public LoginApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x000D0334 File Offset: 0x000CE534
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x00013296 File Offset: 0x00011496
		public unsafe static LoginApi SENSORS_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_SENSORS_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_SENSORS_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x000D035C File Offset: 0x000CE55C
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x000132A8 File Offset: 0x000114A8
		public unsafe static LoginApi RECORDING_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_RECORDING_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_RECORDING_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x000D0384 File Offset: 0x000CE584
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x000132BA File Offset: 0x000114BA
		public unsafe static LoginApi SESSIONS_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_SESSIONS_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_SESSIONS_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x000D03AC File Offset: 0x000CE5AC
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x000132CC File Offset: 0x000114CC
		public unsafe static LoginApi HISTORY_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_HISTORY_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_HISTORY_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x000D03D4 File Offset: 0x000CE5D4
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x000132DE File Offset: 0x000114DE
		public unsafe static LoginApi GOALS_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_GOALS_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_GOALS_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x000D03FC File Offset: 0x000CE5FC
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x000132F0 File Offset: 0x000114F0
		public unsafe static LoginApi CONFIG_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_CONFIG_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_CONFIG_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000D0424 File Offset: 0x000CE624
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00013302 File Offset: 0x00011502
		public unsafe static LoginApi BLE_API
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoginApi.NativeFieldInfoPtr_BLE_API, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginApi>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginApi.NativeFieldInfoPtr_BLE_API, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x000D044C File Offset: 0x000CE64C
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x00013314 File Offset: 0x00011514
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginApi.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginApi.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeFieldInfoPtr_SENSORS_API;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeFieldInfoPtr_RECORDING_API;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeFieldInfoPtr_SESSIONS_API;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeFieldInfoPtr_HISTORY_API;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeFieldInfoPtr_GOALS_API;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeFieldInfoPtr_CONFIG_API;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeFieldInfoPtr_BLE_API;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
