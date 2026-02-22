using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000091 RID: 145
	public static class PointerType : Object
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00024C54 File Offset: 0x00022E54
		// Note: this type is marked as 'beforefieldinit'.
		static PointerType()
		{
			Il2CppClassPointerStore<PointerType>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "PointerType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerType>.NativeClassPtr);
			PointerType.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "mouse");
			PointerType.NativeFieldInfoPtr_touch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "touch");
			PointerType.NativeFieldInfoPtr_pen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "pen");
			PointerType.NativeFieldInfoPtr_unknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerType>.NativeClassPtr, "unknown");
			PointerType.NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerType>.NativeClassPtr, 100664019);
			PointerType.NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerType>.NativeClassPtr, 100664020);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00024CFC File Offset: 0x00022EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95883, RefRangeEnd = 95884, XrefRangeStart = 95875, XrefRangeEnd = 95883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPointerType(int pointerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pointerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerType.NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00024D34 File Offset: 0x00022F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95888, RefRangeEnd = 95890, XrefRangeStart = 95884, XrefRangeEnd = 95888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDirectManipulationDevice(string pointerType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pointerType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PointerType.NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00005446 File Offset: 0x00003646
		public PointerType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00024D78 File Offset: 0x00022F78
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x0000544F File Offset: 0x0000364F
		public unsafe static string mouse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_mouse, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_mouse, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00024D98 File Offset: 0x00022F98
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x00005461 File Offset: 0x00003661
		public unsafe static string touch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_touch, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_touch, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x00024DB8 File Offset: 0x00022FB8
		// (set) Token: 0x060007A2 RID: 1954 RVA: 0x00005473 File Offset: 0x00003673
		public unsafe static string pen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_pen, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_pen, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060007A3 RID: 1955 RVA: 0x00024DD8 File Offset: 0x00022FD8
		// (set) Token: 0x060007A4 RID: 1956 RVA: 0x00005485 File Offset: 0x00003685
		public unsafe static string unknown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PointerType.NativeFieldInfoPtr_unknown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PointerType.NativeFieldInfoPtr_unknown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_mouse;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_touch;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_pen;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_unknown;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_GetPointerType_Internal_Static_String_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_IsDirectManipulationDevice_Internal_Static_Boolean_String_0;
	}
}
