using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000043 RID: 67
	public class VisualElementFocusChangeDirection : FocusChangeDirection
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x0001AEA4 File Offset: 0x000190A4
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementFocusChangeDirection()
		{
			Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementFocusChangeDirection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr);
			VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, "s_Left");
			VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, "s_Right");
			VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100663659);
			VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100663660);
			VisualElementFocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr, 100663661);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0001AF38 File Offset: 0x00019138
		public unsafe static FocusChangeDirection left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93438, XrefRangeEnd = 93442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0001AF6C File Offset: 0x0001916C
		public unsafe static FocusChangeDirection right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93442, XrefRangeEnd = 93446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001AFA0 File Offset: 0x000191A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93446, XrefRangeEnd = 93450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementFocusChangeDirection(int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementFocusChangeDirection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementFocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004437 File Offset: 0x00002637
		public VisualElementFocusChangeDirection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0001AFE8 File Offset: 0x000191E8
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00004440 File Offset: 0x00002640
		public unsafe static VisualElementFocusChangeDirection s_Left
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Left, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001B010 File Offset: 0x00019210
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00004452 File Offset: 0x00002652
		public unsafe static VisualElementFocusChangeDirection s_Right
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElementFocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementFocusChangeDirection.NativeFieldInfoPtr_s_Right, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0001B038 File Offset: 0x00019238
		public new static VisualElementFocusChangeDirection lastValue
		{
			get
			{
				return VisualElementFocusChangeDirection.s_Right;
			}
		}

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;
	}
}
