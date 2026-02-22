using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200000C RID: 12
	public static class BinaryCompatibility : Object
	{
		// Token: 0x06000095 RID: 149 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCompatibility()
		{
			Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BinaryCompatibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr);
			BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, "_targetsAtLeast_Desktop_V4_5_2");
			BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100663356);
			BinaryCompatibility.NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCompatibility>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000AA2C File Offset: 0x00008C2C
		public unsafe static bool TargetsAtLeast_Desktop_V4_5_2
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11735, XrefRangeEnd = 11739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AA5C File Offset: 0x00008C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11739, XrefRangeEnd = 11757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RunningOnCheck(string propertyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCompatibility.NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000245D File Offset: 0x0000065D
		public BinaryCompatibility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002466 File Offset: 0x00000666
		public unsafe static bool _targetsAtLeast_Desktop_V4_5_2
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryCompatibility.NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2, (void*)(&value));
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__targetsAtLeast_Desktop_V4_5_2;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetsAtLeast_Desktop_V4_5_2_Internal_Static_get_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_RunningOnCheck_Private_Static_Boolean_String_0;
	}
}
