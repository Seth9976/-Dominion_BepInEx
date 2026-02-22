using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	[StructLayout(2)]
	public struct Vector2Int
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x0003C3BC File Offset: 0x0003A5BC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Int()
		{
			Il2CppClassPointerStore<Vector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr);
			Vector2Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_X");
			Vector2Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_Y");
			Vector2Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Zero");
			Vector2Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_One");
			Vector2Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Up");
			Vector2Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Down");
			Vector2Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Left");
			Vector2Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Right");
			Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664174);
			Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664175);
			Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664176);
			Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664177);
			Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664178);
			Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664179);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664180);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664181);
			Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664182);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664183);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664184);
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0003C568 File Offset: 0x0003A768
		// (set) Token: 0x06000E40 RID: 3648 RVA: 0x0003C598 File Offset: 0x0003A798
		public unsafe int x
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0003C5CC File Offset: 0x0003A7CC
		// (set) Token: 0x06000E42 RID: 3650 RVA: 0x0003C5FC File Offset: 0x0003A7FC
		public unsafe int y
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62285, RefRangeEnd = 62297, XrefRangeStart = 62285, XrefRangeEnd = 62297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003C630 File Offset: 0x0003A830
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x0003C670 File Offset: 0x0003A870
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67332, RefRangeEnd = 67334, XrefRangeStart = 67332, XrefRangeEnd = 67332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(Vector2Int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x0003C6B0 File Offset: 0x0003A8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67334, XrefRangeEnd = 67337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003C6F4 File Offset: 0x0003A8F4
		[CallerCount(0)]
		public unsafe bool Equals(Vector2Int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0003C734 File Offset: 0x0003A934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67337, XrefRangeEnd = 67339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003C764 File Offset: 0x0003A964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67339, XrefRangeEnd = 67347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0003C790 File Offset: 0x0003A990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67361, RefRangeEnd = 67362, XrefRangeStart = 67347, XrefRangeEnd = 67361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00009762 File Offset: 0x00007962
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003C7E0 File Offset: 0x0003A9E0
		// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00009774 File Offset: 0x00007974
		public unsafe static Vector2Int s_Zero
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x0003C7FC File Offset: 0x0003A9FC
		// (set) Token: 0x06000E4E RID: 3662 RVA: 0x00009782 File Offset: 0x00007982
		public unsafe static Vector2Int s_One
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000E4F RID: 3663 RVA: 0x0003C818 File Offset: 0x0003AA18
		// (set) Token: 0x06000E50 RID: 3664 RVA: 0x00009790 File Offset: 0x00007990
		public unsafe static Vector2Int s_Up
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x0003C834 File Offset: 0x0003AA34
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x0000979E File Offset: 0x0000799E
		public unsafe static Vector2Int s_Down
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x0003C850 File Offset: 0x0003AA50
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x000097AC File Offset: 0x000079AC
		public unsafe static Vector2Int s_Left
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003C86C File Offset: 0x0003AA6C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x000097BA File Offset: 0x000079BA
		public unsafe static Vector2Int s_Right
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000097C8 File Offset: 0x000079C8
		public void Set(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x1700030D RID: 781
		public int this[int index]
		{
			get
			{
				int num;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					num = this.y;
				}
				else
				{
					num = this.x;
				}
				return num;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0003C918 File Offset: 0x0003AB18
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003C94C File Offset: 0x0003AB4C
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x0003C97C File Offset: 0x0003AB7C
		public static float Distance(Vector2Int a, Vector2Int b)
		{
			float num = (float)(a.x - b.x);
			float num2 = (float)(a.y - b.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0003CA00 File Offset: 0x0003AC00
		public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x0003CA40 File Offset: 0x0003AC40
		public static Vector2Int Scale(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000097D9 File Offset: 0x000079D9
		public void Scale(Vector2Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x0003CA78 File Offset: 0x0003AC78
		public void Clamp(Vector2Int min, Vector2Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x0003CAEC File Offset: 0x0003ACEC
		public static explicit operator Vector3Int(Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0003CB14 File Offset: 0x0003AD14
		public static Vector2Int FloorToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x0003CB44 File Offset: 0x0003AD44
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0003CB74 File Offset: 0x0003AD74
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0003CBA4 File Offset: 0x0003ADA4
		public static Vector2Int operator -(Vector2Int v)
		{
			return new Vector2Int(-v.x, -v.y);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0003CBCC File Offset: 0x0003ADCC
		public static Vector2Int operator +(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x + b.x, a.y + b.y);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0003CC04 File Offset: 0x0003AE04
		public static Vector2Int operator -(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x - b.x, a.y - b.y);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003CC3C File Offset: 0x0003AE3C
		public static Vector2Int operator *(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x0003CC74 File Offset: 0x0003AE74
		public static Vector2Int operator *(int a, Vector2Int b)
		{
			return new Vector2Int(a * b.x, a * b.y);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0003CCA0 File Offset: 0x0003AEA0
		public static Vector2Int operator *(Vector2Int a, int b)
		{
			return new Vector2Int(a.x * b, a.y * b);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003CCCC File Offset: 0x0003AECC
		public static Vector2Int operator /(Vector2Int a, int b)
		{
			return new Vector2Int(a.x / b, a.y / b);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0003CCF8 File Offset: 0x0003AEF8
		public static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0003CD30 File Offset: 0x0003AF30
		public static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003CD4C File Offset: 0x0003AF4C
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003CD68 File Offset: 0x0003AF68
		public static Vector2Int zero
		{
			get
			{
				return Vector2Int.s_Zero;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x0003CD80 File Offset: 0x0003AF80
		public static Vector2Int one
		{
			get
			{
				return Vector2Int.s_One;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003CD98 File Offset: 0x0003AF98
		public static Vector2Int up
		{
			get
			{
				return Vector2Int.s_Up;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0003CDB0 File Offset: 0x0003AFB0
		public static Vector2Int down
		{
			get
			{
				return Vector2Int.s_Down;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		public static Vector2Int left
		{
			get
			{
				return Vector2Int.s_Left;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x0003CDE0 File Offset: 0x0003AFE0
		public static Vector2Int right
		{
			get
			{
				return Vector2Int.s_Right;
			}
		}

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B4F RID: 2895
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04000B50 RID: 2896
		[FieldOffset(4)]
		public int m_Y;
	}
}
