using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct Vector2
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x0003B1D8 File Offset: 0x000393D8
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2()
		{
			Il2CppClassPointerStore<Vector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2>.NativeClassPtr);
			Vector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "x");
			Vector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "y");
			Vector2.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "zeroVector");
			Vector2.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "oneVector");
			Vector2.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "upVector");
			Vector2.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "downVector");
			Vector2.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "leftVector");
			Vector2.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "rightVector");
			Vector2.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "positiveInfinityVector");
			Vector2.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "negativeInfinityVector");
			Vector2.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilon");
			Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664145);
			Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664146);
			Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664147);
			Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664148);
			Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664149);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664150);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664151);
			Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664152);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664153);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664154);
			Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664155);
			Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664156);
			Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664157);
			Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664158);
			Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664159);
			Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664160);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664161);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664162);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664163);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664164);
			Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664165);
			Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664166);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664167);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664168);
			Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664169);
			Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664170);
			Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664171);
			Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100664172);
		}

		// Token: 0x170002F9 RID: 761
		public unsafe float this[int index]
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 66917, RefRangeEnd = 67010, XrefRangeStart = 66917, XrefRangeEnd = 66917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(31)]
			[CachedScanResults(RefRangeStart = 67010, RefRangeEnd = 67041, XrefRangeStart = 67010, XrefRangeEnd = 67010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x0003B5A8 File Offset: 0x000397A8
		[CallerCount(0)]
		public unsafe Vector2(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x0003B5E8 File Offset: 0x000397E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67041, XrefRangeEnd = 67042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x0003B644 File Offset: 0x00039844
		[CallerCount(0)]
		public unsafe static Vector2 Scale(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0003B690 File Offset: 0x00039890
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 67052, RefRangeEnd = 67057, XrefRangeStart = 67042, XrefRangeEnd = 67052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0003B6BC File Offset: 0x000398BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67083, RefRangeEnd = 67084, XrefRangeStart = 67057, XrefRangeEnd = 67083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x0003B70C File Offset: 0x0003990C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 67086, RefRangeEnd = 67089, XrefRangeStart = 67084, XrefRangeEnd = 67086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x0003B73C File Offset: 0x0003993C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67089, XrefRangeEnd = 67092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x0003B780 File Offset: 0x00039980
		[CallerCount(0)]
		public unsafe bool Equals(Vector2 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x0003B7C0 File Offset: 0x000399C0
		[CallerCount(0)]
		public unsafe static float Dot(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0003B80C File Offset: 0x00039A0C
		public unsafe float magnitude
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67095, RefRangeEnd = 67097, XrefRangeStart = 67092, XrefRangeEnd = 67095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x0003B83C File Offset: 0x00039A3C
		public unsafe float sqrMagnitude
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 67097, RefRangeEnd = 67113, XrefRangeStart = 67097, XrefRangeEnd = 67097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x0003B86C File Offset: 0x00039A6C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 67097, RefRangeEnd = 67113, XrefRangeStart = 67097, XrefRangeEnd = 67113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float SqrMagnitude()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0003B89C File Offset: 0x00039A9C
		[CallerCount(0)]
		public unsafe static Vector2 operator +(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		[CallerCount(0)]
		public unsafe static Vector2 operator -(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x0003B934 File Offset: 0x00039B34
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0003B980 File Offset: 0x00039B80
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0003B9CC File Offset: 0x00039BCC
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003BA18 File Offset: 0x00039C18
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0003BA64 File Offset: 0x00039C64
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0003BAFC File Offset: 0x00039CFC
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x0003BB3C File Offset: 0x00039D3C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 67113, RefRangeEnd = 67121, XrefRangeStart = 67113, XrefRangeEnd = 67113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0003BB7C File Offset: 0x00039D7C
		public unsafe static Vector2 zero
		{
			[CallerCount(157)]
			[CachedScanResults(RefRangeStart = 67123, RefRangeEnd = 67280, XrefRangeStart = 67121, XrefRangeEnd = 67123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0003BBAC File Offset: 0x00039DAC
		public unsafe static Vector2 one
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 67282, RefRangeEnd = 67317, XrefRangeStart = 67280, XrefRangeEnd = 67282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x0003BBDC File Offset: 0x00039DDC
		public unsafe static Vector2 up
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 67319, RefRangeEnd = 67326, XrefRangeStart = 67317, XrefRangeEnd = 67319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x0003BC0C File Offset: 0x00039E0C
		public unsafe static Vector2 right
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 67328, RefRangeEnd = 67332, XrefRangeStart = 67326, XrefRangeEnd = 67328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x0000968A File Offset: 0x0000788A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2>.NativeClassPtr, ref this));
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0003BC3C File Offset: 0x00039E3C
		// (set) Token: 0x06000E12 RID: 3602 RVA: 0x0000969C File Offset: 0x0000789C
		public unsafe static Vector2 zeroVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E13 RID: 3603 RVA: 0x0003BC58 File Offset: 0x00039E58
		// (set) Token: 0x06000E14 RID: 3604 RVA: 0x000096AA File Offset: 0x000078AA
		public unsafe static Vector2 oneVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0003BC74 File Offset: 0x00039E74
		// (set) Token: 0x06000E16 RID: 3606 RVA: 0x000096B8 File Offset: 0x000078B8
		public unsafe static Vector2 upVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0003BC90 File Offset: 0x00039E90
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x000096C6 File Offset: 0x000078C6
		public unsafe static Vector2 downVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0003BCAC File Offset: 0x00039EAC
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x000096D4 File Offset: 0x000078D4
		public unsafe static Vector2 leftVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000096E2 File Offset: 0x000078E2
		public unsafe static Vector2 rightVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0003BCE4 File Offset: 0x00039EE4
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x000096F0 File Offset: 0x000078F0
		public unsafe static Vector2 positiveInfinityVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0003BD00 File Offset: 0x00039F00
		// (set) Token: 0x06000E20 RID: 3616 RVA: 0x000096FE File Offset: 0x000078FE
		public unsafe static Vector2 negativeInfinityVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0003BD1C File Offset: 0x00039F1C
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x0000970C File Offset: 0x0000790C
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0003BD38 File Offset: 0x00039F38
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x0000971A File Offset: 0x0000791A
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00009728 File Offset: 0x00007928
		public void Set(float newX, float newY)
		{
			this.x = newX;
			this.y = newY;
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x0003BD54 File Offset: 0x00039F54
		public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			return new Vector2(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0003BD98 File Offset: 0x00039F98
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = num * num + num2 * num2;
			bool flag = num3 == 0f || (maxDistanceDelta >= 0f && num3 <= maxDistanceDelta * maxDistanceDelta);
			Vector2 vector;
			if (flag)
			{
				vector = target;
			}
			else
			{
				float num4 = (float)Math.Sqrt((double)num3);
				vector = new Vector2(current.x + num / num4 * maxDistanceDelta, current.y + num2 / num4 * maxDistanceDelta);
			}
			return vector;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00009739 File Offset: 0x00007939
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x0003BE20 File Offset: 0x0003A020
		public void Normalize()
		{
			float magnitude = this.magnitude;
			bool flag = magnitude > 1E-05f;
			if (flag)
			{
				this /= magnitude;
			}
			else
			{
				this = Vector2.zero;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0003BE60 File Offset: 0x0003A060
		public Vector2 normalized
		{
			get
			{
				Vector2 vector = new Vector2(this.x, this.y);
				vector.Normalize();
				return vector;
			}
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0003BE90 File Offset: 0x0003A090
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0003BEAC File Offset: 0x0003A0AC
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			float num = -2f * Vector2.Dot(inNormal, inDirection);
			return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0003BEF0 File Offset: 0x0003A0F0
		public static Vector2 Perpendicular(Vector2 inDirection)
		{
			return new Vector2(-inDirection.y, inDirection.x);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0003BF14 File Offset: 0x0003A114
		public static float Angle(Vector2 from, Vector2 to)
		{
			float num = (float)Math.Sqrt((double)(from.sqrMagnitude * to.sqrMagnitude));
			bool flag = num < 1E-15f;
			float num2;
			if (flag)
			{
				num2 = 0f;
			}
			else
			{
				float num3 = Mathf.Clamp(Vector2.Dot(from, to) / num, -1f, 1f);
				num2 = (float)Math.Acos((double)num3) * 57.29578f;
			}
			return num2;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0003BF78 File Offset: 0x0003A178
		public static float SignedAngle(Vector2 from, Vector2 to)
		{
			float num = Vector2.Angle(from, to);
			float num2 = Mathf.Sign(from.x * to.y - from.y * to.x);
			return num * num2;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0003BFB8 File Offset: 0x0003A1B8
		public static float Distance(Vector2 a, Vector2 b)
		{
			float num = a.x - b.x;
			float num2 = a.y - b.y;
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			bool flag = sqrMagnitude > maxLength * maxLength;
			Vector2 vector2;
			if (flag)
			{
				float num = (float)Math.Sqrt((double)sqrMagnitude);
				float num2 = vector.x / num;
				float num3 = vector.y / num;
				vector2 = new Vector2(num2 * maxLength, num3 * maxLength);
			}
			else
			{
				vector2 = vector;
			}
			return vector2;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0003C048 File Offset: 0x0003A248
		public static float SqrMagnitude(Vector2 a)
		{
			return a.x * a.x + a.y * a.y;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x0003C078 File Offset: 0x0003A278
		public static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		public static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			return new Vector2(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0003C0F0 File Offset: 0x0003A2F0
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x0003C114 File Offset: 0x0003A314
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			float deltaTime = Time.deltaTime;
			float positiveInfinity = float.PositiveInfinity;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, positiveInfinity, deltaTime);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x0003C140 File Offset: 0x0003A340
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			smoothTime = Mathf.Max(0.0001f, smoothTime);
			float num = 2f / smoothTime;
			float num2 = num * deltaTime;
			float num3 = 1f / (1f + num2 + 0.48f * num2 * num2 + 0.235f * num2 * num2 * num2);
			float num4 = current.x - target.x;
			float num5 = current.y - target.y;
			Vector2 vector = target;
			float num6 = maxSpeed * smoothTime;
			float num7 = num6 * num6;
			float num8 = num4 * num4 + num5 * num5;
			bool flag = num8 > num7;
			if (flag)
			{
				float num9 = (float)Math.Sqrt((double)num8);
				num4 = num4 / num9 * num6;
				num5 = num5 / num9 * num6;
			}
			target.x = current.x - num4;
			target.y = current.y - num5;
			float num10 = (currentVelocity.x + num * num4) * deltaTime;
			float num11 = (currentVelocity.y + num * num5) * deltaTime;
			currentVelocity.x = (currentVelocity.x - num * num10) * num3;
			currentVelocity.y = (currentVelocity.y - num * num11) * num3;
			float num12 = target.x + (num4 + num10) * num3;
			float num13 = target.y + (num5 + num11) * num3;
			float num14 = vector.x - current.x;
			float num15 = vector.y - current.y;
			float num16 = num12 - vector.x;
			float num17 = num13 - vector.y;
			bool flag2 = num14 * num16 + num15 * num17 > 0f;
			if (flag2)
			{
				num12 = vector.x;
				num13 = vector.y;
				currentVelocity.x = (num12 - vector.x) / deltaTime;
				currentVelocity.y = (num13 - vector.y) / deltaTime;
			}
			return new Vector2(num12, num13);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x0003C30C File Offset: 0x0003A50C
		public static Vector2 operator -(Vector2 a)
		{
			return new Vector2(-a.x, -a.y);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x0003C334 File Offset: 0x0003A534
		public static Vector2 operator *(float d, Vector2 a)
		{
			return new Vector2(a.x * d, a.y * d);
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0003C35C File Offset: 0x0003A55C
		public static Vector2 down
		{
			get
			{
				return Vector2.downVector;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x0003C374 File Offset: 0x0003A574
		public static Vector2 left
		{
			get
			{
				return Vector2.leftVector;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0003C38C File Offset: 0x0003A58C
		public static Vector2 positiveInfinity
		{
			get
			{
				return Vector2.positiveInfinityVector;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x0003C3A4 File Offset: 0x0003A5A4
		public static Vector2 negativeInfinity
		{
			get
			{
				return Vector2.negativeInfinityVector;
			}
		}

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x04000B17 RID: 2839
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Single_0;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0;

		// Token: 0x04000B3A RID: 2874
		[FieldOffset(0)]
		public float x;

		// Token: 0x04000B3B RID: 2875
		[FieldOffset(4)]
		public float y;
	}
}
