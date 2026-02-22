using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000046 RID: 70
	public class StoreServiceInterface : Object
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000D55C File Offset: 0x0000B75C
		// Note: this type is marked as 'beforefieldinit'.
		static StoreServiceInterface()
		{
			Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "StoreServiceInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr);
			StoreServiceInterface.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr, "s_typeCache");
			StoreServiceInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr, 100663585);
			StoreServiceInterface.NativeMethodInfoPtr_GetNameProp_Private_Static_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr, 100663586);
			StoreServiceInterface.NativeMethodInfoPtr_GetName_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreServiceInterface>.NativeClassPtr, 100663587);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153009, XrefRangeEnd = 153023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetClassType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreServiceInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000D610 File Offset: 0x0000B810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153023, XrefRangeEnd = 153040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetNameProp()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreServiceInterface.NativeMethodInfoPtr_GetNameProp_Private_Static_PropertyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000D644 File Offset: 0x0000B844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153040, XrefRangeEnd = 153060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreServiceInterface.NativeMethodInfoPtr_GetName_Internal_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003152 File Offset: 0x00001352
		public StoreServiceInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000D670 File Offset: 0x0000B870
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe static Type s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StoreServiceInterface.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoreServiceInterface.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_GetNameProp_Private_Static_PropertyInfo_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Internal_Static_String_0;
	}
}
