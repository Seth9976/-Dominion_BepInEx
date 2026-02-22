using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020000B0 RID: 176
	[StructLayout(2)]
	public struct Length
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x0002B57C File Offset: 0x0002977C
		// Note: this type is marked as 'beforefieldinit'.
		static Length()
		{
			Il2CppClassPointerStore<Length>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Length");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Length>.NativeClassPtr);
			Length.NativeFieldInfoPtr_k_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "k_MaxValue");
			Length.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "m_Value");
			Length.NativeFieldInfoPtr_m_Unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Length>.NativeClassPtr, "m_Unit");
			Length.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664167);
			Length.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664168);
			Length.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664169);
			Length.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664170);
			Length.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664171);
			Length.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Length>.NativeClassPtr, 100664172);
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0002B660 File Offset: 0x00029860
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x000063C6 File Offset: 0x000045C6
		public unsafe float value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_get_value_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Value = Mathf.Clamp(value, -8388608f, 8388608f);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0002B690 File Offset: 0x00029890
		[CallerCount(0)]
		public unsafe static bool operator ==(Length lhs, Length rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0002B6DC File Offset: 0x000298DC
		[CallerCount(0)]
		public unsafe bool Equals(Length other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002B71C File Offset: 0x0002991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96665, XrefRangeEnd = 96668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002B760 File Offset: 0x00029960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96668, XrefRangeEnd = 96669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0002B790 File Offset: 0x00029990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96669, XrefRangeEnd = 96689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Length.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000063A6 File Offset: 0x000045A6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Length>.NativeClassPtr, ref this));
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002B7BC File Offset: 0x000299BC
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x000063B8 File Offset: 0x000045B8
		public unsafe static float k_MaxValue
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Length.NativeFieldInfoPtr_k_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Length.NativeFieldInfoPtr_k_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0002B7D8 File Offset: 0x000299D8
		public static Length Percent(float value)
		{
			return new Length(value, LengthUnit.Percent);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0002B7F4 File Offset: 0x000299F4
		public static Length Auto()
		{
			return new Length(0f, Length.Unit.Auto);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0002B814 File Offset: 0x00029A14
		public static Length None()
		{
			return new Length(0f, Length.Unit.None);
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x000063DE File Offset: 0x000045DE
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x000063E6 File Offset: 0x000045E6
		public LengthUnit unit
		{
			get
			{
				return (LengthUnit)this.m_Unit;
			}
			set
			{
				this.m_Unit = (Length.Unit)value;
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000063EF File Offset: 0x000045EF
		public bool IsAuto()
		{
			return this.m_Unit == Length.Unit.Auto;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000063FA File Offset: 0x000045FA
		public bool IsNone()
		{
			return this.m_Unit == Length.Unit.None;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0002B834 File Offset: 0x00029A34
		public static implicit operator Length(float value)
		{
			return new Length(value, LengthUnit.Pixel);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0002B850 File Offset: 0x00029A50
		public static bool operator !=(Length lhs, Length rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxValue;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr_m_Unit;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Length_Length_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Length_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400052C RID: 1324
		[FieldOffset(0)]
		public float m_Value;

		// Token: 0x0400052D RID: 1325
		[FieldOffset(4)]
		public Length.Unit m_Unit;

		// Token: 0x0200021F RID: 543
		public enum Unit
		{
			// Token: 0x040008D7 RID: 2263
			Pixel,
			// Token: 0x040008D8 RID: 2264
			Percent,
			// Token: 0x040008D9 RID: 2265
			Auto,
			// Token: 0x040008DA RID: 2266
			None
		}
	}
}
