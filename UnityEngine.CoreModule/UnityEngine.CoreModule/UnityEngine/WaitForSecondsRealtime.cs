using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000CA RID: 202
	public class WaitForSecondsRealtime : CustomYieldInstruction
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x00047398 File Offset: 0x00045598
		// Note: this type is marked as 'beforefieldinit'.
		static WaitForSecondsRealtime()
		{
			Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForSecondsRealtime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr);
			WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "<waitTime>k__BackingField");
			WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "m_WaitUntilTime");
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100664532);
			WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100664533);
			WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100664534);
			WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100664535);
			WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100664536);
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00047454 File Offset: 0x00045654
		// (set) Token: 0x0600118C RID: 4492 RVA: 0x00047490 File Offset: 0x00045690
		public unsafe float waitTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000474D0 File Offset: 0x000456D0
		public unsafe override bool keepWaiting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76639, XrefRangeEnd = 76643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00047518 File Offset: 0x00045718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76644, RefRangeEnd = 76648, XrefRangeStart = 76643, XrefRangeEnd = 76644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitForSecondsRealtime(float time)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00047560 File Offset: 0x00045760
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public WaitForSecondsRealtime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x0004759C File Offset: 0x0004579C
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x0000A7E9 File Offset: 0x000089E9
		public unsafe float _waitTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000475C4 File Offset: 0x000457C4
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000A804 File Offset: 0x00008A04
		public unsafe float m_WaitUntilTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime)) = value;
			}
		}

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr__waitTime_k__BackingField;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitUntilTime;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_get_waitTime_Public_get_Single_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
