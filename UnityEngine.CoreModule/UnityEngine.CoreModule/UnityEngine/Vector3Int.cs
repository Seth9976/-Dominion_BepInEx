using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000089 RID: 137
	[StructLayout(2)]
	public struct Vector3Int
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x0003CDF8 File Offset: 0x0003AFF8
		// Note: this type is marked as 'beforefieldinit'.
		static Vector3Int()
		{
			Il2CppClassPointerStore<Vector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector3Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr);
			Vector3Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_X");
			Vector3Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Y");
			Vector3Int.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "m_Z");
			Vector3Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Zero");
			Vector3Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_One");
			Vector3Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Up");
			Vector3Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Down");
			Vector3Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Left");
			Vector3Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Right");
			Vector3Int.NativeFieldInfoPtr_s_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Forward");
			Vector3Int.NativeFieldInfoPtr_s_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, "s_Back");
			Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664186);
			Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664187);
			Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664188);
			Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664189);
			Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664190);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664191);
			Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664192);
			Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664193);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664194);
			Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100664195);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003CFCC File Offset: 0x0003B1CC
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x00009888 File Offset: 0x00007A88
		public unsafe int x
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 62259, RefRangeEnd = 62285, XrefRangeStart = 62259, XrefRangeEnd = 62285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0003CFFC File Offset: 0x0003B1FC
		// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00009892 File Offset: 0x00007A92
		public unsafe int y
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62285, RefRangeEnd = 62297, XrefRangeStart = 62285, XrefRangeEnd = 62297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0003D02C File Offset: 0x0003B22C
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x0000989C File Offset: 0x00007A9C
		public unsafe int z
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x0003D05C File Offset: 0x0003B25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67362, RefRangeEnd = 67363, XrefRangeStart = 67362, XrefRangeEnd = 67362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3Int(int x, int y, int z)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0003D0AC File Offset: 0x0003B2AC
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector3Int lhs, Vector3Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67363, XrefRangeEnd = 67366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0003D13C File Offset: 0x0003B33C
		[CallerCount(0)]
		public unsafe bool Equals(Vector3Int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x0003D17C File Offset: 0x0003B37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67366, XrefRangeEnd = 67369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x0003D1AC File Offset: 0x0003B3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67369, XrefRangeEnd = 67379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67395, RefRangeEnd = 67396, XrefRangeStart = 67379, XrefRangeEnd = 67395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00009806 File Offset: 0x00007A06
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0003D228 File Offset: 0x0003B428
		// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00009818 File Offset: 0x00007A18
		public unsafe static Vector3Int s_Zero
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0003D244 File Offset: 0x0003B444
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00009826 File Offset: 0x00007A26
		public unsafe static Vector3Int s_One
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0003D260 File Offset: 0x0003B460
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00009834 File Offset: 0x00007A34
		public unsafe static Vector3Int s_Up
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0003D27C File Offset: 0x0003B47C
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00009842 File Offset: 0x00007A42
		public unsafe static Vector3Int s_Down
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x0003D298 File Offset: 0x0003B498
		// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00009850 File Offset: 0x00007A50
		public unsafe static Vector3Int s_Left
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0003D2B4 File Offset: 0x0003B4B4
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x0000985E File Offset: 0x00007A5E
		public unsafe static Vector3Int s_Right
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0003D2D0 File Offset: 0x0003B4D0
		// (set) Token: 0x06000E8F RID: 3727 RVA: 0x0000986C File Offset: 0x00007A6C
		public unsafe static Vector3Int s_Forward
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*)(&value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0003D2EC File Offset: 0x0003B4EC
		// (set) Token: 0x06000E91 RID: 3729 RVA: 0x0000987A File Offset: 0x00007A7A
		public unsafe static Vector3Int s_Back
		{
			get
			{
				Vector3Int vector3Int;
				IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&vector3Int));
				return vector3Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*)(&value));
			}
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000098A6 File Offset: 0x00007AA6
		public void Set(int x, int y, int z)
		{
			this.m_X = x;
			this.m_Y = y;
			this.m_Z = z;
		}

		// Token: 0x17000321 RID: 801
		public int this[int index]
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0003D308 File Offset: 0x0003B508
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y + this.z * this.z));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0003D34C File Offset: 0x0003B54C
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y + this.z * this.z;
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0003D388 File Offset: 0x0003B588
		public static float Distance(Vector3Int a, Vector3Int b)
		{
			return (a - b).magnitude;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0003D3AC File Offset: 0x0003B5AC
		public static Vector3Int Min(Vector3Int lhs, Vector3Int rhs)
		{
			return new Vector3Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z));
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0003D3FC File Offset: 0x0003B5FC
		public static Vector3Int Max(Vector3Int lhs, Vector3Int rhs)
		{
			return new Vector3Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z));
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0003D44C File Offset: 0x0003B64C
		public static Vector3Int Scale(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0003D490 File Offset: 0x0003B690
		public void Scale(Vector3Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
			this.z *= scale.z;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0003D4E0 File Offset: 0x0003B6E0
		public void Clamp(Vector3Int min, Vector3Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
			this.z = Math.Max(min.z, this.z);
			this.z = Math.Min(max.z, this.z);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0003D584 File Offset: 0x0003B784
		public static implicit operator Vector3(Vector3Int v)
		{
			return new Vector3((float)v.x, (float)v.y, (float)v.z);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x0003D5B4 File Offset: 0x0003B7B4
		public static explicit operator Vector2Int(Vector3Int v)
		{
			return new Vector2Int(v.x, v.y);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0003D5DC File Offset: 0x0003B7DC
		public static Vector3Int FloorToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003D614 File Offset: 0x0003B814
		public static Vector3Int CeilToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0003D64C File Offset: 0x0003B84C
		public static Vector3Int RoundToInt(Vector3 v)
		{
			return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003D684 File Offset: 0x0003B884
		public static Vector3Int operator +(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0003D6C8 File Offset: 0x0003B8C8
		public static Vector3Int operator -(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x - b.x, a.y - b.y, a.z - b.z);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x0003D70C File Offset: 0x0003B90C
		public static Vector3Int operator *(Vector3Int a, Vector3Int b)
		{
			return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0003D750 File Offset: 0x0003B950
		public static Vector3Int operator -(Vector3Int a)
		{
			return new Vector3Int(-a.x, -a.y, -a.z);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x0003D780 File Offset: 0x0003B980
		public static Vector3Int operator *(Vector3Int a, int b)
		{
			return new Vector3Int(a.x * b, a.y * b, a.z * b);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		public static Vector3Int operator *(int a, Vector3Int b)
		{
			return new Vector3Int(a * b.x, a * b.y, a * b.z);
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x0003D7E8 File Offset: 0x0003B9E8
		public static Vector3Int operator /(Vector3Int a, int b)
		{
			return new Vector3Int(a.x / b, a.y / b, a.z / b);
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0003D81C File Offset: 0x0003BA1C
		public static bool operator !=(Vector3Int lhs, Vector3Int rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0003D838 File Offset: 0x0003BA38
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x0003D854 File Offset: 0x0003BA54
		public static Vector3Int zero
		{
			get
			{
				return Vector3Int.s_Zero;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0003D86C File Offset: 0x0003BA6C
		public static Vector3Int one
		{
			get
			{
				return Vector3Int.s_One;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x0003D884 File Offset: 0x0003BA84
		public static Vector3Int up
		{
			get
			{
				return Vector3Int.s_Up;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0003D89C File Offset: 0x0003BA9C
		public static Vector3Int down
		{
			get
			{
				return Vector3Int.s_Down;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0003D8B4 File Offset: 0x0003BAB4
		public static Vector3Int left
		{
			get
			{
				return Vector3Int.s_Left;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0003D8CC File Offset: 0x0003BACC
		public static Vector3Int right
		{
			get
			{
				return Vector3Int.s_Right;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		public static Vector3Int forward
		{
			get
			{
				return Vector3Int.s_Forward;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		public static Vector3Int back
		{
			get
			{
				return Vector3Int.s_Back;
			}
		}

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_m_Z;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeFieldInfoPtr_s_Forward;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_s_Back;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_z_Public_get_Int32_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000B66 RID: 2918
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04000B67 RID: 2919
		[FieldOffset(4)]
		public int m_Y;

		// Token: 0x04000B68 RID: 2920
		[FieldOffset(8)]
		public int m_Z;
	}
}
