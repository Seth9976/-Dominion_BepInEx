using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000048 RID: 72
	public class UserInfoInterface : Object
	{
		// Token: 0x0600024D RID: 589 RVA: 0x0000D86C File Offset: 0x0000BA6C
		// Note: this type is marked as 'beforefieldinit'.
		static UserInfoInterface()
		{
			Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UserInfoInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr);
			UserInfoInterface.NativeFieldInfoPtr_s_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, "s_typeCache");
			UserInfoInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserInfoInterface>.NativeClassPtr, 100663593);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153103, XrefRangeEnd = 153117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetClassType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UserInfoInterface.NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003188 File Offset: 0x00001388
		public UserInfoInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00003191 File Offset: 0x00001391
		public unsafe static Type s_typeCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UserInfoInterface.NativeFieldInfoPtr_s_typeCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UserInfoInterface.NativeFieldInfoPtr_s_typeCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_s_typeCache;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_GetClassType_Internal_Static_Type_0;
	}
}
