using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Runtime.Remoting.Lifetime
{
	// Token: 0x020003B0 RID: 944
	public class LeaseManager : Object
	{
		// Token: 0x06003D50 RID: 15696 RVA: 0x0011FC84 File Offset: 0x0011DE84
		// Note: this type is marked as 'beforefieldinit'.
		static LeaseManager()
		{
			Il2CppClassPointerStore<LeaseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LeaseManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr);
			LeaseManager.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_objects");
			LeaseManager.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, "_timer");
			LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672323);
			LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672324);
			LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672325);
			LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672326);
			LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672327);
			LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr, 100672328);
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x0011FD54 File Offset: 0x0011DF54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352095, RefRangeEnd = 352096, XrefRangeStart = 352091, XrefRangeEnd = 352095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPollTime(TimeSpan timeSpan)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeSpan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x0011FD94 File Offset: 0x0011DF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 352121, RefRangeEnd = 352122, XrefRangeStart = 352096, XrefRangeEnd = 352121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackLifetime(ServerIdentity identity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(identity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x0011FDD8 File Offset: 0x0011DFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352122, XrefRangeEnd = 352144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StartManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x0011FE0C File Offset: 0x0011E00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352144, XrefRangeEnd = 352145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_StopManager_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x0011FE40 File Offset: 0x0011E040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352145, XrefRangeEnd = 352154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManageLeases(Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0011FE84 File Offset: 0x0011E084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352154, XrefRangeEnd = 352159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaseManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaseManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00017193 File Offset: 0x00015393
		public LeaseManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06003D58 RID: 15704 RVA: 0x0011FEC0 File Offset: 0x0011E0C0
		// (set) Token: 0x06003D59 RID: 15705 RVA: 0x0001719C File Offset: 0x0001539C
		public unsafe ArrayList _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06003D5A RID: 15706 RVA: 0x0011FEF0 File Offset: 0x0011E0F0
		// (set) Token: 0x06003D5B RID: 15707 RVA: 0x000171BB File Offset: 0x000153BB
		public unsafe Timer _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LeaseManager.NativeFieldInfoPtr__timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_SetPollTime_Public_Void_TimeSpan_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_TrackLifetime_Public_Void_ServerIdentity_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr_StartManager_Public_Void_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr_StopManager_Public_Void_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_ManageLeases_Public_Void_Object_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
