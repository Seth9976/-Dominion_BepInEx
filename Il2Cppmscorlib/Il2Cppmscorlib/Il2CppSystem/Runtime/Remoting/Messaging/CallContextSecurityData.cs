using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Principal;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E1 RID: 993
	[Serializable]
	public class CallContextSecurityData : Object
	{
		// Token: 0x06003F07 RID: 16135 RVA: 0x001259BC File Offset: 0x00123BBC
		// Note: this type is marked as 'beforefieldinit'.
		static CallContextSecurityData()
		{
			Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CallContextSecurityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr);
			CallContextSecurityData.NativeFieldInfoPtr__principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, "_principal");
			CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672533);
			CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672534);
			CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr, 100672535);
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x00125A3C File Offset: 0x00123C3C
		public unsafe bool HasInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 348766, RefRangeEnd = 348768, XrefRangeStart = 348766, XrefRangeEnd = 348768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00125A78 File Offset: 0x00123C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354231, RefRangeEnd = 354232, XrefRangeStart = 354227, XrefRangeEnd = 354231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00125AB8 File Offset: 0x00123CB8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallContextSecurityData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallContextSecurityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallContextSecurityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x00017D1B File Offset: 0x00015F1B
		public CallContextSecurityData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x00125AF4 File Offset: 0x00123CF4
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x00017D24 File Offset: 0x00015F24
		public unsafe IPrincipal _principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrincipal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallContextSecurityData.NativeFieldInfoPtr__principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033D0 RID: 13264
		private static readonly IntPtr NativeFieldInfoPtr__principal;

		// Token: 0x040033D1 RID: 13265
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInfo_Internal_get_Boolean_0;

		// Token: 0x040033D2 RID: 13266
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x040033D3 RID: 13267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
