using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000040 RID: 64
	[StructLayout(2)]
	public struct Bounds
	{
		// Token: 0x060003DF RID: 991 RVA: 0x0001EFB8 File Offset: 0x0001D1B8
		// Note: this type is marked as 'beforefieldinit'.
		static Bounds()
		{
			Il2CppClassPointerStore<Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Bounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounds>.NativeClassPtr);
			Bounds.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Center");
			Bounds.NativeFieldInfoPtr_m_Extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, "m_Extents");
			Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663475);
			Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663476);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663477);
			Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663478);
			Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663479);
			Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663480);
			Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663481);
			Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663482);
			Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663483);
			Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663484);
			Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663485);
			Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663486);
			Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663487);
			Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663488);
			Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663489);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663490);
			Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663491);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663492);
			Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100663493);
			Bounds.Contains_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.Contains_InjectedDelegate>("UnityEngine.Bounds::Contains_Injected");
			Bounds.SqrDistance_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.SqrDistance_InjectedDelegate>("UnityEngine.Bounds::SqrDistance_Injected");
			Bounds.IntersectRayAABB_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.IntersectRayAABB_InjectedDelegate>("UnityEngine.Bounds::IntersectRayAABB_Injected");
			Bounds.ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.ClosestPoint_InjectedDelegate>("UnityEngine.Bounds::ClosestPoint_Injected");
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 61040, RefRangeEnd = 61055, XrefRangeStart = 61040, XrefRangeEnd = 61040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bounds(Vector3 center, Vector3 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref center;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001F208 File Offset: 0x0001D408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61055, XrefRangeEnd = 61057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001F238 File Offset: 0x0001D438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61057, XrefRangeEnd = 61062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001F27C File Offset: 0x0001D47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61062, XrefRangeEnd = 61063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Bounds other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		public unsafe Vector3 center
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61099, XrefRangeStart = 61063, XrefRangeEnd = 61063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61099, RefRangeEnd = 61100, XrefRangeStart = 61099, XrefRangeEnd = 61099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0001F320 File Offset: 0x0001D520
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0001F350 File Offset: 0x0001D550
		public unsafe Vector3 size
		{
			[CallerCount(51)]
			[CachedScanResults(RefRangeStart = 61100, RefRangeEnd = 61151, XrefRangeStart = 61100, XrefRangeEnd = 61100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61151, RefRangeEnd = 61152, XrefRangeStart = 61151, XrefRangeEnd = 61151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001F384 File Offset: 0x0001D584
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0001F3B4 File Offset: 0x0001D5B4
		public unsafe Vector3 extents
		{
			[CallerCount(64)]
			[CachedScanResults(RefRangeStart = 61152, RefRangeEnd = 61216, XrefRangeStart = 61152, XrefRangeEnd = 61152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000047C3 File Offset: 0x000029C3
		public unsafe Vector3 min
		{
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 61216, RefRangeEnd = 61262, XrefRangeStart = 61216, XrefRangeEnd = 61216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetMinMax(value, this.max);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0001F418 File Offset: 0x0001D618
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000047D4 File Offset: 0x000029D4
		public unsafe Vector3 max
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 61262, RefRangeEnd = 61299, XrefRangeStart = 61262, XrefRangeEnd = 61262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.SetMinMax(this.min, value);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001F448 File Offset: 0x0001D648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61299, XrefRangeEnd = 61300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001F494 File Offset: 0x0001D694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61301, RefRangeEnd = 61303, XrefRangeStart = 61300, XrefRangeEnd = 61301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Bounds lhs, Bounds rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		[CallerCount(0)]
		public unsafe void SetMinMax(Vector3 min, Vector3 max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0001F520 File Offset: 0x0001D720
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 61303, RefRangeEnd = 61307, XrefRangeStart = 61303, XrefRangeEnd = 61303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001F554 File Offset: 0x0001D754
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 61309, RefRangeEnd = 61313, XrefRangeStart = 61307, XrefRangeEnd = 61309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encapsulate(Bounds bounds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bounds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001F588 File Offset: 0x0001D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61313, XrefRangeEnd = 61314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61340, RefRangeEnd = 61341, XrefRangeStart = 61314, XrefRangeEnd = 61340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000047B1 File Offset: 0x000029B1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bounds>.NativeClassPtr, ref this));
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000047E5 File Offset: 0x000029E5
		public void Expand(float amount)
		{
			amount *= 0.5f;
			this.extents += new Vector3(amount, amount, amount);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000480B File Offset: 0x00002A0B
		public void Expand(Vector3 amount)
		{
			this.extents += amount * 0.5f;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001F604 File Offset: 0x0001D804
		public bool Intersects(Bounds bounds)
		{
			return this.min.x <= bounds.max.x && this.max.x >= bounds.min.x && this.min.y <= bounds.max.y && this.max.y >= bounds.min.y && this.min.z <= bounds.max.z && this.max.z >= bounds.min.z;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001F6B8 File Offset: 0x0001D8B8
		public bool IntersectRay(Ray ray)
		{
			float num;
			return Bounds.IntersectRayAABB(ray, this, out num);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public bool IntersectRay(Ray ray, out float distance)
		{
			return Bounds.IntersectRayAABB(ray, this, out distance);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000482B File Offset: 0x00002A2B
		public bool Contains(Vector3 point)
		{
			return Bounds.Contains_Injected(ref this, ref point);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00004835 File Offset: 0x00002A35
		public float SqrDistance(Vector3 point)
		{
			return Bounds.SqrDistance_Injected(ref this, ref point);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000483F File Offset: 0x00002A3F
		public static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
		{
			return Bounds.IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001F714 File Offset: 0x0001D914
		public Vector3 ClosestPoint(Vector3 point)
		{
			Vector3 vector;
			Bounds.ClosestPoint_Injected(ref this, ref point, out vector);
			return vector;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000484B File Offset: 0x00002A4B
		public static bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			return Bounds.Contains_InjectedDelegateField(ref _unity_self, ref point);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004859 File Offset: 0x00002A59
		public static float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point)
		{
			return Bounds.SqrDistance_InjectedDelegateField(ref _unity_self, ref point);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00004867 File Offset: 0x00002A67
		public static bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist)
		{
			return Bounds.IntersectRayAABB_InjectedDelegateField(ref ray, ref bounds, out dist);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00004876 File Offset: 0x00002A76
		public static void ClosestPoint_Injected(ref Bounds _unity_self, ref Vector3 point, out Vector3 ret)
		{
			Bounds.ClosestPoint_InjectedDelegateField(ref _unity_self, ref point, out ret);
		}

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_m_Center;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_m_Extents;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040002C2 RID: 706
		[FieldOffset(0)]
		public Vector3 m_Center;

		// Token: 0x040002C3 RID: 707
		[FieldOffset(12)]
		public Vector3 m_Extents;

		// Token: 0x040002C4 RID: 708
		private static readonly Bounds.Contains_InjectedDelegate Contains_InjectedDelegateField;

		// Token: 0x040002C5 RID: 709
		private static readonly Bounds.SqrDistance_InjectedDelegate SqrDistance_InjectedDelegateField;

		// Token: 0x040002C6 RID: 710
		private static readonly Bounds.IntersectRayAABB_InjectedDelegate IntersectRayAABB_InjectedDelegateField;

		// Token: 0x040002C7 RID: 711
		private static readonly Bounds.ClosestPoint_InjectedDelegate ClosestPoint_InjectedDelegateField;

		// Token: 0x02000433 RID: 1075
		// (Invoke) Token: 0x0600262D RID: 9773
		private delegate bool Contains_InjectedDelegate(IntPtr _unity_self, IntPtr point);

		// Token: 0x02000434 RID: 1076
		// (Invoke) Token: 0x0600262F RID: 9775
		private delegate float SqrDistance_InjectedDelegate(IntPtr _unity_self, IntPtr point);

		// Token: 0x02000435 RID: 1077
		// (Invoke) Token: 0x06002631 RID: 9777
		private delegate bool IntersectRayAABB_InjectedDelegate(IntPtr ray, IntPtr bounds, [Out] IntPtr dist);

		// Token: 0x02000436 RID: 1078
		// (Invoke) Token: 0x06002633 RID: 9779
		private delegate void ClosestPoint_InjectedDelegate(IntPtr _unity_self, IntPtr point, [Out] IntPtr ret);
	}
}
