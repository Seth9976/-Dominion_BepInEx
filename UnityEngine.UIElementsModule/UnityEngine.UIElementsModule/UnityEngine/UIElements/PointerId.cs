using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000092 RID: 146
	public static class PointerId : Object
	{
		// Token: 0x060007A5 RID: 1957 RVA: 0x00024DF8 File Offset: 0x00022FF8
		// Note: this type is marked as 'beforefieldinit'.
		static PointerId()
		{
			Il2CppClassPointerStore<PointerId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerId>.NativeClassPtr);
			PointerId.NativeFieldInfoPtr_maxPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "maxPointers");
			PointerId.NativeFieldInfoPtr_invalidPointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "invalidPointerId");
			PointerId.NativeFieldInfoPtr_mousePointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "mousePointerId");
			PointerId.NativeFieldInfoPtr_touchPointerIdBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "touchPointerIdBase");
			PointerId.NativeFieldInfoPtr_touchPointerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "touchPointerCount");
			PointerId.NativeFieldInfoPtr_penPointerIdBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "penPointerIdBase");
			PointerId.NativeFieldInfoPtr_penPointerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "penPointerCount");
			PointerId.NativeFieldInfoPtr_hoveringPointers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerId>.NativeClassPtr, "hoveringPointers");
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00005497 File Offset: 0x00003697
		public PointerId(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x00024EC8 File Offset: 0x000230C8
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x000054A0 File Offset: 0x000036A0
		public unsafe static int maxPointers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_maxPointers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_maxPointers, (void*)(&value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x00024EE4 File Offset: 0x000230E4
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x000054AE File Offset: 0x000036AE
		public unsafe static int invalidPointerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_invalidPointerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_invalidPointerId, (void*)(&value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x00024F00 File Offset: 0x00023100
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x000054BC File Offset: 0x000036BC
		public unsafe static int mousePointerId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_mousePointerId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_mousePointerId, (void*)(&value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x00024F1C File Offset: 0x0002311C
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x000054CA File Offset: 0x000036CA
		public unsafe static int touchPointerIdBase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_touchPointerIdBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_touchPointerIdBase, (void*)(&value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x00024F38 File Offset: 0x00023138
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x000054D8 File Offset: 0x000036D8
		public unsafe static int touchPointerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_touchPointerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_touchPointerCount, (void*)(&value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x00024F54 File Offset: 0x00023154
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000054E6 File Offset: 0x000036E6
		public unsafe static int penPointerIdBase
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_penPointerIdBase, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_penPointerIdBase, (void*)(&value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00024F70 File Offset: 0x00023170
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000054F4 File Offset: 0x000036F4
		public unsafe static int penPointerCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_penPointerCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_penPointerCount, (void*)(&value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00024F8C File Offset: 0x0002318C
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00005502 File Offset: 0x00003702
		public unsafe static Il2CppStructArray<int> hoveringPointers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerId.NativeFieldInfoPtr_hoveringPointers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerId.NativeFieldInfoPtr_hoveringPointers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_maxPointers;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_invalidPointerId;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_mousePointerId;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_touchPointerIdBase;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_touchPointerCount;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_penPointerIdBase;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_penPointerCount;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_hoveringPointers;
	}
}
