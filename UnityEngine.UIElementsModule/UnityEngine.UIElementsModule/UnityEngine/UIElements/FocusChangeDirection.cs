using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000E RID: 14
	public class FocusChangeDirection : Object
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000E39C File Offset: 0x0000C59C
		// Note: this type is marked as 'beforefieldinit'.
		static FocusChangeDirection()
		{
			Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "FocusChangeDirection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr);
			FocusChangeDirection.NativeFieldInfoPtr__unspecified_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, "<unspecified>k__BackingField");
			FocusChangeDirection.NativeFieldInfoPtr__none_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, "<none>k__BackingField");
			FocusChangeDirection.NativeFieldInfoPtr__lastValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, "<lastValue>k__BackingField");
			FocusChangeDirection.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, "m_Value");
			FocusChangeDirection.NativeMethodInfoPtr_get_unspecified_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663337);
			FocusChangeDirection.NativeMethodInfoPtr_get_none_Public_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663338);
			FocusChangeDirection.NativeMethodInfoPtr_get_lastValue_Protected_Static_get_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663339);
			FocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663340);
			FocusChangeDirection.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_FocusChangeDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663341);
			FocusChangeDirection.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663342);
			FocusChangeDirection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663343);
			FocusChangeDirection.NativeMethodInfoPtr_ApplyTo_Internal_Virtual_New_Void_FocusController_Focusable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr, 100663344);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public unsafe static FocusChangeDirection unspecified
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91185, XrefRangeEnd = 91189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr_get_unspecified_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		public unsafe static FocusChangeDirection none
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91189, XrefRangeEnd = 91193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr_get_none_Public_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000E524 File Offset: 0x0000C724
		public unsafe static FocusChangeDirection lastValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91193, XrefRangeEnd = 91197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr_get_lastValue_Protected_Static_get_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr3) : null;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000E558 File Offset: 0x0000C758
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FocusChangeDirection(int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FocusChangeDirection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		[CallerCount(0)]
		public unsafe static implicit operator int(FocusChangeDirection fcd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fcd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_FocusChangeDirection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000E5E4 File Offset: 0x0000C7E4
		[CallerCount(0)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FocusChangeDirection.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000E618 File Offset: 0x0000C818
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusChangeDirection.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000E654 File Offset: 0x0000C854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91197, XrefRangeEnd = 91198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyTo(FocusController focusController, Focusable f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusController);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(f);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FocusChangeDirection.NativeMethodInfoPtr_ApplyTo_Internal_Virtual_New_Void_FocusController_Focusable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000252A File Offset: 0x0000072A
		public FocusChangeDirection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002533 File Offset: 0x00000733
		public unsafe static FocusChangeDirection _unspecified_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FocusChangeDirection.NativeFieldInfoPtr__unspecified_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FocusChangeDirection.NativeFieldInfoPtr__unspecified_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002545 File Offset: 0x00000745
		public unsafe static FocusChangeDirection _none_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FocusChangeDirection.NativeFieldInfoPtr__none_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FocusChangeDirection.NativeFieldInfoPtr__none_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000E704 File Offset: 0x0000C904
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002557 File Offset: 0x00000757
		public unsafe static FocusChangeDirection _lastValue_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FocusChangeDirection.NativeFieldInfoPtr__lastValue_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FocusChangeDirection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FocusChangeDirection.NativeFieldInfoPtr__lastValue_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000E72C File Offset: 0x0000C92C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002569 File Offset: 0x00000769
		public unsafe int m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusChangeDirection.NativeFieldInfoPtr_m_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FocusChangeDirection.NativeFieldInfoPtr_m_Value)) = value;
			}
		}

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr__unspecified_k__BackingField;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr__none_k__BackingField;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr__lastValue_k__BackingField;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_unspecified_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_none_Public_Static_get_FocusChangeDirection_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_lastValue_Protected_Static_get_FocusChangeDirection_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_FocusChangeDirection_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTo_Internal_Virtual_New_Void_FocusController_Focusable_0;
	}
}
