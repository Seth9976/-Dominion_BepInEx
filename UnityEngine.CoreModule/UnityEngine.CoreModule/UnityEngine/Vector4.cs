using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	[StructLayout(2)]
	public struct Vector4
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003D914 File Offset: 0x0003BB14
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4()
		{
			Il2CppClassPointerStore<Vector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4>.NativeClassPtr);
			Vector4.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "kEpsilon");
			Vector4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "x");
			Vector4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "y");
			Vector4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "z");
			Vector4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "w");
			Vector4.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "zeroVector");
			Vector4.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "oneVector");
			Vector4.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "positiveInfinityVector");
			Vector4.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "negativeInfinityVector");
			Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664197);
			Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664198);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664199);
			Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664200);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664201);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664202);
			Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664203);
			Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664204);
			Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664205);
			Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664206);
			Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664207);
			Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664208);
			Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664209);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664210);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664211);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664212);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664213);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100664214);
		}

		// Token: 0x17000331 RID: 817
		public unsafe float this[int index]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 67396, RefRangeEnd = 67412, XrefRangeStart = 67396, XrefRangeEnd = 67396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 67412, RefRangeEnd = 67416, XrefRangeStart = 67412, XrefRangeEnd = 67412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0003DBE0 File Offset: 0x0003BDE0
		[CallerCount(113)]
		[CachedScanResults(RefRangeStart = 61474, RefRangeEnd = 61587, XrefRangeStart = 61474, XrefRangeEnd = 61587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0003DC3C File Offset: 0x0003BE3C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 66187, RefRangeEnd = 66192, XrefRangeStart = 66187, XrefRangeEnd = 66192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0003DC6C File Offset: 0x0003BE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67416, XrefRangeEnd = 67419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0003DCB0 File Offset: 0x0003BEB0
		[CallerCount(0)]
		public unsafe bool Equals(Vector4 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66115, RefRangeEnd = 66118, XrefRangeStart = 66115, XrefRangeEnd = 66118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Dot(Vector4 a, Vector4 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0003DD3C File Offset: 0x0003BF3C
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0003DD6C File Offset: 0x0003BF6C
		public unsafe static Vector4 zero
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 67421, RefRangeEnd = 67447, XrefRangeStart = 67419, XrefRangeEnd = 67421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003DD9C File Offset: 0x0003BF9C
		[CallerCount(0)]
		public unsafe static Vector4 operator *(Vector4 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0003DDE8 File Offset: 0x0003BFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 64949, RefRangeEnd = 64950, XrefRangeStart = 64949, XrefRangeEnd = 64950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 operator /(Vector4 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x0003DE34 File Offset: 0x0003C034
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003DE80 File Offset: 0x0003C080
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0003DECC File Offset: 0x0003C0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67447, RefRangeEnd = 67448, XrefRangeStart = 67447, XrefRangeEnd = 67447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0003DF0C File Offset: 0x0003C10C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67448, RefRangeEnd = 67450, XrefRangeStart = 67448, XrefRangeEnd = 67448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(Vector4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0003DF4C File Offset: 0x0003C14C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 67450, RefRangeEnd = 67481, XrefRangeStart = 67450, XrefRangeEnd = 67450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector4(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0003DF8C File Offset: 0x0003C18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67481, XrefRangeEnd = 67487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0003DFB8 File Offset: 0x0003C1B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67525, RefRangeEnd = 67526, XrefRangeStart = 67487, XrefRangeEnd = 67525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000098D8 File Offset: 0x00007AD8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector4>.NativeClassPtr, ref this));
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0003E008 File Offset: 0x0003C208
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x000098EA File Offset: 0x00007AEA
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0003E024 File Offset: 0x0003C224
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x000098F8 File Offset: 0x00007AF8
		public unsafe static Vector4 zeroVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0003E040 File Offset: 0x0003C240
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00009906 File Offset: 0x00007B06
		public unsafe static Vector4 oneVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0003E05C File Offset: 0x0003C25C
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00009914 File Offset: 0x00007B14
		public unsafe static Vector4 positiveInfinityVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0003E078 File Offset: 0x0003C278
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00009922 File Offset: 0x00007B22
		public unsafe static Vector4 negativeInfinityVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00009930 File Offset: 0x00007B30
		public void Set(float newX, float newY, float newZ, float newW)
		{
			this.x = newX;
			this.y = newY;
			this.z = newZ;
			this.w = newW;
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0003E094 File Offset: 0x0003C294
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0003E10C File Offset: 0x0003C30C
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003E17C File Offset: 0x0003C37C
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = target.z - current.z;
			float num4 = target.w - current.w;
			float num5 = num * num + num2 * num2 + num3 * num3 + num4 * num4;
			bool flag = num5 == 0f || (maxDistanceDelta >= 0f && num5 <= maxDistanceDelta * maxDistanceDelta);
			Vector4 vector;
			if (flag)
			{
				vector = target;
			}
			else
			{
				float num6 = (float)Math.Sqrt((double)num5);
				vector = new Vector4(current.x + num / num6 * maxDistanceDelta, current.y + num2 / num6 * maxDistanceDelta, current.z + num3 / num6 * maxDistanceDelta, current.w + num4 / num6 * maxDistanceDelta);
			}
			return vector;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0003E24C File Offset: 0x0003C44C
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0003E298 File Offset: 0x0003C498
		public void Scale(Vector4 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
			this.w *= scale.w;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0003E2F4 File Offset: 0x0003C4F4
		public static Vector4 Normalize(Vector4 a)
		{
			float num = Vector4.Magnitude(a);
			bool flag = num > 1E-05f;
			Vector4 vector;
			if (flag)
			{
				vector = a / num;
			}
			else
			{
				vector = Vector4.zero;
			}
			return vector;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003E328 File Offset: 0x0003C528
		public void Normalize()
		{
			float num = Vector4.Magnitude(this);
			bool flag = num > 1E-05f;
			if (flag)
			{
				this /= num;
			}
			else
			{
				this = Vector4.zero;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0003E370 File Offset: 0x0003C570
		public Vector4 normalized
		{
			get
			{
				return Vector4.Normalize(this);
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0003E390 File Offset: 0x0003C590
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return b * (Vector4.Dot(a, b) / Vector4.Dot(b, b));
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		public static float Distance(Vector4 a, Vector4 b)
		{
			return Vector4.Magnitude(a - b);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0003E3D8 File Offset: 0x0003C5D8
		public static float Magnitude(Vector4 a)
		{
			return (float)Math.Sqrt((double)Vector4.Dot(a, a));
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x0003E3F8 File Offset: 0x0003C5F8
		public float magnitude
		{
			get
			{
				return (float)Math.Sqrt((double)Vector4.Dot(this, this));
			}
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003E424 File Offset: 0x0003C624
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003E480 File Offset: 0x0003C680
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public static Vector4 one
		{
			get
			{
				return Vector4.oneVector;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0003E4F4 File Offset: 0x0003C6F4
		public static Vector4 positiveInfinity
		{
			get
			{
				return Vector4.positiveInfinityVector;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x0003E50C File Offset: 0x0003C70C
		public static Vector4 negativeInfinity
		{
			get
			{
				return Vector4.negativeInfinityVector;
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0003E524 File Offset: 0x0003C724
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0003E570 File Offset: 0x0003C770
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0003E5BC File Offset: 0x0003C7BC
		public static Vector4 operator -(Vector4 a)
		{
			return new Vector4(-a.x, -a.y, -a.z, -a.w);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
		public static Vector4 operator *(float d, Vector4 a)
		{
			return new Vector4(a.x * d, a.y * d, a.z * d, a.w * d);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0003E628 File Offset: 0x0003C828
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0003E644 File Offset: 0x0003C844
		public static float SqrMagnitude(Vector4 a)
		{
			return Vector4.Dot(a, a);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0003E660 File Offset: 0x0003C860
		public float SqrMagnitude()
		{
			return Vector4.Dot(this, this);
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B84 RID: 2948
		[FieldOffset(0)]
		public float x;

		// Token: 0x04000B85 RID: 2949
		[FieldOffset(4)]
		public float y;

		// Token: 0x04000B86 RID: 2950
		[FieldOffset(8)]
		public float z;

		// Token: 0x04000B87 RID: 2951
		[FieldOffset(12)]
		public float w;
	}
}
