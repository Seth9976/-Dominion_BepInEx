using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200008F RID: 143
	public static class PointerDeviceState : Object
	{
		// Token: 0x06000780 RID: 1920 RVA: 0x00024690 File Offset: 0x00022890
		// Note: this type is marked as 'beforefieldinit'.
		static PointerDeviceState()
		{
			Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerDeviceState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr);
			PointerDeviceState.NativeFieldInfoPtr_m_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "m_Positions");
			PointerDeviceState.NativeFieldInfoPtr_m_Panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "m_Panels");
			PointerDeviceState.NativeFieldInfoPtr_m_PressedButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, "m_PressedButtons");
			PointerDeviceState.NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664005);
			PointerDeviceState.NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664006);
			PointerDeviceState.NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664007);
			PointerDeviceState.NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664008);
			PointerDeviceState.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664009);
			PointerDeviceState.NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664010);
			PointerDeviceState.NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerDeviceState>.NativeClassPtr, 100664011);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00024788 File Offset: 0x00022988
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95799, RefRangeEnd = 95801, XrefRangeStart = 95793, XrefRangeEnd = 95799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000247DC File Offset: 0x000229DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95810, RefRangeEnd = 95811, XrefRangeStart = 95801, XrefRangeEnd = 95810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PressButton(int pointerId, int buttonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0002481C File Offset: 0x00022A1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95820, RefRangeEnd = 95821, XrefRangeStart = 95811, XrefRangeEnd = 95820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseButton(int pointerId, int buttonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buttonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0002485C File Offset: 0x00022A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95821, XrefRangeEnd = 95825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseAllButtons(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00024890 File Offset: 0x00022A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95829, RefRangeEnd = 95830, XrefRangeStart = 95825, XrefRangeEnd = 95829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 GetPointerPosition(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000248D0 File Offset: 0x00022AD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95834, RefRangeEnd = 95837, XrefRangeStart = 95830, XrefRangeEnd = 95834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPressedButtons(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00024910 File Offset: 0x00022B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95841, RefRangeEnd = 95843, XrefRangeStart = 95837, XrefRangeEnd = 95841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exceptButtonId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerDeviceState.NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000053E4 File Offset: 0x000035E4
		public PointerDeviceState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0002495C File Offset: 0x00022B5C
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x000053ED File Offset: 0x000035ED
		public unsafe static Il2CppStructArray<Vector2> m_Positions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_m_Positions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_m_Positions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00024984 File Offset: 0x00022B84
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x000053FF File Offset: 0x000035FF
		public unsafe static Il2CppReferenceArray<IPanel> m_Panels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_m_Panels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPanel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_m_Panels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x000249AC File Offset: 0x00022BAC
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00005411 File Offset: 0x00003611
		public unsafe static Il2CppStructArray<int> m_PressedButtons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerDeviceState.NativeFieldInfoPtr_m_PressedButtons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerDeviceState.NativeFieldInfoPtr_m_PressedButtons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00005423 File Offset: 0x00003623
		public static void Reset()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00005430 File Offset: 0x00003630
		public static IPanel GetPanel(int pointerId)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_m_Positions;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_m_Panels;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedButtons;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_SavePointerPosition_Public_Static_Void_Int32_Vector2_IPanel_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_PressButton_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseButton_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAllButtons_Public_Static_Void_Int32_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerPosition_Public_Static_Vector2_Int32_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_GetPressedButtons_Public_Static_Int32_Int32_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_HasAdditionalPressedButtons_Internal_Static_Boolean_Int32_Int32_0;
	}
}
