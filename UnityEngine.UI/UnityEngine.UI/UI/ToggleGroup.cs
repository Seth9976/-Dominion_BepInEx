using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003B RID: 59
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x060007A4 RID: 1956 RVA: 0x00024D1C File Offset: 0x00022F1C
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleGroup()
		{
			Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ToggleGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr);
			ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_AllowSwitchOff");
			ToggleGroup.NativeFieldInfoPtr_m_Toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "m_Toggles");
			ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664431);
			ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664432);
			ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664433);
			ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664434);
			ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664435);
			ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664436);
			ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664437);
			ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664438);
			ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664439);
			ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664440);
			ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664441);
			ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664442);
			ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664443);
			ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, 100664444);
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x00024E8C File Offset: 0x0002308C
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x00024EC8 File Offset: 0x000230C8
		public unsafe bool allowSwitchOff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00024F08 File Offset: 0x00023108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119254, XrefRangeEnd = 119261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00024F44 File Offset: 0x00023144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119261, XrefRangeEnd = 119262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00024F80 File Offset: 0x00023180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleGroup.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00024FBC File Offset: 0x000231BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119262, XrefRangeEnd = 119269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateToggleIsInGroup(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00025000 File Offset: 0x00023200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119290, RefRangeEnd = 119293, XrefRangeStart = 119269, XrefRangeEnd = 119290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendCallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00025050 File Offset: 0x00023250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119293, XrefRangeEnd = 119299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00025094 File Offset: 0x00023294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119299, XrefRangeEnd = 119305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterToggle(Toggle toggle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x000250D8 File Offset: 0x000232D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119345, RefRangeEnd = 119348, XrefRangeStart = 119305, XrefRangeEnd = 119345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureValidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_EnsureValidState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0002510C File Offset: 0x0002330C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 119371, RefRangeEnd = 119373, XrefRangeStart = 119348, XrefRangeEnd = 119371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyTogglesOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00025148 File Offset: 0x00023348
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119391, RefRangeEnd = 119394, XrefRangeStart = 119373, XrefRangeEnd = 119391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Toggle> ActiveToggles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Toggle>>(intPtr3) : null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00025188 File Offset: 0x00023388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119394, XrefRangeEnd = 119401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toggle GetFirstActiveToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr3) : null;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000251C8 File Offset: 0x000233C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119401, XrefRangeEnd = 119409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllTogglesOff(bool sendCallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sendCallback;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000049F2 File Offset: 0x00002BF2
		public ToggleGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00025208 File Offset: 0x00023408
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x000049FB File Offset: 0x00002BFB
		public unsafe bool m_AllowSwitchOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_AllowSwitchOff)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00025230 File Offset: 0x00023430
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00004A16 File Offset: 0x00002C16
		public unsafe List<Toggle> m_Toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Toggle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleGroup.NativeFieldInfoPtr_m_Toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_m_AllowSwitchOff;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_m_Toggles;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_get_allowSwitchOff_Public_get_Boolean_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_set_allowSwitchOff_Public_set_Void_Boolean_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_ValidateToggleIsInGroup_Private_Void_Toggle_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_NotifyToggleOn_Public_Void_Toggle_Boolean_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterToggle_Public_Void_Toggle_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_RegisterToggle_Public_Void_Toggle_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_EnsureValidState_Public_Void_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_AnyTogglesOn_Public_Boolean_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_ActiveToggles_Public_IEnumerable_1_Toggle_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstActiveToggle_Public_Toggle_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_SetAllTogglesOff_Public_Void_Boolean_0;

		// Token: 0x020000B4 RID: 180
		[ObfuscatedName("UnityEngine.UI.ToggleGroup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C83 RID: 3203 RVA: 0x00036188 File Offset: 0x00034388
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ToggleGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr);
				ToggleGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9");
				ToggleGroup.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__13_0");
				ToggleGroup.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, "<>9__14_0");
				ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100665048);
				ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100665049);
				ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr, 100665050);
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x0003622C File Offset: 0x0003442C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x00036268 File Offset: 0x00034468
			[CallerCount(0)]
			public unsafe bool _AnyTogglesOn_b__13_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x000362B8 File Offset: 0x000344B8
			[CallerCount(0)]
			public unsafe bool _ActiveToggles_b__14_0(Toggle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleGroup.__c.NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00006B67 File Offset: 0x00004D67
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000422 RID: 1058
			// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00036308 File Offset: 0x00034508
			// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00006B70 File Offset: 0x00004D70
			public unsafe static ToggleGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00036330 File Offset: 0x00034530
			// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00006B82 File Offset: 0x00004D82
			public unsafe static Predicate<Toggle> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Toggle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00036358 File Offset: 0x00034558
			// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00006B94 File Offset: 0x00004D94
			public unsafe static Func<Toggle, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Toggle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ToggleGroup.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009D3 RID: 2515
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009D4 RID: 2516
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040009D5 RID: 2517
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040009D6 RID: 2518
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009D7 RID: 2519
			private static readonly IntPtr NativeMethodInfoPtr__AnyTogglesOn_b__13_0_Internal_Boolean_Toggle_0;

			// Token: 0x040009D8 RID: 2520
			private static readonly IntPtr NativeMethodInfoPtr__ActiveToggles_b__14_0_Internal_Boolean_Toggle_0;
		}
	}
}
