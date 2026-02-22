using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public sealed class Navigation : ValueType
	{
		// Token: 0x0600052D RID: 1325 RVA: 0x0001AFD8 File Offset: 0x000191D8
		// Note: this type is marked as 'beforefieldinit'.
		static Navigation()
		{
			Il2CppClassPointerStore<Navigation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "Navigation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Navigation>.NativeClassPtr);
			Navigation.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_Mode");
			Navigation.NativeFieldInfoPtr_m_WrapAround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_WrapAround");
			Navigation.NativeFieldInfoPtr_m_SelectOnUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnUp");
			Navigation.NativeFieldInfoPtr_m_SelectOnDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnDown");
			Navigation.NativeFieldInfoPtr_m_SelectOnLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnLeft");
			Navigation.NativeFieldInfoPtr_m_SelectOnRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Navigation>.NativeClassPtr, "m_SelectOnRight");
			Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664059);
			Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664060);
			Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664061);
			Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664062);
			Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664063);
			Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664064);
			Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664065);
			Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664066);
			Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664067);
			Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664068);
			Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664069);
			Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664070);
			Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664071);
			Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Navigation>.NativeClassPtr, 100664072);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0001B198 File Offset: 0x00019398
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x0001B1DC File Offset: 0x000193DC
		public unsafe Navigation.Mode mode
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 31381, RefRangeEnd = 31445, XrefRangeStart = 31381, XrefRangeEnd = 31445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_mode_Public_get_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0001B220 File Offset: 0x00019420
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x0001B264 File Offset: 0x00019464
		public unsafe bool wrapAround
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0001B2A8 File Offset: 0x000194A8
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x0001B2EC File Offset: 0x000194EC
		public unsafe Selectable selectOnUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 88837, RefRangeEnd = 88838, XrefRangeStart = 88837, XrefRangeEnd = 88838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x0001B334 File Offset: 0x00019534
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x0001B378 File Offset: 0x00019578
		public unsafe Selectable selectOnDown
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001B3C0 File Offset: 0x000195C0
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x0001B404 File Offset: 0x00019604
		public unsafe Selectable selectOnLeft
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0001B44C File Offset: 0x0001964C
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x0001B490 File Offset: 0x00019690
		public unsafe Selectable selectOnRight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0001B4D8 File Offset: 0x000196D8
		public unsafe static Navigation defaultNavigation
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Navigation(intPtr);
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0001B504 File Offset: 0x00019704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116455, XrefRangeEnd = 116468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Navigation other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Navigation.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00003C2E File Offset: 0x00001E2E
		public Navigation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00003C37 File Offset: 0x00001E37
		public Navigation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Navigation>.NativeClassPtr))
		{
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0001B55C File Offset: 0x0001975C
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003C49 File Offset: 0x00001E49
		public unsafe Navigation.Mode m_Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_Mode)) = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x0001B584 File Offset: 0x00019784
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00003C64 File Offset: 0x00001E64
		public unsafe bool m_WrapAround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_WrapAround)) = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0001B5AC File Offset: 0x000197AC
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00003C7F File Offset: 0x00001E7F
		public unsafe Selectable m_SelectOnUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001B5DC File Offset: 0x000197DC
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00003C9E File Offset: 0x00001E9E
		public unsafe Selectable m_SelectOnDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0001B60C File Offset: 0x0001980C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00003CBD File Offset: 0x00001EBD
		public unsafe Selectable m_SelectOnLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001B63C File Offset: 0x0001983C
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00003CDC File Offset: 0x00001EDC
		public unsafe Selectable m_SelectOnRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Navigation.NativeFieldInfoPtr_m_SelectOnRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_m_WrapAround;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnUp;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnDown;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnLeft;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectOnRight;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_mode_Public_get_Mode_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_set_mode_Public_set_Void_Mode_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_get_wrapAround_Public_get_Boolean_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_set_wrapAround_Public_set_Void_Boolean_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnUp_Public_get_Selectable_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnUp_Public_set_Void_Selectable_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnDown_Public_get_Selectable_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnDown_Public_set_Void_Selectable_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnLeft_Public_get_Selectable_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnLeft_Public_set_Void_Selectable_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_get_selectOnRight_Public_get_Selectable_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_set_selectOnRight_Public_set_Void_Selectable_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultNavigation_Public_Static_get_Navigation_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Navigation_0;

		// Token: 0x020000A2 RID: 162
		[Flags]
		public enum Mode
		{
			// Token: 0x0400098C RID: 2444
			None = 0,
			// Token: 0x0400098D RID: 2445
			Horizontal = 1,
			// Token: 0x0400098E RID: 2446
			Vertical = 2,
			// Token: 0x0400098F RID: 2447
			Automatic = 3,
			// Token: 0x04000990 RID: 2448
			Explicit = 4
		}
	}
}
