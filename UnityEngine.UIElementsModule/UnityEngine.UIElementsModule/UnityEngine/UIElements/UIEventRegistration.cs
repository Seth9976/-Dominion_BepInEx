using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200003A RID: 58
	public static class UIEventRegistration : Object
	{
		// Token: 0x06000302 RID: 770 RVA: 0x00015618 File Offset: 0x00013818
		// Note: this type is marked as 'beforefieldinit'.
		static UIEventRegistration()
		{
			Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIEventRegistration");
			UIEventRegistration.NativeFieldInfoPtr_s_Utilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, "s_Utilities");
			UIEventRegistration.NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663549);
			UIEventRegistration.NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663550);
			UIEventRegistration.NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663551);
			UIEventRegistration.NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663552);
			UIEventRegistration.NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663553);
			UIEventRegistration.NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663554);
			UIEventRegistration.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, 100663555);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000156E0 File Offset: 0x000138E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92607, XrefRangeEnd = 92615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUIElementSystem(IUIElementsUtility utility)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(utility);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00015718 File Offset: 0x00013918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92638, RefRangeEnd = 92639, XrefRangeStart = 92615, XrefRangeEnd = 92638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TakeCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00015740 File Offset: 0x00013940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92662, RefRangeEnd = 92663, XrefRangeStart = 92639, XrefRangeEnd = 92662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReleaseCapture()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00015768 File Offset: 0x00013968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92688, RefRangeEnd = 92689, XrefRangeStart = 92663, XrefRangeEnd = 92688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EndContainerGUIFromException(Exception exception)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000157AC File Offset: 0x000139AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92713, RefRangeEnd = 92714, XrefRangeStart = 92689, XrefRangeEnd = 92713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instanceID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nativeEventPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x000157F8 File Offset: 0x000139F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92737, RefRangeEnd = 92738, XrefRangeStart = 92714, XrefRangeEnd = 92737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRoots()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00015820 File Offset: 0x00013A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92761, RefRangeEnd = 92762, XrefRangeStart = 92738, XrefRangeEnd = 92761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MakeCurrentIMGUIContainerDirty()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000037AA File Offset: 0x000019AA
		public UIEventRegistration(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00015848 File Offset: 0x00013A48
		// (set) Token: 0x0600030C RID: 780 RVA: 0x000037B3 File Offset: 0x000019B3
		public unsafe static List<IUIElementsUtility> s_Utilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIEventRegistration.NativeFieldInfoPtr_s_Utilities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IUIElementsUtility>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIEventRegistration.NativeFieldInfoPtr_s_Utilities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00015870 File Offset: 0x00013A70
		public static void UpdateSchedulers()
		{
			List<IUIElementsUtility>.Enumerator enumerator = UIEventRegistration.s_Utilities.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					IUIElementsUtility iuielementsUtility = enumerator.Current;
					iuielementsUtility.UpdateSchedulers();
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000158C8 File Offset: 0x00013AC8
		public static void RequestRepaintForPanels(Action<ScriptableObject> repaintCallback)
		{
			List<IUIElementsUtility>.Enumerator enumerator = UIEventRegistration.s_Utilities.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					IUIElementsUtility iuielementsUtility = enumerator.Current;
					iuielementsUtility.RequestRepaintForPanels(repaintCallback);
				}
			}
			finally
			{
				enumerator.Dispose();
			}
		}

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_s_Utilities;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUIElementSystem_Internal_Static_Void_IUIElementsUtility_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_TakeCapture_Private_Static_Void_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseCapture_Private_Static_Void_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Private_Static_Boolean_Exception_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_ProcessEvent_Private_Static_Boolean_Int32_IntPtr_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRoots_Private_Static_Void_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_MakeCurrentIMGUIContainerDirty_Internal_Static_Void_0;

		// Token: 0x020001F6 RID: 502
		[ObfuscatedName("UnityEngine.UIElements.UIEventRegistration+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001364 RID: 4964 RVA: 0x0003B48C File Offset: 0x0003968C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIEventRegistration>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr);
				UIEventRegistration.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, "<>9");
				UIEventRegistration.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663557);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663558);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663559);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663560);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663561);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663562);
				UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr, 100663563);
			}

			// Token: 0x06001365 RID: 4965 RVA: 0x0003B558 File Offset: 0x00039758
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIEventRegistration.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001366 RID: 4966 RVA: 0x0003B594 File Offset: 0x00039794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92578, XrefRangeEnd = 92582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001367 RID: 4967 RVA: 0x0003B5C8 File Offset: 0x000397C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92582, XrefRangeEnd = 92586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001368 RID: 4968 RVA: 0x0003B5FC File Offset: 0x000397FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92586, XrefRangeEnd = 92590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_2(int i, IntPtr ptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr2;
				checked
				{
					ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr2 = ref i;
				}
				ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001369 RID: 4969 RVA: 0x0003B654 File Offset: 0x00039854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92590, XrefRangeEnd = 92594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600136A RID: 4970 RVA: 0x0003B688 File Offset: 0x00039888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92594, XrefRangeEnd = 92598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_4(Exception exception)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600136B RID: 4971 RVA: 0x0003B6D8 File Offset: 0x000398D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92598, XrefRangeEnd = 92607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __cctor_b__1_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIEventRegistration.__c.NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600136C RID: 4972 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x0600136D RID: 4973 RVA: 0x0003B70C File Offset: 0x0003990C
			// (set) Token: 0x0600136E RID: 4974 RVA: 0x0000C7B9 File Offset: 0x0000A9B9
			public unsafe static UIEventRegistration.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIEventRegistration.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIEventRegistration.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIEventRegistration.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000873 RID: 2163
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000874 RID: 2164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000875 RID: 2165
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Void_0;

			// Token: 0x04000876 RID: 2166
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_1_Internal_Void_0;

			// Token: 0x04000877 RID: 2167
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_2_Internal_Boolean_Int32_IntPtr_0;

			// Token: 0x04000878 RID: 2168
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_3_Internal_Void_0;

			// Token: 0x04000879 RID: 2169
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_4_Internal_Boolean_Exception_0;

			// Token: 0x0400087A RID: 2170
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_5_Internal_Void_0;
		}

		// Token: 0x020001F7 RID: 503
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
